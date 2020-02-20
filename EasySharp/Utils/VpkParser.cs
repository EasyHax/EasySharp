using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using SharpVPK.Exceptions;
using SharpVPK.V1;
using SharpVPK;

namespace SharpSkin_dll
{
    public class VpkParser
    {
        public static void Do()
        {
            var archive = new VpkArchive();

            Console.WriteLine(File.Exists("csgo/pak01_dir.vpk"));
            Console.WriteLine("1");
            archive.Load("csgo/pak01_dir.vpk");
            Console.WriteLine("2");

            Console.WriteLine(archive.Directories.Count);

            foreach (var directory in archive.Directories)
                foreach (var entry in directory.Entries)
                    Console.WriteLine(entry.ToString());
        }
    }
}

namespace SharpVPK.Exceptions
{
    public class ArchiveParsingException : Exception
    {
        public ArchiveParsingException()
        {
        }

        public ArchiveParsingException(string message)
            : base(message)
        {
        }

        public ArchiveParsingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

namespace SharpVPK.V1
{
    internal class VpkReaderV1 : VpkReaderBase
    {
        public VpkReaderV1(string filename)
            : base(filename)
        {
        }

        public override IVpkArchiveHeader ReadArchiveHeader()
        {
            var hdrStructSize = Marshal.SizeOf(typeof(VpkArchiveHeaderV1));
            var hdrBuff = Reader.ReadBytes(hdrStructSize);
            return BytesToStructure<VpkArchiveHeaderV1>(hdrBuff);
        }

        public override uint CalculateEntryOffset(uint offset)
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace SharpVPK.V1
{
    public struct VpkArchiveHeaderV1 : IVpkArchiveHeader
    {
        private const int StaticSignature = 0x55aa1234;

        public uint Signature { get; set; }
        public uint Version { get; set; }
        public uint TreeLength { get; set; }

        public VpkArchiveHeaderV1(uint signature, uint version, uint treeLength)
            : this()
        {
            Signature = signature;
            Version = version;
            TreeLength = treeLength;
        }

        public bool Verify()
        {
            return Signature == StaticSignature && Version == 2;
            return true;
        }

        public uint CalculateDataOffset()
        {
            return 12 + TreeLength;
        }
    }
}

namespace SharpVPK
{
    public class VpkEntry
    {
        public string Extension { get; set; }
        public string Path { get; set; }
        public string Filename { get; set; }
        public byte[] PreloadData { get { return ReadPreloadData(); } }
        public byte[] Data { get { return ReadData(); } }
        public bool HasPreloadData { get; set; }

        internal uint CRC;
        internal ushort PreloadBytes;
        internal uint PreloadDataOffset;
        internal ushort ArchiveIndex;
        internal uint EntryOffset;
        internal uint EntryLength;
        internal VpkArchive ParentArchive;

        internal VpkEntry(VpkArchive parentArchive, uint crc, ushort preloadBytes, uint preloadDataOffset, ushort archiveIndex, uint entryOffset,
            uint entryLength, string extension, string path, string filename)
        {
            ParentArchive = parentArchive;
            CRC = crc;
            PreloadBytes = preloadBytes;
            PreloadDataOffset = preloadDataOffset;
            ArchiveIndex = archiveIndex;
            EntryOffset = entryOffset;
            EntryLength = entryLength;
            Extension = extension;
            Path = path;
            Filename = filename;
            HasPreloadData = preloadBytes > 0;
        }

        public override string ToString()
        {
            return string.Concat(Path, "/", Filename, ".", Extension);
        }

        private byte[] ReadPreloadData()
        {
            if (PreloadBytes > 0)
            {
                var buff = new byte[PreloadBytes];
                using (var fs = new FileStream(ParentArchive.ArchivePath, FileMode.Open, FileAccess.Read))
                {
                    buff = new byte[PreloadBytes];
                    fs.Seek(PreloadDataOffset, SeekOrigin.Begin);
                    fs.Read(buff, 0, buff.Length);
                }
                return buff;
            }
            return null;
        }

        private byte[] ReadData()
        {
            var partFile = ParentArchive.Parts.FirstOrDefault(part => part.Index == ArchiveIndex);
            if (partFile == null)
                return null;
            if (HasPreloadData)
                return ReadPreloadData();
            var buff = new byte[EntryLength];
            using (var fs = new FileStream(partFile.Filename, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(EntryOffset, SeekOrigin.Begin);
                fs.Read(buff, 0, buff.Length);
            }
            return buff;
        }

    }
}

namespace SharpVPK
{
    public class VpkDirectory
    {
        public List<VpkEntry> Entries { get; set; }
        public string Path { get; set; }
        internal VpkArchive ParentArchive { get; set; }

        internal VpkDirectory(VpkArchive parentArchive, string path, List<VpkEntry> entries)
        {
            Console.WriteLine(ParentArchive + " " + Path + " " + Entries[0].ToString());
            ParentArchive = parentArchive;
            Path = path;
            Entries = entries;
        }
    }
}

namespace SharpVPK
{
    internal class ArchivePart
    {
        public uint Size { get; set; }
        public int Index { get; set; }
        public string Filename { get; set; }

        public ArchivePart(uint size, int index, string filename)
        {
            Size = size;
            Index = index;
            Filename = filename;
        }
    }
}

namespace SharpVPK
{
    public class VpkArchive
    {
        public List<VpkDirectory> Directories { get; set; }
        public bool IsMultiPart { get; set; }
        private VpkReaderBase _reader;
        internal List<ArchivePart> Parts { get; set; }
        internal string ArchivePath { get; set; }

        public VpkArchive()
        {
            Directories = new List<VpkDirectory>();
        }

        public void Load(string filename)
        {
            ArchivePath = filename;
            IsMultiPart = filename.EndsWith("_dir.vpk");
            if (IsMultiPart)
                LoadParts(filename);
            _reader = new VpkReaderV1(filename);
            Console.WriteLine("readed1");
            var hdr = _reader.ReadArchiveHeader();
            Console.WriteLine("readed2");
            if (!hdr.Verify())
            {
                Console.WriteLine("error");
                throw new ArchiveParsingException("Invalid archive header");
            }
            Directories.AddRange(_reader.ReadDirectories(this));
        }

        private void LoadParts(string filename)
        {
            Console.WriteLine("load");
            Parts = new List<ArchivePart>();
            var fileBaseName = filename.Split('_')[0];
            foreach (var file in Directory.GetFiles(Path.GetDirectoryName(filename)))
            {
                Console.WriteLine("loaded: " + file);
                if (file.Split('_')[0] != fileBaseName || file == filename)
                    continue;
                var fi = new FileInfo(file);
                var partIdx = Int32.Parse(file.Split('_')[1].Split('.')[0]);
                Parts.Add(new ArchivePart((uint)fi.Length, partIdx, file));
            }
            Console.WriteLine("end");
            Parts.Add(new ArchivePart((uint)new FileInfo(filename).Length, -1, filename));
            Parts = Parts.OrderBy(p => p.Index).ToList();
        }
    }
}

namespace SharpVPK
{
    interface IVpkArchiveHeader
    {
        uint Signature { get; set; }
        uint Version { get; set; }
        uint TreeLength { get; set; }

        bool Verify();
        uint CalculateDataOffset();
    }
}

namespace SharpVPK
{
    internal abstract class VpkReaderBase
    {
        public BinaryReader Reader;
        private readonly StringBuilder _strBuilder;

        protected VpkReaderBase(string filename)
        {
            Reader = new BinaryReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
            _strBuilder = new StringBuilder(256);
        }

        public abstract IVpkArchiveHeader ReadArchiveHeader();

        public string ReadNullTerminatedString()
        {
            _strBuilder.Clear();
            char chr;
            while ((chr = Reader.ReadChar()) != 0x0)
                _strBuilder.Append(chr);
            return _strBuilder.ToString();
        }

        protected T BytesToStructure<T>(byte[] bytearray)
        {
            var structSize = Marshal.SizeOf(typeof(T));
            var pStruct = Marshal.AllocHGlobal(structSize);
            Marshal.Copy(bytearray, 0, pStruct, structSize);
            var @struct = (T)Marshal.PtrToStructure(pStruct, typeof(T));
            Marshal.FreeHGlobal(pStruct);

            return @struct;
        }

        public IEnumerable<VpkDirectory> ReadDirectories(VpkArchive parentArchive)
        {
            while (true)
            {
                var ext = ReadNullTerminatedString();
                if (string.IsNullOrEmpty(ext))
                    break;
                while (true)
                {
                    var path = ReadNullTerminatedString();
                    if (string.IsNullOrEmpty(path))
                        break;

                    var entries = ReadEntries(parentArchive, ext, path).ToList();
                    yield return new VpkDirectory(parentArchive, path, entries);
                }
            }
        }

        public IEnumerable<VpkEntry> ReadEntries(VpkArchive parentArchive, string ext, string path)
        {
            while (true)
            {
                var fileName = ReadNullTerminatedString();
                if (string.IsNullOrEmpty(fileName))
                    break;

                var crc = Reader.ReadUInt32();
                var preloadBytes = Reader.ReadUInt16();
                var archiveIdx = Reader.ReadUInt16();
                var entryOffset = Reader.ReadUInt32();
                var entryLen = Reader.ReadUInt32();
                // skip terminator
                Reader.ReadUInt16();
                var preloadDataOffset = (uint)Reader.BaseStream.Position;
                if (preloadBytes > 0)
                    Reader.BaseStream.Position += preloadBytes;

                yield return new VpkEntry(parentArchive, crc, preloadBytes, preloadDataOffset, archiveIdx, entryOffset, entryLen, ext, path, fileName);
            }
        }

        public abstract uint CalculateEntryOffset(uint offset);
    }
}