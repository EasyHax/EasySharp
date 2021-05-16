using System;
using System.Runtime.InteropServices;


using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{    
    public unsafe class Structs
    {
        public class baseStructs
        {
            public IntPtr addr;

            public static implicit operator bool(baseStructs b) => b.addr != IntPtr.Zero;
            public static implicit operator IntPtr(baseStructs b) => b.addr;
            public static implicit operator int(baseStructs b) => (int)b.addr;
        }

        #region Structs
        public class TestTraceline : baseStructs
        {
            public static implicit operator TestTraceline(IntPtr ptr) => new TestTraceline() { addr = ptr                                                                                                                                                        };
            public int m_clrRender {                             get => *(int*)(addr + Offset.DT_TestTraceline.m_clrRender);                                 set => *(int*)(addr + Offset.DT_TestTraceline.m_clrRender) = value;                                 }
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TestTraceline.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TestTraceline.m_vecOrigin) = value;                                 }
            public int m_angRotation_0 {                         get => *(int*)(addr + Offset.DT_TestTraceline.m_angRotation_0);                             set => *(int*)(addr + Offset.DT_TestTraceline.m_angRotation_0) = value;                             }
            public int m_angRotation_1 {                         get => *(int*)(addr + Offset.DT_TestTraceline.m_angRotation_1);                             set => *(int*)(addr + Offset.DT_TestTraceline.m_angRotation_1) = value;                             }
            public int m_angRotation_2 {                         get => *(int*)(addr + Offset.DT_TestTraceline.m_angRotation_2);                             set => *(int*)(addr + Offset.DT_TestTraceline.m_angRotation_2) = value;                             }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_TestTraceline.moveparent);                                  set => *(int*)(addr + Offset.DT_TestTraceline.moveparent) = value;                                  }

        }

        public class TEWorldDecal : baseStructs
        {
            public static implicit operator TEWorldDecal(IntPtr ptr) => new TEWorldDecal() { addr = ptr                                                                                                                                                          };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEWorldDecal.m_vecOrigin);                                  set => *(int*)(addr + Offset.DT_TEWorldDecal.m_vecOrigin) = value;                                  }
            public int m_nIndex {                                get => *(int*)(addr + Offset.DT_TEWorldDecal.m_nIndex);                                     set => *(int*)(addr + Offset.DT_TEWorldDecal.m_nIndex) = value;                                     }

        }

        public class TESpriteSpray : baseStructs
        {
            public static implicit operator TESpriteSpray(IntPtr ptr) => new TESpriteSpray() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TESpriteSpray.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TESpriteSpray.m_vecOrigin) = value;                                 }
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_TESpriteSpray.m_vecDirection);                              set => *(int*)(addr + Offset.DT_TESpriteSpray.m_vecDirection) = value;                              }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TESpriteSpray.m_nModelIndex);                               set => *(int*)(addr + Offset.DT_TESpriteSpray.m_nModelIndex) = value;                               }
            public int m_fNoise {                                get => *(int*)(addr + Offset.DT_TESpriteSpray.m_fNoise);                                    set => *(int*)(addr + Offset.DT_TESpriteSpray.m_fNoise) = value;                                    }
            public int m_nCount {                                get => *(int*)(addr + Offset.DT_TESpriteSpray.m_nCount);                                    set => *(int*)(addr + Offset.DT_TESpriteSpray.m_nCount) = value;                                    }
            public int m_nSpeed {                                get => *(int*)(addr + Offset.DT_TESpriteSpray.m_nSpeed);                                    set => *(int*)(addr + Offset.DT_TESpriteSpray.m_nSpeed) = value;                                    }

        }

        public class TESprite : baseStructs
        {
            public static implicit operator TESprite(IntPtr ptr) => new TESprite() { addr = ptr                                                                                                                                                                  };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TESprite.m_vecOrigin);                                      set => *(int*)(addr + Offset.DT_TESprite.m_vecOrigin) = value;                                      }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TESprite.m_nModelIndex);                                    set => *(int*)(addr + Offset.DT_TESprite.m_nModelIndex) = value;                                    }
            public int m_fScale {                                get => *(int*)(addr + Offset.DT_TESprite.m_fScale);                                         set => *(int*)(addr + Offset.DT_TESprite.m_fScale) = value;                                         }
            public int m_nBrightness {                           get => *(int*)(addr + Offset.DT_TESprite.m_nBrightness);                                    set => *(int*)(addr + Offset.DT_TESprite.m_nBrightness) = value;                                    }

        }

        public class TESparks : baseStructs
        {
            public static implicit operator TESparks(IntPtr ptr) => new TESparks() { addr = ptr                                                                                                                                                                  };
            public int m_nMagnitude {                            get => *(int*)(addr + Offset.DT_TESparks.m_nMagnitude);                                     set => *(int*)(addr + Offset.DT_TESparks.m_nMagnitude) = value;                                     }
            public int m_nTrailLength {                          get => *(int*)(addr + Offset.DT_TESparks.m_nTrailLength);                                   set => *(int*)(addr + Offset.DT_TESparks.m_nTrailLength) = value;                                   }
            public int m_vecDir {                                get => *(int*)(addr + Offset.DT_TESparks.m_vecDir);                                         set => *(int*)(addr + Offset.DT_TESparks.m_vecDir) = value;                                         }

        }

        public class TESmoke : baseStructs
        {
            public static implicit operator TESmoke(IntPtr ptr) => new TESmoke() { addr = ptr                                                                                                                                                                    };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TESmoke.m_vecOrigin);                                       set => *(int*)(addr + Offset.DT_TESmoke.m_vecOrigin) = value;                                       }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TESmoke.m_nModelIndex);                                     set => *(int*)(addr + Offset.DT_TESmoke.m_nModelIndex) = value;                                     }
            public int m_fScale {                                get => *(int*)(addr + Offset.DT_TESmoke.m_fScale);                                          set => *(int*)(addr + Offset.DT_TESmoke.m_fScale) = value;                                          }
            public int m_nFrameRate {                            get => *(int*)(addr + Offset.DT_TESmoke.m_nFrameRate);                                      set => *(int*)(addr + Offset.DT_TESmoke.m_nFrameRate) = value;                                      }

        }

        public class TEShowLine : baseStructs
        {
            public static implicit operator TEShowLine(IntPtr ptr) => new TEShowLine() { addr = ptr                                                                                                                                                              };
            public int m_vecEnd {                                get => *(int*)(addr + Offset.DT_TEShowLine.m_vecEnd);                                       set => *(int*)(addr + Offset.DT_TEShowLine.m_vecEnd) = value;                                       }

        }

        public class TEProjectedDecal : baseStructs
        {
            public static implicit operator TEProjectedDecal(IntPtr ptr) => new TEProjectedDecal() { addr = ptr                                                                                                                                                  };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEProjectedDecal.m_vecOrigin);                              set => *(int*)(addr + Offset.DT_TEProjectedDecal.m_vecOrigin) = value;                              }
            public int m_angRotation {                           get => *(int*)(addr + Offset.DT_TEProjectedDecal.m_angRotation);                            set => *(int*)(addr + Offset.DT_TEProjectedDecal.m_angRotation) = value;                            }
            public int m_flDistance {                            get => *(int*)(addr + Offset.DT_TEProjectedDecal.m_flDistance);                             set => *(int*)(addr + Offset.DT_TEProjectedDecal.m_flDistance) = value;                             }
            public int m_nIndex {                                get => *(int*)(addr + Offset.DT_TEProjectedDecal.m_nIndex);                                 set => *(int*)(addr + Offset.DT_TEProjectedDecal.m_nIndex) = value;                                 }

        }

        public class FEPlayerDecal : baseStructs
        {
            public static implicit operator FEPlayerDecal(IntPtr ptr) => new FEPlayerDecal() { addr = ptr                                                                                                                                                        };
            public int m_nUniqueID {                             get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nUniqueID);                                 set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nUniqueID) = value;                                 }
            public int m_unAccountID {                           get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_unAccountID);                               set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_unAccountID) = value;                               }
            public int m_unTraceID {                             get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_unTraceID);                                 set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_unTraceID) = value;                                 }
            public int m_rtGcTime {                              get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_rtGcTime);                                  set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_rtGcTime) = value;                                  }
            public int m_vecEndPos {                             get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecEndPos);                                 set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecEndPos) = value;                                 }
            public int m_vecStart {                              get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecStart);                                  set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecStart) = value;                                  }
            public int m_vecRight {                              get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecRight);                                  set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecRight) = value;                                  }
            public int m_vecNormal {                             get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecNormal);                                 set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_vecNormal) = value;                                 }
            public int m_nEntity {                               get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nEntity);                                   set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nEntity) = value;                                   }
            public int m_nPlayer {                               get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nPlayer);                                   set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nPlayer) = value;                                   }
            public int m_nHitbox {                               get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nHitbox);                                   set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nHitbox) = value;                                   }
            public int m_nTintID {                               get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nTintID);                                   set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nTintID) = value;                                   }
            public int m_flCreationTime {                        get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_flCreationTime);                            set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_flCreationTime) = value;                            }
            public int m_nVersion {                              get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nVersion);                                  set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_nVersion) = value;                                  }
            public int m_ubSignature {                           get => *(int*)(addr + Offset.DT_FEPlayerDecal.m_ubSignature);                               set => *(int*)(addr + Offset.DT_FEPlayerDecal.m_ubSignature) = value;                               }

        }

        public class TEPlayerDecal : baseStructs
        {
            public static implicit operator TEPlayerDecal(IntPtr ptr) => new TEPlayerDecal() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEPlayerDecal.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TEPlayerDecal.m_vecOrigin) = value;                                 }
            public int m_vecStart {                              get => *(int*)(addr + Offset.DT_TEPlayerDecal.m_vecStart);                                  set => *(int*)(addr + Offset.DT_TEPlayerDecal.m_vecStart) = value;                                  }
            public int m_vecRight {                              get => *(int*)(addr + Offset.DT_TEPlayerDecal.m_vecRight);                                  set => *(int*)(addr + Offset.DT_TEPlayerDecal.m_vecRight) = value;                                  }
            public int m_nEntity {                               get => *(int*)(addr + Offset.DT_TEPlayerDecal.m_nEntity);                                   set => *(int*)(addr + Offset.DT_TEPlayerDecal.m_nEntity) = value;                                   }
            public int m_nPlayer {                               get => *(int*)(addr + Offset.DT_TEPlayerDecal.m_nPlayer);                                   set => *(int*)(addr + Offset.DT_TEPlayerDecal.m_nPlayer) = value;                                   }
            public int m_nHitbox {                               get => *(int*)(addr + Offset.DT_TEPlayerDecal.m_nHitbox);                                   set => *(int*)(addr + Offset.DT_TEPlayerDecal.m_nHitbox) = value;                                   }

        }

        public class TEPhysicsProp : baseStructs
        {
            public static implicit operator TEPhysicsProp(IntPtr ptr) => new TEPhysicsProp() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_vecOrigin) = value;                                 }
            public int m_angRotation_0 {                         get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_angRotation_0);                             set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_angRotation_0) = value;                             }
            public int m_angRotation_1 {                         get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_angRotation_1);                             set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_angRotation_1) = value;                             }
            public int m_angRotation_2 {                         get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_angRotation_2);                             set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_angRotation_2) = value;                             }
            public int m_vecVelocity {                           get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_vecVelocity);                               set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_vecVelocity) = value;                               }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nModelIndex);                               set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nModelIndex) = value;                               }
            public int m_nFlags {                                get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nFlags);                                    set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nFlags) = value;                                    }
            public int m_nSkin {                                 get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nSkin);                                     set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nSkin) = value;                                     }
            public int m_nEffects {                              get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nEffects);                                  set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_nEffects) = value;                                  }
            public int m_clrRender {                             get => *(int*)(addr + Offset.DT_TEPhysicsProp.m_clrRender);                                 set => *(int*)(addr + Offset.DT_TEPhysicsProp.m_clrRender) = value;                                 }

        }

        public class TEParticleSystem : baseStructs
        {
            public static implicit operator TEParticleSystem(IntPtr ptr) => new TEParticleSystem() { addr = ptr                                                                                                                                                  };
            public int m_vecOrigin_0 {                           get => *(int*)(addr + Offset.DT_TEParticleSystem.m_vecOrigin_0);                            set => *(int*)(addr + Offset.DT_TEParticleSystem.m_vecOrigin_0) = value;                            }
            public int m_vecOrigin_1 {                           get => *(int*)(addr + Offset.DT_TEParticleSystem.m_vecOrigin_1);                            set => *(int*)(addr + Offset.DT_TEParticleSystem.m_vecOrigin_1) = value;                            }
            public int m_vecOrigin_2 {                           get => *(int*)(addr + Offset.DT_TEParticleSystem.m_vecOrigin_2);                            set => *(int*)(addr + Offset.DT_TEParticleSystem.m_vecOrigin_2) = value;                            }

        }

        public class TEMuzzleFlash : baseStructs
        {
            public static implicit operator TEMuzzleFlash(IntPtr ptr) => new TEMuzzleFlash() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_vecOrigin) = value;                                 }
            public int m_vecAngles {                             get => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_vecAngles);                                 set => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_vecAngles) = value;                                 }
            public int m_flScale {                               get => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_flScale);                                   set => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_flScale) = value;                                   }
            public int m_nType {                                 get => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_nType);                                     set => *(int*)(addr + Offset.DT_TEMuzzleFlash.m_nType) = value;                                     }

        }

        public class TELargeFunnel : baseStructs
        {
            public static implicit operator TELargeFunnel(IntPtr ptr) => new TELargeFunnel() { addr = ptr                                                                                                                                                        };
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TELargeFunnel.m_nModelIndex);                               set => *(int*)(addr + Offset.DT_TELargeFunnel.m_nModelIndex) = value;                               }
            public int m_nReversed {                             get => *(int*)(addr + Offset.DT_TELargeFunnel.m_nReversed);                                 set => *(int*)(addr + Offset.DT_TELargeFunnel.m_nReversed) = value;                                 }

        }

        public class TEKillPlayerAttachments : baseStructs
        {
            public static implicit operator TEKillPlayerAttachments(IntPtr ptr) => new TEKillPlayerAttachments() { addr = ptr                                                                                                                                    };
            public int m_nPlayer {                               get => *(int*)(addr + Offset.DT_TEKillPlayerAttachments.m_nPlayer);                         set => *(int*)(addr + Offset.DT_TEKillPlayerAttachments.m_nPlayer) = value;                         }

        }

        public class TEImpact : baseStructs
        {
            public static implicit operator TEImpact(IntPtr ptr) => new TEImpact() { addr = ptr                                                                                                                                                                  };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEImpact.m_vecOrigin);                                      set => *(int*)(addr + Offset.DT_TEImpact.m_vecOrigin) = value;                                      }
            public int m_vecNormal {                             get => *(int*)(addr + Offset.DT_TEImpact.m_vecNormal);                                      set => *(int*)(addr + Offset.DT_TEImpact.m_vecNormal) = value;                                      }
            public int m_iType {                                 get => *(int*)(addr + Offset.DT_TEImpact.m_iType);                                          set => *(int*)(addr + Offset.DT_TEImpact.m_iType) = value;                                          }
            public int m_ucFlags {                               get => *(int*)(addr + Offset.DT_TEImpact.m_ucFlags);                                        set => *(int*)(addr + Offset.DT_TEImpact.m_ucFlags) = value;                                        }

        }

        public class TEGlowSprite : baseStructs
        {
            public static implicit operator TEGlowSprite(IntPtr ptr) => new TEGlowSprite() { addr = ptr                                                                                                                                                          };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEGlowSprite.m_vecOrigin);                                  set => *(int*)(addr + Offset.DT_TEGlowSprite.m_vecOrigin) = value;                                  }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEGlowSprite.m_nModelIndex);                                set => *(int*)(addr + Offset.DT_TEGlowSprite.m_nModelIndex) = value;                                }
            public int m_fScale {                                get => *(int*)(addr + Offset.DT_TEGlowSprite.m_fScale);                                     set => *(int*)(addr + Offset.DT_TEGlowSprite.m_fScale) = value;                                     }
            public int m_fLife {                                 get => *(int*)(addr + Offset.DT_TEGlowSprite.m_fLife);                                      set => *(int*)(addr + Offset.DT_TEGlowSprite.m_fLife) = value;                                      }
            public int m_nBrightness {                           get => *(int*)(addr + Offset.DT_TEGlowSprite.m_nBrightness);                                set => *(int*)(addr + Offset.DT_TEGlowSprite.m_nBrightness) = value;                                }

        }

        public class TEShatterSurface : baseStructs
        {
            public static implicit operator TEShatterSurface(IntPtr ptr) => new TEShatterSurface() { addr = ptr                                                                                                                                                  };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecOrigin);                              set => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecOrigin) = value;                              }
            public int m_vecAngles {                             get => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecAngles);                              set => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecAngles) = value;                              }
            public int m_vecForce {                              get => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecForce);                               set => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecForce) = value;                               }
            public int m_vecForcePos {                           get => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecForcePos);                            set => *(int*)(addr + Offset.DT_TEShatterSurface.m_vecForcePos) = value;                            }
            public int m_flWidth {                               get => *(int*)(addr + Offset.DT_TEShatterSurface.m_flWidth);                                set => *(int*)(addr + Offset.DT_TEShatterSurface.m_flWidth) = value;                                }
            public int m_flHeight {                              get => *(int*)(addr + Offset.DT_TEShatterSurface.m_flHeight);                               set => *(int*)(addr + Offset.DT_TEShatterSurface.m_flHeight) = value;                               }
            public int m_flShardSize {                           get => *(int*)(addr + Offset.DT_TEShatterSurface.m_flShardSize);                            set => *(int*)(addr + Offset.DT_TEShatterSurface.m_flShardSize) = value;                            }
            public int m_nSurfaceType {                          get => *(int*)(addr + Offset.DT_TEShatterSurface.m_nSurfaceType);                           set => *(int*)(addr + Offset.DT_TEShatterSurface.m_nSurfaceType) = value;                           }
            public int m_uchFrontColor_0 {                       get => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchFrontColor_0);                        set => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchFrontColor_0) = value;                        }
            public int m_uchFrontColor_1 {                       get => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchFrontColor_1);                        set => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchFrontColor_1) = value;                        }
            public int m_uchFrontColor_2 {                       get => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchFrontColor_2);                        set => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchFrontColor_2) = value;                        }
            public int m_uchBackColor_0 {                        get => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchBackColor_0);                         set => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchBackColor_0) = value;                         }
            public int m_uchBackColor_1 {                        get => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchBackColor_1);                         set => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchBackColor_1) = value;                         }
            public int m_uchBackColor_2 {                        get => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchBackColor_2);                         set => *(int*)(addr + Offset.DT_TEShatterSurface.m_uchBackColor_2) = value;                         }

        }

        public class TEFootprintDecal : baseStructs
        {
            public static implicit operator TEFootprintDecal(IntPtr ptr) => new TEFootprintDecal() { addr = ptr                                                                                                                                                  };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEFootprintDecal.m_vecOrigin);                              set => *(int*)(addr + Offset.DT_TEFootprintDecal.m_vecOrigin) = value;                              }
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_TEFootprintDecal.m_vecDirection);                           set => *(int*)(addr + Offset.DT_TEFootprintDecal.m_vecDirection) = value;                           }
            public int m_nEntity {                               get => *(int*)(addr + Offset.DT_TEFootprintDecal.m_nEntity);                                set => *(int*)(addr + Offset.DT_TEFootprintDecal.m_nEntity) = value;                                }
            public int m_nIndex {                                get => *(int*)(addr + Offset.DT_TEFootprintDecal.m_nIndex);                                 set => *(int*)(addr + Offset.DT_TEFootprintDecal.m_nIndex) = value;                                 }
            public int m_chMaterialType {                        get => *(int*)(addr + Offset.DT_TEFootprintDecal.m_chMaterialType);                         set => *(int*)(addr + Offset.DT_TEFootprintDecal.m_chMaterialType) = value;                         }

        }

        public class TEFizz : baseStructs
        {
            public static implicit operator TEFizz(IntPtr ptr) => new TEFizz() { addr = ptr                                                                                                                                                                      };
            public int m_nEntity {                               get => *(int*)(addr + Offset.DT_TEFizz.m_nEntity);                                          set => *(int*)(addr + Offset.DT_TEFizz.m_nEntity) = value;                                          }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEFizz.m_nModelIndex);                                      set => *(int*)(addr + Offset.DT_TEFizz.m_nModelIndex) = value;                                      }
            public int m_nDensity {                              get => *(int*)(addr + Offset.DT_TEFizz.m_nDensity);                                         set => *(int*)(addr + Offset.DT_TEFizz.m_nDensity) = value;                                         }
            public int m_nCurrent {                              get => *(int*)(addr + Offset.DT_TEFizz.m_nCurrent);                                         set => *(int*)(addr + Offset.DT_TEFizz.m_nCurrent) = value;                                         }

        }

        public class TEExplosion : baseStructs
        {
            public static implicit operator TEExplosion(IntPtr ptr) => new TEExplosion() { addr = ptr                                                                                                                                                            };
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEExplosion.m_nModelIndex);                                 set => *(int*)(addr + Offset.DT_TEExplosion.m_nModelIndex) = value;                                 }
            public int m_fScale {                                get => *(int*)(addr + Offset.DT_TEExplosion.m_fScale);                                      set => *(int*)(addr + Offset.DT_TEExplosion.m_fScale) = value;                                      }
            public int m_nFrameRate {                            get => *(int*)(addr + Offset.DT_TEExplosion.m_nFrameRate);                                  set => *(int*)(addr + Offset.DT_TEExplosion.m_nFrameRate) = value;                                  }
            public int m_nFlags {                                get => *(int*)(addr + Offset.DT_TEExplosion.m_nFlags);                                      set => *(int*)(addr + Offset.DT_TEExplosion.m_nFlags) = value;                                      }
            public int m_vecNormal {                             get => *(int*)(addr + Offset.DT_TEExplosion.m_vecNormal);                                   set => *(int*)(addr + Offset.DT_TEExplosion.m_vecNormal) = value;                                   }
            public int m_chMaterialType {                        get => *(int*)(addr + Offset.DT_TEExplosion.m_chMaterialType);                              set => *(int*)(addr + Offset.DT_TEExplosion.m_chMaterialType) = value;                              }
            public int m_nRadius {                               get => *(int*)(addr + Offset.DT_TEExplosion.m_nRadius);                                     set => *(int*)(addr + Offset.DT_TEExplosion.m_nRadius) = value;                                     }
            public int m_nMagnitude {                            get => *(int*)(addr + Offset.DT_TEExplosion.m_nMagnitude);                                  set => *(int*)(addr + Offset.DT_TEExplosion.m_nMagnitude) = value;                                  }

        }

        public class TEEnergySplash : baseStructs
        {
            public static implicit operator TEEnergySplash(IntPtr ptr) => new TEEnergySplash() { addr = ptr                                                                                                                                                      };
            public int m_vecPos {                                get => *(int*)(addr + Offset.DT_TEEnergySplash.m_vecPos);                                   set => *(int*)(addr + Offset.DT_TEEnergySplash.m_vecPos) = value;                                   }
            public int m_vecDir {                                get => *(int*)(addr + Offset.DT_TEEnergySplash.m_vecDir);                                   set => *(int*)(addr + Offset.DT_TEEnergySplash.m_vecDir) = value;                                   }
            public int m_bExplosive {                            get => *(int*)(addr + Offset.DT_TEEnergySplash.m_bExplosive);                               set => *(int*)(addr + Offset.DT_TEEnergySplash.m_bExplosive) = value;                               }

        }

        public class TEDynamicLight : baseStructs
        {
            public static implicit operator TEDynamicLight(IntPtr ptr) => new TEDynamicLight() { addr = ptr                                                                                                                                                      };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEDynamicLight.m_vecOrigin);                                set => *(int*)(addr + Offset.DT_TEDynamicLight.m_vecOrigin) = value;                                }
            public int r {                                       get => *(int*)(addr + Offset.DT_TEDynamicLight.r);                                          set => *(int*)(addr + Offset.DT_TEDynamicLight.r) = value;                                          }
            public int g {                                       get => *(int*)(addr + Offset.DT_TEDynamicLight.g);                                          set => *(int*)(addr + Offset.DT_TEDynamicLight.g) = value;                                          }
            public int b {                                       get => *(int*)(addr + Offset.DT_TEDynamicLight.b);                                          set => *(int*)(addr + Offset.DT_TEDynamicLight.b) = value;                                          }
            public int exponent {                                get => *(int*)(addr + Offset.DT_TEDynamicLight.exponent);                                   set => *(int*)(addr + Offset.DT_TEDynamicLight.exponent) = value;                                   }
            public int m_fRadius {                               get => *(int*)(addr + Offset.DT_TEDynamicLight.m_fRadius);                                  set => *(int*)(addr + Offset.DT_TEDynamicLight.m_fRadius) = value;                                  }
            public int m_fTime {                                 get => *(int*)(addr + Offset.DT_TEDynamicLight.m_fTime);                                    set => *(int*)(addr + Offset.DT_TEDynamicLight.m_fTime) = value;                                    }
            public int m_fDecay {                                get => *(int*)(addr + Offset.DT_TEDynamicLight.m_fDecay);                                   set => *(int*)(addr + Offset.DT_TEDynamicLight.m_fDecay) = value;                                   }

        }

        public class TEDecal : baseStructs
        {
            public static implicit operator TEDecal(IntPtr ptr) => new TEDecal() { addr = ptr                                                                                                                                                                    };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEDecal.m_vecOrigin);                                       set => *(int*)(addr + Offset.DT_TEDecal.m_vecOrigin) = value;                                       }
            public int m_vecStart {                              get => *(int*)(addr + Offset.DT_TEDecal.m_vecStart);                                        set => *(int*)(addr + Offset.DT_TEDecal.m_vecStart) = value;                                        }
            public int m_nEntity {                               get => *(int*)(addr + Offset.DT_TEDecal.m_nEntity);                                         set => *(int*)(addr + Offset.DT_TEDecal.m_nEntity) = value;                                         }
            public int m_nHitbox {                               get => *(int*)(addr + Offset.DT_TEDecal.m_nHitbox);                                         set => *(int*)(addr + Offset.DT_TEDecal.m_nHitbox) = value;                                         }
            public int m_nIndex {                                get => *(int*)(addr + Offset.DT_TEDecal.m_nIndex);                                          set => *(int*)(addr + Offset.DT_TEDecal.m_nIndex) = value;                                          }

        }

        public class TEClientProjectile : baseStructs
        {
            public static implicit operator TEClientProjectile(IntPtr ptr) => new TEClientProjectile() { addr = ptr                                                                                                                                              };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEClientProjectile.m_vecOrigin);                            set => *(int*)(addr + Offset.DT_TEClientProjectile.m_vecOrigin) = value;                            }
            public int m_vecVelocity {                           get => *(int*)(addr + Offset.DT_TEClientProjectile.m_vecVelocity);                          set => *(int*)(addr + Offset.DT_TEClientProjectile.m_vecVelocity) = value;                          }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEClientProjectile.m_nModelIndex);                          set => *(int*)(addr + Offset.DT_TEClientProjectile.m_nModelIndex) = value;                          }
            public int m_nLifeTime {                             get => *(int*)(addr + Offset.DT_TEClientProjectile.m_nLifeTime);                            set => *(int*)(addr + Offset.DT_TEClientProjectile.m_nLifeTime) = value;                            }
            public int m_hOwner {                                get => *(int*)(addr + Offset.DT_TEClientProjectile.m_hOwner);                               set => *(int*)(addr + Offset.DT_TEClientProjectile.m_hOwner) = value;                               }

        }

        public class TEBubbleTrail : baseStructs
        {
            public static implicit operator TEBubbleTrail(IntPtr ptr) => new TEBubbleTrail() { addr = ptr                                                                                                                                                        };
            public int m_vecMins {                               get => *(int*)(addr + Offset.DT_TEBubbleTrail.m_vecMins);                                   set => *(int*)(addr + Offset.DT_TEBubbleTrail.m_vecMins) = value;                                   }
            public int m_vecMaxs {                               get => *(int*)(addr + Offset.DT_TEBubbleTrail.m_vecMaxs);                                   set => *(int*)(addr + Offset.DT_TEBubbleTrail.m_vecMaxs) = value;                                   }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEBubbleTrail.m_nModelIndex);                               set => *(int*)(addr + Offset.DT_TEBubbleTrail.m_nModelIndex) = value;                               }
            public int m_flWaterZ {                              get => *(int*)(addr + Offset.DT_TEBubbleTrail.m_flWaterZ);                                  set => *(int*)(addr + Offset.DT_TEBubbleTrail.m_flWaterZ) = value;                                  }
            public int m_nCount {                                get => *(int*)(addr + Offset.DT_TEBubbleTrail.m_nCount);                                    set => *(int*)(addr + Offset.DT_TEBubbleTrail.m_nCount) = value;                                    }
            public int m_fSpeed {                                get => *(int*)(addr + Offset.DT_TEBubbleTrail.m_fSpeed);                                    set => *(int*)(addr + Offset.DT_TEBubbleTrail.m_fSpeed) = value;                                    }

        }

        public class TEBubbles : baseStructs
        {
            public static implicit operator TEBubbles(IntPtr ptr) => new TEBubbles() { addr = ptr                                                                                                                                                                };
            public int m_vecMins {                               get => *(int*)(addr + Offset.DT_TEBubbles.m_vecMins);                                       set => *(int*)(addr + Offset.DT_TEBubbles.m_vecMins) = value;                                       }
            public int m_vecMaxs {                               get => *(int*)(addr + Offset.DT_TEBubbles.m_vecMaxs);                                       set => *(int*)(addr + Offset.DT_TEBubbles.m_vecMaxs) = value;                                       }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEBubbles.m_nModelIndex);                                   set => *(int*)(addr + Offset.DT_TEBubbles.m_nModelIndex) = value;                                   }
            public int m_fHeight {                               get => *(int*)(addr + Offset.DT_TEBubbles.m_fHeight);                                       set => *(int*)(addr + Offset.DT_TEBubbles.m_fHeight) = value;                                       }
            public int m_nCount {                                get => *(int*)(addr + Offset.DT_TEBubbles.m_nCount);                                        set => *(int*)(addr + Offset.DT_TEBubbles.m_nCount) = value;                                        }
            public int m_fSpeed {                                get => *(int*)(addr + Offset.DT_TEBubbles.m_fSpeed);                                        set => *(int*)(addr + Offset.DT_TEBubbles.m_fSpeed) = value;                                        }

        }

        public class TEBSPDecal : baseStructs
        {
            public static implicit operator TEBSPDecal(IntPtr ptr) => new TEBSPDecal() { addr = ptr                                                                                                                                                              };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEBSPDecal.m_vecOrigin);                                    set => *(int*)(addr + Offset.DT_TEBSPDecal.m_vecOrigin) = value;                                    }
            public int m_nEntity {                               get => *(int*)(addr + Offset.DT_TEBSPDecal.m_nEntity);                                      set => *(int*)(addr + Offset.DT_TEBSPDecal.m_nEntity) = value;                                      }
            public int m_nIndex {                                get => *(int*)(addr + Offset.DT_TEBSPDecal.m_nIndex);                                       set => *(int*)(addr + Offset.DT_TEBSPDecal.m_nIndex) = value;                                       }

        }

        public class TEBreakModel : baseStructs
        {
            public static implicit operator TEBreakModel(IntPtr ptr) => new TEBreakModel() { addr = ptr                                                                                                                                                          };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEBreakModel.m_vecOrigin);                                  set => *(int*)(addr + Offset.DT_TEBreakModel.m_vecOrigin) = value;                                  }
            public int m_angRotation_0 {                         get => *(int*)(addr + Offset.DT_TEBreakModel.m_angRotation_0);                              set => *(int*)(addr + Offset.DT_TEBreakModel.m_angRotation_0) = value;                              }
            public int m_angRotation_1 {                         get => *(int*)(addr + Offset.DT_TEBreakModel.m_angRotation_1);                              set => *(int*)(addr + Offset.DT_TEBreakModel.m_angRotation_1) = value;                              }
            public int m_angRotation_2 {                         get => *(int*)(addr + Offset.DT_TEBreakModel.m_angRotation_2);                              set => *(int*)(addr + Offset.DT_TEBreakModel.m_angRotation_2) = value;                              }
            public int m_vecSize {                               get => *(int*)(addr + Offset.DT_TEBreakModel.m_vecSize);                                    set => *(int*)(addr + Offset.DT_TEBreakModel.m_vecSize) = value;                                    }
            public int m_vecVelocity {                           get => *(int*)(addr + Offset.DT_TEBreakModel.m_vecVelocity);                                set => *(int*)(addr + Offset.DT_TEBreakModel.m_vecVelocity) = value;                                }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_TEBreakModel.m_nModelIndex);                                set => *(int*)(addr + Offset.DT_TEBreakModel.m_nModelIndex) = value;                                }
            public int m_nRandomization {                        get => *(int*)(addr + Offset.DT_TEBreakModel.m_nRandomization);                             set => *(int*)(addr + Offset.DT_TEBreakModel.m_nRandomization) = value;                             }
            public int m_nCount {                                get => *(int*)(addr + Offset.DT_TEBreakModel.m_nCount);                                     set => *(int*)(addr + Offset.DT_TEBreakModel.m_nCount) = value;                                     }
            public int m_fTime {                                 get => *(int*)(addr + Offset.DT_TEBreakModel.m_fTime);                                      set => *(int*)(addr + Offset.DT_TEBreakModel.m_fTime) = value;                                      }
            public int m_nFlags {                                get => *(int*)(addr + Offset.DT_TEBreakModel.m_nFlags);                                     set => *(int*)(addr + Offset.DT_TEBreakModel.m_nFlags) = value;                                     }

        }

        public class TEBloodStream : baseStructs
        {
            public static implicit operator TEBloodStream(IntPtr ptr) => new TEBloodStream() { addr = ptr                                                                                                                                                        };
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_TEBloodStream.m_vecDirection);                              set => *(int*)(addr + Offset.DT_TEBloodStream.m_vecDirection) = value;                              }
            public int r {                                       get => *(int*)(addr + Offset.DT_TEBloodStream.r);                                           set => *(int*)(addr + Offset.DT_TEBloodStream.r) = value;                                           }
            public int g {                                       get => *(int*)(addr + Offset.DT_TEBloodStream.g);                                           set => *(int*)(addr + Offset.DT_TEBloodStream.g) = value;                                           }
            public int b {                                       get => *(int*)(addr + Offset.DT_TEBloodStream.b);                                           set => *(int*)(addr + Offset.DT_TEBloodStream.b) = value;                                           }
            public int a {                                       get => *(int*)(addr + Offset.DT_TEBloodStream.a);                                           set => *(int*)(addr + Offset.DT_TEBloodStream.a) = value;                                           }
            public int m_nAmount {                               get => *(int*)(addr + Offset.DT_TEBloodStream.m_nAmount);                                   set => *(int*)(addr + Offset.DT_TEBloodStream.m_nAmount) = value;                                   }

        }

        public class TEBloodSprite : baseStructs
        {
            public static implicit operator TEBloodSprite(IntPtr ptr) => new TEBloodSprite() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEBloodSprite.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TEBloodSprite.m_vecOrigin) = value;                                 }
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_TEBloodSprite.m_vecDirection);                              set => *(int*)(addr + Offset.DT_TEBloodSprite.m_vecDirection) = value;                              }
            public int r {                                       get => *(int*)(addr + Offset.DT_TEBloodSprite.r);                                           set => *(int*)(addr + Offset.DT_TEBloodSprite.r) = value;                                           }
            public int g {                                       get => *(int*)(addr + Offset.DT_TEBloodSprite.g);                                           set => *(int*)(addr + Offset.DT_TEBloodSprite.g) = value;                                           }
            public int b {                                       get => *(int*)(addr + Offset.DT_TEBloodSprite.b);                                           set => *(int*)(addr + Offset.DT_TEBloodSprite.b) = value;                                           }
            public int a {                                       get => *(int*)(addr + Offset.DT_TEBloodSprite.a);                                           set => *(int*)(addr + Offset.DT_TEBloodSprite.a) = value;                                           }
            public int m_nSprayModel {                           get => *(int*)(addr + Offset.DT_TEBloodSprite.m_nSprayModel);                               set => *(int*)(addr + Offset.DT_TEBloodSprite.m_nSprayModel) = value;                               }
            public int m_nDropModel {                            get => *(int*)(addr + Offset.DT_TEBloodSprite.m_nDropModel);                                set => *(int*)(addr + Offset.DT_TEBloodSprite.m_nDropModel) = value;                                }
            public int m_nSize {                                 get => *(int*)(addr + Offset.DT_TEBloodSprite.m_nSize);                                     set => *(int*)(addr + Offset.DT_TEBloodSprite.m_nSize) = value;                                     }

        }

        public class TEBeamSpline : baseStructs
        {
            public static implicit operator TEBeamSpline(IntPtr ptr) => new TEBeamSpline() { addr = ptr                                                                                                                                                          };
            public int m_nPoints {                               get => *(int*)(addr + Offset.DT_TEBeamSpline.m_nPoints);                                    set => *(int*)(addr + Offset.DT_TEBeamSpline.m_nPoints) = value;                                    }
            public int m_vecPoints_0 {                           get => *(int*)(addr + Offset.DT_TEBeamSpline.m_vecPoints_0);                                set => *(int*)(addr + Offset.DT_TEBeamSpline.m_vecPoints_0) = value;                                }
            public int m_vecPoints {                             get => *(int*)(addr + Offset.DT_TEBeamSpline.m_vecPoints);                                  set => *(int*)(addr + Offset.DT_TEBeamSpline.m_vecPoints) = value;                                  }

        }

        public class TEBeamRingPoint : baseStructs
        {
            public static implicit operator TEBeamRingPoint(IntPtr ptr) => new TEBeamRingPoint() { addr = ptr                                                                                                                                                    };
            public int m_vecCenter {                             get => *(int*)(addr + Offset.DT_TEBeamRingPoint.m_vecCenter);                               set => *(int*)(addr + Offset.DT_TEBeamRingPoint.m_vecCenter) = value;                               }
            public int m_flStartRadius {                         get => *(int*)(addr + Offset.DT_TEBeamRingPoint.m_flStartRadius);                           set => *(int*)(addr + Offset.DT_TEBeamRingPoint.m_flStartRadius) = value;                           }
            public int m_flEndRadius {                           get => *(int*)(addr + Offset.DT_TEBeamRingPoint.m_flEndRadius);                             set => *(int*)(addr + Offset.DT_TEBeamRingPoint.m_flEndRadius) = value;                             }

        }

        public class TEBeamRing : baseStructs
        {
            public static implicit operator TEBeamRing(IntPtr ptr) => new TEBeamRing() { addr = ptr                                                                                                                                                              };
            public int m_nStartEntity {                          get => *(int*)(addr + Offset.DT_TEBeamRing.m_nStartEntity);                                 set => *(int*)(addr + Offset.DT_TEBeamRing.m_nStartEntity) = value;                                 }
            public int m_nEndEntity {                            get => *(int*)(addr + Offset.DT_TEBeamRing.m_nEndEntity);                                   set => *(int*)(addr + Offset.DT_TEBeamRing.m_nEndEntity) = value;                                   }

        }

        public class TEBeamPoints : baseStructs
        {
            public static implicit operator TEBeamPoints(IntPtr ptr) => new TEBeamPoints() { addr = ptr                                                                                                                                                          };
            public int m_vecStartPoint {                         get => *(int*)(addr + Offset.DT_TEBeamPoints.m_vecStartPoint);                              set => *(int*)(addr + Offset.DT_TEBeamPoints.m_vecStartPoint) = value;                              }
            public int m_vecEndPoint {                           get => *(int*)(addr + Offset.DT_TEBeamPoints.m_vecEndPoint);                                set => *(int*)(addr + Offset.DT_TEBeamPoints.m_vecEndPoint) = value;                                }

        }

        public class TEBeamLaser : baseStructs
        {
            public static implicit operator TEBeamLaser(IntPtr ptr) => new TEBeamLaser() { addr = ptr                                                                                                                                                            };
            public int m_nStartEntity {                          get => *(int*)(addr + Offset.DT_TEBeamLaser.m_nStartEntity);                                set => *(int*)(addr + Offset.DT_TEBeamLaser.m_nStartEntity) = value;                                }
            public int m_nEndEntity {                            get => *(int*)(addr + Offset.DT_TEBeamLaser.m_nEndEntity);                                  set => *(int*)(addr + Offset.DT_TEBeamLaser.m_nEndEntity) = value;                                  }

        }

        public class TEBeamFollow : baseStructs
        {
            public static implicit operator TEBeamFollow(IntPtr ptr) => new TEBeamFollow() { addr = ptr                                                                                                                                                          };
            public int m_iEntIndex {                             get => *(int*)(addr + Offset.DT_TEBeamFollow.m_iEntIndex);                                  set => *(int*)(addr + Offset.DT_TEBeamFollow.m_iEntIndex) = value;                                  }

        }

        public class TEBeamEnts : baseStructs
        {
            public static implicit operator TEBeamEnts(IntPtr ptr) => new TEBeamEnts() { addr = ptr                                                                                                                                                              };
            public int m_nStartEntity {                          get => *(int*)(addr + Offset.DT_TEBeamEnts.m_nStartEntity);                                 set => *(int*)(addr + Offset.DT_TEBeamEnts.m_nStartEntity) = value;                                 }
            public int m_nEndEntity {                            get => *(int*)(addr + Offset.DT_TEBeamEnts.m_nEndEntity);                                   set => *(int*)(addr + Offset.DT_TEBeamEnts.m_nEndEntity) = value;                                   }

        }

        public class TEBeamEntPoint : baseStructs
        {
            public static implicit operator TEBeamEntPoint(IntPtr ptr) => new TEBeamEntPoint() { addr = ptr                                                                                                                                                      };
            public int m_nStartEntity {                          get => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_nStartEntity);                             set => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_nStartEntity) = value;                             }
            public int m_nEndEntity {                            get => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_nEndEntity);                               set => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_nEndEntity) = value;                               }
            public int m_vecStartPoint {                         get => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_vecStartPoint);                            set => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_vecStartPoint) = value;                            }
            public int m_vecEndPoint {                           get => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_vecEndPoint);                              set => *(int*)(addr + Offset.DT_TEBeamEntPoint.m_vecEndPoint) = value;                              }

        }

        public class BaseBeam : baseStructs
        {
            public static implicit operator BaseBeam(IntPtr ptr) => new BaseBeam() { addr = ptr                                                                                                                                                                  };
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_BaseBeam.m_nModelIndex);                                    set => *(int*)(addr + Offset.DT_BaseBeam.m_nModelIndex) = value;                                    }
            public int m_nHaloIndex {                            get => *(int*)(addr + Offset.DT_BaseBeam.m_nHaloIndex);                                     set => *(int*)(addr + Offset.DT_BaseBeam.m_nHaloIndex) = value;                                     }
            public int m_nStartFrame {                           get => *(int*)(addr + Offset.DT_BaseBeam.m_nStartFrame);                                    set => *(int*)(addr + Offset.DT_BaseBeam.m_nStartFrame) = value;                                    }
            public int m_nFrameRate {                            get => *(int*)(addr + Offset.DT_BaseBeam.m_nFrameRate);                                     set => *(int*)(addr + Offset.DT_BaseBeam.m_nFrameRate) = value;                                     }
            public int m_fLife {                                 get => *(int*)(addr + Offset.DT_BaseBeam.m_fLife);                                          set => *(int*)(addr + Offset.DT_BaseBeam.m_fLife) = value;                                          }
            public int m_fWidth {                                get => *(int*)(addr + Offset.DT_BaseBeam.m_fWidth);                                         set => *(int*)(addr + Offset.DT_BaseBeam.m_fWidth) = value;                                         }
            public int m_fEndWidth {                             get => *(int*)(addr + Offset.DT_BaseBeam.m_fEndWidth);                                      set => *(int*)(addr + Offset.DT_BaseBeam.m_fEndWidth) = value;                                      }
            public int m_nFadeLength {                           get => *(int*)(addr + Offset.DT_BaseBeam.m_nFadeLength);                                    set => *(int*)(addr + Offset.DT_BaseBeam.m_nFadeLength) = value;                                    }
            public int m_fAmplitude {                            get => *(int*)(addr + Offset.DT_BaseBeam.m_fAmplitude);                                     set => *(int*)(addr + Offset.DT_BaseBeam.m_fAmplitude) = value;                                     }
            public int m_nSpeed {                                get => *(int*)(addr + Offset.DT_BaseBeam.m_nSpeed);                                         set => *(int*)(addr + Offset.DT_BaseBeam.m_nSpeed) = value;                                         }
            public int r {                                       get => *(int*)(addr + Offset.DT_BaseBeam.r);                                                set => *(int*)(addr + Offset.DT_BaseBeam.r) = value;                                                }
            public int g {                                       get => *(int*)(addr + Offset.DT_BaseBeam.g);                                                set => *(int*)(addr + Offset.DT_BaseBeam.g) = value;                                                }
            public int b {                                       get => *(int*)(addr + Offset.DT_BaseBeam.b);                                                set => *(int*)(addr + Offset.DT_BaseBeam.b) = value;                                                }
            public int a {                                       get => *(int*)(addr + Offset.DT_BaseBeam.a);                                                set => *(int*)(addr + Offset.DT_BaseBeam.a) = value;                                                }
            public int m_nFlags {                                get => *(int*)(addr + Offset.DT_BaseBeam.m_nFlags);                                         set => *(int*)(addr + Offset.DT_BaseBeam.m_nFlags) = value;                                         }

        }

        public class TEMetalSparks : baseStructs
        {
            public static implicit operator TEMetalSparks(IntPtr ptr) => new TEMetalSparks() { addr = ptr                                                                                                                                                        };
            public int m_vecPos {                                get => *(int*)(addr + Offset.DT_TEMetalSparks.m_vecPos);                                    set => *(int*)(addr + Offset.DT_TEMetalSparks.m_vecPos) = value;                                    }
            public int m_vecDir {                                get => *(int*)(addr + Offset.DT_TEMetalSparks.m_vecDir);                                    set => *(int*)(addr + Offset.DT_TEMetalSparks.m_vecDir) = value;                                    }

        }

        public class SteamJet : baseStructs
        {
            public static implicit operator SteamJet(IntPtr ptr) => new SteamJet() { addr = ptr                                                                                                                                                                  };
            public int m_SpreadSpeed {                           get => *(int*)(addr + Offset.DT_SteamJet.m_SpreadSpeed);                                    set => *(int*)(addr + Offset.DT_SteamJet.m_SpreadSpeed) = value;                                    }
            public int m_Speed {                                 get => *(int*)(addr + Offset.DT_SteamJet.m_Speed);                                          set => *(int*)(addr + Offset.DT_SteamJet.m_Speed) = value;                                          }
            public int m_StartSize {                             get => *(int*)(addr + Offset.DT_SteamJet.m_StartSize);                                      set => *(int*)(addr + Offset.DT_SteamJet.m_StartSize) = value;                                      }
            public int m_EndSize {                               get => *(int*)(addr + Offset.DT_SteamJet.m_EndSize);                                        set => *(int*)(addr + Offset.DT_SteamJet.m_EndSize) = value;                                        }
            public int m_Rate {                                  get => *(int*)(addr + Offset.DT_SteamJet.m_Rate);                                           set => *(int*)(addr + Offset.DT_SteamJet.m_Rate) = value;                                           }
            public int m_JetLength {                             get => *(int*)(addr + Offset.DT_SteamJet.m_JetLength);                                      set => *(int*)(addr + Offset.DT_SteamJet.m_JetLength) = value;                                      }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_SteamJet.m_bEmit);                                          set => *(int*)(addr + Offset.DT_SteamJet.m_bEmit) = value;                                          }
            public int m_bFaceLeft {                             get => *(int*)(addr + Offset.DT_SteamJet.m_bFaceLeft);                                      set => *(int*)(addr + Offset.DT_SteamJet.m_bFaceLeft) = value;                                      }
            public int m_nType {                                 get => *(int*)(addr + Offset.DT_SteamJet.m_nType);                                          set => *(int*)(addr + Offset.DT_SteamJet.m_nType) = value;                                          }
            public int m_spawnflags {                            get => *(int*)(addr + Offset.DT_SteamJet.m_spawnflags);                                     set => *(int*)(addr + Offset.DT_SteamJet.m_spawnflags) = value;                                     }
            public int m_flRollSpeed {                           get => *(int*)(addr + Offset.DT_SteamJet.m_flRollSpeed);                                    set => *(int*)(addr + Offset.DT_SteamJet.m_flRollSpeed) = value;                                    }

        }

        public class SmokeStack : baseStructs
        {
            public static implicit operator SmokeStack(IntPtr ptr) => new SmokeStack() { addr = ptr                                                                                                                                                              };
            public int m_SpreadSpeed {                           get => *(int*)(addr + Offset.DT_SmokeStack.m_SpreadSpeed);                                  set => *(int*)(addr + Offset.DT_SmokeStack.m_SpreadSpeed) = value;                                  }
            public int m_Speed {                                 get => *(int*)(addr + Offset.DT_SmokeStack.m_Speed);                                        set => *(int*)(addr + Offset.DT_SmokeStack.m_Speed) = value;                                        }
            public int m_StartSize {                             get => *(int*)(addr + Offset.DT_SmokeStack.m_StartSize);                                    set => *(int*)(addr + Offset.DT_SmokeStack.m_StartSize) = value;                                    }
            public int m_EndSize {                               get => *(int*)(addr + Offset.DT_SmokeStack.m_EndSize);                                      set => *(int*)(addr + Offset.DT_SmokeStack.m_EndSize) = value;                                      }
            public int m_Rate {                                  get => *(int*)(addr + Offset.DT_SmokeStack.m_Rate);                                         set => *(int*)(addr + Offset.DT_SmokeStack.m_Rate) = value;                                         }
            public int m_JetLength {                             get => *(int*)(addr + Offset.DT_SmokeStack.m_JetLength);                                    set => *(int*)(addr + Offset.DT_SmokeStack.m_JetLength) = value;                                    }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_SmokeStack.m_bEmit);                                        set => *(int*)(addr + Offset.DT_SmokeStack.m_bEmit) = value;                                        }
            public int m_flBaseSpread {                          get => *(int*)(addr + Offset.DT_SmokeStack.m_flBaseSpread);                                 set => *(int*)(addr + Offset.DT_SmokeStack.m_flBaseSpread) = value;                                 }
            public int m_flTwist {                               get => *(int*)(addr + Offset.DT_SmokeStack.m_flTwist);                                      set => *(int*)(addr + Offset.DT_SmokeStack.m_flTwist) = value;                                      }
            public int m_flRollSpeed {                           get => *(int*)(addr + Offset.DT_SmokeStack.m_flRollSpeed);                                  set => *(int*)(addr + Offset.DT_SmokeStack.m_flRollSpeed) = value;                                  }
            public int m_iMaterialModel {                        get => *(int*)(addr + Offset.DT_SmokeStack.m_iMaterialModel);                               set => *(int*)(addr + Offset.DT_SmokeStack.m_iMaterialModel) = value;                               }
            public int m_AmbientLight_m_vPos {                   get => *(int*)(addr + Offset.DT_SmokeStack.m_AmbientLight_m_vPos);                          set => *(int*)(addr + Offset.DT_SmokeStack.m_AmbientLight_m_vPos) = value;                          }
            public int m_AmbientLight_m_vColor {                 get => *(int*)(addr + Offset.DT_SmokeStack.m_AmbientLight_m_vColor);                        set => *(int*)(addr + Offset.DT_SmokeStack.m_AmbientLight_m_vColor) = value;                        }
            public int m_AmbientLight_m_flIntensity {            get => *(int*)(addr + Offset.DT_SmokeStack.m_AmbientLight_m_flIntensity);                   set => *(int*)(addr + Offset.DT_SmokeStack.m_AmbientLight_m_flIntensity) = value;                   }
            public int m_DirLight_m_vPos {                       get => *(int*)(addr + Offset.DT_SmokeStack.m_DirLight_m_vPos);                              set => *(int*)(addr + Offset.DT_SmokeStack.m_DirLight_m_vPos) = value;                              }
            public int m_DirLight_m_vColor {                     get => *(int*)(addr + Offset.DT_SmokeStack.m_DirLight_m_vColor);                            set => *(int*)(addr + Offset.DT_SmokeStack.m_DirLight_m_vColor) = value;                            }
            public int m_DirLight_m_flIntensity {                get => *(int*)(addr + Offset.DT_SmokeStack.m_DirLight_m_flIntensity);                       set => *(int*)(addr + Offset.DT_SmokeStack.m_DirLight_m_flIntensity) = value;                       }
            public int m_vWind {                                 get => *(int*)(addr + Offset.DT_SmokeStack.m_vWind);                                        set => *(int*)(addr + Offset.DT_SmokeStack.m_vWind) = value;                                        }

        }

        public class DustTrail : baseStructs
        {
            public static implicit operator DustTrail(IntPtr ptr) => new DustTrail() { addr = ptr                                                                                                                                                                };
            public int m_SpawnRate {                             get => *(int*)(addr + Offset.DT_DustTrail.m_SpawnRate);                                     set => *(int*)(addr + Offset.DT_DustTrail.m_SpawnRate) = value;                                     }
            public int m_Color {                                 get => *(int*)(addr + Offset.DT_DustTrail.m_Color);                                         set => *(int*)(addr + Offset.DT_DustTrail.m_Color) = value;                                         }
            public int m_ParticleLifetime {                      get => *(int*)(addr + Offset.DT_DustTrail.m_ParticleLifetime);                              set => *(int*)(addr + Offset.DT_DustTrail.m_ParticleLifetime) = value;                              }
            public int m_StopEmitTime {                          get => *(int*)(addr + Offset.DT_DustTrail.m_StopEmitTime);                                  set => *(int*)(addr + Offset.DT_DustTrail.m_StopEmitTime) = value;                                  }
            public int m_MinSpeed {                              get => *(int*)(addr + Offset.DT_DustTrail.m_MinSpeed);                                      set => *(int*)(addr + Offset.DT_DustTrail.m_MinSpeed) = value;                                      }
            public int m_MaxSpeed {                              get => *(int*)(addr + Offset.DT_DustTrail.m_MaxSpeed);                                      set => *(int*)(addr + Offset.DT_DustTrail.m_MaxSpeed) = value;                                      }
            public int m_MinDirectedSpeed {                      get => *(int*)(addr + Offset.DT_DustTrail.m_MinDirectedSpeed);                              set => *(int*)(addr + Offset.DT_DustTrail.m_MinDirectedSpeed) = value;                              }
            public int m_MaxDirectedSpeed {                      get => *(int*)(addr + Offset.DT_DustTrail.m_MaxDirectedSpeed);                              set => *(int*)(addr + Offset.DT_DustTrail.m_MaxDirectedSpeed) = value;                              }
            public int m_StartSize {                             get => *(int*)(addr + Offset.DT_DustTrail.m_StartSize);                                     set => *(int*)(addr + Offset.DT_DustTrail.m_StartSize) = value;                                     }
            public int m_EndSize {                               get => *(int*)(addr + Offset.DT_DustTrail.m_EndSize);                                       set => *(int*)(addr + Offset.DT_DustTrail.m_EndSize) = value;                                       }
            public int m_SpawnRadius {                           get => *(int*)(addr + Offset.DT_DustTrail.m_SpawnRadius);                                   set => *(int*)(addr + Offset.DT_DustTrail.m_SpawnRadius) = value;                                   }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_DustTrail.m_bEmit);                                         set => *(int*)(addr + Offset.DT_DustTrail.m_bEmit) = value;                                         }
            public int m_Opacity {                               get => *(int*)(addr + Offset.DT_DustTrail.m_Opacity);                                       set => *(int*)(addr + Offset.DT_DustTrail.m_Opacity) = value;                                       }

        }

        public class FireTrail : baseStructs
        {
            public static implicit operator FireTrail(IntPtr ptr) => new FireTrail() { addr = ptr                                                                                                                                                                };
            public int m_nAttachment {                           get => *(int*)(addr + Offset.DT_FireTrail.m_nAttachment);                                   set => *(int*)(addr + Offset.DT_FireTrail.m_nAttachment) = value;                                   }
            public int m_flLifetime {                            get => *(int*)(addr + Offset.DT_FireTrail.m_flLifetime);                                    set => *(int*)(addr + Offset.DT_FireTrail.m_flLifetime) = value;                                    }

        }

        public class SporeTrail : baseStructs
        {
            public static implicit operator SporeTrail(IntPtr ptr) => new SporeTrail() { addr = ptr                                                                                                                                                              };
            public int m_flSpawnRate {                           get => *(int*)(addr + Offset.DT_SporeTrail.m_flSpawnRate);                                  set => *(int*)(addr + Offset.DT_SporeTrail.m_flSpawnRate) = value;                                  }
            public int m_vecEndColor {                           get => *(int*)(addr + Offset.DT_SporeTrail.m_vecEndColor);                                  set => *(int*)(addr + Offset.DT_SporeTrail.m_vecEndColor) = value;                                  }
            public int m_flParticleLifetime {                    get => *(int*)(addr + Offset.DT_SporeTrail.m_flParticleLifetime);                           set => *(int*)(addr + Offset.DT_SporeTrail.m_flParticleLifetime) = value;                           }
            public int m_flStartSize {                           get => *(int*)(addr + Offset.DT_SporeTrail.m_flStartSize);                                  set => *(int*)(addr + Offset.DT_SporeTrail.m_flStartSize) = value;                                  }
            public int m_flEndSize {                             get => *(int*)(addr + Offset.DT_SporeTrail.m_flEndSize);                                    set => *(int*)(addr + Offset.DT_SporeTrail.m_flEndSize) = value;                                    }
            public int m_flSpawnRadius {                         get => *(int*)(addr + Offset.DT_SporeTrail.m_flSpawnRadius);                                set => *(int*)(addr + Offset.DT_SporeTrail.m_flSpawnRadius) = value;                                }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_SporeTrail.m_bEmit);                                        set => *(int*)(addr + Offset.DT_SporeTrail.m_bEmit) = value;                                        }

        }

        public class SporeExplosion : baseStructs
        {
            public static implicit operator SporeExplosion(IntPtr ptr) => new SporeExplosion() { addr = ptr                                                                                                                                                      };
            public int m_flSpawnRate {                           get => *(int*)(addr + Offset.DT_SporeExplosion.m_flSpawnRate);                              set => *(int*)(addr + Offset.DT_SporeExplosion.m_flSpawnRate) = value;                              }
            public int m_flParticleLifetime {                    get => *(int*)(addr + Offset.DT_SporeExplosion.m_flParticleLifetime);                       set => *(int*)(addr + Offset.DT_SporeExplosion.m_flParticleLifetime) = value;                       }
            public int m_flStartSize {                           get => *(int*)(addr + Offset.DT_SporeExplosion.m_flStartSize);                              set => *(int*)(addr + Offset.DT_SporeExplosion.m_flStartSize) = value;                              }
            public int m_flEndSize {                             get => *(int*)(addr + Offset.DT_SporeExplosion.m_flEndSize);                                set => *(int*)(addr + Offset.DT_SporeExplosion.m_flEndSize) = value;                                }
            public int m_flSpawnRadius {                         get => *(int*)(addr + Offset.DT_SporeExplosion.m_flSpawnRadius);                            set => *(int*)(addr + Offset.DT_SporeExplosion.m_flSpawnRadius) = value;                            }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_SporeExplosion.m_bEmit);                                    set => *(int*)(addr + Offset.DT_SporeExplosion.m_bEmit) = value;                                    }
            public int m_bDontRemove {                           get => *(int*)(addr + Offset.DT_SporeExplosion.m_bDontRemove);                              set => *(int*)(addr + Offset.DT_SporeExplosion.m_bDontRemove) = value;                              }

        }

        public class RocketTrail : baseStructs
        {
            public static implicit operator RocketTrail(IntPtr ptr) => new RocketTrail() { addr = ptr                                                                                                                                                            };
            public int m_SpawnRate {                             get => *(int*)(addr + Offset.DT_RocketTrail.m_SpawnRate);                                   set => *(int*)(addr + Offset.DT_RocketTrail.m_SpawnRate) = value;                                   }
            public int m_StartColor {                            get => *(int*)(addr + Offset.DT_RocketTrail.m_StartColor);                                  set => *(int*)(addr + Offset.DT_RocketTrail.m_StartColor) = value;                                  }
            public int m_EndColor {                              get => *(int*)(addr + Offset.DT_RocketTrail.m_EndColor);                                    set => *(int*)(addr + Offset.DT_RocketTrail.m_EndColor) = value;                                    }
            public int m_ParticleLifetime {                      get => *(int*)(addr + Offset.DT_RocketTrail.m_ParticleLifetime);                            set => *(int*)(addr + Offset.DT_RocketTrail.m_ParticleLifetime) = value;                            }
            public int m_StopEmitTime {                          get => *(int*)(addr + Offset.DT_RocketTrail.m_StopEmitTime);                                set => *(int*)(addr + Offset.DT_RocketTrail.m_StopEmitTime) = value;                                }
            public int m_MinSpeed {                              get => *(int*)(addr + Offset.DT_RocketTrail.m_MinSpeed);                                    set => *(int*)(addr + Offset.DT_RocketTrail.m_MinSpeed) = value;                                    }
            public int m_MaxSpeed {                              get => *(int*)(addr + Offset.DT_RocketTrail.m_MaxSpeed);                                    set => *(int*)(addr + Offset.DT_RocketTrail.m_MaxSpeed) = value;                                    }
            public int m_StartSize {                             get => *(int*)(addr + Offset.DT_RocketTrail.m_StartSize);                                   set => *(int*)(addr + Offset.DT_RocketTrail.m_StartSize) = value;                                   }
            public int m_EndSize {                               get => *(int*)(addr + Offset.DT_RocketTrail.m_EndSize);                                     set => *(int*)(addr + Offset.DT_RocketTrail.m_EndSize) = value;                                     }
            public int m_SpawnRadius {                           get => *(int*)(addr + Offset.DT_RocketTrail.m_SpawnRadius);                                 set => *(int*)(addr + Offset.DT_RocketTrail.m_SpawnRadius) = value;                                 }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_RocketTrail.m_bEmit);                                       set => *(int*)(addr + Offset.DT_RocketTrail.m_bEmit) = value;                                       }
            public int m_nAttachment {                           get => *(int*)(addr + Offset.DT_RocketTrail.m_nAttachment);                                 set => *(int*)(addr + Offset.DT_RocketTrail.m_nAttachment) = value;                                 }
            public int m_Opacity {                               get => *(int*)(addr + Offset.DT_RocketTrail.m_Opacity);                                     set => *(int*)(addr + Offset.DT_RocketTrail.m_Opacity) = value;                                     }
            public int m_bDamaged {                              get => *(int*)(addr + Offset.DT_RocketTrail.m_bDamaged);                                    set => *(int*)(addr + Offset.DT_RocketTrail.m_bDamaged) = value;                                    }
            public int m_flFlareScale {                          get => *(int*)(addr + Offset.DT_RocketTrail.m_flFlareScale);                                set => *(int*)(addr + Offset.DT_RocketTrail.m_flFlareScale) = value;                                }

        }

        public class SmokeTrail : baseStructs
        {
            public static implicit operator SmokeTrail(IntPtr ptr) => new SmokeTrail() { addr = ptr                                                                                                                                                              };
            public int m_SpawnRate {                             get => *(int*)(addr + Offset.DT_SmokeTrail.m_SpawnRate);                                    set => *(int*)(addr + Offset.DT_SmokeTrail.m_SpawnRate) = value;                                    }
            public int m_StartColor {                            get => *(int*)(addr + Offset.DT_SmokeTrail.m_StartColor);                                   set => *(int*)(addr + Offset.DT_SmokeTrail.m_StartColor) = value;                                   }
            public int m_EndColor {                              get => *(int*)(addr + Offset.DT_SmokeTrail.m_EndColor);                                     set => *(int*)(addr + Offset.DT_SmokeTrail.m_EndColor) = value;                                     }
            public int m_ParticleLifetime {                      get => *(int*)(addr + Offset.DT_SmokeTrail.m_ParticleLifetime);                             set => *(int*)(addr + Offset.DT_SmokeTrail.m_ParticleLifetime) = value;                             }
            public int m_StopEmitTime {                          get => *(int*)(addr + Offset.DT_SmokeTrail.m_StopEmitTime);                                 set => *(int*)(addr + Offset.DT_SmokeTrail.m_StopEmitTime) = value;                                 }
            public int m_MinSpeed {                              get => *(int*)(addr + Offset.DT_SmokeTrail.m_MinSpeed);                                     set => *(int*)(addr + Offset.DT_SmokeTrail.m_MinSpeed) = value;                                     }
            public int m_MaxSpeed {                              get => *(int*)(addr + Offset.DT_SmokeTrail.m_MaxSpeed);                                     set => *(int*)(addr + Offset.DT_SmokeTrail.m_MaxSpeed) = value;                                     }
            public int m_MinDirectedSpeed {                      get => *(int*)(addr + Offset.DT_SmokeTrail.m_MinDirectedSpeed);                             set => *(int*)(addr + Offset.DT_SmokeTrail.m_MinDirectedSpeed) = value;                             }
            public int m_MaxDirectedSpeed {                      get => *(int*)(addr + Offset.DT_SmokeTrail.m_MaxDirectedSpeed);                             set => *(int*)(addr + Offset.DT_SmokeTrail.m_MaxDirectedSpeed) = value;                             }
            public int m_StartSize {                             get => *(int*)(addr + Offset.DT_SmokeTrail.m_StartSize);                                    set => *(int*)(addr + Offset.DT_SmokeTrail.m_StartSize) = value;                                    }
            public int m_EndSize {                               get => *(int*)(addr + Offset.DT_SmokeTrail.m_EndSize);                                      set => *(int*)(addr + Offset.DT_SmokeTrail.m_EndSize) = value;                                      }
            public int m_SpawnRadius {                           get => *(int*)(addr + Offset.DT_SmokeTrail.m_SpawnRadius);                                  set => *(int*)(addr + Offset.DT_SmokeTrail.m_SpawnRadius) = value;                                  }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_SmokeTrail.m_bEmit);                                        set => *(int*)(addr + Offset.DT_SmokeTrail.m_bEmit) = value;                                        }
            public int m_nAttachment {                           get => *(int*)(addr + Offset.DT_SmokeTrail.m_nAttachment);                                  set => *(int*)(addr + Offset.DT_SmokeTrail.m_nAttachment) = value;                                  }
            public int m_Opacity {                               get => *(int*)(addr + Offset.DT_SmokeTrail.m_Opacity);                                      set => *(int*)(addr + Offset.DT_SmokeTrail.m_Opacity) = value;                                      }

        }

        public class PropVehicleDriveable : baseStructs
        {
            public static implicit operator PropVehicleDriveable(IntPtr ptr) => new PropVehicleDriveable() { addr = ptr                                                                                                                                          };
            public int m_hPlayer {                               get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_hPlayer);                            set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_hPlayer) = value;                            }
            public int m_nSpeed {                                get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nSpeed);                             set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nSpeed) = value;                             }
            public int m_nRPM {                                  get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nRPM);                               set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nRPM) = value;                               }
            public int m_flThrottle {                            get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_flThrottle);                         set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_flThrottle) = value;                         }
            public int m_nBoostTimeLeft {                        get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nBoostTimeLeft);                     set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nBoostTimeLeft) = value;                     }
            public int m_nHasBoost {                             get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nHasBoost);                          set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nHasBoost) = value;                          }
            public int m_nScannerDisabledWeapons {               get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nScannerDisabledWeapons);            set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nScannerDisabledWeapons) = value;            }
            public int m_nScannerDisabledVehicle {               get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nScannerDisabledVehicle);            set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_nScannerDisabledVehicle) = value;            }
            public int m_bEnterAnimOn {                          get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bEnterAnimOn);                       set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bEnterAnimOn) = value;                       }
            public int m_bExitAnimOn {                           get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bExitAnimOn);                        set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bExitAnimOn) = value;                        }
            public int m_bUnableToFire {                         get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bUnableToFire);                      set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bUnableToFire) = value;                      }
            public int m_vecEyeExitEndpoint {                    get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_vecEyeExitEndpoint);                 set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_vecEyeExitEndpoint) = value;                 }
            public int m_bHasGun {                               get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bHasGun);                            set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_bHasGun) = value;                            }
            public int m_vecGunCrosshair {                       get => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_vecGunCrosshair);                    set => *(int*)(addr + Offset.DT_PropVehicleDriveable.m_vecGunCrosshair) = value;                    }

        }

        public class ParticleSmokeGrenade : baseStructs
        {
            public static implicit operator ParticleSmokeGrenade(IntPtr ptr) => new ParticleSmokeGrenade() { addr = ptr                                                                                                                                          };
            public int m_flSpawnTime {                           get => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_flSpawnTime);                        set => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_flSpawnTime) = value;                        }
            public int m_FadeStartTime {                         get => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_FadeStartTime);                      set => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_FadeStartTime) = value;                      }
            public int m_FadeEndTime {                           get => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_FadeEndTime);                        set => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_FadeEndTime) = value;                        }
            public int m_MinColor {                              get => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_MinColor);                           set => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_MinColor) = value;                           }
            public int m_MaxColor {                              get => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_MaxColor);                           set => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_MaxColor) = value;                           }
            public int m_CurrentStage {                          get => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_CurrentStage);                       set => *(int*)(addr + Offset.DT_ParticleSmokeGrenade.m_CurrentStage) = value;                       }

        }

        public class ParticleFire : baseStructs
        {
            public static implicit operator ParticleFire(IntPtr ptr) => new ParticleFire() { addr = ptr                                                                                                                                                          };
            public int m_vOrigin {                               get => *(int*)(addr + Offset.DT_ParticleFire.m_vOrigin);                                    set => *(int*)(addr + Offset.DT_ParticleFire.m_vOrigin) = value;                                    }
            public int m_vDirection {                            get => *(int*)(addr + Offset.DT_ParticleFire.m_vDirection);                                 set => *(int*)(addr + Offset.DT_ParticleFire.m_vDirection) = value;                                 }

        }

        public class TEGaussExplosion : baseStructs
        {
            public static implicit operator TEGaussExplosion(IntPtr ptr) => new TEGaussExplosion() { addr = ptr                                                                                                                                                  };
            public int m_nType {                                 get => *(int*)(addr + Offset.DT_TEGaussExplosion.m_nType);                                  set => *(int*)(addr + Offset.DT_TEGaussExplosion.m_nType) = value;                                  }
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_TEGaussExplosion.m_vecDirection);                           set => *(int*)(addr + Offset.DT_TEGaussExplosion.m_vecDirection) = value;                           }

        }

        public class QuadraticBeam : baseStructs
        {
            public static implicit operator QuadraticBeam(IntPtr ptr) => new QuadraticBeam() { addr = ptr                                                                                                                                                        };
            public int m_targetPosition {                        get => *(int*)(addr + Offset.DT_QuadraticBeam.m_targetPosition);                            set => *(int*)(addr + Offset.DT_QuadraticBeam.m_targetPosition) = value;                            }
            public int m_controlPosition {                       get => *(int*)(addr + Offset.DT_QuadraticBeam.m_controlPosition);                           set => *(int*)(addr + Offset.DT_QuadraticBeam.m_controlPosition) = value;                           }
            public int m_scrollRate {                            get => *(int*)(addr + Offset.DT_QuadraticBeam.m_scrollRate);                                set => *(int*)(addr + Offset.DT_QuadraticBeam.m_scrollRate) = value;                                }
            public int m_flWidth {                               get => *(int*)(addr + Offset.DT_QuadraticBeam.m_flWidth);                                   set => *(int*)(addr + Offset.DT_QuadraticBeam.m_flWidth) = value;                                   }

        }

        public class Embers : baseStructs
        {
            public static implicit operator Embers(IntPtr ptr) => new Embers() { addr = ptr                                                                                                                                                                      };
            public int m_nDensity {                              get => *(int*)(addr + Offset.DT_Embers.m_nDensity);                                         set => *(int*)(addr + Offset.DT_Embers.m_nDensity) = value;                                         }
            public int m_nLifetime {                             get => *(int*)(addr + Offset.DT_Embers.m_nLifetime);                                        set => *(int*)(addr + Offset.DT_Embers.m_nLifetime) = value;                                        }
            public int m_nSpeed {                                get => *(int*)(addr + Offset.DT_Embers.m_nSpeed);                                           set => *(int*)(addr + Offset.DT_Embers.m_nSpeed) = value;                                           }
            public int m_bEmit {                                 get => *(int*)(addr + Offset.DT_Embers.m_bEmit);                                            set => *(int*)(addr + Offset.DT_Embers.m_bEmit) = value;                                            }

        }

        public class Precipitation : baseStructs
        {
            public static implicit operator Precipitation(IntPtr ptr) => new Precipitation() { addr = ptr                                                                                                                                                        };
            public int m_nPrecipType {                           get => *(int*)(addr + Offset.DT_Precipitation.m_nPrecipType);                               set => *(int*)(addr + Offset.DT_Precipitation.m_nPrecipType) = value;                               }

        }

        public class BaseAttributableItem : BaseCombatWeapon
        {
            public static implicit operator BaseAttributableItem(IntPtr ptr) => new BaseAttributableItem() { addr = ptr                                                                                                                                          };
            public int m_OriginalOwnerXuidLow {                  get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_OriginalOwnerXuidLow);               set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_OriginalOwnerXuidLow) = value;               }
            public int m_OriginalOwnerXuidHigh {                 get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_OriginalOwnerXuidHigh);              set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_OriginalOwnerXuidHigh) = value;              }
            public int m_nFallbackPaintKit {                     get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_nFallbackPaintKit);                  set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_nFallbackPaintKit) = value;                  }
            public int m_nFallbackSeed {                         get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_nFallbackSeed);                      set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_nFallbackSeed) = value;                      }
            public float m_flFallbackWear {                        get => *(float*)(addr + Offset.DT_BaseAttributableItem.m_flFallbackWear);                     set => *(float*)(addr + Offset.DT_BaseAttributableItem.m_flFallbackWear) = value;                     }
            public int m_nFallbackStatTrak {                     get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_nFallbackStatTrak);                  set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_nFallbackStatTrak) = value;                  }
            public int m_hOuter {                                get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_hOuter);                             set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_hOuter) = value;                             }
            public int m_ProviderType {                          get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_ProviderType);                       set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_ProviderType) = value;                       }
            public int m_iReapplyProvisionParity {               get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iReapplyProvisionParity);            set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iReapplyProvisionParity) = value;            }
            public int m_iItemDefinitionIndex {                  get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iItemDefinitionIndex);               set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iItemDefinitionIndex) = value;               }
            public int m_iEntityLevel {                          get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iEntityLevel);                       set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iEntityLevel) = value;                       }
            public int m_iItemIDHigh {                           get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iItemIDHigh);                        set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iItemIDHigh) = value;                        }
            public int m_iItemIDLow {                            get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iItemIDLow);                         set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iItemIDLow) = value;                         }
            public int m_iAccountID {                            get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iAccountID);                         set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iAccountID) = value;                         }
            public int m_iEntityQuality {                        get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iEntityQuality);                     set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_iEntityQuality) = value;                     }
            public int m_bInitialized {                          get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_bInitialized);                       set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_bInitialized) = value;                       }
            public IntPtr m_szCustomName {                       get => addr + Offset.DT_BaseAttributableItem.m_szCustomName; }
            public int m_NetworkedDynamicAttributesForDemos {    get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_NetworkedDynamicAttributesForDemos); set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_NetworkedDynamicAttributesForDemos) = value; }
            public int m_Item {                                  get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_Item);                               set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_Item) = value;                               }
            public int m_AttributeManager {                      get => *(int*)(addr + Offset.DT_BaseAttributableItem.m_AttributeManager);                   set => *(int*)(addr + Offset.DT_BaseAttributableItem.m_AttributeManager) = value;                   }

        }

        public class EconEntity : baseStructs
        {
            public static implicit operator EconEntity(IntPtr ptr) => new EconEntity() { addr = ptr                                                                                                                                                              };
            public int m_OriginalOwnerXuidLow {                  get => *(int*)(addr + Offset.DT_EconEntity.m_OriginalOwnerXuidLow);                         set => *(int*)(addr + Offset.DT_EconEntity.m_OriginalOwnerXuidLow) = value;                         }
            public int m_OriginalOwnerXuidHigh {                 get => *(int*)(addr + Offset.DT_EconEntity.m_OriginalOwnerXuidHigh);                        set => *(int*)(addr + Offset.DT_EconEntity.m_OriginalOwnerXuidHigh) = value;                        }
            public int m_nFallbackPaintKit {                     get => *(int*)(addr + Offset.DT_EconEntity.m_nFallbackPaintKit);                            set => *(int*)(addr + Offset.DT_EconEntity.m_nFallbackPaintKit) = value;                            }
            public int m_nFallbackSeed {                         get => *(int*)(addr + Offset.DT_EconEntity.m_nFallbackSeed);                                set => *(int*)(addr + Offset.DT_EconEntity.m_nFallbackSeed) = value;                                }
            public int m_flFallbackWear {                        get => *(int*)(addr + Offset.DT_EconEntity.m_flFallbackWear);                               set => *(int*)(addr + Offset.DT_EconEntity.m_flFallbackWear) = value;                               }
            public int m_nFallbackStatTrak {                     get => *(int*)(addr + Offset.DT_EconEntity.m_nFallbackStatTrak);                            set => *(int*)(addr + Offset.DT_EconEntity.m_nFallbackStatTrak) = value;                            }
            public int m_hOuter {                                get => *(int*)(addr + Offset.DT_EconEntity.m_hOuter);                                       set => *(int*)(addr + Offset.DT_EconEntity.m_hOuter) = value;                                       }
            public int m_ProviderType {                          get => *(int*)(addr + Offset.DT_EconEntity.m_ProviderType);                                 set => *(int*)(addr + Offset.DT_EconEntity.m_ProviderType) = value;                                 }
            public int m_iReapplyProvisionParity {               get => *(int*)(addr + Offset.DT_EconEntity.m_iReapplyProvisionParity);                      set => *(int*)(addr + Offset.DT_EconEntity.m_iReapplyProvisionParity) = value;                      }
            public int m_iItemDefinitionIndex {                  get => *(int*)(addr + Offset.DT_EconEntity.m_iItemDefinitionIndex);                         set => *(int*)(addr + Offset.DT_EconEntity.m_iItemDefinitionIndex) = value;                         }
            public int m_iEntityLevel {                          get => *(int*)(addr + Offset.DT_EconEntity.m_iEntityLevel);                                 set => *(int*)(addr + Offset.DT_EconEntity.m_iEntityLevel) = value;                                 }
            public int m_iItemIDHigh {                           get => *(int*)(addr + Offset.DT_EconEntity.m_iItemIDHigh);                                  set => *(int*)(addr + Offset.DT_EconEntity.m_iItemIDHigh) = value;                                  }
            public int m_iItemIDLow {                            get => *(int*)(addr + Offset.DT_EconEntity.m_iItemIDLow);                                   set => *(int*)(addr + Offset.DT_EconEntity.m_iItemIDLow) = value;                                   }
            public int m_iAccountID {                            get => *(int*)(addr + Offset.DT_EconEntity.m_iAccountID);                                   set => *(int*)(addr + Offset.DT_EconEntity.m_iAccountID) = value;                                   }
            public int m_iEntityQuality {                        get => *(int*)(addr + Offset.DT_EconEntity.m_iEntityQuality);                               set => *(int*)(addr + Offset.DT_EconEntity.m_iEntityQuality) = value;                               }
            public int m_bInitialized {                          get => *(int*)(addr + Offset.DT_EconEntity.m_bInitialized);                                 set => *(int*)(addr + Offset.DT_EconEntity.m_bInitialized) = value;                                 }
            public int m_szCustomName {                          get => *(int*)(addr + Offset.DT_EconEntity.m_szCustomName);                                 set => *(int*)(addr + Offset.DT_EconEntity.m_szCustomName) = value;                                 }
            public int m_NetworkedDynamicAttributesForDemos {    get => *(int*)(addr + Offset.DT_EconEntity.m_NetworkedDynamicAttributesForDemos);           set => *(int*)(addr + Offset.DT_EconEntity.m_NetworkedDynamicAttributesForDemos) = value;           }
            public int m_Item {                                  get => *(int*)(addr + Offset.DT_EconEntity.m_Item);                                         set => *(int*)(addr + Offset.DT_EconEntity.m_Item) = value;                                         }
            public int m_AttributeManager {                      get => *(int*)(addr + Offset.DT_EconEntity.m_AttributeManager);                             set => *(int*)(addr + Offset.DT_EconEntity.m_AttributeManager) = value;                             }

        }

        public class WeaponXM1014 : baseStructs
        {
            public static implicit operator WeaponXM1014(IntPtr ptr) => new WeaponXM1014() { addr = ptr                                                                                                                                                          };
            public int m_reloadState {                           get => *(int*)(addr + Offset.DT_WeaponXM1014.m_reloadState);                                set => *(int*)(addr + Offset.DT_WeaponXM1014.m_reloadState) = value;                                }

        }

        public class WeaponTaser : baseStructs
        {
            public static implicit operator WeaponTaser(IntPtr ptr) => new WeaponTaser() { addr = ptr                                                                                                                                                            };
            public int m_fFireTime {                             get => *(int*)(addr + Offset.DT_WeaponTaser.m_fFireTime);                                   set => *(int*)(addr + Offset.DT_WeaponTaser.m_fFireTime) = value;                                   }

        }

        public class WeaponTablet : baseStructs
        {
            public static implicit operator WeaponTablet(IntPtr ptr) => new WeaponTablet() { addr = ptr                                                                                                                                                          };
            public int m_flUpgradeExpirationTime_0 {             get => *(int*)(addr + Offset.DT_WeaponTablet.m_flUpgradeExpirationTime_0);                  set => *(int*)(addr + Offset.DT_WeaponTablet.m_flUpgradeExpirationTime_0) = value;                  }
            public int m_flUpgradeExpirationTime {               get => *(int*)(addr + Offset.DT_WeaponTablet.m_flUpgradeExpirationTime);                    set => *(int*)(addr + Offset.DT_WeaponTablet.m_flUpgradeExpirationTime) = value;                    }
            public int m_vecLocalHexFlags_0 {                    get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecLocalHexFlags_0);                         set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecLocalHexFlags_0) = value;                         }
            public int m_vecLocalHexFlags {                      get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecLocalHexFlags);                           set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecLocalHexFlags) = value;                           }
            public int m_nContractKillGridIndex {                get => *(int*)(addr + Offset.DT_WeaponTablet.m_nContractKillGridIndex);                     set => *(int*)(addr + Offset.DT_WeaponTablet.m_nContractKillGridIndex) = value;                     }
            public int m_nContractKillGridHighResIndex {         get => *(int*)(addr + Offset.DT_WeaponTablet.m_nContractKillGridHighResIndex);              set => *(int*)(addr + Offset.DT_WeaponTablet.m_nContractKillGridHighResIndex) = value;              }
            public int m_bTabletReceptionIsBlocked {             get => *(int*)(addr + Offset.DT_WeaponTablet.m_bTabletReceptionIsBlocked);                  set => *(int*)(addr + Offset.DT_WeaponTablet.m_bTabletReceptionIsBlocked) = value;                  }
            public int m_flScanProgress {                        get => *(int*)(addr + Offset.DT_WeaponTablet.m_flScanProgress);                             set => *(int*)(addr + Offset.DT_WeaponTablet.m_flScanProgress) = value;                             }
            public int m_flBootTime {                            get => *(int*)(addr + Offset.DT_WeaponTablet.m_flBootTime);                                 set => *(int*)(addr + Offset.DT_WeaponTablet.m_flBootTime) = value;                                 }
            public int m_flShowMapTime {                         get => *(int*)(addr + Offset.DT_WeaponTablet.m_flShowMapTime);                              set => *(int*)(addr + Offset.DT_WeaponTablet.m_flShowMapTime) = value;                              }
            public int m_vecNotificationIds_0 {                  get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationIds_0);                       set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationIds_0) = value;                       }
            public int m_vecNotificationIds {                    get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationIds);                         set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationIds) = value;                         }
            public int m_vecNotificationTimestamps_0 {           get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationTimestamps_0);                set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationTimestamps_0) = value;                }
            public int m_vecNotificationTimestamps {             get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationTimestamps);                  set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNotificationTimestamps) = value;                  }
            public int m_vecPlayerPositionHistory_0 {            get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecPlayerPositionHistory_0);                 set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecPlayerPositionHistory_0) = value;                 }
            public int m_vecPlayerPositionHistory {              get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecPlayerPositionHistory);                   set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecPlayerPositionHistory) = value;                   }
            public int m_nLastPurchaseIndex {                    get => *(int*)(addr + Offset.DT_WeaponTablet.m_nLastPurchaseIndex);                         set => *(int*)(addr + Offset.DT_WeaponTablet.m_nLastPurchaseIndex) = value;                         }
            public int m_vecNearestMetalCratePos {               get => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNearestMetalCratePos);                    set => *(int*)(addr + Offset.DT_WeaponTablet.m_vecNearestMetalCratePos) = value;                    }

        }

        public class WeaponSawedoff : baseStructs
        {
            public static implicit operator WeaponSawedoff(IntPtr ptr) => new WeaponSawedoff() { addr = ptr                                                                                                                                                      };
            public int m_reloadState {                           get => *(int*)(addr + Offset.DT_WeaponSawedoff.m_reloadState);                              set => *(int*)(addr + Offset.DT_WeaponSawedoff.m_reloadState) = value;                              }

        }

        public class WeaponNOVA : baseStructs
        {
            public static implicit operator WeaponNOVA(IntPtr ptr) => new WeaponNOVA() { addr = ptr                                                                                                                                                              };
            public int m_reloadState {                           get => *(int*)(addr + Offset.DT_WeaponNOVA.m_reloadState);                                  set => *(int*)(addr + Offset.DT_WeaponNOVA.m_reloadState) = value;                                  }

        }

        public class WeaponMelee : baseStructs
        {
            public static implicit operator WeaponMelee(IntPtr ptr) => new WeaponMelee() { addr = ptr                                                                                                                                                            };
            public int m_flThrowAt {                             get => *(int*)(addr + Offset.DT_WeaponMelee.m_flThrowAt);                                   set => *(int*)(addr + Offset.DT_WeaponMelee.m_flThrowAt) = value;                                   }

        }

        public class WeaponM3 : baseStructs
        {
            public static implicit operator WeaponM3(IntPtr ptr) => new WeaponM3() { addr = ptr                                                                                                                                                                  };
            public int m_reloadState {                           get => *(int*)(addr + Offset.DT_WeaponM3.m_reloadState);                                    set => *(int*)(addr + Offset.DT_WeaponM3.m_reloadState) = value;                                    }

        }

        public class WeaponFists : baseStructs
        {
            public static implicit operator WeaponFists(IntPtr ptr) => new WeaponFists() { addr = ptr                                                                                                                                                            };
            public int m_bPlayingUninterruptableAct {            get => *(int*)(addr + Offset.DT_WeaponFists.m_bPlayingUninterruptableAct);                  set => *(int*)(addr + Offset.DT_WeaponFists.m_bPlayingUninterruptableAct) = value;                  }

        }

        public class WeaponCSBaseGun : baseStructs
        {
            public static implicit operator WeaponCSBaseGun(IntPtr ptr) => new WeaponCSBaseGun() { addr = ptr                                                                                                                                                    };
            public int m_zoomLevel {                             get => *(int*)(addr + Offset.DT_WeaponCSBaseGun.m_zoomLevel);                               set => *(int*)(addr + Offset.DT_WeaponCSBaseGun.m_zoomLevel) = value;                               }
            public int m_iBurstShotsRemaining {                  get => *(int*)(addr + Offset.DT_WeaponCSBaseGun.m_iBurstShotsRemaining);                    set => *(int*)(addr + Offset.DT_WeaponCSBaseGun.m_iBurstShotsRemaining) = value;                    }

        }

        public class WeaponCSBase : baseStructs
        {
            public static implicit operator WeaponCSBase(IntPtr ptr) => new WeaponCSBase() { addr = ptr                                                                                                                                                          };
            public int m_weaponMode {                            get => *(int*)(addr + Offset.DT_WeaponCSBase.m_weaponMode);                                 set => *(int*)(addr + Offset.DT_WeaponCSBase.m_weaponMode) = value;                                 }
            public int m_fAccuracyPenalty {                      get => *(int*)(addr + Offset.DT_WeaponCSBase.m_fAccuracyPenalty);                           set => *(int*)(addr + Offset.DT_WeaponCSBase.m_fAccuracyPenalty) = value;                           }
            public int m_fLastShotTime {                         get => *(int*)(addr + Offset.DT_WeaponCSBase.m_fLastShotTime);                              set => *(int*)(addr + Offset.DT_WeaponCSBase.m_fLastShotTime) = value;                              }
            public int m_iRecoilIndex {                          get => *(int*)(addr + Offset.DT_WeaponCSBase.m_iRecoilIndex);                               set => *(int*)(addr + Offset.DT_WeaponCSBase.m_iRecoilIndex) = value;                               }
            public int m_flRecoilIndex {                         get => *(int*)(addr + Offset.DT_WeaponCSBase.m_flRecoilIndex);                              set => *(int*)(addr + Offset.DT_WeaponCSBase.m_flRecoilIndex) = value;                              }
            public int m_hPrevOwner {                            get => *(int*)(addr + Offset.DT_WeaponCSBase.m_hPrevOwner);                                 set => *(int*)(addr + Offset.DT_WeaponCSBase.m_hPrevOwner) = value;                                 }
            public int m_bBurstMode {                            get => *(int*)(addr + Offset.DT_WeaponCSBase.m_bBurstMode);                                 set => *(int*)(addr + Offset.DT_WeaponCSBase.m_bBurstMode) = value;                                 }
            public int m_flPostponeFireReadyTime {               get => *(int*)(addr + Offset.DT_WeaponCSBase.m_flPostponeFireReadyTime);                    set => *(int*)(addr + Offset.DT_WeaponCSBase.m_flPostponeFireReadyTime) = value;                    }
            public int m_bReloadVisuallyComplete {               get => *(int*)(addr + Offset.DT_WeaponCSBase.m_bReloadVisuallyComplete);                    set => *(int*)(addr + Offset.DT_WeaponCSBase.m_bReloadVisuallyComplete) = value;                    }
            public int m_bSilencerOn {                           get => *(int*)(addr + Offset.DT_WeaponCSBase.m_bSilencerOn);                                set => *(int*)(addr + Offset.DT_WeaponCSBase.m_bSilencerOn) = value;                                }
            public int m_flDoneSwitchingSilencer {               get => *(int*)(addr + Offset.DT_WeaponCSBase.m_flDoneSwitchingSilencer);                    set => *(int*)(addr + Offset.DT_WeaponCSBase.m_flDoneSwitchingSilencer) = value;                    }
            public int m_iOriginalTeamNumber {                   get => *(int*)(addr + Offset.DT_WeaponCSBase.m_iOriginalTeamNumber);                        set => *(int*)(addr + Offset.DT_WeaponCSBase.m_iOriginalTeamNumber) = value;                        }
            public int m_iIronSightMode {                        get => *(int*)(addr + Offset.DT_WeaponCSBase.m_iIronSightMode);                             set => *(int*)(addr + Offset.DT_WeaponCSBase.m_iIronSightMode) = value;                             }

        }

        public class WeaponC4 : baseStructs
        {
            public static implicit operator WeaponC4(IntPtr ptr) => new WeaponC4() { addr = ptr                                                                                                                                                                  };
            public int m_bStartedArming {                        get => *(int*)(addr + Offset.DT_WeaponC4.m_bStartedArming);                                 set => *(int*)(addr + Offset.DT_WeaponC4.m_bStartedArming) = value;                                 }
            public int m_bBombPlacedAnimation {                  get => *(int*)(addr + Offset.DT_WeaponC4.m_bBombPlacedAnimation);                           set => *(int*)(addr + Offset.DT_WeaponC4.m_bBombPlacedAnimation) = value;                           }
            public int m_fArmedTime {                            get => *(int*)(addr + Offset.DT_WeaponC4.m_fArmedTime);                                     set => *(int*)(addr + Offset.DT_WeaponC4.m_fArmedTime) = value;                                     }
            public int m_bShowC4LED {                            get => *(int*)(addr + Offset.DT_WeaponC4.m_bShowC4LED);                                     set => *(int*)(addr + Offset.DT_WeaponC4.m_bShowC4LED) = value;                                     }
            public int m_bIsPlantingViaUse {                     get => *(int*)(addr + Offset.DT_WeaponC4.m_bIsPlantingViaUse);                              set => *(int*)(addr + Offset.DT_WeaponC4.m_bIsPlantingViaUse) = value;                              }

        }

        public class BumpMineProjectile : baseStructs
        {
            public static implicit operator BumpMineProjectile(IntPtr ptr) => new BumpMineProjectile() { addr = ptr                                                                                                                                              };
            public int m_nParentBoneIndex {                      get => *(int*)(addr + Offset.DT_BumpMineProjectile.m_nParentBoneIndex);                     set => *(int*)(addr + Offset.DT_BumpMineProjectile.m_nParentBoneIndex) = value;                     }
            public int m_vecParentBonePos {                      get => *(int*)(addr + Offset.DT_BumpMineProjectile.m_vecParentBonePos);                     set => *(int*)(addr + Offset.DT_BumpMineProjectile.m_vecParentBonePos) = value;                     }
            public int m_bArmed {                                get => *(int*)(addr + Offset.DT_BumpMineProjectile.m_bArmed);                               set => *(int*)(addr + Offset.DT_BumpMineProjectile.m_bArmed) = value;                               }

        }

        public class BreachChargeProjectile : baseStructs
        {
            public static implicit operator BreachChargeProjectile(IntPtr ptr) => new BreachChargeProjectile() { addr = ptr                                                                                                                                      };
            public int m_bShouldExplode {                        get => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_bShouldExplode);                   set => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_bShouldExplode) = value;                   }
            public int m_weaponThatThrewMe {                     get => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_weaponThatThrewMe);                set => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_weaponThatThrewMe) = value;                }
            public int m_nParentBoneIndex {                      get => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_nParentBoneIndex);                 set => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_nParentBoneIndex) = value;                 }
            public int m_vecParentBonePos {                      get => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_vecParentBonePos);                 set => *(int*)(addr + Offset.DT_BreachChargeProjectile.m_vecParentBonePos) = value;                 }

        }

        public class WeaponBaseItem : baseStructs
        {
            public static implicit operator WeaponBaseItem(IntPtr ptr) => new WeaponBaseItem() { addr = ptr                                                                                                                                                      };
            public int m_bRedraw {                               get => *(int*)(addr + Offset.DT_WeaponBaseItem.m_bRedraw);                                  set => *(int*)(addr + Offset.DT_WeaponBaseItem.m_bRedraw) = value;                                  }

        }

        public class BaseCSGrenade : baseStructs
        {
            public static implicit operator BaseCSGrenade(IntPtr ptr) => new BaseCSGrenade() { addr = ptr                                                                                                                                                        };
            public int m_bRedraw {                               get => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bRedraw);                                   set => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bRedraw) = value;                                   }
            public int m_bIsHeldByPlayer {                       get => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bIsHeldByPlayer);                           set => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bIsHeldByPlayer) = value;                           }
            public int m_bPinPulled {                            get => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bPinPulled);                                set => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bPinPulled) = value;                                }
            public int m_fThrowTime {                            get => *(int*)(addr + Offset.DT_BaseCSGrenade.m_fThrowTime);                                set => *(int*)(addr + Offset.DT_BaseCSGrenade.m_fThrowTime) = value;                                }
            public int m_bLoopingSoundPlaying {                  get => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bLoopingSoundPlaying);                      set => *(int*)(addr + Offset.DT_BaseCSGrenade.m_bLoopingSoundPlaying) = value;                      }
            public int m_flThrowStrength {                       get => *(int*)(addr + Offset.DT_BaseCSGrenade.m_flThrowStrength);                           set => *(int*)(addr + Offset.DT_BaseCSGrenade.m_flThrowStrength) = value;                           }

        }

        public class SmokeGrenadeProjectile : baseStructs
        {
            public static implicit operator SmokeGrenadeProjectile(IntPtr ptr) => new SmokeGrenadeProjectile() { addr = ptr                                                                                                                                      };
            public int m_bDidSmokeEffect {                       get => *(int*)(addr + Offset.DT_SmokeGrenadeProjectile.m_bDidSmokeEffect);                  set => *(int*)(addr + Offset.DT_SmokeGrenadeProjectile.m_bDidSmokeEffect) = value;                  }
            public int m_nSmokeEffectTickBegin {                 get => *(int*)(addr + Offset.DT_SmokeGrenadeProjectile.m_nSmokeEffectTickBegin);            set => *(int*)(addr + Offset.DT_SmokeGrenadeProjectile.m_nSmokeEffectTickBegin) = value;            }

        }

        public class MolotovProjectile : baseStructs
        {
            public static implicit operator MolotovProjectile(IntPtr ptr) => new MolotovProjectile() { addr = ptr                                                                                                                                                };
            public int m_bIsIncGrenade {                         get => *(int*)(addr + Offset.DT_MolotovProjectile.m_bIsIncGrenade);                         set => *(int*)(addr + Offset.DT_MolotovProjectile.m_bIsIncGrenade) = value;                         }

        }

        public class ItemDogtags : baseStructs
        {
            public static implicit operator ItemDogtags(IntPtr ptr) => new ItemDogtags() { addr = ptr                                                                                                                                                            };
            public int m_OwningPlayer {                          get => *(int*)(addr + Offset.DT_ItemDogtags.m_OwningPlayer);                                set => *(int*)(addr + Offset.DT_ItemDogtags.m_OwningPlayer) = value;                                }
            public int m_KillingPlayer {                         get => *(int*)(addr + Offset.DT_ItemDogtags.m_KillingPlayer);                               set => *(int*)(addr + Offset.DT_ItemDogtags.m_KillingPlayer) = value;                               }

        }

        public class PhysPropLootCrate : baseStructs
        {
            public static implicit operator PhysPropLootCrate(IntPtr ptr) => new PhysPropLootCrate() { addr = ptr                                                                                                                                                };
            public int m_bRenderInPSPM {                         get => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_bRenderInPSPM);                         set => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_bRenderInPSPM) = value;                         }
            public int m_bRenderInTablet {                       get => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_bRenderInTablet);                       set => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_bRenderInTablet) = value;                       }
            public int m_iHealth {                               get => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_iHealth);                               set => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_iHealth) = value;                               }
            public int m_iMaxHealth {                            get => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_iMaxHealth);                            set => *(int*)(addr + Offset.DT_PhysPropLootCrate.m_iMaxHealth) = value;                            }

        }

        public class EnvGasCanister : baseStructs
        {
            public static implicit operator EnvGasCanister(IntPtr ptr) => new EnvGasCanister() { addr = ptr                                                                                                                                                      };
            public int m_flFlightSpeed {                         get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flFlightSpeed);                            set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flFlightSpeed) = value;                            }
            public int m_flLaunchTime {                          get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flLaunchTime);                             set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flLaunchTime) = value;                             }
            public int m_vecParabolaDirection {                  get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecParabolaDirection);                     set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecParabolaDirection) = value;                     }
            public int m_flFlightTime {                          get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flFlightTime);                             set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flFlightTime) = value;                             }
            public int m_flWorldEnterTime {                      get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flWorldEnterTime);                         set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flWorldEnterTime) = value;                         }
            public int m_flInitialZSpeed {                       get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flInitialZSpeed);                          set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flInitialZSpeed) = value;                          }
            public int m_flZAcceleration {                       get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flZAcceleration);                          set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flZAcceleration) = value;                          }
            public int m_flHorizSpeed {                          get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flHorizSpeed);                             set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flHorizSpeed) = value;                             }
            public int m_bLaunchedFromWithinWorld {              get => *(int*)(addr + Offset.DT_EnvGasCanister.m_bLaunchedFromWithinWorld);                 set => *(int*)(addr + Offset.DT_EnvGasCanister.m_bLaunchedFromWithinWorld) = value;                 }
            public int m_vecImpactPosition {                     get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecImpactPosition);                        set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecImpactPosition) = value;                        }
            public int m_vecStartPosition {                      get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecStartPosition);                         set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecStartPosition) = value;                         }
            public int m_vecEnterWorldPosition {                 get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecEnterWorldPosition);                    set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecEnterWorldPosition) = value;                    }
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecDirection);                             set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecDirection) = value;                             }
            public int m_vecStartAngles {                        get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecStartAngles);                           set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecStartAngles) = value;                           }
            public int m_vecSkyboxOrigin {                       get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecSkyboxOrigin);                          set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecSkyboxOrigin) = value;                          }
            public int m_flSkyboxScale {                         get => *(int*)(addr + Offset.DT_EnvGasCanister.m_flSkyboxScale);                            set => *(int*)(addr + Offset.DT_EnvGasCanister.m_flSkyboxScale) = value;                            }
            public int m_bInSkybox {                             get => *(int*)(addr + Offset.DT_EnvGasCanister.m_bInSkybox);                                set => *(int*)(addr + Offset.DT_EnvGasCanister.m_bInSkybox) = value;                                }
            public int m_bDoImpactEffects {                      get => *(int*)(addr + Offset.DT_EnvGasCanister.m_bDoImpactEffects);                         set => *(int*)(addr + Offset.DT_EnvGasCanister.m_bDoImpactEffects) = value;                         }
            public int m_bLanded {                               get => *(int*)(addr + Offset.DT_EnvGasCanister.m_bLanded);                                  set => *(int*)(addr + Offset.DT_EnvGasCanister.m_bLanded) = value;                                  }
            public int m_hSkyboxCopy {                           get => *(int*)(addr + Offset.DT_EnvGasCanister.m_hSkyboxCopy);                              set => *(int*)(addr + Offset.DT_EnvGasCanister.m_hSkyboxCopy) = value;                              }
            public int m_nMyZoneIndex {                          get => *(int*)(addr + Offset.DT_EnvGasCanister.m_nMyZoneIndex);                             set => *(int*)(addr + Offset.DT_EnvGasCanister.m_nMyZoneIndex) = value;                             }
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecOrigin);                                set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecOrigin) = value;                                }
            public int m_vecOrigin_2 {                           get => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecOrigin_2);                              set => *(int*)(addr + Offset.DT_EnvGasCanister.m_vecOrigin_2) = value;                              }

        }

        public class Dronegun : baseStructs
        {
            public static implicit operator Dronegun(IntPtr ptr) => new Dronegun() { addr = ptr                                                                                                                                                                  };
            public int m_vecAttentionTarget {                    get => *(int*)(addr + Offset.DT_Dronegun.m_vecAttentionTarget);                             set => *(int*)(addr + Offset.DT_Dronegun.m_vecAttentionTarget) = value;                             }
            public int m_vecTargetOffset {                       get => *(int*)(addr + Offset.DT_Dronegun.m_vecTargetOffset);                                set => *(int*)(addr + Offset.DT_Dronegun.m_vecTargetOffset) = value;                                }
            public int m_iHealth {                               get => *(int*)(addr + Offset.DT_Dronegun.m_iHealth);                                        set => *(int*)(addr + Offset.DT_Dronegun.m_iHealth) = value;                                        }
            public int m_bHasTarget {                            get => *(int*)(addr + Offset.DT_Dronegun.m_bHasTarget);                                     set => *(int*)(addr + Offset.DT_Dronegun.m_bHasTarget) = value;                                     }

        }

        public class ParadropChopper : baseStructs
        {
            public static implicit operator ParadropChopper(IntPtr ptr) => new ParadropChopper() { addr = ptr                                                                                                                                                    };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_ParadropChopper.m_vecOrigin);                               set => *(int*)(addr + Offset.DT_ParadropChopper.m_vecOrigin) = value;                               }
            public int m_vecOrigin_2 {                           get => *(int*)(addr + Offset.DT_ParadropChopper.m_vecOrigin_2);                             set => *(int*)(addr + Offset.DT_ParadropChopper.m_vecOrigin_2) = value;                             }
            public int m_hCallingPlayer {                        get => *(int*)(addr + Offset.DT_ParadropChopper.m_hCallingPlayer);                          set => *(int*)(addr + Offset.DT_ParadropChopper.m_hCallingPlayer) = value;                          }

        }

        public class SurvivalSpawnChopper : baseStructs
        {
            public static implicit operator SurvivalSpawnChopper(IntPtr ptr) => new SurvivalSpawnChopper() { addr = ptr                                                                                                                                          };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_SurvivalSpawnChopper.m_vecOrigin);                          set => *(int*)(addr + Offset.DT_SurvivalSpawnChopper.m_vecOrigin) = value;                          }
            public int m_vecOrigin_2 {                           get => *(int*)(addr + Offset.DT_SurvivalSpawnChopper.m_vecOrigin_2);                        set => *(int*)(addr + Offset.DT_SurvivalSpawnChopper.m_vecOrigin_2) = value;                        }

        }

        public class BRC4Target : baseStructs
        {
            public static implicit operator BRC4Target(IntPtr ptr) => new BRC4Target() { addr = ptr                                                                                                                                                              };
            public int m_bBrokenOpen {                           get => *(int*)(addr + Offset.DT_BRC4Target.m_bBrokenOpen);                                  set => *(int*)(addr + Offset.DT_BRC4Target.m_bBrokenOpen) = value;                                  }
            public int m_flRadius {                              get => *(int*)(addr + Offset.DT_BRC4Target.m_flRadius);                                     set => *(int*)(addr + Offset.DT_BRC4Target.m_flRadius) = value;                                     }

        }

        public class InfoMapRegion : baseStructs
        {
            public static implicit operator InfoMapRegion(IntPtr ptr) => new InfoMapRegion() { addr = ptr                                                                                                                                                        };
            public int m_flRadius {                              get => *(int*)(addr + Offset.DT_InfoMapRegion.m_flRadius);                                  set => *(int*)(addr + Offset.DT_InfoMapRegion.m_flRadius) = value;                                  }
            public int m_szLocToken {                            get => *(int*)(addr + Offset.DT_InfoMapRegion.m_szLocToken);                                set => *(int*)(addr + Offset.DT_InfoMapRegion.m_szLocToken) = value;                                }

        }

        public class Inferno : baseStructs
        {
            public static implicit operator Inferno(IntPtr ptr) => new Inferno() { addr = ptr                                                                                                                                                                    };
            public int m_nFireEffectTickBegin {                  get => *(int*)(addr + Offset.DT_Inferno.m_nFireEffectTickBegin);                            set => *(int*)(addr + Offset.DT_Inferno.m_nFireEffectTickBegin) = value;                            }
            public int m_fireCount {                             get => *(int*)(addr + Offset.DT_Inferno.m_fireCount);                                       set => *(int*)(addr + Offset.DT_Inferno.m_fireCount) = value;                                       }
            public int m_fireXDelta {                            get => *(int*)(addr + Offset.DT_Inferno.m_fireXDelta);                                      set => *(int*)(addr + Offset.DT_Inferno.m_fireXDelta) = value;                                      }
            public int m_fireYDelta {                            get => *(int*)(addr + Offset.DT_Inferno.m_fireYDelta);                                      set => *(int*)(addr + Offset.DT_Inferno.m_fireYDelta) = value;                                      }
            public int m_fireZDelta {                            get => *(int*)(addr + Offset.DT_Inferno.m_fireZDelta);                                      set => *(int*)(addr + Offset.DT_Inferno.m_fireZDelta) = value;                                      }
            public int m_bFireIsBurning {                        get => *(int*)(addr + Offset.DT_Inferno.m_bFireIsBurning);                                  set => *(int*)(addr + Offset.DT_Inferno.m_bFireIsBurning) = value;                                  }

        }

        public class CChicken : baseStructs
        {
            public static implicit operator CChicken(IntPtr ptr) => new CChicken() { addr = ptr                                                                                                                                                                  };
            public int m_jumpedThisFrame {                       get => *(int*)(addr + Offset.DT_CChicken.m_jumpedThisFrame);                                set => *(int*)(addr + Offset.DT_CChicken.m_jumpedThisFrame) = value;                                }
            public int m_leader {                                get => *(int*)(addr + Offset.DT_CChicken.m_leader);                                         set => *(int*)(addr + Offset.DT_CChicken.m_leader) = value;                                         }

        }

        public class Drone : baseStructs
        {
            public static implicit operator Drone(IntPtr ptr) => new Drone() { addr = ptr                                                                                                                                                                        };
            public int m_hMoveToThisEntity {                     get => *(int*)(addr + Offset.DT_Drone.m_hMoveToThisEntity);                                 set => *(int*)(addr + Offset.DT_Drone.m_hMoveToThisEntity) = value;                                 }
            public int m_hDeliveryCargo {                        get => *(int*)(addr + Offset.DT_Drone.m_hDeliveryCargo);                                    set => *(int*)(addr + Offset.DT_Drone.m_hDeliveryCargo) = value;                                    }
            public int m_bPilotTakeoverAllowed {                 get => *(int*)(addr + Offset.DT_Drone.m_bPilotTakeoverAllowed);                             set => *(int*)(addr + Offset.DT_Drone.m_bPilotTakeoverAllowed) = value;                             }
            public int m_hPotentialCargo {                       get => *(int*)(addr + Offset.DT_Drone.m_hPotentialCargo);                                   set => *(int*)(addr + Offset.DT_Drone.m_hPotentialCargo) = value;                                   }
            public int m_hCurrentPilot {                         get => *(int*)(addr + Offset.DT_Drone.m_hCurrentPilot);                                     set => *(int*)(addr + Offset.DT_Drone.m_hCurrentPilot) = value;                                     }
            public int m_vecTagPositions_0 {                     get => *(int*)(addr + Offset.DT_Drone.m_vecTagPositions_0);                                 set => *(int*)(addr + Offset.DT_Drone.m_vecTagPositions_0) = value;                                 }
            public int m_vecTagPositions {                       get => *(int*)(addr + Offset.DT_Drone.m_vecTagPositions);                                   set => *(int*)(addr + Offset.DT_Drone.m_vecTagPositions) = value;                                   }
            public int m_vecTagIncrements_0 {                    get => *(int*)(addr + Offset.DT_Drone.m_vecTagIncrements_0);                                set => *(int*)(addr + Offset.DT_Drone.m_vecTagIncrements_0) = value;                                }
            public int m_vecTagIncrements {                      get => *(int*)(addr + Offset.DT_Drone.m_vecTagIncrements);                                  set => *(int*)(addr + Offset.DT_Drone.m_vecTagIncrements) = value;                                  }

        }

        public class FootstepControl : baseStructs
        {
            public static implicit operator FootstepControl(IntPtr ptr) => new FootstepControl() { addr = ptr                                                                                                                                                    };
            public int m_source {                                get => *(int*)(addr + Offset.DT_FootstepControl.m_source);                                  set => *(int*)(addr + Offset.DT_FootstepControl.m_source) = value;                                  }
            public int m_destination {                           get => *(int*)(addr + Offset.DT_FootstepControl.m_destination);                             set => *(int*)(addr + Offset.DT_FootstepControl.m_destination) = value;                             }

        }

        public class TEPlantBomb : baseStructs
        {
            public static implicit operator TEPlantBomb(IntPtr ptr) => new TEPlantBomb() { addr = ptr                                                                                                                                                            };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEPlantBomb.m_vecOrigin);                                   set => *(int*)(addr + Offset.DT_TEPlantBomb.m_vecOrigin) = value;                                   }
            public int m_iPlayer {                               get => *(int*)(addr + Offset.DT_TEPlantBomb.m_iPlayer);                                     set => *(int*)(addr + Offset.DT_TEPlantBomb.m_iPlayer) = value;                                     }
            public int m_option {                                get => *(int*)(addr + Offset.DT_TEPlantBomb.m_option);                                      set => *(int*)(addr + Offset.DT_TEPlantBomb.m_option) = value;                                      }

        }

        public class TEFireBullets : baseStructs
        {
            public static implicit operator TEFireBullets(IntPtr ptr) => new TEFireBullets() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_TEFireBullets.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_TEFireBullets.m_vecOrigin) = value;                                 }
            public int m_vecAngles_0 {                           get => *(int*)(addr + Offset.DT_TEFireBullets.m_vecAngles_0);                               set => *(int*)(addr + Offset.DT_TEFireBullets.m_vecAngles_0) = value;                               }
            public int m_vecAngles_1 {                           get => *(int*)(addr + Offset.DT_TEFireBullets.m_vecAngles_1);                               set => *(int*)(addr + Offset.DT_TEFireBullets.m_vecAngles_1) = value;                               }
            public int m_iWeaponID {                             get => *(int*)(addr + Offset.DT_TEFireBullets.m_iWeaponID);                                 set => *(int*)(addr + Offset.DT_TEFireBullets.m_iWeaponID) = value;                                 }
            public int m_weapon {                                get => *(int*)(addr + Offset.DT_TEFireBullets.m_weapon);                                    set => *(int*)(addr + Offset.DT_TEFireBullets.m_weapon) = value;                                    }
            public int m_iMode {                                 get => *(int*)(addr + Offset.DT_TEFireBullets.m_iMode);                                     set => *(int*)(addr + Offset.DT_TEFireBullets.m_iMode) = value;                                     }
            public int m_iSeed {                                 get => *(int*)(addr + Offset.DT_TEFireBullets.m_iSeed);                                     set => *(int*)(addr + Offset.DT_TEFireBullets.m_iSeed) = value;                                     }
            public int m_iPlayer {                               get => *(int*)(addr + Offset.DT_TEFireBullets.m_iPlayer);                                   set => *(int*)(addr + Offset.DT_TEFireBullets.m_iPlayer) = value;                                   }
            public int m_fInaccuracy {                           get => *(int*)(addr + Offset.DT_TEFireBullets.m_fInaccuracy);                               set => *(int*)(addr + Offset.DT_TEFireBullets.m_fInaccuracy) = value;                               }
            public int m_fSpread {                               get => *(int*)(addr + Offset.DT_TEFireBullets.m_fSpread);                                   set => *(int*)(addr + Offset.DT_TEFireBullets.m_fSpread) = value;                                   }
            public int m_nItemDefIndex {                         get => *(int*)(addr + Offset.DT_TEFireBullets.m_nItemDefIndex);                             set => *(int*)(addr + Offset.DT_TEFireBullets.m_nItemDefIndex) = value;                             }
            public int m_iSoundType {                            get => *(int*)(addr + Offset.DT_TEFireBullets.m_iSoundType);                                set => *(int*)(addr + Offset.DT_TEFireBullets.m_iSoundType) = value;                                }
            public int m_flRecoilIndex {                         get => *(int*)(addr + Offset.DT_TEFireBullets.m_flRecoilIndex);                             set => *(int*)(addr + Offset.DT_TEFireBullets.m_flRecoilIndex) = value;                             }

        }

        public class TERadioIcon : baseStructs
        {
            public static implicit operator TERadioIcon(IntPtr ptr) => new TERadioIcon() { addr = ptr                                                                                                                                                            };
            public int m_iAttachToClient {                       get => *(int*)(addr + Offset.DT_TERadioIcon.m_iAttachToClient);                             set => *(int*)(addr + Offset.DT_TERadioIcon.m_iAttachToClient) = value;                             }

        }

        public class PlantedC4 : baseStructs
        {
            public static implicit operator PlantedC4(IntPtr ptr) => new PlantedC4() { addr = ptr                                                                                                                                                                };
            public int m_bBombTicking {                          get => *(int*)(addr + Offset.DT_PlantedC4.m_bBombTicking);                                  set => *(int*)(addr + Offset.DT_PlantedC4.m_bBombTicking) = value;                                  }
            public int m_nBombSite {                             get => *(int*)(addr + Offset.DT_PlantedC4.m_nBombSite);                                     set => *(int*)(addr + Offset.DT_PlantedC4.m_nBombSite) = value;                                     }
            public int m_flC4Blow {                              get => *(int*)(addr + Offset.DT_PlantedC4.m_flC4Blow);                                      set => *(int*)(addr + Offset.DT_PlantedC4.m_flC4Blow) = value;                                      }
            public int m_flTimerLength {                         get => *(int*)(addr + Offset.DT_PlantedC4.m_flTimerLength);                                 set => *(int*)(addr + Offset.DT_PlantedC4.m_flTimerLength) = value;                                 }
            public int m_flDefuseLength {                        get => *(int*)(addr + Offset.DT_PlantedC4.m_flDefuseLength);                                set => *(int*)(addr + Offset.DT_PlantedC4.m_flDefuseLength) = value;                                }
            public int m_flDefuseCountDown {                     get => *(int*)(addr + Offset.DT_PlantedC4.m_flDefuseCountDown);                             set => *(int*)(addr + Offset.DT_PlantedC4.m_flDefuseCountDown) = value;                             }
            public int m_bBombDefused {                          get => *(int*)(addr + Offset.DT_PlantedC4.m_bBombDefused);                                  set => *(int*)(addr + Offset.DT_PlantedC4.m_bBombDefused) = value;                                  }
            public int m_hBombDefuser {                          get => *(int*)(addr + Offset.DT_PlantedC4.m_hBombDefuser);                                  set => *(int*)(addr + Offset.DT_PlantedC4.m_hBombDefuser) = value;                                  }

        }

        public class CSPlayerResource : baseStructs
        {
            public static implicit operator CSPlayerResource(IntPtr ptr) => new CSPlayerResource() { addr = ptr                                                                                                                                                  };
            public int m_iPlayerC4 {                             get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iPlayerC4);                              set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iPlayerC4) = value;                              }
            public int m_iPlayerVIP {                            get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iPlayerVIP);                             set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iPlayerVIP) = value;                             }
            public int m_bombsiteCenterA {                       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bombsiteCenterA);                        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bombsiteCenterA) = value;                        }
            public int m_bombsiteCenterB {                       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bombsiteCenterB);                        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bombsiteCenterB) = value;                        }
            public int m_bEndMatchNextMapAllVoted {              get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bEndMatchNextMapAllVoted);               set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bEndMatchNextMapAllVoted) = value;               }
            public int m_bHostageAlive {                         get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bHostageAlive);                          set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bHostageAlive) = value;                          }
            public int m_isHostageFollowingSomeone {             get => *(int*)(addr + Offset.DT_CSPlayerResource.m_isHostageFollowingSomeone);              set => *(int*)(addr + Offset.DT_CSPlayerResource.m_isHostageFollowingSomeone) = value;              }
            public int m_iHostageEntityIDs {                     get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iHostageEntityIDs);                      set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iHostageEntityIDs) = value;                      }
            public int m_hostageRescueX {                        get => *(int*)(addr + Offset.DT_CSPlayerResource.m_hostageRescueX);                         set => *(int*)(addr + Offset.DT_CSPlayerResource.m_hostageRescueX) = value;                         }
            public int m_hostageRescueY {                        get => *(int*)(addr + Offset.DT_CSPlayerResource.m_hostageRescueY);                         set => *(int*)(addr + Offset.DT_CSPlayerResource.m_hostageRescueY) = value;                         }
            public int m_hostageRescueZ {                        get => *(int*)(addr + Offset.DT_CSPlayerResource.m_hostageRescueZ);                         set => *(int*)(addr + Offset.DT_CSPlayerResource.m_hostageRescueZ) = value;                         }
            public int m_iMVPs {                                 get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMVPs);                                  set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMVPs) = value;                                  }
            public int m_iArmor {                                get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iArmor);                                 set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iArmor) = value;                                 }
            public int m_bHasHelmet {                            get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bHasHelmet);                             set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bHasHelmet) = value;                             }
            public int m_bHasDefuser {                           get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bHasDefuser);                            set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bHasDefuser) = value;                            }
            public int m_iScore {                                get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iScore);                                 set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iScore) = value;                                 }
            public int m_iCompetitiveRanking {                   get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompetitiveRanking);                    set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompetitiveRanking) = value;                    }
            public int m_iCompetitiveWins {                      get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompetitiveWins);                       set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompetitiveWins) = value;                       }
            public int m_iCompetitiveRankType {                  get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompetitiveRankType);                   set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompetitiveRankType) = value;                   }
            public int m_iCompTeammateColor {                    get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompTeammateColor);                     set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCompTeammateColor) = value;                     }
            public int m_iLifetimeStart {                        get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iLifetimeStart);                         set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iLifetimeStart) = value;                         }
            public int m_iLifetimeEnd {                          get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iLifetimeEnd);                           set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iLifetimeEnd) = value;                           }
            public int m_bControllingBot {                       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_bControllingBot);                        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_bControllingBot) = value;                        }
            public int m_iControlledPlayer {                     get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iControlledPlayer);                      set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iControlledPlayer) = value;                      }
            public int m_iControlledByPlayer {                   get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iControlledByPlayer);                    set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iControlledByPlayer) = value;                    }
            public int m_iBotDifficulty {                        get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iBotDifficulty);                         set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iBotDifficulty) = value;                         }
            public int m_szClan {                                get => *(int*)(addr + Offset.DT_CSPlayerResource.m_szClan);                                 set => *(int*)(addr + Offset.DT_CSPlayerResource.m_szClan) = value;                                 }
            public int m_nCharacterDefIndex {                    get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nCharacterDefIndex);                     set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nCharacterDefIndex) = value;                     }
            public int m_iTotalCashSpent {                       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iTotalCashSpent);                        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iTotalCashSpent) = value;                        }
            public int m_iGunGameLevel {                         get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iGunGameLevel);                          set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iGunGameLevel) = value;                          }
            public int m_iCashSpentThisRound {                   get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCashSpentThisRound);                    set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iCashSpentThisRound) = value;                    }
            public int m_nEndMatchNextMapVotes {                 get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nEndMatchNextMapVotes);                  set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nEndMatchNextMapVotes) = value;                  }
            public int m_nActiveCoinRank {                       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nActiveCoinRank);                        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nActiveCoinRank) = value;                        }
            public int m_nMusicID {                              get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nMusicID);                               set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nMusicID) = value;                               }
            public int m_nPersonaDataPublicLevel {               get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicLevel);                set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicLevel) = value;                }
            public int m_nPersonaDataPublicCommendsLeader {      get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicCommendsLeader);       set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicCommendsLeader) = value;       }
            public int m_nPersonaDataPublicCommendsTeacher {     get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicCommendsTeacher);      set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicCommendsTeacher) = value;      }
            public int m_nPersonaDataPublicCommendsFriendly {    get => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicCommendsFriendly);     set => *(int*)(addr + Offset.DT_CSPlayerResource.m_nPersonaDataPublicCommendsFriendly) = value;     }
            public int m_iMatchStats_Kills_Total {               get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Kills_Total);                set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Kills_Total) = value;                }
            public int m_iMatchStats_5k_Total {                  get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_5k_Total);                   set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_5k_Total) = value;                   }
            public int m_iMatchStats_4k_Total {                  get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_4k_Total);                   set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_4k_Total) = value;                   }
            public int m_iMatchStats_3k_Total {                  get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_3k_Total);                   set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_3k_Total) = value;                   }
            public int m_iMatchStats_Damage_Total {              get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Damage_Total);               set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Damage_Total) = value;               }
            public int m_iMatchStats_EquipmentValue_Total {      get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_EquipmentValue_Total);       set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_EquipmentValue_Total) = value;       }
            public int m_iMatchStats_KillReward_Total {          get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_KillReward_Total);           set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_KillReward_Total) = value;           }
            public int m_iMatchStats_LiveTime_Total {            get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_LiveTime_Total);             set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_LiveTime_Total) = value;             }
            public int m_iMatchStats_Deaths_Total {              get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Deaths_Total);               set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Deaths_Total) = value;               }
            public int m_iMatchStats_Assists_Total {             get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Assists_Total);              set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Assists_Total) = value;              }
            public int m_iMatchStats_HeadShotKills_Total {       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_HeadShotKills_Total);        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_HeadShotKills_Total) = value;        }
            public int m_iMatchStats_Objective_Total {           get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Objective_Total);            set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_Objective_Total) = value;            }
            public int m_iMatchStats_CashEarned_Total {          get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_CashEarned_Total);           set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_CashEarned_Total) = value;           }
            public int m_iMatchStats_UtilityDamage_Total {       get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_UtilityDamage_Total);        set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_UtilityDamage_Total) = value;        }
            public int m_iMatchStats_EnemiesFlashed_Total {      get => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_EnemiesFlashed_Total);       set => *(int*)(addr + Offset.DT_CSPlayerResource.m_iMatchStats_EnemiesFlashed_Total) = value;       }

        }

        public class CSPlayer : BaseCombatCharacter
        {
            public static implicit operator CSPlayer(IntPtr ptr) => new CSPlayer() { addr = ptr                                                                                                                                                                  };
            public int m_iCrosshairId {                          get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasDefuser + 92);                               set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasDefuser + 92) = value;                               }
            public int m_angEyeAngles_0 {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_angEyeAngles_0);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_angEyeAngles_0) = value;                                 }
            public int m_angEyeAngles_1 {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_angEyeAngles_1);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_angEyeAngles_1) = value;                                 }
            public int m_iAddonBits {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_iAddonBits);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_iAddonBits) = value;                                     }
            public int m_iPrimaryAddon {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_iPrimaryAddon);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_iPrimaryAddon) = value;                                  }
            public int m_iSecondaryAddon {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_iSecondaryAddon);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_iSecondaryAddon) = value;                                }
            public int m_iThrowGrenadeCounter {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_iThrowGrenadeCounter);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_iThrowGrenadeCounter) = value;                           }
            public int m_bWaitForNoAttack {                      get => *(int*)(addr + Offset.DT_CSPlayer.m_bWaitForNoAttack);                               set => *(int*)(addr + Offset.DT_CSPlayer.m_bWaitForNoAttack) = value;                               }
            public int m_bIsRespawningForDMBonus {               get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsRespawningForDMBonus);                        set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsRespawningForDMBonus) = value;                        }
            public int m_iPlayerState {                          get => *(int*)(addr + Offset.DT_CSPlayer.m_iPlayerState);                                   set => *(int*)(addr + Offset.DT_CSPlayer.m_iPlayerState) = value;                                   }
            public int m_iAccount {                              get => *(int*)(addr + Offset.DT_CSPlayer.m_iAccount);                                       set => *(int*)(addr + Offset.DT_CSPlayer.m_iAccount) = value;                                       }
            public int m_iStartAccount {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_iStartAccount);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_iStartAccount) = value;                                  }
            public int m_totalHitsOnServer {                     get => *(int*)(addr + Offset.DT_CSPlayer.m_totalHitsOnServer);                              set => *(int*)(addr + Offset.DT_CSPlayer.m_totalHitsOnServer) = value;                              }
            public int m_bInBombZone {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_bInBombZone);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_bInBombZone) = value;                                    }
            public int m_bInBuyZone {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_bInBuyZone);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_bInBuyZone) = value;                                     }
            public int m_bInNoDefuseArea {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_bInNoDefuseArea);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_bInNoDefuseArea) = value;                                }
            public int m_bKilledByTaser {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_bKilledByTaser);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_bKilledByTaser) = value;                                 }
            public int m_iMoveState {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_iMoveState);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_iMoveState) = value;                                     }
            public int m_iClass {                                get => *(int*)(addr + Offset.DT_CSPlayer.m_iClass);                                         set => *(int*)(addr + Offset.DT_CSPlayer.m_iClass) = value;                                         }
            public int m_ArmorValue {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_ArmorValue);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_ArmorValue) = value;                                     }
            public int m_angEyeAngles {                          get => *(int*)(addr + Offset.DT_CSPlayer.m_angEyeAngles);                                   set => *(int*)(addr + Offset.DT_CSPlayer.m_angEyeAngles) = value;                                   }
            public int m_bHasDefuser {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasDefuser);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasDefuser) = value;                                    }
            public int m_bNightVisionOn {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_bNightVisionOn);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_bNightVisionOn) = value;                                 }
            public int m_bHasNightVision {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasNightVision);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasNightVision) = value;                                }
            public int m_bInHostageRescueZone {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_bInHostageRescueZone);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_bInHostageRescueZone) = value;                           }
            public int m_bIsDefusing {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsDefusing);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsDefusing) = value;                                    }
            public int m_bIsGrabbingHostage {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsGrabbingHostage);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsGrabbingHostage) = value;                             }
            public int m_iBlockingUseActionInProgress {          get => *(int*)(addr + Offset.DT_CSPlayer.m_iBlockingUseActionInProgress);                   set => *(int*)(addr + Offset.DT_CSPlayer.m_iBlockingUseActionInProgress) = value;                   }
            public int m_bIsScoped {                             get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsScoped);                                      set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsScoped) = value;                                      }
            public int m_bIsWalking {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsWalking);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsWalking) = value;                                     }
            public int m_nIsAutoMounting {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_nIsAutoMounting);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_nIsAutoMounting) = value;                                }
            public int m_bResumeZoom {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_bResumeZoom);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_bResumeZoom) = value;                                    }
            public int m_fImmuneToGunGameDamageTime {            get => *(int*)(addr + Offset.DT_CSPlayer.m_fImmuneToGunGameDamageTime);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_fImmuneToGunGameDamageTime) = value;                     }
            public int m_bGunGameImmunity {                      get => *(int*)(addr + Offset.DT_CSPlayer.m_bGunGameImmunity);                               set => *(int*)(addr + Offset.DT_CSPlayer.m_bGunGameImmunity) = value;                               }
            public int m_bHasMovedSinceSpawn {                   get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasMovedSinceSpawn);                            set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasMovedSinceSpawn) = value;                            }
            public int m_bMadeFinalGunGameProgressiveKill {      get => *(int*)(addr + Offset.DT_CSPlayer.m_bMadeFinalGunGameProgressiveKill);               set => *(int*)(addr + Offset.DT_CSPlayer.m_bMadeFinalGunGameProgressiveKill) = value;               }
            public int m_iGunGameProgressiveWeaponIndex {        get => *(int*)(addr + Offset.DT_CSPlayer.m_iGunGameProgressiveWeaponIndex);                 set => *(int*)(addr + Offset.DT_CSPlayer.m_iGunGameProgressiveWeaponIndex) = value;                 }
            public int m_iNumGunGameTRKillPoints {               get => *(int*)(addr + Offset.DT_CSPlayer.m_iNumGunGameTRKillPoints);                        set => *(int*)(addr + Offset.DT_CSPlayer.m_iNumGunGameTRKillPoints) = value;                        }
            public int m_iNumGunGameKillsWithCurrentWeapon {     get => *(int*)(addr + Offset.DT_CSPlayer.m_iNumGunGameKillsWithCurrentWeapon);              set => *(int*)(addr + Offset.DT_CSPlayer.m_iNumGunGameKillsWithCurrentWeapon) = value;              }
            public int m_iNumRoundKills {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_iNumRoundKills);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_iNumRoundKills) = value;                                 }
            public int m_fMolotovUseTime {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_fMolotovUseTime);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_fMolotovUseTime) = value;                                }
            public int m_fMolotovDamageTime {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_fMolotovDamageTime);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_fMolotovDamageTime) = value;                             }
            public int m_szArmsModel {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_szArmsModel);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_szArmsModel) = value;                                    }
            public int m_hCarriedHostage {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_hCarriedHostage);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_hCarriedHostage) = value;                                }
            public int m_hCarriedHostageProp {                   get => *(int*)(addr + Offset.DT_CSPlayer.m_hCarriedHostageProp);                            set => *(int*)(addr + Offset.DT_CSPlayer.m_hCarriedHostageProp) = value;                            }
            public int m_bIsRescuing {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsRescuing);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsRescuing) = value;                                    }
            public int m_flGroundAccelLinearFracLastTime {       get => *(int*)(addr + Offset.DT_CSPlayer.m_flGroundAccelLinearFracLastTime);                set => *(int*)(addr + Offset.DT_CSPlayer.m_flGroundAccelLinearFracLastTime) = value;                }
            public int m_bCanMoveDuringFreezePeriod {            get => *(int*)(addr + Offset.DT_CSPlayer.m_bCanMoveDuringFreezePeriod);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_bCanMoveDuringFreezePeriod) = value;                     }
            public int m_isCurrentGunGameLeader {                get => *(int*)(addr + Offset.DT_CSPlayer.m_isCurrentGunGameLeader);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_isCurrentGunGameLeader) = value;                         }
            public int m_isCurrentGunGameTeamLeader {            get => *(int*)(addr + Offset.DT_CSPlayer.m_isCurrentGunGameTeamLeader);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_isCurrentGunGameTeamLeader) = value;                     }
            public int m_flGuardianTooFarDistFrac {              get => *(int*)(addr + Offset.DT_CSPlayer.m_flGuardianTooFarDistFrac);                       set => *(int*)(addr + Offset.DT_CSPlayer.m_flGuardianTooFarDistFrac) = value;                       }
            public int m_flDetectedByEnemySensorTime {           get => *(int*)(addr + Offset.DT_CSPlayer.m_flDetectedByEnemySensorTime);                    set => *(int*)(addr + Offset.DT_CSPlayer.m_flDetectedByEnemySensorTime) = value;                    }
            public int m_bIsPlayerGhost {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsPlayerGhost);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsPlayerGhost) = value;                                 }
            public int m_bHasParachute {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasParachute);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasParachute) = value;                                  }
            public int m_unMusicID {                             get => *(int*)(addr + Offset.DT_CSPlayer.m_unMusicID);                                      set => *(int*)(addr + Offset.DT_CSPlayer.m_unMusicID) = value;                                      }
            public int m_bHasHelmet {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasHelmet);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasHelmet) = value;                                     }
            public int m_bHasHeavyArmor {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasHeavyArmor);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasHeavyArmor) = value;                                 }
            public int m_nHeavyAssaultSuitCooldownRemaining {    get => *(int*)(addr + Offset.DT_CSPlayer.m_nHeavyAssaultSuitCooldownRemaining);             set => *(int*)(addr + Offset.DT_CSPlayer.m_nHeavyAssaultSuitCooldownRemaining) = value;             }
            public int m_flFlashDuration {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_flFlashDuration);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_flFlashDuration) = value;                                }
            public int m_flFlashMaxAlpha {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_flFlashMaxAlpha);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_flFlashMaxAlpha) = value;                                }
            public int m_iProgressBarDuration {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_iProgressBarDuration);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_iProgressBarDuration) = value;                           }
            public int m_flProgressBarStartTime {                get => *(int*)(addr + Offset.DT_CSPlayer.m_flProgressBarStartTime);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_flProgressBarStartTime) = value;                         }
            public int m_hRagdoll {                              get => *(int*)(addr + Offset.DT_CSPlayer.m_hRagdoll);                                       set => *(int*)(addr + Offset.DT_CSPlayer.m_hRagdoll) = value;                                       }
            public int m_hPlayerPing {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_hPlayerPing);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_hPlayerPing) = value;                                    }
            public int m_cycleLatch {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_cycleLatch);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_cycleLatch) = value;                                     }
            public int m_unCurrentEquipmentValue {               get => *(int*)(addr + Offset.DT_CSPlayer.m_unCurrentEquipmentValue);                        set => *(int*)(addr + Offset.DT_CSPlayer.m_unCurrentEquipmentValue) = value;                        }
            public int m_unRoundStartEquipmentValue {            get => *(int*)(addr + Offset.DT_CSPlayer.m_unRoundStartEquipmentValue);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_unRoundStartEquipmentValue) = value;                     }
            public int m_unFreezetimeEndEquipmentValue {         get => *(int*)(addr + Offset.DT_CSPlayer.m_unFreezetimeEndEquipmentValue);                  set => *(int*)(addr + Offset.DT_CSPlayer.m_unFreezetimeEndEquipmentValue) = value;                  }
            public int m_bIsControllingBot {                     get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsControllingBot);                              set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsControllingBot) = value;                              }
            public int m_bHasControlledBotThisRound {            get => *(int*)(addr + Offset.DT_CSPlayer.m_bHasControlledBotThisRound);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_bHasControlledBotThisRound) = value;                     }
            public int m_bCanControlObservedBot {                get => *(int*)(addr + Offset.DT_CSPlayer.m_bCanControlObservedBot);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_bCanControlObservedBot) = value;                         }
            public int m_iControlledBotEntIndex {                get => *(int*)(addr + Offset.DT_CSPlayer.m_iControlledBotEntIndex);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_iControlledBotEntIndex) = value;                         }
            public int m_vecAutomoveTargetEnd {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_vecAutomoveTargetEnd);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_vecAutomoveTargetEnd) = value;                           }
            public int m_flAutoMoveStartTime {                   get => *(int*)(addr + Offset.DT_CSPlayer.m_flAutoMoveStartTime);                            set => *(int*)(addr + Offset.DT_CSPlayer.m_flAutoMoveStartTime) = value;                            }
            public int m_flAutoMoveTargetTime {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_flAutoMoveTargetTime);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_flAutoMoveTargetTime) = value;                           }
            public int m_bIsAssassinationTarget {                get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsAssassinationTarget);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsAssassinationTarget) = value;                         }
            public int m_bHud_MiniScoreHidden {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_bHud_MiniScoreHidden);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_bHud_MiniScoreHidden) = value;                           }
            public int m_bHud_RadarHidden {                      get => *(int*)(addr + Offset.DT_CSPlayer.m_bHud_RadarHidden);                               set => *(int*)(addr + Offset.DT_CSPlayer.m_bHud_RadarHidden) = value;                               }
            public int m_nLastKillerIndex {                      get => *(int*)(addr + Offset.DT_CSPlayer.m_nLastKillerIndex);                               set => *(int*)(addr + Offset.DT_CSPlayer.m_nLastKillerIndex) = value;                               }
            public int m_nLastConcurrentKilled {                 get => *(int*)(addr + Offset.DT_CSPlayer.m_nLastConcurrentKilled);                          set => *(int*)(addr + Offset.DT_CSPlayer.m_nLastConcurrentKilled) = value;                          }
            public int m_nDeathCamMusic {                        get => *(int*)(addr + Offset.DT_CSPlayer.m_nDeathCamMusic);                                 set => *(int*)(addr + Offset.DT_CSPlayer.m_nDeathCamMusic) = value;                                 }
            public int m_bIsHoldingLookAtWeapon {                get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsHoldingLookAtWeapon);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsHoldingLookAtWeapon) = value;                         }
            public int m_bIsLookingAtWeapon {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsLookingAtWeapon);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsLookingAtWeapon) = value;                             }
            public int m_iNumRoundKillsHeadshots {               get => *(int*)(addr + Offset.DT_CSPlayer.m_iNumRoundKillsHeadshots);                        set => *(int*)(addr + Offset.DT_CSPlayer.m_iNumRoundKillsHeadshots) = value;                        }
            public int m_unTotalRoundDamageDealt {               get => *(int*)(addr + Offset.DT_CSPlayer.m_unTotalRoundDamageDealt);                        set => *(int*)(addr + Offset.DT_CSPlayer.m_unTotalRoundDamageDealt) = value;                        }
            public int m_flLowerBodyYawTarget {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_flLowerBodyYawTarget);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_flLowerBodyYawTarget) = value;                           }
            public int m_bStrafing {                             get => *(int*)(addr + Offset.DT_CSPlayer.m_bStrafing);                                      set => *(int*)(addr + Offset.DT_CSPlayer.m_bStrafing) = value;                                      }
            public int m_flThirdpersonRecoil {                   get => *(int*)(addr + Offset.DT_CSPlayer.m_flThirdpersonRecoil);                            set => *(int*)(addr + Offset.DT_CSPlayer.m_flThirdpersonRecoil) = value;                            }
            public int m_bHideTargetID {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_bHideTargetID);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_bHideTargetID) = value;                                  }
            public int m_bIsSpawnRappelling {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_bIsSpawnRappelling);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_bIsSpawnRappelling) = value;                             }
            public int m_vecSpawnRappellingRopeOrigin {          get => *(int*)(addr + Offset.DT_CSPlayer.m_vecSpawnRappellingRopeOrigin);                   set => *(int*)(addr + Offset.DT_CSPlayer.m_vecSpawnRappellingRopeOrigin) = value;                   }
            public int m_nSurvivalTeam {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_nSurvivalTeam);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_nSurvivalTeam) = value;                                  }
            public int m_hSurvivalAssassinationTarget {          get => *(int*)(addr + Offset.DT_CSPlayer.m_hSurvivalAssassinationTarget);                   set => *(int*)(addr + Offset.DT_CSPlayer.m_hSurvivalAssassinationTarget) = value;                   }
            public int m_flHealthShotBoostExpirationTime {       get => *(int*)(addr + Offset.DT_CSPlayer.m_flHealthShotBoostExpirationTime);                set => *(int*)(addr + Offset.DT_CSPlayer.m_flHealthShotBoostExpirationTime) = value;                }
            public int m_flLastExoJumpTime {                     get => *(int*)(addr + Offset.DT_CSPlayer.m_flLastExoJumpTime);                              set => *(int*)(addr + Offset.DT_CSPlayer.m_flLastExoJumpTime) = value;                              }
            public Vector m_vecOrigin {                          get => *(Vector*)(addr + Offset.DT_CSPlayer.m_vecOrigin);                                   set => *(Vector*)(addr + Offset.DT_CSPlayer.m_vecOrigin) = value;                                      }
            public int m_vecOrigin_2 {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_vecOrigin_2);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_vecOrigin_2) = value;                                    }
            public int m_flStamina {                             get => *(int*)(addr + Offset.DT_CSPlayer.m_flStamina);                                      set => *(int*)(addr + Offset.DT_CSPlayer.m_flStamina) = value;                                      }
            public int m_iDirection {                            get => *(int*)(addr + Offset.DT_CSPlayer.m_iDirection);                                     set => *(int*)(addr + Offset.DT_CSPlayer.m_iDirection) = value;                                     }
            public int m_iShotsFired {                           get => *(int*)(addr + Offset.DT_CSPlayer.m_iShotsFired);                                    set => *(int*)(addr + Offset.DT_CSPlayer.m_iShotsFired) = value;                                    }
            public int m_nNumFastDucks {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_nNumFastDucks);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_nNumFastDucks) = value;                                  }
            public int m_bDuckOverride {                         get => *(int*)(addr + Offset.DT_CSPlayer.m_bDuckOverride);                                  set => *(int*)(addr + Offset.DT_CSPlayer.m_bDuckOverride) = value;                                  }
            public int m_flVelocityModifier {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_flVelocityModifier);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_flVelocityModifier) = value;                             }
            public int m_unActiveQuestId {                       get => *(int*)(addr + Offset.DT_CSPlayer.m_unActiveQuestId);                                set => *(int*)(addr + Offset.DT_CSPlayer.m_unActiveQuestId) = value;                                }
            public int m_nQuestProgressReason {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_nQuestProgressReason);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_nQuestProgressReason) = value;                           }
            public int m_bPlayerDominated {                      get => *(int*)(addr + Offset.DT_CSPlayer.m_bPlayerDominated);                               set => *(int*)(addr + Offset.DT_CSPlayer.m_bPlayerDominated) = value;                               }
            public int m_bPlayerDominatingMe {                   get => *(int*)(addr + Offset.DT_CSPlayer.m_bPlayerDominatingMe);                            set => *(int*)(addr + Offset.DT_CSPlayer.m_bPlayerDominatingMe) = value;                            }
            public int m_iWeaponPurchasesThisRound {             get => *(int*)(addr + Offset.DT_CSPlayer.m_iWeaponPurchasesThisRound);                      set => *(int*)(addr + Offset.DT_CSPlayer.m_iWeaponPurchasesThisRound) = value;                      }
            public int cslocaldata {                             get => *(int*)(addr + Offset.DT_CSPlayer.cslocaldata);                                      set => *(int*)(addr + Offset.DT_CSPlayer.cslocaldata) = value;                                      }
            public int csnonlocaldata {                          get => *(int*)(addr + Offset.DT_CSPlayer.csnonlocaldata);                                   set => *(int*)(addr + Offset.DT_CSPlayer.csnonlocaldata) = value;                                   }
            public int csteamdata {                              get => *(int*)(addr + Offset.DT_CSPlayer.csteamdata);                                       set => *(int*)(addr + Offset.DT_CSPlayer.csteamdata) = value;                                       }
            public int m_iMatchStats_Kills {                     get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Kills);                              set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Kills) = value;                              }
            public int m_iMatchStats_Damage {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Damage);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Damage) = value;                             }
            public int m_iMatchStats_EquipmentValue {            get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_EquipmentValue);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_EquipmentValue) = value;                     }
            public int m_iMatchStats_MoneySaved {                get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_MoneySaved);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_MoneySaved) = value;                         }
            public int m_iMatchStats_KillReward {                get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_KillReward);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_KillReward) = value;                         }
            public int m_iMatchStats_LiveTime {                  get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_LiveTime);                           set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_LiveTime) = value;                           }
            public int m_iMatchStats_Deaths {                    get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Deaths);                             set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Deaths) = value;                             }
            public int m_iMatchStats_Assists {                   get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Assists);                            set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Assists) = value;                            }
            public int m_iMatchStats_HeadShotKills {             get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_HeadShotKills);                      set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_HeadShotKills) = value;                      }
            public int m_iMatchStats_Objective {                 get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Objective);                          set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_Objective) = value;                          }
            public int m_iMatchStats_CashEarned {                get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_CashEarned);                         set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_CashEarned) = value;                         }
            public int m_iMatchStats_UtilityDamage {             get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_UtilityDamage);                      set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_UtilityDamage) = value;                      }
            public int m_iMatchStats_EnemiesFlashed {            get => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_EnemiesFlashed);                     set => *(int*)(addr + Offset.DT_CSPlayer.m_iMatchStats_EnemiesFlashed) = value;                     }
            public int m_rank {                                  get => *(int*)(addr + Offset.DT_CSPlayer.m_rank);                                           set => *(int*)(addr + Offset.DT_CSPlayer.m_rank) = value;                                           }
            public int m_passiveItems {                          get => *(int*)(addr + Offset.DT_CSPlayer.m_passiveItems);                                   set => *(int*)(addr + Offset.DT_CSPlayer.m_passiveItems) = value;                                   }

        }

        public class PlayerPing : baseStructs
        {
            public static implicit operator PlayerPing(IntPtr ptr) => new PlayerPing() { addr = ptr                                                                                                                                                              };
            public int m_hPlayer {                               get => *(int*)(addr + Offset.DT_PlayerPing.m_hPlayer);                                      set => *(int*)(addr + Offset.DT_PlayerPing.m_hPlayer) = value;                                      }
            public int m_hPingedEntity {                         get => *(int*)(addr + Offset.DT_PlayerPing.m_hPingedEntity);                                set => *(int*)(addr + Offset.DT_PlayerPing.m_hPingedEntity) = value;                                }
            public int m_iType {                                 get => *(int*)(addr + Offset.DT_PlayerPing.m_iType);                                        set => *(int*)(addr + Offset.DT_PlayerPing.m_iType) = value;                                        }

        }

        public class CSRagdoll : baseStructs
        {
            public static implicit operator CSRagdoll(IntPtr ptr) => new CSRagdoll() { addr = ptr                                                                                                                                                                };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_CSRagdoll.m_vecOrigin);                                     set => *(int*)(addr + Offset.DT_CSRagdoll.m_vecOrigin) = value;                                     }
            public int m_vecRagdollOrigin {                      get => *(int*)(addr + Offset.DT_CSRagdoll.m_vecRagdollOrigin);                              set => *(int*)(addr + Offset.DT_CSRagdoll.m_vecRagdollOrigin) = value;                              }
            public int m_hPlayer {                               get => *(int*)(addr + Offset.DT_CSRagdoll.m_hPlayer);                                       set => *(int*)(addr + Offset.DT_CSRagdoll.m_hPlayer) = value;                                       }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_CSRagdoll.m_nModelIndex);                                   set => *(int*)(addr + Offset.DT_CSRagdoll.m_nModelIndex) = value;                                   }
            public int m_nForceBone {                            get => *(int*)(addr + Offset.DT_CSRagdoll.m_nForceBone);                                    set => *(int*)(addr + Offset.DT_CSRagdoll.m_nForceBone) = value;                                    }
            public int m_vecForce {                              get => *(int*)(addr + Offset.DT_CSRagdoll.m_vecForce);                                      set => *(int*)(addr + Offset.DT_CSRagdoll.m_vecForce) = value;                                      }
            public int m_vecRagdollVelocity {                    get => *(int*)(addr + Offset.DT_CSRagdoll.m_vecRagdollVelocity);                            set => *(int*)(addr + Offset.DT_CSRagdoll.m_vecRagdollVelocity) = value;                            }
            public int m_iDeathPose {                            get => *(int*)(addr + Offset.DT_CSRagdoll.m_iDeathPose);                                    set => *(int*)(addr + Offset.DT_CSRagdoll.m_iDeathPose) = value;                                    }
            public int m_iDeathFrame {                           get => *(int*)(addr + Offset.DT_CSRagdoll.m_iDeathFrame);                                   set => *(int*)(addr + Offset.DT_CSRagdoll.m_iDeathFrame) = value;                                   }
            public int m_iTeamNum {                              get => *(int*)(addr + Offset.DT_CSRagdoll.m_iTeamNum);                                      set => *(int*)(addr + Offset.DT_CSRagdoll.m_iTeamNum) = value;                                      }
            public int m_bClientSideAnimation {                  get => *(int*)(addr + Offset.DT_CSRagdoll.m_bClientSideAnimation);                          set => *(int*)(addr + Offset.DT_CSRagdoll.m_bClientSideAnimation) = value;                          }
            public int m_flDeathYaw {                            get => *(int*)(addr + Offset.DT_CSRagdoll.m_flDeathYaw);                                    set => *(int*)(addr + Offset.DT_CSRagdoll.m_flDeathYaw) = value;                                    }
            public int m_flAbsYaw {                              get => *(int*)(addr + Offset.DT_CSRagdoll.m_flAbsYaw);                                      set => *(int*)(addr + Offset.DT_CSRagdoll.m_flAbsYaw) = value;                                      }

        }

        public class TEPlayerAnimEvent : baseStructs
        {
            public static implicit operator TEPlayerAnimEvent(IntPtr ptr) => new TEPlayerAnimEvent() { addr = ptr                                                                                                                                                };
            public int m_hPlayer {                               get => *(int*)(addr + Offset.DT_TEPlayerAnimEvent.m_hPlayer);                               set => *(int*)(addr + Offset.DT_TEPlayerAnimEvent.m_hPlayer) = value;                               }
            public int m_iEvent {                                get => *(int*)(addr + Offset.DT_TEPlayerAnimEvent.m_iEvent);                                set => *(int*)(addr + Offset.DT_TEPlayerAnimEvent.m_iEvent) = value;                                }
            public int m_nData {                                 get => *(int*)(addr + Offset.DT_TEPlayerAnimEvent.m_nData);                                 set => *(int*)(addr + Offset.DT_TEPlayerAnimEvent.m_nData) = value;                                 }

        }

        public class CHostage : baseStructs
        {
            public static implicit operator CHostage(IntPtr ptr) => new CHostage() { addr = ptr                                                                                                                                                                  };
            public int m_isRescued {                             get => *(int*)(addr + Offset.DT_CHostage.m_isRescued);                                      set => *(int*)(addr + Offset.DT_CHostage.m_isRescued) = value;                                      }
            public int m_jumpedThisFrame {                       get => *(int*)(addr + Offset.DT_CHostage.m_jumpedThisFrame);                                set => *(int*)(addr + Offset.DT_CHostage.m_jumpedThisFrame) = value;                                }
            public int m_iHealth {                               get => *(int*)(addr + Offset.DT_CHostage.m_iHealth);                                        set => *(int*)(addr + Offset.DT_CHostage.m_iHealth) = value;                                        }
            public int m_iMaxHealth {                            get => *(int*)(addr + Offset.DT_CHostage.m_iMaxHealth);                                     set => *(int*)(addr + Offset.DT_CHostage.m_iMaxHealth) = value;                                     }
            public int m_lifeState {                             get => *(int*)(addr + Offset.DT_CHostage.m_lifeState);                                      set => *(int*)(addr + Offset.DT_CHostage.m_lifeState) = value;                                      }
            public int m_fFlags {                                get => *(int*)(addr + Offset.DT_CHostage.m_fFlags);                                         set => *(int*)(addr + Offset.DT_CHostage.m_fFlags) = value;                                         }
            public int m_nHostageState {                         get => *(int*)(addr + Offset.DT_CHostage.m_nHostageState);                                  set => *(int*)(addr + Offset.DT_CHostage.m_nHostageState) = value;                                  }
            public int m_flRescueStartTime {                     get => *(int*)(addr + Offset.DT_CHostage.m_flRescueStartTime);                              set => *(int*)(addr + Offset.DT_CHostage.m_flRescueStartTime) = value;                              }
            public int m_flGrabSuccessTime {                     get => *(int*)(addr + Offset.DT_CHostage.m_flGrabSuccessTime);                              set => *(int*)(addr + Offset.DT_CHostage.m_flGrabSuccessTime) = value;                              }
            public int m_flDropStartTime {                       get => *(int*)(addr + Offset.DT_CHostage.m_flDropStartTime);                                set => *(int*)(addr + Offset.DT_CHostage.m_flDropStartTime) = value;                                }
            public int m_vel {                                   get => *(int*)(addr + Offset.DT_CHostage.m_vel);                                            set => *(int*)(addr + Offset.DT_CHostage.m_vel) = value;                                            }
            public int m_leader {                                get => *(int*)(addr + Offset.DT_CHostage.m_leader);                                         set => *(int*)(addr + Offset.DT_CHostage.m_leader) = value;                                         }

        }

        public class BaseCSGrenadeProjectile : baseStructs
        {
            public static implicit operator BaseCSGrenadeProjectile(IntPtr ptr) => new BaseCSGrenadeProjectile() { addr = ptr                                                                                                                                    };
            public int m_vInitialVelocity {                      get => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_vInitialVelocity);                set => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_vInitialVelocity) = value;                }
            public int m_nBounces {                              get => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_nBounces);                        set => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_nBounces) = value;                        }
            public int m_nExplodeEffectIndex {                   get => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_nExplodeEffectIndex);             set => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_nExplodeEffectIndex) = value;             }
            public int m_nExplodeEffectTickBegin {               get => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_nExplodeEffectTickBegin);         set => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_nExplodeEffectTickBegin) = value;         }
            public int m_vecExplodeEffectOrigin {                get => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_vecExplodeEffectOrigin);          set => *(int*)(addr + Offset.DT_BaseCSGrenadeProjectile.m_vecExplodeEffectOrigin) = value;          }

        }

        public class HandleTest : baseStructs
        {
            public static implicit operator HandleTest(IntPtr ptr) => new HandleTest() { addr = ptr                                                                                                                                                              };
            public int m_Handle {                                get => *(int*)(addr + Offset.DT_HandleTest.m_Handle);                                       set => *(int*)(addr + Offset.DT_HandleTest.m_Handle) = value;                                       }
            public int m_bSendHandle {                           get => *(int*)(addr + Offset.DT_HandleTest.m_bSendHandle);                                  set => *(int*)(addr + Offset.DT_HandleTest.m_bSendHandle) = value;                                  }

        }

        public class SpriteTrail : baseStructs
        {
            public static implicit operator SpriteTrail(IntPtr ptr) => new SpriteTrail() { addr = ptr                                                                                                                                                            };
            public int m_flLifeTime {                            get => *(int*)(addr + Offset.DT_SpriteTrail.m_flLifeTime);                                  set => *(int*)(addr + Offset.DT_SpriteTrail.m_flLifeTime) = value;                                  }
            public int m_flStartWidth {                          get => *(int*)(addr + Offset.DT_SpriteTrail.m_flStartWidth);                                set => *(int*)(addr + Offset.DT_SpriteTrail.m_flStartWidth) = value;                                }
            public int m_flEndWidth {                            get => *(int*)(addr + Offset.DT_SpriteTrail.m_flEndWidth);                                  set => *(int*)(addr + Offset.DT_SpriteTrail.m_flEndWidth) = value;                                  }
            public int m_flStartWidthVariance {                  get => *(int*)(addr + Offset.DT_SpriteTrail.m_flStartWidthVariance);                        set => *(int*)(addr + Offset.DT_SpriteTrail.m_flStartWidthVariance) = value;                        }
            public int m_flTextureRes {                          get => *(int*)(addr + Offset.DT_SpriteTrail.m_flTextureRes);                                set => *(int*)(addr + Offset.DT_SpriteTrail.m_flTextureRes) = value;                                }
            public int m_flMinFadeLength {                       get => *(int*)(addr + Offset.DT_SpriteTrail.m_flMinFadeLength);                             set => *(int*)(addr + Offset.DT_SpriteTrail.m_flMinFadeLength) = value;                             }
            public int m_vecSkyboxOrigin {                       get => *(int*)(addr + Offset.DT_SpriteTrail.m_vecSkyboxOrigin);                             set => *(int*)(addr + Offset.DT_SpriteTrail.m_vecSkyboxOrigin) = value;                             }
            public int m_flSkyboxScale {                         get => *(int*)(addr + Offset.DT_SpriteTrail.m_flSkyboxScale);                               set => *(int*)(addr + Offset.DT_SpriteTrail.m_flSkyboxScale) = value;                               }

        }

        public class Sprite : baseStructs
        {
            public static implicit operator Sprite(IntPtr ptr) => new Sprite() { addr = ptr                                                                                                                                                                      };
            public int m_hAttachedToEntity {                     get => *(int*)(addr + Offset.DT_Sprite.m_hAttachedToEntity);                                set => *(int*)(addr + Offset.DT_Sprite.m_hAttachedToEntity) = value;                                }
            public int m_nAttachment {                           get => *(int*)(addr + Offset.DT_Sprite.m_nAttachment);                                      set => *(int*)(addr + Offset.DT_Sprite.m_nAttachment) = value;                                      }
            public int m_flScaleTime {                           get => *(int*)(addr + Offset.DT_Sprite.m_flScaleTime);                                      set => *(int*)(addr + Offset.DT_Sprite.m_flScaleTime) = value;                                      }
            public int m_flSpriteScale {                         get => *(int*)(addr + Offset.DT_Sprite.m_flSpriteScale);                                    set => *(int*)(addr + Offset.DT_Sprite.m_flSpriteScale) = value;                                    }
            public int m_flSpriteFramerate {                     get => *(int*)(addr + Offset.DT_Sprite.m_flSpriteFramerate);                                set => *(int*)(addr + Offset.DT_Sprite.m_flSpriteFramerate) = value;                                }
            public int m_flGlowProxySize {                       get => *(int*)(addr + Offset.DT_Sprite.m_flGlowProxySize);                                  set => *(int*)(addr + Offset.DT_Sprite.m_flGlowProxySize) = value;                                  }
            public int m_flHDRColorScale {                       get => *(int*)(addr + Offset.DT_Sprite.m_flHDRColorScale);                                  set => *(int*)(addr + Offset.DT_Sprite.m_flHDRColorScale) = value;                                  }
            public int m_flFrame {                               get => *(int*)(addr + Offset.DT_Sprite.m_flFrame);                                          set => *(int*)(addr + Offset.DT_Sprite.m_flFrame) = value;                                          }
            public int m_flBrightnessTime {                      get => *(int*)(addr + Offset.DT_Sprite.m_flBrightnessTime);                                 set => *(int*)(addr + Offset.DT_Sprite.m_flBrightnessTime) = value;                                 }
            public int m_nBrightness {                           get => *(int*)(addr + Offset.DT_Sprite.m_nBrightness);                                      set => *(int*)(addr + Offset.DT_Sprite.m_nBrightness) = value;                                      }
            public int m_bWorldSpaceScale {                      get => *(int*)(addr + Offset.DT_Sprite.m_bWorldSpaceScale);                                 set => *(int*)(addr + Offset.DT_Sprite.m_bWorldSpaceScale) = value;                                 }

        }

        public class Ragdoll_Attached : baseStructs
        {
            public static implicit operator Ragdoll_Attached(IntPtr ptr) => new Ragdoll_Attached() { addr = ptr                                                                                                                                                  };
            public int m_boneIndexAttached {                     get => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_boneIndexAttached);                      set => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_boneIndexAttached) = value;                      }
            public int m_ragdollAttachedObjectIndex {            get => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_ragdollAttachedObjectIndex);             set => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_ragdollAttachedObjectIndex) = value;             }
            public int m_attachmentPointBoneSpace {              get => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_attachmentPointBoneSpace);               set => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_attachmentPointBoneSpace) = value;               }
            public int m_attachmentPointRagdollSpace {           get => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_attachmentPointRagdollSpace);            set => *(int*)(addr + Offset.DT_Ragdoll_Attached.m_attachmentPointRagdollSpace) = value;            }

        }

        public class Ragdoll : baseStructs
        {
            public static implicit operator Ragdoll(IntPtr ptr) => new Ragdoll() { addr = ptr                                                                                                                                                                    };
            public int m_ragAngles_0 {                           get => *(int*)(addr + Offset.DT_Ragdoll.m_ragAngles_0);                                     set => *(int*)(addr + Offset.DT_Ragdoll.m_ragAngles_0) = value;                                     }
            public int m_ragAngles {                             get => *(int*)(addr + Offset.DT_Ragdoll.m_ragAngles);                                       set => *(int*)(addr + Offset.DT_Ragdoll.m_ragAngles) = value;                                       }
            public int m_ragPos_0 {                              get => *(int*)(addr + Offset.DT_Ragdoll.m_ragPos_0);                                        set => *(int*)(addr + Offset.DT_Ragdoll.m_ragPos_0) = value;                                        }
            public int m_ragPos {                                get => *(int*)(addr + Offset.DT_Ragdoll.m_ragPos);                                          set => *(int*)(addr + Offset.DT_Ragdoll.m_ragPos) = value;                                          }
            public int m_hUnragdoll {                            get => *(int*)(addr + Offset.DT_Ragdoll.m_hUnragdoll);                                      set => *(int*)(addr + Offset.DT_Ragdoll.m_hUnragdoll) = value;                                      }
            public int m_flBlendWeight {                         get => *(int*)(addr + Offset.DT_Ragdoll.m_flBlendWeight);                                   set => *(int*)(addr + Offset.DT_Ragdoll.m_flBlendWeight) = value;                                   }
            public int m_nOverlaySequence {                      get => *(int*)(addr + Offset.DT_Ragdoll.m_nOverlaySequence);                                set => *(int*)(addr + Offset.DT_Ragdoll.m_nOverlaySequence) = value;                                }

        }

        public class PropCounter : baseStructs
        {
            public static implicit operator PropCounter(IntPtr ptr) => new PropCounter() { addr = ptr                                                                                                                                                            };
            public int m_flDisplayValue {                        get => *(int*)(addr + Offset.DT_PropCounter.m_flDisplayValue);                              set => *(int*)(addr + Offset.DT_PropCounter.m_flDisplayValue) = value;                              }

        }

        public class PoseController : baseStructs
        {
            public static implicit operator PoseController(IntPtr ptr) => new PoseController() { addr = ptr                                                                                                                                                      };
            public int m_bPoseValueParity {                      get => *(int*)(addr + Offset.DT_PoseController.m_bPoseValueParity);                         set => *(int*)(addr + Offset.DT_PoseController.m_bPoseValueParity) = value;                         }
            public int m_fPoseValue {                            get => *(int*)(addr + Offset.DT_PoseController.m_fPoseValue);                               set => *(int*)(addr + Offset.DT_PoseController.m_fPoseValue) = value;                               }
            public int m_fInterpolationTime {                    get => *(int*)(addr + Offset.DT_PoseController.m_fInterpolationTime);                       set => *(int*)(addr + Offset.DT_PoseController.m_fInterpolationTime) = value;                       }
            public int m_bInterpolationWrap {                    get => *(int*)(addr + Offset.DT_PoseController.m_bInterpolationWrap);                       set => *(int*)(addr + Offset.DT_PoseController.m_bInterpolationWrap) = value;                       }
            public int m_fCycleFrequency {                       get => *(int*)(addr + Offset.DT_PoseController.m_fCycleFrequency);                          set => *(int*)(addr + Offset.DT_PoseController.m_fCycleFrequency) = value;                          }
            public int m_nFModType {                             get => *(int*)(addr + Offset.DT_PoseController.m_nFModType);                                set => *(int*)(addr + Offset.DT_PoseController.m_nFModType) = value;                                }
            public int m_fFModTimeOffset {                       get => *(int*)(addr + Offset.DT_PoseController.m_fFModTimeOffset);                          set => *(int*)(addr + Offset.DT_PoseController.m_fFModTimeOffset) = value;                          }
            public int m_fFModRate {                             get => *(int*)(addr + Offset.DT_PoseController.m_fFModRate);                                set => *(int*)(addr + Offset.DT_PoseController.m_fFModRate) = value;                                }
            public int m_fFModAmplitude {                        get => *(int*)(addr + Offset.DT_PoseController.m_fFModAmplitude);                           set => *(int*)(addr + Offset.DT_PoseController.m_fFModAmplitude) = value;                           }
            public int m_hProps {                                get => *(int*)(addr + Offset.DT_PoseController.m_hProps);                                   set => *(int*)(addr + Offset.DT_PoseController.m_hProps) = value;                                   }
            public int m_chPoseIndex {                           get => *(int*)(addr + Offset.DT_PoseController.m_chPoseIndex);                              set => *(int*)(addr + Offset.DT_PoseController.m_chPoseIndex) = value;                              }

        }

        public class GrassBurn : baseStructs
        {
            public static implicit operator GrassBurn(IntPtr ptr) => new GrassBurn() { addr = ptr                                                                                                                                                                };
            public int m_flGrassBurnClearTime {                  get => *(int*)(addr + Offset.DT_GrassBurn.m_flGrassBurnClearTime);                          set => *(int*)(addr + Offset.DT_GrassBurn.m_flGrassBurnClearTime) = value;                          }

        }

        public class FuncLadder : baseStructs
        {
            public static implicit operator FuncLadder(IntPtr ptr) => new FuncLadder() { addr = ptr                                                                                                                                                              };
            public int m_vecPlayerMountPositionTop {             get => *(int*)(addr + Offset.DT_FuncLadder.m_vecPlayerMountPositionTop);                    set => *(int*)(addr + Offset.DT_FuncLadder.m_vecPlayerMountPositionTop) = value;                    }
            public int m_vecPlayerMountPositionBottom {          get => *(int*)(addr + Offset.DT_FuncLadder.m_vecPlayerMountPositionBottom);                 set => *(int*)(addr + Offset.DT_FuncLadder.m_vecPlayerMountPositionBottom) = value;                 }
            public int m_vecLadderDir {                          get => *(int*)(addr + Offset.DT_FuncLadder.m_vecLadderDir);                                 set => *(int*)(addr + Offset.DT_FuncLadder.m_vecLadderDir) = value;                                 }
            public int m_bFakeLadder {                           get => *(int*)(addr + Offset.DT_FuncLadder.m_bFakeLadder);                                  set => *(int*)(addr + Offset.DT_FuncLadder.m_bFakeLadder) = value;                                  }

        }

        public class TEFoundryHelpers : baseStructs
        {
            public static implicit operator TEFoundryHelpers(IntPtr ptr) => new TEFoundryHelpers() { addr = ptr                                                                                                                                                  };
            public int m_iEntity {                               get => *(int*)(addr + Offset.DT_TEFoundryHelpers.m_iEntity);                                set => *(int*)(addr + Offset.DT_TEFoundryHelpers.m_iEntity) = value;                                }

        }

        public class DetailController : baseStructs
        {
            public static implicit operator DetailController(IntPtr ptr) => new DetailController() { addr = ptr                                                                                                                                                  };
            public int m_flFadeStartDist {                       get => *(int*)(addr + Offset.DT_DetailController.m_flFadeStartDist);                        set => *(int*)(addr + Offset.DT_DetailController.m_flFadeStartDist) = value;                        }
            public int m_flFadeEndDist {                         get => *(int*)(addr + Offset.DT_DetailController.m_flFadeEndDist);                          set => *(int*)(addr + Offset.DT_DetailController.m_flFadeEndDist) = value;                          }

        }

        public class DangerZone : baseStructs
        {
            public static implicit operator DangerZone(IntPtr ptr) => new DangerZone() { addr = ptr                                                                                                                                                              };
            public int m_vecDangerZoneOriginStartedAt {          get => *(int*)(addr + Offset.DT_DangerZone.m_vecDangerZoneOriginStartedAt);                 set => *(int*)(addr + Offset.DT_DangerZone.m_vecDangerZoneOriginStartedAt) = value;                 }
            public int m_flBombLaunchTime {                      get => *(int*)(addr + Offset.DT_DangerZone.m_flBombLaunchTime);                             set => *(int*)(addr + Offset.DT_DangerZone.m_flBombLaunchTime) = value;                             }
            public int m_flExtraRadius {                         get => *(int*)(addr + Offset.DT_DangerZone.m_flExtraRadius);                                set => *(int*)(addr + Offset.DT_DangerZone.m_flExtraRadius) = value;                                }
            public int m_flExtraRadiusStartTime {                get => *(int*)(addr + Offset.DT_DangerZone.m_flExtraRadiusStartTime);                       set => *(int*)(addr + Offset.DT_DangerZone.m_flExtraRadiusStartTime) = value;                       }
            public int m_flExtraRadiusTotalLerpTime {            get => *(int*)(addr + Offset.DT_DangerZone.m_flExtraRadiusTotalLerpTime);                   set => *(int*)(addr + Offset.DT_DangerZone.m_flExtraRadiusTotalLerpTime) = value;                   }
            public int m_nDropOrder {                            get => *(int*)(addr + Offset.DT_DangerZone.m_nDropOrder);                                   set => *(int*)(addr + Offset.DT_DangerZone.m_nDropOrder) = value;                                   }
            public int m_iWave {                                 get => *(int*)(addr + Offset.DT_DangerZone.m_iWave);                                        set => *(int*)(addr + Offset.DT_DangerZone.m_iWave) = value;                                        }

        }

        public class DangerZoneController : baseStructs
        {
            public static implicit operator DangerZoneController(IntPtr ptr) => new DangerZoneController() { addr = ptr                                                                                                                                          };
            public int m_bDangerZoneControllerEnabled {          get => *(int*)(addr + Offset.DT_DangerZoneController.m_bDangerZoneControllerEnabled);       set => *(int*)(addr + Offset.DT_DangerZoneController.m_bDangerZoneControllerEnabled) = value;       }
            public int m_bMissionControlledExplosions {          get => *(int*)(addr + Offset.DT_DangerZoneController.m_bMissionControlledExplosions);       set => *(int*)(addr + Offset.DT_DangerZoneController.m_bMissionControlledExplosions) = value;       }
            public int m_flStartTime {                           get => *(int*)(addr + Offset.DT_DangerZoneController.m_flStartTime);                        set => *(int*)(addr + Offset.DT_DangerZoneController.m_flStartTime) = value;                        }
            public int m_flFinalExpansionTime {                  get => *(int*)(addr + Offset.DT_DangerZoneController.m_flFinalExpansionTime);               set => *(int*)(addr + Offset.DT_DangerZoneController.m_flFinalExpansionTime) = value;               }
            public int m_vecEndGameCircleStart {                 get => *(int*)(addr + Offset.DT_DangerZoneController.m_vecEndGameCircleStart);              set => *(int*)(addr + Offset.DT_DangerZoneController.m_vecEndGameCircleStart) = value;              }
            public int m_vecEndGameCircleEnd {                   get => *(int*)(addr + Offset.DT_DangerZoneController.m_vecEndGameCircleEnd);                set => *(int*)(addr + Offset.DT_DangerZoneController.m_vecEndGameCircleEnd) = value;                }
            public int m_hTheFinalZone {                         get => *(int*)(addr + Offset.DT_DangerZoneController.m_hTheFinalZone);                      set => *(int*)(addr + Offset.DT_DangerZoneController.m_hTheFinalZone) = value;                      }
            public int m_DangerZones {                           get => *(int*)(addr + Offset.DT_DangerZoneController.m_DangerZones);                        set => *(int*)(addr + Offset.DT_DangerZoneController.m_DangerZones) = value;                        }
            public int m_flWaveEndTimes {                        get => *(int*)(addr + Offset.DT_DangerZoneController.m_flWaveEndTimes);                     set => *(int*)(addr + Offset.DT_DangerZoneController.m_flWaveEndTimes) = value;                     }

        }

        public class WorldVguiText : baseStructs
        {
            public static implicit operator WorldVguiText(IntPtr ptr) => new WorldVguiText() { addr = ptr                                                                                                                                                        };
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_WorldVguiText.m_bEnabled);                                  set => *(int*)(addr + Offset.DT_WorldVguiText.m_bEnabled) = value;                                  }
            public int m_szDisplayText {                         get => *(int*)(addr + Offset.DT_WorldVguiText.m_szDisplayText);                             set => *(int*)(addr + Offset.DT_WorldVguiText.m_szDisplayText) = value;                             }
            public int m_szDisplayTextOption {                   get => *(int*)(addr + Offset.DT_WorldVguiText.m_szDisplayTextOption);                       set => *(int*)(addr + Offset.DT_WorldVguiText.m_szDisplayTextOption) = value;                       }
            public int m_szFont {                                get => *(int*)(addr + Offset.DT_WorldVguiText.m_szFont);                                    set => *(int*)(addr + Offset.DT_WorldVguiText.m_szFont) = value;                                    }
            public int m_iTextPanelWidth {                       get => *(int*)(addr + Offset.DT_WorldVguiText.m_iTextPanelWidth);                           set => *(int*)(addr + Offset.DT_WorldVguiText.m_iTextPanelWidth) = value;                           }
            public int m_clrText {                               get => *(int*)(addr + Offset.DT_WorldVguiText.m_clrText);                                   set => *(int*)(addr + Offset.DT_WorldVguiText.m_clrText) = value;                                   }

        }

        public class World : baseStructs
        {
            public static implicit operator World(IntPtr ptr) => new World() { addr = ptr                                                                                                                                                                        };
            public int m_flWaveHeight {                          get => *(int*)(addr + Offset.DT_World.m_flWaveHeight);                                      set => *(int*)(addr + Offset.DT_World.m_flWaveHeight) = value;                                      }
            public int m_WorldMins {                             get => *(int*)(addr + Offset.DT_World.m_WorldMins);                                         set => *(int*)(addr + Offset.DT_World.m_WorldMins) = value;                                         }
            public int m_WorldMaxs {                             get => *(int*)(addr + Offset.DT_World.m_WorldMaxs);                                         set => *(int*)(addr + Offset.DT_World.m_WorldMaxs) = value;                                         }
            public int m_bStartDark {                            get => *(int*)(addr + Offset.DT_World.m_bStartDark);                                        set => *(int*)(addr + Offset.DT_World.m_bStartDark) = value;                                        }
            public int m_flMaxOccludeeArea {                     get => *(int*)(addr + Offset.DT_World.m_flMaxOccludeeArea);                                 set => *(int*)(addr + Offset.DT_World.m_flMaxOccludeeArea) = value;                                 }
            public int m_flMinOccluderArea {                     get => *(int*)(addr + Offset.DT_World.m_flMinOccluderArea);                                 set => *(int*)(addr + Offset.DT_World.m_flMinOccluderArea) = value;                                 }
            public int m_flMaxPropScreenSpaceWidth {             get => *(int*)(addr + Offset.DT_World.m_flMaxPropScreenSpaceWidth);                         set => *(int*)(addr + Offset.DT_World.m_flMaxPropScreenSpaceWidth) = value;                         }
            public int m_flMinPropScreenSpaceWidth {             get => *(int*)(addr + Offset.DT_World.m_flMinPropScreenSpaceWidth);                         set => *(int*)(addr + Offset.DT_World.m_flMinPropScreenSpaceWidth) = value;                         }
            public int m_iszDetailSpriteMaterial {               get => *(int*)(addr + Offset.DT_World.m_iszDetailSpriteMaterial);                           set => *(int*)(addr + Offset.DT_World.m_iszDetailSpriteMaterial) = value;                           }
            public int m_bColdWorld {                            get => *(int*)(addr + Offset.DT_World.m_bColdWorld);                                        set => *(int*)(addr + Offset.DT_World.m_bColdWorld) = value;                                        }
            public int m_iTimeOfDay {                            get => *(int*)(addr + Offset.DT_World.m_iTimeOfDay);                                        set => *(int*)(addr + Offset.DT_World.m_iTimeOfDay) = value;                                        }

        }

        public class WaterLODControl : baseStructs
        {
            public static implicit operator WaterLODControl(IntPtr ptr) => new WaterLODControl() { addr = ptr                                                                                                                                                    };
            public int m_flCheapWaterStartDistance {             get => *(int*)(addr + Offset.DT_WaterLODControl.m_flCheapWaterStartDistance);               set => *(int*)(addr + Offset.DT_WaterLODControl.m_flCheapWaterStartDistance) = value;               }
            public int m_flCheapWaterEndDistance {               get => *(int*)(addr + Offset.DT_WaterLODControl.m_flCheapWaterEndDistance);                 set => *(int*)(addr + Offset.DT_WaterLODControl.m_flCheapWaterEndDistance) = value;                 }

        }

        public class VoteController : baseStructs
        {
            public static implicit operator VoteController(IntPtr ptr) => new VoteController() { addr = ptr                                                                                                                                                      };
            public int m_iActiveIssueIndex {                     get => *(int*)(addr + Offset.DT_VoteController.m_iActiveIssueIndex);                        set => *(int*)(addr + Offset.DT_VoteController.m_iActiveIssueIndex) = value;                        }
            public int m_iOnlyTeamToVote {                       get => *(int*)(addr + Offset.DT_VoteController.m_iOnlyTeamToVote);                          set => *(int*)(addr + Offset.DT_VoteController.m_iOnlyTeamToVote) = value;                          }
            public int m_nPotentialVotes {                       get => *(int*)(addr + Offset.DT_VoteController.m_nPotentialVotes);                          set => *(int*)(addr + Offset.DT_VoteController.m_nPotentialVotes) = value;                          }
            public int m_bIsYesNoVote {                          get => *(int*)(addr + Offset.DT_VoteController.m_bIsYesNoVote);                             set => *(int*)(addr + Offset.DT_VoteController.m_bIsYesNoVote) = value;                             }
            public int m_nVoteOptionCount {                      get => *(int*)(addr + Offset.DT_VoteController.m_nVoteOptionCount);                         set => *(int*)(addr + Offset.DT_VoteController.m_nVoteOptionCount) = value;                         }

        }

        public class VGuiScreen : baseStructs
        {
            public static implicit operator VGuiScreen(IntPtr ptr) => new VGuiScreen() { addr = ptr                                                                                                                                                              };
            public int m_flWidth {                               get => *(int*)(addr + Offset.DT_VGuiScreen.m_flWidth);                                      set => *(int*)(addr + Offset.DT_VGuiScreen.m_flWidth) = value;                                      }
            public int m_flHeight {                              get => *(int*)(addr + Offset.DT_VGuiScreen.m_flHeight);                                     set => *(int*)(addr + Offset.DT_VGuiScreen.m_flHeight) = value;                                     }
            public int m_fScreenFlags {                          get => *(int*)(addr + Offset.DT_VGuiScreen.m_fScreenFlags);                                 set => *(int*)(addr + Offset.DT_VGuiScreen.m_fScreenFlags) = value;                                 }
            public int m_nPanelName {                            get => *(int*)(addr + Offset.DT_VGuiScreen.m_nPanelName);                                   set => *(int*)(addr + Offset.DT_VGuiScreen.m_nPanelName) = value;                                   }
            public int m_nAttachmentIndex {                      get => *(int*)(addr + Offset.DT_VGuiScreen.m_nAttachmentIndex);                             set => *(int*)(addr + Offset.DT_VGuiScreen.m_nAttachmentIndex) = value;                             }
            public int m_nOverlayMaterial {                      get => *(int*)(addr + Offset.DT_VGuiScreen.m_nOverlayMaterial);                             set => *(int*)(addr + Offset.DT_VGuiScreen.m_nOverlayMaterial) = value;                             }
            public int m_hPlayerOwner {                          get => *(int*)(addr + Offset.DT_VGuiScreen.m_hPlayerOwner);                                 set => *(int*)(addr + Offset.DT_VGuiScreen.m_hPlayerOwner) = value;                                 }

        }

        public class PropJeep : baseStructs
        {
            public static implicit operator PropJeep(IntPtr ptr) => new PropJeep() { addr = ptr                                                                                                                                                                  };
            public int m_bHeadlightIsOn {                        get => *(int*)(addr + Offset.DT_PropJeep.m_bHeadlightIsOn);                                 set => *(int*)(addr + Offset.DT_PropJeep.m_bHeadlightIsOn) = value;                                 }

        }

        public class PropVehicleChoreoGeneric : baseStructs
        {
            public static implicit operator PropVehicleChoreoGeneric(IntPtr ptr) => new PropVehicleChoreoGeneric() { addr = ptr                                                                                                                                  };
            public int m_hPlayer {                               get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_hPlayer);                        set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_hPlayer) = value;                        }
            public int m_bEnterAnimOn {                          get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_bEnterAnimOn);                   set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_bEnterAnimOn) = value;                   }
            public int m_bExitAnimOn {                           get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_bExitAnimOn);                    set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_bExitAnimOn) = value;                    }
            public int m_bForceEyesToAttachment {                get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_bForceEyesToAttachment);         set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_bForceEyesToAttachment) = value;         }
            public int m_vecEyeExitEndpoint {                    get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vecEyeExitEndpoint);             set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vecEyeExitEndpoint) = value;             }
            public int m_vehicleView_bClampEyeAngles {           get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_bClampEyeAngles);    set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_bClampEyeAngles) = value;    }
            public int m_vehicleView_flPitchCurveZero {          get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchCurveZero);   set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchCurveZero) = value;   }
            public int m_vehicleView_flPitchCurveLinear {        get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchCurveLinear); set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchCurveLinear) = value; }
            public int m_vehicleView_flRollCurveZero {           get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flRollCurveZero);    set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flRollCurveZero) = value;    }
            public int m_vehicleView_flRollCurveLinear {         get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flRollCurveLinear);  set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flRollCurveLinear) = value;  }
            public int m_vehicleView_flFOV {                     get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flFOV);              set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flFOV) = value;              }
            public int m_vehicleView_flYawMin {                  get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flYawMin);           set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flYawMin) = value;           }
            public int m_vehicleView_flYawMax {                  get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flYawMax);           set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flYawMax) = value;           }
            public int m_vehicleView_flPitchMin {                get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchMin);         set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchMin) = value;         }
            public int m_vehicleView_flPitchMax {                get => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchMax);         set => *(int*)(addr + Offset.DT_PropVehicleChoreoGeneric.m_vehicleView_flPitchMax) = value;         }

        }

        public class TriggerSoundOperator : baseStructs
        {
            public static implicit operator TriggerSoundOperator(IntPtr ptr) => new TriggerSoundOperator() { addr = ptr                                                                                                                                          };
            public int m_nSoundOperator {                        get => *(int*)(addr + Offset.DT_TriggerSoundOperator.m_nSoundOperator);                     set => *(int*)(addr + Offset.DT_TriggerSoundOperator.m_nSoundOperator) = value;                     }

        }

        public class BaseTrigger : baseStructs
        {
            public static implicit operator BaseTrigger(IntPtr ptr) => new BaseTrigger() { addr = ptr                                                                                                                                                            };
            public int m_bClientSidePredicted {                  get => *(int*)(addr + Offset.DT_BaseTrigger.m_bClientSidePredicted);                        set => *(int*)(addr + Offset.DT_BaseTrigger.m_bClientSidePredicted) = value;                        }
            public int m_spawnflags {                            get => *(int*)(addr + Offset.DT_BaseTrigger.m_spawnflags);                                  set => *(int*)(addr + Offset.DT_BaseTrigger.m_spawnflags) = value;                                  }

        }

        public class Tesla : baseStructs
        {
            public static implicit operator Tesla(IntPtr ptr) => new Tesla() { addr = ptr                                                                                                                                                                        };
            public int m_SoundName {                             get => *(int*)(addr + Offset.DT_Tesla.m_SoundName);                                         set => *(int*)(addr + Offset.DT_Tesla.m_SoundName) = value;                                         }
            public int m_iszSpriteName {                         get => *(int*)(addr + Offset.DT_Tesla.m_iszSpriteName);                                     set => *(int*)(addr + Offset.DT_Tesla.m_iszSpriteName) = value;                                     }

        }

        public class BaseTeamObjectiveResource : baseStructs
        {
            public static implicit operator BaseTeamObjectiveResource(IntPtr ptr) => new BaseTeamObjectiveResource() { addr = ptr                                                                                                                                };
            public int m_iTimerToShowInHUD {                     get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTimerToShowInHUD);             set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTimerToShowInHUD) = value;             }
            public int m_iStopWatchTimer {                       get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iStopWatchTimer);               set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iStopWatchTimer) = value;               }
            public int m_iNumControlPoints {                     get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iNumControlPoints);             set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iNumControlPoints) = value;             }
            public int m_bPlayingMiniRounds {                    get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bPlayingMiniRounds);            set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bPlayingMiniRounds) = value;            }
            public int m_bControlPointsReset {                   get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bControlPointsReset);           set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bControlPointsReset) = value;           }
            public int m_iUpdateCapHudParity {                   get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iUpdateCapHudParity);           set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iUpdateCapHudParity) = value;           }
            public int m_vCPPositions_0 {                        get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_vCPPositions_0);                set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_vCPPositions_0) = value;                }
            public int m_vCPPositions {                          get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_vCPPositions);                  set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_vCPPositions) = value;                  }
            public int m_iszWarnSound_0 {                        get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iszWarnSound_0);                set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iszWarnSound_0) = value;                }
            public int m_iszWarnSound {                          get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iszWarnSound);                  set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iszWarnSound) = value;                  }
            public int m_pszCapLayoutInHUD {                     get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_pszCapLayoutInHUD);             set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_pszCapLayoutInHUD) = value;             }
            public int m_bCPIsVisible {                          get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bCPIsVisible);                  set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bCPIsVisible) = value;                  }
            public int m_flLazyCapPerc {                         get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_flLazyCapPerc);                 set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_flLazyCapPerc) = value;                 }
            public int m_iTeamIcons {                            get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamIcons);                    set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamIcons) = value;                    }
            public int m_iTeamOverlays {                         get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamOverlays);                 set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamOverlays) = value;                 }
            public int m_iTeamReqCappers {                       get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamReqCappers);               set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamReqCappers) = value;               }
            public int m_flTeamCapTime {                         get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_flTeamCapTime);                 set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_flTeamCapTime) = value;                 }
            public int m_iPreviousPoints {                       get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iPreviousPoints);               set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iPreviousPoints) = value;               }
            public int m_bTeamCanCap {                           get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bTeamCanCap);                   set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bTeamCanCap) = value;                   }
            public int m_iTeamBaseIcons {                        get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamBaseIcons);                set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamBaseIcons) = value;                }
            public int m_iBaseControlPoints {                    get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iBaseControlPoints);            set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iBaseControlPoints) = value;            }
            public int m_bInMiniRound {                          get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bInMiniRound);                  set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bInMiniRound) = value;                  }
            public int m_iWarnOnCap {                            get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iWarnOnCap);                    set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iWarnOnCap) = value;                    }
            public int m_flPathDistance {                        get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_flPathDistance);                set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_flPathDistance) = value;                }
            public int m_iNumTeamMembers {                       get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iNumTeamMembers);               set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iNumTeamMembers) = value;               }
            public int m_iCappingTeam {                          get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iCappingTeam);                  set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iCappingTeam) = value;                  }
            public int m_iTeamInZone {                           get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamInZone);                   set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iTeamInZone) = value;                   }
            public int m_bBlocked {                              get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bBlocked);                      set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_bBlocked) = value;                      }
            public int m_iOwner {                                get => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iOwner);                        set => *(int*)(addr + Offset.DT_BaseTeamObjectiveResource.m_iOwner) = value;                        }

        }

        public class Team : baseStructs
        {
            public static implicit operator Team(IntPtr ptr) => new Team() { addr = ptr                                                                                                                                                                          };
            public int m_iTeamNum {                              get => *(int*)(addr + Offset.DT_Team.m_iTeamNum);                                           set => *(int*)(addr + Offset.DT_Team.m_iTeamNum) = value;                                           }
            public int m_bSurrendered {                          get => *(int*)(addr + Offset.DT_Team.m_bSurrendered);                                       set => *(int*)(addr + Offset.DT_Team.m_bSurrendered) = value;                                       }
            public int m_scoreTotal {                            get => *(int*)(addr + Offset.DT_Team.m_scoreTotal);                                         set => *(int*)(addr + Offset.DT_Team.m_scoreTotal) = value;                                         }
            public int m_scoreFirstHalf {                        get => *(int*)(addr + Offset.DT_Team.m_scoreFirstHalf);                                     set => *(int*)(addr + Offset.DT_Team.m_scoreFirstHalf) = value;                                     }
            public int m_scoreSecondHalf {                       get => *(int*)(addr + Offset.DT_Team.m_scoreSecondHalf);                                    set => *(int*)(addr + Offset.DT_Team.m_scoreSecondHalf) = value;                                    }
            public int m_scoreOvertime {                         get => *(int*)(addr + Offset.DT_Team.m_scoreOvertime);                                      set => *(int*)(addr + Offset.DT_Team.m_scoreOvertime) = value;                                      }
            public int m_iClanID {                               get => *(int*)(addr + Offset.DT_Team.m_iClanID);                                            set => *(int*)(addr + Offset.DT_Team.m_iClanID) = value;                                            }
            public int m_szTeamname {                            get => *(int*)(addr + Offset.DT_Team.m_szTeamname);                                         set => *(int*)(addr + Offset.DT_Team.m_szTeamname) = value;                                         }
            public int m_szClanTeamname {                        get => *(int*)(addr + Offset.DT_Team.m_szClanTeamname);                                     set => *(int*)(addr + Offset.DT_Team.m_szClanTeamname) = value;                                     }
            public int m_szTeamFlagImage {                       get => *(int*)(addr + Offset.DT_Team.m_szTeamFlagImage);                                    set => *(int*)(addr + Offset.DT_Team.m_szTeamFlagImage) = value;                                    }
            public int m_szTeamLogoImage {                       get => *(int*)(addr + Offset.DT_Team.m_szTeamLogoImage);                                    set => *(int*)(addr + Offset.DT_Team.m_szTeamLogoImage) = value;                                    }
            public int m_szTeamMatchStat {                       get => *(int*)(addr + Offset.DT_Team.m_szTeamMatchStat);                                    set => *(int*)(addr + Offset.DT_Team.m_szTeamMatchStat) = value;                                    }
            public int m_nGGLeaderEntIndex_CT {                  get => *(int*)(addr + Offset.DT_Team.m_nGGLeaderEntIndex_CT);                               set => *(int*)(addr + Offset.DT_Team.m_nGGLeaderEntIndex_CT) = value;                               }
            public int m_nGGLeaderEntIndex_T {                   get => *(int*)(addr + Offset.DT_Team.m_nGGLeaderEntIndex_T);                                set => *(int*)(addr + Offset.DT_Team.m_nGGLeaderEntIndex_T) = value;                                }
            public int m_numMapVictories {                       get => *(int*)(addr + Offset.DT_Team.m_numMapVictories);                                    set => *(int*)(addr + Offset.DT_Team.m_numMapVictories) = value;                                    }
            public int player_array_element {                    get => *(int*)(addr + Offset.DT_Team.player_array_element);                                 set => *(int*)(addr + Offset.DT_Team.player_array_element) = value;                                 }
            public int player_array {                            get => *(int*)(addr + Offset.DT_Team.player_array);                                         set => *(int*)(addr + Offset.DT_Team.player_array) = value;                                         }

        }

        public class SunlightShadowControl : baseStructs
        {
            public static implicit operator SunlightShadowControl(IntPtr ptr) => new SunlightShadowControl() { addr = ptr                                                                                                                                        };
            public int m_shadowDirection {                       get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_shadowDirection);                   set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_shadowDirection) = value;                   }
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_bEnabled);                          set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_bEnabled) = value;                          }
            public int m_TextureName {                           get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_TextureName);                       set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_TextureName) = value;                       }
            public int m_LightColor {                            get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_LightColor);                        set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_LightColor) = value;                        }
            public int m_flColorTransitionTime {                 get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flColorTransitionTime);             set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flColorTransitionTime) = value;             }
            public int m_flSunDistance {                         get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flSunDistance);                     set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flSunDistance) = value;                     }
            public int m_flFOV {                                 get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flFOV);                             set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flFOV) = value;                             }
            public int m_flNearZ {                               get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flNearZ);                           set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flNearZ) = value;                           }
            public int m_flNorthOffset {                         get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flNorthOffset);                     set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_flNorthOffset) = value;                     }
            public int m_bEnableShadows {                        get => *(int*)(addr + Offset.DT_SunlightShadowControl.m_bEnableShadows);                    set => *(int*)(addr + Offset.DT_SunlightShadowControl.m_bEnableShadows) = value;                    }

        }

        public class Sun : baseStructs
        {
            public static implicit operator Sun(IntPtr ptr) => new Sun() { addr = ptr                                                                                                                                                                            };
            public int m_clrRender {                             get => *(int*)(addr + Offset.DT_Sun.m_clrRender);                                           set => *(int*)(addr + Offset.DT_Sun.m_clrRender) = value;                                           }
            public int m_clrOverlay {                            get => *(int*)(addr + Offset.DT_Sun.m_clrOverlay);                                          set => *(int*)(addr + Offset.DT_Sun.m_clrOverlay) = value;                                          }
            public int m_vDirection {                            get => *(int*)(addr + Offset.DT_Sun.m_vDirection);                                          set => *(int*)(addr + Offset.DT_Sun.m_vDirection) = value;                                          }
            public int m_bOn {                                   get => *(int*)(addr + Offset.DT_Sun.m_bOn);                                                 set => *(int*)(addr + Offset.DT_Sun.m_bOn) = value;                                                 }
            public int m_nSize {                                 get => *(int*)(addr + Offset.DT_Sun.m_nSize);                                               set => *(int*)(addr + Offset.DT_Sun.m_nSize) = value;                                               }
            public int m_nOverlaySize {                          get => *(int*)(addr + Offset.DT_Sun.m_nOverlaySize);                                        set => *(int*)(addr + Offset.DT_Sun.m_nOverlaySize) = value;                                        }
            public int m_nMaterial {                             get => *(int*)(addr + Offset.DT_Sun.m_nMaterial);                                           set => *(int*)(addr + Offset.DT_Sun.m_nMaterial) = value;                                           }
            public int m_nOverlayMaterial {                      get => *(int*)(addr + Offset.DT_Sun.m_nOverlayMaterial);                                    set => *(int*)(addr + Offset.DT_Sun.m_nOverlayMaterial) = value;                                    }
            public int HDRColorScale {                           get => *(int*)(addr + Offset.DT_Sun.HDRColorScale);                                         set => *(int*)(addr + Offset.DT_Sun.HDRColorScale) = value;                                         }
            public int glowDistanceScale {                       get => *(int*)(addr + Offset.DT_Sun.glowDistanceScale);                                     set => *(int*)(addr + Offset.DT_Sun.glowDistanceScale) = value;                                     }

        }

        public class ParticlePerformanceMonitor : baseStructs
        {
            public static implicit operator ParticlePerformanceMonitor(IntPtr ptr) => new ParticlePerformanceMonitor() { addr = ptr                                                                                                                              };
            public int m_bMeasurePerf {                          get => *(int*)(addr + Offset.DT_ParticlePerformanceMonitor.m_bMeasurePerf);                 set => *(int*)(addr + Offset.DT_ParticlePerformanceMonitor.m_bMeasurePerf) = value;                 }
            public int m_bDisplayPerf {                          get => *(int*)(addr + Offset.DT_ParticlePerformanceMonitor.m_bDisplayPerf);                 set => *(int*)(addr + Offset.DT_ParticlePerformanceMonitor.m_bDisplayPerf) = value;                 }

        }

        public class SpotlightEnd : baseStructs
        {
            public static implicit operator SpotlightEnd(IntPtr ptr) => new SpotlightEnd() { addr = ptr                                                                                                                                                          };
            public int m_flLightScale {                          get => *(int*)(addr + Offset.DT_SpotlightEnd.m_flLightScale);                               set => *(int*)(addr + Offset.DT_SpotlightEnd.m_flLightScale) = value;                               }
            public int m_Radius {                                get => *(int*)(addr + Offset.DT_SpotlightEnd.m_Radius);                                     set => *(int*)(addr + Offset.DT_SpotlightEnd.m_Radius) = value;                                     }

        }

        public class SpatialEntity : baseStructs
        {
            public static implicit operator SpatialEntity(IntPtr ptr) => new SpatialEntity() { addr = ptr                                                                                                                                                        };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_SpatialEntity.m_vecOrigin);                                 set => *(int*)(addr + Offset.DT_SpatialEntity.m_vecOrigin) = value;                                 }
            public int m_minFalloff {                            get => *(int*)(addr + Offset.DT_SpatialEntity.m_minFalloff);                                set => *(int*)(addr + Offset.DT_SpatialEntity.m_minFalloff) = value;                                }
            public int m_maxFalloff {                            get => *(int*)(addr + Offset.DT_SpatialEntity.m_maxFalloff);                                set => *(int*)(addr + Offset.DT_SpatialEntity.m_maxFalloff) = value;                                }
            public int m_flCurWeight {                           get => *(int*)(addr + Offset.DT_SpatialEntity.m_flCurWeight);                               set => *(int*)(addr + Offset.DT_SpatialEntity.m_flCurWeight) = value;                               }
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_SpatialEntity.m_bEnabled);                                  set => *(int*)(addr + Offset.DT_SpatialEntity.m_bEnabled) = value;                                  }

        }

        public class SlideshowDisplay : baseStructs
        {
            public static implicit operator SlideshowDisplay(IntPtr ptr) => new SlideshowDisplay() { addr = ptr                                                                                                                                                  };
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_bEnabled);                               set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_bEnabled) = value;                               }
            public int m_szDisplayText {                         get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_szDisplayText);                          set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_szDisplayText) = value;                          }
            public int m_szSlideshowDirectory {                  get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_szSlideshowDirectory);                   set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_szSlideshowDirectory) = value;                   }
            public int m_fMinSlideTime {                         get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_fMinSlideTime);                          set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_fMinSlideTime) = value;                          }
            public int m_fMaxSlideTime {                         get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_fMaxSlideTime);                          set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_fMaxSlideTime) = value;                          }
            public int m_iCycleType {                            get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_iCycleType);                             set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_iCycleType) = value;                             }
            public int m_bNoListRepeats {                        get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_bNoListRepeats);                         set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_bNoListRepeats) = value;                         }
            public int m_chCurrentSlideLists {                   get => *(int*)(addr + Offset.DT_SlideshowDisplay.m_chCurrentSlideLists);                    set => *(int*)(addr + Offset.DT_SlideshowDisplay.m_chCurrentSlideLists) = value;                    }

        }

        public class ShadowControl : baseStructs
        {
            public static implicit operator ShadowControl(IntPtr ptr) => new ShadowControl() { addr = ptr                                                                                                                                                        };
            public int m_shadowDirection {                       get => *(int*)(addr + Offset.DT_ShadowControl.m_shadowDirection);                           set => *(int*)(addr + Offset.DT_ShadowControl.m_shadowDirection) = value;                           }
            public int m_shadowColor {                           get => *(int*)(addr + Offset.DT_ShadowControl.m_shadowColor);                               set => *(int*)(addr + Offset.DT_ShadowControl.m_shadowColor) = value;                               }
            public int m_flShadowMaxDist {                       get => *(int*)(addr + Offset.DT_ShadowControl.m_flShadowMaxDist);                           set => *(int*)(addr + Offset.DT_ShadowControl.m_flShadowMaxDist) = value;                           }
            public int m_bDisableShadows {                       get => *(int*)(addr + Offset.DT_ShadowControl.m_bDisableShadows);                           set => *(int*)(addr + Offset.DT_ShadowControl.m_bDisableShadows) = value;                           }
            public int m_bEnableLocalLightShadows {              get => *(int*)(addr + Offset.DT_ShadowControl.m_bEnableLocalLightShadows);                  set => *(int*)(addr + Offset.DT_ShadowControl.m_bEnableLocalLightShadows) = value;                  }

        }

        public class SceneEntity : baseStructs
        {
            public static implicit operator SceneEntity(IntPtr ptr) => new SceneEntity() { addr = ptr                                                                                                                                                            };
            public int m_nSceneStringIndex {                     get => *(int*)(addr + Offset.DT_SceneEntity.m_nSceneStringIndex);                           set => *(int*)(addr + Offset.DT_SceneEntity.m_nSceneStringIndex) = value;                           }
            public int m_bIsPlayingBack {                        get => *(int*)(addr + Offset.DT_SceneEntity.m_bIsPlayingBack);                              set => *(int*)(addr + Offset.DT_SceneEntity.m_bIsPlayingBack) = value;                              }
            public int m_bPaused {                               get => *(int*)(addr + Offset.DT_SceneEntity.m_bPaused);                                     set => *(int*)(addr + Offset.DT_SceneEntity.m_bPaused) = value;                                     }
            public int m_bMultiplayer {                          get => *(int*)(addr + Offset.DT_SceneEntity.m_bMultiplayer);                                set => *(int*)(addr + Offset.DT_SceneEntity.m_bMultiplayer) = value;                                }
            public int m_flForceClientTime {                     get => *(int*)(addr + Offset.DT_SceneEntity.m_flForceClientTime);                           set => *(int*)(addr + Offset.DT_SceneEntity.m_flForceClientTime) = value;                           }
            public int m_hActorList {                            get => *(int*)(addr + Offset.DT_SceneEntity.m_hActorList);                                  set => *(int*)(addr + Offset.DT_SceneEntity.m_hActorList) = value;                                  }

        }

        public class RopeKeyframe : baseStructs
        {
            public static implicit operator RopeKeyframe(IntPtr ptr) => new RopeKeyframe() { addr = ptr                                                                                                                                                          };
            public int m_nChangeCount {                          get => *(int*)(addr + Offset.DT_RopeKeyframe.m_nChangeCount);                               set => *(int*)(addr + Offset.DT_RopeKeyframe.m_nChangeCount) = value;                               }
            public int m_iRopeMaterialModelIndex {               get => *(int*)(addr + Offset.DT_RopeKeyframe.m_iRopeMaterialModelIndex);                    set => *(int*)(addr + Offset.DT_RopeKeyframe.m_iRopeMaterialModelIndex) = value;                    }
            public int m_hStartPoint {                           get => *(int*)(addr + Offset.DT_RopeKeyframe.m_hStartPoint);                                set => *(int*)(addr + Offset.DT_RopeKeyframe.m_hStartPoint) = value;                                }
            public int m_hEndPoint {                             get => *(int*)(addr + Offset.DT_RopeKeyframe.m_hEndPoint);                                  set => *(int*)(addr + Offset.DT_RopeKeyframe.m_hEndPoint) = value;                                  }
            public int m_iStartAttachment {                      get => *(int*)(addr + Offset.DT_RopeKeyframe.m_iStartAttachment);                           set => *(int*)(addr + Offset.DT_RopeKeyframe.m_iStartAttachment) = value;                           }
            public int m_iEndAttachment {                        get => *(int*)(addr + Offset.DT_RopeKeyframe.m_iEndAttachment);                             set => *(int*)(addr + Offset.DT_RopeKeyframe.m_iEndAttachment) = value;                             }
            public int m_fLockedPoints {                         get => *(int*)(addr + Offset.DT_RopeKeyframe.m_fLockedPoints);                              set => *(int*)(addr + Offset.DT_RopeKeyframe.m_fLockedPoints) = value;                              }
            public int m_Slack {                                 get => *(int*)(addr + Offset.DT_RopeKeyframe.m_Slack);                                      set => *(int*)(addr + Offset.DT_RopeKeyframe.m_Slack) = value;                                      }
            public int m_RopeLength {                            get => *(int*)(addr + Offset.DT_RopeKeyframe.m_RopeLength);                                 set => *(int*)(addr + Offset.DT_RopeKeyframe.m_RopeLength) = value;                                 }
            public int m_RopeFlags {                             get => *(int*)(addr + Offset.DT_RopeKeyframe.m_RopeFlags);                                  set => *(int*)(addr + Offset.DT_RopeKeyframe.m_RopeFlags) = value;                                  }
            public int m_TextureScale {                          get => *(int*)(addr + Offset.DT_RopeKeyframe.m_TextureScale);                               set => *(int*)(addr + Offset.DT_RopeKeyframe.m_TextureScale) = value;                               }
            public int m_nSegments {                             get => *(int*)(addr + Offset.DT_RopeKeyframe.m_nSegments);                                  set => *(int*)(addr + Offset.DT_RopeKeyframe.m_nSegments) = value;                                  }
            public int m_bConstrainBetweenEndpoints {            get => *(int*)(addr + Offset.DT_RopeKeyframe.m_bConstrainBetweenEndpoints);                 set => *(int*)(addr + Offset.DT_RopeKeyframe.m_bConstrainBetweenEndpoints) = value;                 }
            public int m_Subdiv {                                get => *(int*)(addr + Offset.DT_RopeKeyframe.m_Subdiv);                                     set => *(int*)(addr + Offset.DT_RopeKeyframe.m_Subdiv) = value;                                     }
            public int m_Width {                                 get => *(int*)(addr + Offset.DT_RopeKeyframe.m_Width);                                      set => *(int*)(addr + Offset.DT_RopeKeyframe.m_Width) = value;                                      }
            public int m_flScrollSpeed {                         get => *(int*)(addr + Offset.DT_RopeKeyframe.m_flScrollSpeed);                              set => *(int*)(addr + Offset.DT_RopeKeyframe.m_flScrollSpeed) = value;                              }
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_RopeKeyframe.m_vecOrigin);                                  set => *(int*)(addr + Offset.DT_RopeKeyframe.m_vecOrigin) = value;                                  }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_RopeKeyframe.moveparent);                                   set => *(int*)(addr + Offset.DT_RopeKeyframe.moveparent) = value;                                   }
            public int m_iParentAttachment {                     get => *(int*)(addr + Offset.DT_RopeKeyframe.m_iParentAttachment);                          set => *(int*)(addr + Offset.DT_RopeKeyframe.m_iParentAttachment) = value;                          }
            public int m_iDefaultRopeMaterialModelIndex {        get => *(int*)(addr + Offset.DT_RopeKeyframe.m_iDefaultRopeMaterialModelIndex);             set => *(int*)(addr + Offset.DT_RopeKeyframe.m_iDefaultRopeMaterialModelIndex) = value;             }
            public int m_nMinCPULevel {                          get => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMinCPULevel);                               set => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMinCPULevel) = value;                               }
            public int m_nMaxCPULevel {                          get => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMaxCPULevel);                               set => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMaxCPULevel) = value;                               }
            public int m_nMinGPULevel {                          get => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMinGPULevel);                               set => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMinGPULevel) = value;                               }
            public int m_nMaxGPULevel {                          get => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMaxGPULevel);                               set => *(int*)(addr + Offset.DT_RopeKeyframe.m_nMaxGPULevel) = value;                               }

        }

        public class RagdollManager : baseStructs
        {
            public static implicit operator RagdollManager(IntPtr ptr) => new RagdollManager() { addr = ptr                                                                                                                                                      };
            public int m_iCurrentMaxRagdollCount {               get => *(int*)(addr + Offset.DT_RagdollManager.m_iCurrentMaxRagdollCount);                  set => *(int*)(addr + Offset.DT_RagdollManager.m_iCurrentMaxRagdollCount) = value;                  }

        }

        public class PhysicsPropMultiplayer : baseStructs
        {
            public static implicit operator PhysicsPropMultiplayer(IntPtr ptr) => new PhysicsPropMultiplayer() { addr = ptr                                                                                                                                      };
            public int m_iPhysicsMode {                          get => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_iPhysicsMode);                     set => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_iPhysicsMode) = value;                     }
            public int m_fMass {                                 get => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_fMass);                            set => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_fMass) = value;                            }
            public int m_collisionMins {                         get => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_collisionMins);                    set => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_collisionMins) = value;                    }
            public int m_collisionMaxs {                         get => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_collisionMaxs);                    set => *(int*)(addr + Offset.DT_PhysicsPropMultiplayer.m_collisionMaxs) = value;                    }

        }

        public class PhysBoxMultiplayer : baseStructs
        {
            public static implicit operator PhysBoxMultiplayer(IntPtr ptr) => new PhysBoxMultiplayer() { addr = ptr                                                                                                                                              };
            public int m_iPhysicsMode {                          get => *(int*)(addr + Offset.DT_PhysBoxMultiplayer.m_iPhysicsMode);                         set => *(int*)(addr + Offset.DT_PhysBoxMultiplayer.m_iPhysicsMode) = value;                         }
            public int m_fMass {                                 get => *(int*)(addr + Offset.DT_PhysBoxMultiplayer.m_fMass);                                set => *(int*)(addr + Offset.DT_PhysBoxMultiplayer.m_fMass) = value;                                }

        }

        public class DynamicProp : baseStructs
        {
            public static implicit operator DynamicProp(IntPtr ptr) => new DynamicProp() { addr = ptr                                                                                                                                                            };
            public int m_bUseHitboxesForRenderBox {              get => *(int*)(addr + Offset.DT_DynamicProp.m_bUseHitboxesForRenderBox);                    set => *(int*)(addr + Offset.DT_DynamicProp.m_bUseHitboxesForRenderBox) = value;                    }
            public int m_flGlowMaxDist {                         get => *(int*)(addr + Offset.DT_DynamicProp.m_flGlowMaxDist);                               set => *(int*)(addr + Offset.DT_DynamicProp.m_flGlowMaxDist) = value;                               }
            public int m_bShouldGlow {                           get => *(int*)(addr + Offset.DT_DynamicProp.m_bShouldGlow);                                 set => *(int*)(addr + Offset.DT_DynamicProp.m_bShouldGlow) = value;                                 }
            public int m_clrGlow {                               get => *(int*)(addr + Offset.DT_DynamicProp.m_clrGlow);                                     set => *(int*)(addr + Offset.DT_DynamicProp.m_clrGlow) = value;                                     }
            public int m_nGlowStyle {                            get => *(int*)(addr + Offset.DT_DynamicProp.m_nGlowStyle);                                  set => *(int*)(addr + Offset.DT_DynamicProp.m_nGlowStyle) = value;                                  }

        }

        public class Prop_Hallucination : baseStructs
        {
            public static implicit operator Prop_Hallucination(IntPtr ptr) => new Prop_Hallucination() { addr = ptr                                                                                                                                              };
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_Prop_Hallucination.m_bEnabled);                             set => *(int*)(addr + Offset.DT_Prop_Hallucination.m_bEnabled) = value;                             }
            public int m_fVisibleTime {                          get => *(int*)(addr + Offset.DT_Prop_Hallucination.m_fVisibleTime);                         set => *(int*)(addr + Offset.DT_Prop_Hallucination.m_fVisibleTime) = value;                         }
            public int m_fRechargeTime {                         get => *(int*)(addr + Offset.DT_Prop_Hallucination.m_fRechargeTime);                        set => *(int*)(addr + Offset.DT_Prop_Hallucination.m_fRechargeTime) = value;                        }

        }

        public class PostProcessController : baseStructs
        {
            public static implicit operator PostProcessController(IntPtr ptr) => new PostProcessController() { addr = ptr                                                                                                                                        };
            public int m_bMaster {                               get => *(int*)(addr + Offset.DT_PostProcessController.m_bMaster);                           set => *(int*)(addr + Offset.DT_PostProcessController.m_bMaster) = value;                           }
            public int m_flPostProcessParameters {               get => *(int*)(addr + Offset.DT_PostProcessController.m_flPostProcessParameters);           set => *(int*)(addr + Offset.DT_PostProcessController.m_flPostProcessParameters) = value;           }

        }

        public class PointWorldText : baseStructs
        {
            public static implicit operator PointWorldText(IntPtr ptr) => new PointWorldText() { addr = ptr                                                                                                                                                      };
            public int m_szText {                                get => *(int*)(addr + Offset.DT_PointWorldText.m_szText);                                   set => *(int*)(addr + Offset.DT_PointWorldText.m_szText) = value;                                   }
            public int m_flTextSize {                            get => *(int*)(addr + Offset.DT_PointWorldText.m_flTextSize);                               set => *(int*)(addr + Offset.DT_PointWorldText.m_flTextSize) = value;                               }
            public int m_textColor {                             get => *(int*)(addr + Offset.DT_PointWorldText.m_textColor);                                set => *(int*)(addr + Offset.DT_PointWorldText.m_textColor) = value;                                }

        }

        public class PointCommentaryNode : baseStructs
        {
            public static implicit operator PointCommentaryNode(IntPtr ptr) => new PointCommentaryNode() { addr = ptr                                                                                                                                            };
            public int m_bActive {                               get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_bActive);                             set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_bActive) = value;                             }
            public int m_flStartTime {                           get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_flStartTime);                         set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_flStartTime) = value;                         }
            public int m_iszCommentaryFile {                     get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iszCommentaryFile);                   set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iszCommentaryFile) = value;                   }
            public int m_iszCommentaryFileNoHDR {                get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iszCommentaryFileNoHDR);              set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iszCommentaryFileNoHDR) = value;              }
            public int m_iszSpeakers {                           get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iszSpeakers);                         set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iszSpeakers) = value;                         }
            public int m_iNodeNumber {                           get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iNodeNumber);                         set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iNodeNumber) = value;                         }
            public int m_iNodeNumberMax {                        get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iNodeNumberMax);                      set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_iNodeNumberMax) = value;                      }
            public int m_hViewPosition {                         get => *(int*)(addr + Offset.DT_PointCommentaryNode.m_hViewPosition);                       set => *(int*)(addr + Offset.DT_PointCommentaryNode.m_hViewPosition) = value;                       }

        }

        public class PointCamera : baseStructs
        {
            public static implicit operator PointCamera(IntPtr ptr) => new PointCamera() { addr = ptr                                                                                                                                                            };
            public int m_FOV {                                   get => *(int*)(addr + Offset.DT_PointCamera.m_FOV);                                         set => *(int*)(addr + Offset.DT_PointCamera.m_FOV) = value;                                         }
            public int m_Resolution {                            get => *(int*)(addr + Offset.DT_PointCamera.m_Resolution);                                  set => *(int*)(addr + Offset.DT_PointCamera.m_Resolution) = value;                                  }
            public int m_bFogEnable {                            get => *(int*)(addr + Offset.DT_PointCamera.m_bFogEnable);                                  set => *(int*)(addr + Offset.DT_PointCamera.m_bFogEnable) = value;                                  }
            public int m_FogColor {                              get => *(int*)(addr + Offset.DT_PointCamera.m_FogColor);                                    set => *(int*)(addr + Offset.DT_PointCamera.m_FogColor) = value;                                    }
            public int m_flFogStart {                            get => *(int*)(addr + Offset.DT_PointCamera.m_flFogStart);                                  set => *(int*)(addr + Offset.DT_PointCamera.m_flFogStart) = value;                                  }
            public int m_flFogEnd {                              get => *(int*)(addr + Offset.DT_PointCamera.m_flFogEnd);                                    set => *(int*)(addr + Offset.DT_PointCamera.m_flFogEnd) = value;                                    }
            public int m_flFogMaxDensity {                       get => *(int*)(addr + Offset.DT_PointCamera.m_flFogMaxDensity);                             set => *(int*)(addr + Offset.DT_PointCamera.m_flFogMaxDensity) = value;                             }
            public int m_bActive {                               get => *(int*)(addr + Offset.DT_PointCamera.m_bActive);                                     set => *(int*)(addr + Offset.DT_PointCamera.m_bActive) = value;                                     }
            public int m_bUseScreenAspectRatio {                 get => *(int*)(addr + Offset.DT_PointCamera.m_bUseScreenAspectRatio);                       set => *(int*)(addr + Offset.DT_PointCamera.m_bUseScreenAspectRatio) = value;                       }

        }

        public class Plasma : baseStructs
        {
            public static implicit operator Plasma(IntPtr ptr) => new Plasma() { addr = ptr                                                                                                                                                                      };
            public int m_flStartScale {                          get => *(int*)(addr + Offset.DT_Plasma.m_flStartScale);                                     set => *(int*)(addr + Offset.DT_Plasma.m_flStartScale) = value;                                     }
            public int m_flScale {                               get => *(int*)(addr + Offset.DT_Plasma.m_flScale);                                          set => *(int*)(addr + Offset.DT_Plasma.m_flScale) = value;                                          }
            public int m_flScaleTime {                           get => *(int*)(addr + Offset.DT_Plasma.m_flScaleTime);                                      set => *(int*)(addr + Offset.DT_Plasma.m_flScaleTime) = value;                                      }
            public int m_nFlags {                                get => *(int*)(addr + Offset.DT_Plasma.m_nFlags);                                           set => *(int*)(addr + Offset.DT_Plasma.m_nFlags) = value;                                           }
            public int m_nPlasmaModelIndex {                     get => *(int*)(addr + Offset.DT_Plasma.m_nPlasmaModelIndex);                                set => *(int*)(addr + Offset.DT_Plasma.m_nPlasmaModelIndex) = value;                                }
            public int m_nPlasmaModelIndex2 {                    get => *(int*)(addr + Offset.DT_Plasma.m_nPlasmaModelIndex2);                               set => *(int*)(addr + Offset.DT_Plasma.m_nPlasmaModelIndex2) = value;                               }
            public int m_nGlowModelIndex {                       get => *(int*)(addr + Offset.DT_Plasma.m_nGlowModelIndex);                                  set => *(int*)(addr + Offset.DT_Plasma.m_nGlowModelIndex) = value;                                  }

        }

        public class PhysicsProp : baseStructs
        {
            public static implicit operator PhysicsProp(IntPtr ptr) => new PhysicsProp() { addr = ptr                                                                                                                                                            };
            public int m_bAwake {                                get => *(int*)(addr + Offset.DT_PhysicsProp.m_bAwake);                                      set => *(int*)(addr + Offset.DT_PhysicsProp.m_bAwake) = value;                                      }
            public int m_spawnflags {                            get => *(int*)(addr + Offset.DT_PhysicsProp.m_spawnflags);                                  set => *(int*)(addr + Offset.DT_PhysicsProp.m_spawnflags) = value;                                  }

        }

        public class StatueProp : baseStructs
        {
            public static implicit operator StatueProp(IntPtr ptr) => new StatueProp() { addr = ptr                                                                                                                                                              };
            public int m_hInitBaseAnimating {                    get => *(int*)(addr + Offset.DT_StatueProp.m_hInitBaseAnimating);                           set => *(int*)(addr + Offset.DT_StatueProp.m_hInitBaseAnimating) = value;                           }
            public int m_bShatter {                              get => *(int*)(addr + Offset.DT_StatueProp.m_bShatter);                                     set => *(int*)(addr + Offset.DT_StatueProp.m_bShatter) = value;                                     }
            public int m_nShatterFlags {                         get => *(int*)(addr + Offset.DT_StatueProp.m_nShatterFlags);                                set => *(int*)(addr + Offset.DT_StatueProp.m_nShatterFlags) = value;                                }
            public int m_vShatterPosition {                      get => *(int*)(addr + Offset.DT_StatueProp.m_vShatterPosition);                             set => *(int*)(addr + Offset.DT_StatueProp.m_vShatterPosition) = value;                             }
            public int m_vShatterForce {                         get => *(int*)(addr + Offset.DT_StatueProp.m_vShatterForce);                                set => *(int*)(addr + Offset.DT_StatueProp.m_vShatterForce) = value;                                }

        }

        public class PhysBox : baseStructs
        {
            public static implicit operator PhysBox(IntPtr ptr) => new PhysBox() { addr = ptr                                                                                                                                                                    };
            public int m_mass {                                  get => *(int*)(addr + Offset.DT_PhysBox.m_mass);                                            set => *(int*)(addr + Offset.DT_PhysBox.m_mass) = value;                                            }

        }

        public class ParticleSystem : baseStructs
        {
            public static implicit operator ParticleSystem(IntPtr ptr) => new ParticleSystem() { addr = ptr                                                                                                                                                      };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_ParticleSystem.m_vecOrigin);                                set => *(int*)(addr + Offset.DT_ParticleSystem.m_vecOrigin) = value;                                }
            public int m_fEffects {                              get => *(int*)(addr + Offset.DT_ParticleSystem.m_fEffects);                                 set => *(int*)(addr + Offset.DT_ParticleSystem.m_fEffects) = value;                                 }
            public int m_hOwnerEntity {                          get => *(int*)(addr + Offset.DT_ParticleSystem.m_hOwnerEntity);                             set => *(int*)(addr + Offset.DT_ParticleSystem.m_hOwnerEntity) = value;                             }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_ParticleSystem.moveparent);                                 set => *(int*)(addr + Offset.DT_ParticleSystem.moveparent) = value;                                 }
            public int m_iParentAttachment {                     get => *(int*)(addr + Offset.DT_ParticleSystem.m_iParentAttachment);                        set => *(int*)(addr + Offset.DT_ParticleSystem.m_iParentAttachment) = value;                        }
            public int m_angRotation {                           get => *(int*)(addr + Offset.DT_ParticleSystem.m_angRotation);                              set => *(int*)(addr + Offset.DT_ParticleSystem.m_angRotation) = value;                              }
            public int m_iEffectIndex {                          get => *(int*)(addr + Offset.DT_ParticleSystem.m_iEffectIndex);                             set => *(int*)(addr + Offset.DT_ParticleSystem.m_iEffectIndex) = value;                             }
            public int m_bActive {                               get => *(int*)(addr + Offset.DT_ParticleSystem.m_bActive);                                  set => *(int*)(addr + Offset.DT_ParticleSystem.m_bActive) = value;                                  }
            public int m_nStopType {                             get => *(int*)(addr + Offset.DT_ParticleSystem.m_nStopType);                                set => *(int*)(addr + Offset.DT_ParticleSystem.m_nStopType) = value;                                }
            public int m_flStartTime {                           get => *(int*)(addr + Offset.DT_ParticleSystem.m_flStartTime);                              set => *(int*)(addr + Offset.DT_ParticleSystem.m_flStartTime) = value;                              }
            public int m_szSnapshotFileName {                    get => *(int*)(addr + Offset.DT_ParticleSystem.m_szSnapshotFileName);                       set => *(int*)(addr + Offset.DT_ParticleSystem.m_szSnapshotFileName) = value;                       }
            public int m_vServerControlPoints {                  get => *(int*)(addr + Offset.DT_ParticleSystem.m_vServerControlPoints);                     set => *(int*)(addr + Offset.DT_ParticleSystem.m_vServerControlPoints) = value;                     }
            public int m_iServerControlPointAssignments {        get => *(int*)(addr + Offset.DT_ParticleSystem.m_iServerControlPointAssignments);           set => *(int*)(addr + Offset.DT_ParticleSystem.m_iServerControlPointAssignments) = value;           }
            public int m_hControlPointEnts {                     get => *(int*)(addr + Offset.DT_ParticleSystem.m_hControlPointEnts);                        set => *(int*)(addr + Offset.DT_ParticleSystem.m_hControlPointEnts) = value;                        }
            public int m_iControlPointParents {                  get => *(int*)(addr + Offset.DT_ParticleSystem.m_iControlPointParents);                     set => *(int*)(addr + Offset.DT_ParticleSystem.m_iControlPointParents) = value;                     }

        }

        public class MovieDisplay : baseStructs
        {
            public static implicit operator MovieDisplay(IntPtr ptr) => new MovieDisplay() { addr = ptr                                                                                                                                                          };
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_MovieDisplay.m_bEnabled);                                   set => *(int*)(addr + Offset.DT_MovieDisplay.m_bEnabled) = value;                                   }
            public int m_bLooping {                              get => *(int*)(addr + Offset.DT_MovieDisplay.m_bLooping);                                   set => *(int*)(addr + Offset.DT_MovieDisplay.m_bLooping) = value;                                   }
            public int m_szMovieFilename {                       get => *(int*)(addr + Offset.DT_MovieDisplay.m_szMovieFilename);                            set => *(int*)(addr + Offset.DT_MovieDisplay.m_szMovieFilename) = value;                            }
            public int m_szGroupName {                           get => *(int*)(addr + Offset.DT_MovieDisplay.m_szGroupName);                                set => *(int*)(addr + Offset.DT_MovieDisplay.m_szGroupName) = value;                                }
            public int m_bStretchToFill {                        get => *(int*)(addr + Offset.DT_MovieDisplay.m_bStretchToFill);                             set => *(int*)(addr + Offset.DT_MovieDisplay.m_bStretchToFill) = value;                             }
            public int m_bForcedSlave {                          get => *(int*)(addr + Offset.DT_MovieDisplay.m_bForcedSlave);                               set => *(int*)(addr + Offset.DT_MovieDisplay.m_bForcedSlave) = value;                               }
            public int m_bUseCustomUVs {                         get => *(int*)(addr + Offset.DT_MovieDisplay.m_bUseCustomUVs);                              set => *(int*)(addr + Offset.DT_MovieDisplay.m_bUseCustomUVs) = value;                              }
            public int m_flUMin {                                get => *(int*)(addr + Offset.DT_MovieDisplay.m_flUMin);                                     set => *(int*)(addr + Offset.DT_MovieDisplay.m_flUMin) = value;                                     }
            public int m_flUMax {                                get => *(int*)(addr + Offset.DT_MovieDisplay.m_flUMax);                                     set => *(int*)(addr + Offset.DT_MovieDisplay.m_flUMax) = value;                                     }
            public int m_flVMin {                                get => *(int*)(addr + Offset.DT_MovieDisplay.m_flVMin);                                     set => *(int*)(addr + Offset.DT_MovieDisplay.m_flVMin) = value;                                     }
            public int m_flVMax {                                get => *(int*)(addr + Offset.DT_MovieDisplay.m_flVMax);                                     set => *(int*)(addr + Offset.DT_MovieDisplay.m_flVMax) = value;                                     }

        }

        public class MaterialModifyControl : baseStructs
        {
            public static implicit operator MaterialModifyControl(IntPtr ptr) => new MaterialModifyControl() { addr = ptr                                                                                                                                        };
            public int m_szMaterialName {                        get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_szMaterialName);                    set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_szMaterialName) = value;                    }
            public int m_szMaterialVar {                         get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_szMaterialVar);                     set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_szMaterialVar) = value;                     }
            public int m_szMaterialVarValue {                    get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_szMaterialVarValue);                set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_szMaterialVarValue) = value;                }
            public int m_iFrameStart {                           get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_iFrameStart);                       set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_iFrameStart) = value;                       }
            public int m_iFrameEnd {                             get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_iFrameEnd);                         set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_iFrameEnd) = value;                         }
            public int m_bWrap {                                 get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_bWrap);                             set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_bWrap) = value;                             }
            public int m_flFramerate {                           get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFramerate);                       set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFramerate) = value;                       }
            public int m_bNewAnimCommandsSemaphore {             get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_bNewAnimCommandsSemaphore);         set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_bNewAnimCommandsSemaphore) = value;         }
            public int m_flFloatLerpStartValue {                 get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFloatLerpStartValue);             set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFloatLerpStartValue) = value;             }
            public int m_flFloatLerpEndValue {                   get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFloatLerpEndValue);               set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFloatLerpEndValue) = value;               }
            public int m_flFloatLerpTransitionTime {             get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFloatLerpTransitionTime);         set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_flFloatLerpTransitionTime) = value;         }
            public int m_bFloatLerpWrap {                        get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_bFloatLerpWrap);                    set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_bFloatLerpWrap) = value;                    }
            public int m_nModifyMode {                           get => *(int*)(addr + Offset.DT_MaterialModifyControl.m_nModifyMode);                       set => *(int*)(addr + Offset.DT_MaterialModifyControl.m_nModifyMode) = value;                       }

        }

        public class LightGlow : baseStructs
        {
            public static implicit operator LightGlow(IntPtr ptr) => new LightGlow() { addr = ptr                                                                                                                                                                };
            public int m_clrRender {                             get => *(int*)(addr + Offset.DT_LightGlow.m_clrRender);                                     set => *(int*)(addr + Offset.DT_LightGlow.m_clrRender) = value;                                     }
            public int m_nHorizontalSize {                       get => *(int*)(addr + Offset.DT_LightGlow.m_nHorizontalSize);                               set => *(int*)(addr + Offset.DT_LightGlow.m_nHorizontalSize) = value;                               }
            public int m_nVerticalSize {                         get => *(int*)(addr + Offset.DT_LightGlow.m_nVerticalSize);                                 set => *(int*)(addr + Offset.DT_LightGlow.m_nVerticalSize) = value;                                 }
            public int m_nMinDist {                              get => *(int*)(addr + Offset.DT_LightGlow.m_nMinDist);                                      set => *(int*)(addr + Offset.DT_LightGlow.m_nMinDist) = value;                                      }
            public int m_nMaxDist {                              get => *(int*)(addr + Offset.DT_LightGlow.m_nMaxDist);                                      set => *(int*)(addr + Offset.DT_LightGlow.m_nMaxDist) = value;                                      }
            public int m_nOuterMaxDist {                         get => *(int*)(addr + Offset.DT_LightGlow.m_nOuterMaxDist);                                 set => *(int*)(addr + Offset.DT_LightGlow.m_nOuterMaxDist) = value;                                 }
            public int m_spawnflags {                            get => *(int*)(addr + Offset.DT_LightGlow.m_spawnflags);                                    set => *(int*)(addr + Offset.DT_LightGlow.m_spawnflags) = value;                                    }
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_LightGlow.m_vecOrigin);                                     set => *(int*)(addr + Offset.DT_LightGlow.m_vecOrigin) = value;                                     }
            public int m_angRotation {                           get => *(int*)(addr + Offset.DT_LightGlow.m_angRotation);                                   set => *(int*)(addr + Offset.DT_LightGlow.m_angRotation) = value;                                   }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_LightGlow.moveparent);                                      set => *(int*)(addr + Offset.DT_LightGlow.moveparent) = value;                                      }
            public int m_flGlowProxySize {                       get => *(int*)(addr + Offset.DT_LightGlow.m_flGlowProxySize);                               set => *(int*)(addr + Offset.DT_LightGlow.m_flGlowProxySize) = value;                               }
            public int HDRColorScale {                           get => *(int*)(addr + Offset.DT_LightGlow.HDRColorScale);                                   set => *(int*)(addr + Offset.DT_LightGlow.HDRColorScale) = value;                                   }

        }

        public class ItemAssaultSuitUseable : baseStructs
        {
            public static implicit operator ItemAssaultSuitUseable(IntPtr ptr) => new ItemAssaultSuitUseable() { addr = ptr                                                                                                                                      };
            public int m_nArmorValue {                           get => *(int*)(addr + Offset.DT_ItemAssaultSuitUseable.m_nArmorValue);                      set => *(int*)(addr + Offset.DT_ItemAssaultSuitUseable.m_nArmorValue) = value;                      }
            public int m_bIsHeavyAssaultSuit {                   get => *(int*)(addr + Offset.DT_ItemAssaultSuitUseable.m_bIsHeavyAssaultSuit);              set => *(int*)(addr + Offset.DT_ItemAssaultSuitUseable.m_bIsHeavyAssaultSuit) = value;              }

        }

        public class Item : baseStructs
        {
            public static implicit operator Item(IntPtr ptr) => new Item() { addr = ptr                                                                                                                                                                          };
            public int m_bShouldGlow {                           get => *(int*)(addr + Offset.DT_Item.m_bShouldGlow);                                        set => *(int*)(addr + Offset.DT_Item.m_bShouldGlow) = value;                                        }

        }

        public class InfoOverlayAccessor : baseStructs
        {
            public static implicit operator InfoOverlayAccessor(IntPtr ptr) => new InfoOverlayAccessor() { addr = ptr                                                                                                                                            };
            public int m_iTextureFrameIndex {                    get => *(int*)(addr + Offset.DT_InfoOverlayAccessor.m_iTextureFrameIndex);                  set => *(int*)(addr + Offset.DT_InfoOverlayAccessor.m_iTextureFrameIndex) = value;                  }
            public int m_iOverlayID {                            get => *(int*)(addr + Offset.DT_InfoOverlayAccessor.m_iOverlayID);                          set => *(int*)(addr + Offset.DT_InfoOverlayAccessor.m_iOverlayID) = value;                          }

        }

        public class FuncSmokeVolume : baseStructs
        {
            public static implicit operator FuncSmokeVolume(IntPtr ptr) => new FuncSmokeVolume() { addr = ptr                                                                                                                                                    };
            public int m_Color1 {                                get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Color1);                                  set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Color1) = value;                                  }
            public int m_Color2 {                                get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Color2);                                  set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Color2) = value;                                  }
            public int m_MaterialName {                          get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_MaterialName);                            set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_MaterialName) = value;                            }
            public int m_ParticleDrawWidth {                     get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_ParticleDrawWidth);                       set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_ParticleDrawWidth) = value;                       }
            public int m_ParticleSpacingDistance {               get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_ParticleSpacingDistance);                 set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_ParticleSpacingDistance) = value;                 }
            public int m_DensityRampSpeed {                      get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_DensityRampSpeed);                        set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_DensityRampSpeed) = value;                        }
            public int m_RotationSpeed {                         get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_RotationSpeed);                           set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_RotationSpeed) = value;                           }
            public int m_MovementSpeed {                         get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_MovementSpeed);                           set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_MovementSpeed) = value;                           }
            public int m_Density {                               get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Density);                                 set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Density) = value;                                 }
            public int m_maxDrawDistance {                       get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_maxDrawDistance);                         set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_maxDrawDistance) = value;                         }
            public int m_spawnflags {                            get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_spawnflags);                              set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_spawnflags) = value;                              }
            public int m_vecMins {                               get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecMins);                                 set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecMins) = value;                                 }
            public int m_vecMaxs {                               get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecMaxs);                                 set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecMaxs) = value;                                 }
            public int m_nSolidType {                            get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_nSolidType);                              set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_nSolidType) = value;                              }
            public int m_usSolidFlags {                          get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_usSolidFlags);                            set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_usSolidFlags) = value;                            }
            public int m_nSurroundType {                         get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_nSurroundType);                           set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_nSurroundType) = value;                           }
            public int m_triggerBloat {                          get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_triggerBloat);                            set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_triggerBloat) = value;                            }
            public int m_vecSpecifiedSurroundingMins {           get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecSpecifiedSurroundingMins);             set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecSpecifiedSurroundingMins) = value;             }
            public int m_vecSpecifiedSurroundingMaxs {           get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecSpecifiedSurroundingMaxs);             set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_vecSpecifiedSurroundingMaxs) = value;             }
            public int m_Collision {                             get => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Collision);                               set => *(int*)(addr + Offset.DT_FuncSmokeVolume.m_Collision) = value;                               }

        }

        public class FuncRotating : baseStructs
        {
            public static implicit operator FuncRotating(IntPtr ptr) => new FuncRotating() { addr = ptr                                                                                                                                                          };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_FuncRotating.m_vecOrigin);                                  set => *(int*)(addr + Offset.DT_FuncRotating.m_vecOrigin) = value;                                  }
            public int m_angRotation_0 {                         get => *(int*)(addr + Offset.DT_FuncRotating.m_angRotation_0);                              set => *(int*)(addr + Offset.DT_FuncRotating.m_angRotation_0) = value;                              }
            public int m_angRotation_1 {                         get => *(int*)(addr + Offset.DT_FuncRotating.m_angRotation_1);                              set => *(int*)(addr + Offset.DT_FuncRotating.m_angRotation_1) = value;                              }
            public int m_angRotation_2 {                         get => *(int*)(addr + Offset.DT_FuncRotating.m_angRotation_2);                              set => *(int*)(addr + Offset.DT_FuncRotating.m_angRotation_2) = value;                              }
            public int m_flSimulationTime {                      get => *(int*)(addr + Offset.DT_FuncRotating.m_flSimulationTime);                           set => *(int*)(addr + Offset.DT_FuncRotating.m_flSimulationTime) = value;                           }

        }

        public class FuncOccluder : baseStructs
        {
            public static implicit operator FuncOccluder(IntPtr ptr) => new FuncOccluder() { addr = ptr                                                                                                                                                          };
            public int m_bActive {                               get => *(int*)(addr + Offset.DT_FuncOccluder.m_bActive);                                    set => *(int*)(addr + Offset.DT_FuncOccluder.m_bActive) = value;                                    }
            public int m_nOccluderIndex {                        get => *(int*)(addr + Offset.DT_FuncOccluder.m_nOccluderIndex);                             set => *(int*)(addr + Offset.DT_FuncOccluder.m_nOccluderIndex) = value;                             }

        }

        public class FuncMoveLinear : baseStructs
        {
            public static implicit operator FuncMoveLinear(IntPtr ptr) => new FuncMoveLinear() { addr = ptr                                                                                                                                                      };
            public int m_vecVelocity {                           get => *(int*)(addr + Offset.DT_FuncMoveLinear.m_vecVelocity);                              set => *(int*)(addr + Offset.DT_FuncMoveLinear.m_vecVelocity) = value;                              }
            public int m_fFlags {                                get => *(int*)(addr + Offset.DT_FuncMoveLinear.m_fFlags);                                   set => *(int*)(addr + Offset.DT_FuncMoveLinear.m_fFlags) = value;                                   }

        }

        public class Func_LOD : baseStructs
        {
            public static implicit operator Func_LOD(IntPtr ptr) => new Func_LOD() { addr = ptr                                                                                                                                                                  };
            public int m_nDisappearMinDist {                     get => *(int*)(addr + Offset.DT_Func_LOD.m_nDisappearMinDist);                              set => *(int*)(addr + Offset.DT_Func_LOD.m_nDisappearMinDist) = value;                              }
            public int m_nDisappearMaxDist {                     get => *(int*)(addr + Offset.DT_Func_LOD.m_nDisappearMaxDist);                              set => *(int*)(addr + Offset.DT_Func_LOD.m_nDisappearMaxDist) = value;                              }

        }

        public class TEDust : baseStructs
        {
            public static implicit operator TEDust(IntPtr ptr) => new TEDust() { addr = ptr                                                                                                                                                                      };
            public int m_flSize {                                get => *(int*)(addr + Offset.DT_TEDust.m_flSize);                                           set => *(int*)(addr + Offset.DT_TEDust.m_flSize) = value;                                           }
            public int m_flSpeed {                               get => *(int*)(addr + Offset.DT_TEDust.m_flSpeed);                                          set => *(int*)(addr + Offset.DT_TEDust.m_flSpeed) = value;                                          }
            public int m_vecDirection {                          get => *(int*)(addr + Offset.DT_TEDust.m_vecDirection);                                     set => *(int*)(addr + Offset.DT_TEDust.m_vecDirection) = value;                                     }

        }

        public class Func_Dust : baseStructs
        {
            public static implicit operator Func_Dust(IntPtr ptr) => new Func_Dust() { addr = ptr                                                                                                                                                                };
            public int m_Color {                                 get => *(int*)(addr + Offset.DT_Func_Dust.m_Color);                                         set => *(int*)(addr + Offset.DT_Func_Dust.m_Color) = value;                                         }
            public int m_SpawnRate {                             get => *(int*)(addr + Offset.DT_Func_Dust.m_SpawnRate);                                     set => *(int*)(addr + Offset.DT_Func_Dust.m_SpawnRate) = value;                                     }
            public int m_flSizeMin {                             get => *(int*)(addr + Offset.DT_Func_Dust.m_flSizeMin);                                     set => *(int*)(addr + Offset.DT_Func_Dust.m_flSizeMin) = value;                                     }
            public int m_flSizeMax {                             get => *(int*)(addr + Offset.DT_Func_Dust.m_flSizeMax);                                     set => *(int*)(addr + Offset.DT_Func_Dust.m_flSizeMax) = value;                                     }
            public int m_LifetimeMin {                           get => *(int*)(addr + Offset.DT_Func_Dust.m_LifetimeMin);                                   set => *(int*)(addr + Offset.DT_Func_Dust.m_LifetimeMin) = value;                                   }
            public int m_LifetimeMax {                           get => *(int*)(addr + Offset.DT_Func_Dust.m_LifetimeMax);                                   set => *(int*)(addr + Offset.DT_Func_Dust.m_LifetimeMax) = value;                                   }
            public int m_DustFlags {                             get => *(int*)(addr + Offset.DT_Func_Dust.m_DustFlags);                                     set => *(int*)(addr + Offset.DT_Func_Dust.m_DustFlags) = value;                                     }
            public int m_SpeedMax {                              get => *(int*)(addr + Offset.DT_Func_Dust.m_SpeedMax);                                      set => *(int*)(addr + Offset.DT_Func_Dust.m_SpeedMax) = value;                                      }
            public int m_DistMax {                               get => *(int*)(addr + Offset.DT_Func_Dust.m_DistMax);                                       set => *(int*)(addr + Offset.DT_Func_Dust.m_DistMax) = value;                                       }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_Func_Dust.m_nModelIndex);                                   set => *(int*)(addr + Offset.DT_Func_Dust.m_nModelIndex) = value;                                   }
            public int m_FallSpeed {                             get => *(int*)(addr + Offset.DT_Func_Dust.m_FallSpeed);                                     set => *(int*)(addr + Offset.DT_Func_Dust.m_FallSpeed) = value;                                     }
            public int m_bAffectedByWind {                       get => *(int*)(addr + Offset.DT_Func_Dust.m_bAffectedByWind);                               set => *(int*)(addr + Offset.DT_Func_Dust.m_bAffectedByWind) = value;                               }
            public int m_vecMins {                               get => *(int*)(addr + Offset.DT_Func_Dust.m_vecMins);                                       set => *(int*)(addr + Offset.DT_Func_Dust.m_vecMins) = value;                                       }
            public int m_vecMaxs {                               get => *(int*)(addr + Offset.DT_Func_Dust.m_vecMaxs);                                       set => *(int*)(addr + Offset.DT_Func_Dust.m_vecMaxs) = value;                                       }
            public int m_nSolidType {                            get => *(int*)(addr + Offset.DT_Func_Dust.m_nSolidType);                                    set => *(int*)(addr + Offset.DT_Func_Dust.m_nSolidType) = value;                                    }
            public int m_usSolidFlags {                          get => *(int*)(addr + Offset.DT_Func_Dust.m_usSolidFlags);                                  set => *(int*)(addr + Offset.DT_Func_Dust.m_usSolidFlags) = value;                                  }
            public int m_nSurroundType {                         get => *(int*)(addr + Offset.DT_Func_Dust.m_nSurroundType);                                 set => *(int*)(addr + Offset.DT_Func_Dust.m_nSurroundType) = value;                                 }
            public int m_triggerBloat {                          get => *(int*)(addr + Offset.DT_Func_Dust.m_triggerBloat);                                  set => *(int*)(addr + Offset.DT_Func_Dust.m_triggerBloat) = value;                                  }
            public int m_vecSpecifiedSurroundingMins {           get => *(int*)(addr + Offset.DT_Func_Dust.m_vecSpecifiedSurroundingMins);                   set => *(int*)(addr + Offset.DT_Func_Dust.m_vecSpecifiedSurroundingMins) = value;                   }
            public int m_vecSpecifiedSurroundingMaxs {           get => *(int*)(addr + Offset.DT_Func_Dust.m_vecSpecifiedSurroundingMaxs);                   set => *(int*)(addr + Offset.DT_Func_Dust.m_vecSpecifiedSurroundingMaxs) = value;                   }
            public int m_Collision {                             get => *(int*)(addr + Offset.DT_Func_Dust.m_Collision);                                     set => *(int*)(addr + Offset.DT_Func_Dust.m_Collision) = value;                                     }

        }

        public class FuncConveyor : baseStructs
        {
            public static implicit operator FuncConveyor(IntPtr ptr) => new FuncConveyor() { addr = ptr                                                                                                                                                          };
            public int m_flConveyorSpeed {                       get => *(int*)(addr + Offset.DT_FuncConveyor.m_flConveyorSpeed);                            set => *(int*)(addr + Offset.DT_FuncConveyor.m_flConveyorSpeed) = value;                            }

        }

        public class BreakableSurface : baseStructs
        {
            public static implicit operator BreakableSurface(IntPtr ptr) => new BreakableSurface() { addr = ptr                                                                                                                                                  };
            public int m_nNumWide {                              get => *(int*)(addr + Offset.DT_BreakableSurface.m_nNumWide);                               set => *(int*)(addr + Offset.DT_BreakableSurface.m_nNumWide) = value;                               }
            public int m_nNumHigh {                              get => *(int*)(addr + Offset.DT_BreakableSurface.m_nNumHigh);                               set => *(int*)(addr + Offset.DT_BreakableSurface.m_nNumHigh) = value;                               }
            public int m_flPanelWidth {                          get => *(int*)(addr + Offset.DT_BreakableSurface.m_flPanelWidth);                           set => *(int*)(addr + Offset.DT_BreakableSurface.m_flPanelWidth) = value;                           }
            public int m_flPanelHeight {                         get => *(int*)(addr + Offset.DT_BreakableSurface.m_flPanelHeight);                          set => *(int*)(addr + Offset.DT_BreakableSurface.m_flPanelHeight) = value;                          }
            public int m_vNormal {                               get => *(int*)(addr + Offset.DT_BreakableSurface.m_vNormal);                                set => *(int*)(addr + Offset.DT_BreakableSurface.m_vNormal) = value;                                }
            public int m_vCorner {                               get => *(int*)(addr + Offset.DT_BreakableSurface.m_vCorner);                                set => *(int*)(addr + Offset.DT_BreakableSurface.m_vCorner) = value;                                }
            public int m_bIsBroken {                             get => *(int*)(addr + Offset.DT_BreakableSurface.m_bIsBroken);                              set => *(int*)(addr + Offset.DT_BreakableSurface.m_bIsBroken) = value;                              }
            public int m_nSurfaceType {                          get => *(int*)(addr + Offset.DT_BreakableSurface.m_nSurfaceType);                           set => *(int*)(addr + Offset.DT_BreakableSurface.m_nSurfaceType) = value;                           }
            public int m_RawPanelBitVec {                        get => *(int*)(addr + Offset.DT_BreakableSurface.m_RawPanelBitVec);                         set => *(int*)(addr + Offset.DT_BreakableSurface.m_RawPanelBitVec) = value;                         }

        }

        public class FuncAreaPortalWindow : baseStructs
        {
            public static implicit operator FuncAreaPortalWindow(IntPtr ptr) => new FuncAreaPortalWindow() { addr = ptr                                                                                                                                          };
            public int m_flFadeStartDist {                       get => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_flFadeStartDist);                    set => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_flFadeStartDist) = value;                    }
            public int m_flFadeDist {                            get => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_flFadeDist);                         set => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_flFadeDist) = value;                         }
            public int m_flTranslucencyLimit {                   get => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_flTranslucencyLimit);                set => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_flTranslucencyLimit) = value;                }
            public int m_iBackgroundModelIndex {                 get => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_iBackgroundModelIndex);              set => *(int*)(addr + Offset.DT_FuncAreaPortalWindow.m_iBackgroundModelIndex) = value;              }

        }

        public class CFish : baseStructs
        {
            public static implicit operator CFish(IntPtr ptr) => new CFish() { addr = ptr                                                                                                                                                                        };
            public int m_poolOrigin {                            get => *(int*)(addr + Offset.DT_CFish.m_poolOrigin);                                        set => *(int*)(addr + Offset.DT_CFish.m_poolOrigin) = value;                                        }
            public int m_x {                                     get => *(int*)(addr + Offset.DT_CFish.m_x);                                                 set => *(int*)(addr + Offset.DT_CFish.m_x) = value;                                                 }
            public int m_y {                                     get => *(int*)(addr + Offset.DT_CFish.m_y);                                                 set => *(int*)(addr + Offset.DT_CFish.m_y) = value;                                                 }
            public int m_z {                                     get => *(int*)(addr + Offset.DT_CFish.m_z);                                                 set => *(int*)(addr + Offset.DT_CFish.m_z) = value;                                                 }
            public int m_angle {                                 get => *(int*)(addr + Offset.DT_CFish.m_angle);                                             set => *(int*)(addr + Offset.DT_CFish.m_angle) = value;                                             }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_CFish.m_nModelIndex);                                       set => *(int*)(addr + Offset.DT_CFish.m_nModelIndex) = value;                                       }
            public int m_lifeState {                             get => *(int*)(addr + Offset.DT_CFish.m_lifeState);                                         set => *(int*)(addr + Offset.DT_CFish.m_lifeState) = value;                                         }
            public int m_waterLevel {                            get => *(int*)(addr + Offset.DT_CFish.m_waterLevel);                                        set => *(int*)(addr + Offset.DT_CFish.m_waterLevel) = value;                                        }

        }

        public class FireSmoke : baseStructs
        {
            public static implicit operator FireSmoke(IntPtr ptr) => new FireSmoke() { addr = ptr                                                                                                                                                                };
            public int m_flStartScale {                          get => *(int*)(addr + Offset.DT_FireSmoke.m_flStartScale);                                  set => *(int*)(addr + Offset.DT_FireSmoke.m_flStartScale) = value;                                  }
            public int m_flScale {                               get => *(int*)(addr + Offset.DT_FireSmoke.m_flScale);                                       set => *(int*)(addr + Offset.DT_FireSmoke.m_flScale) = value;                                       }
            public int m_flScaleTime {                           get => *(int*)(addr + Offset.DT_FireSmoke.m_flScaleTime);                                   set => *(int*)(addr + Offset.DT_FireSmoke.m_flScaleTime) = value;                                   }
            public int m_nFlags {                                get => *(int*)(addr + Offset.DT_FireSmoke.m_nFlags);                                        set => *(int*)(addr + Offset.DT_FireSmoke.m_nFlags) = value;                                        }
            public int m_nFlameModelIndex {                      get => *(int*)(addr + Offset.DT_FireSmoke.m_nFlameModelIndex);                              set => *(int*)(addr + Offset.DT_FireSmoke.m_nFlameModelIndex) = value;                              }
            public int m_nFlameFromAboveModelIndex {             get => *(int*)(addr + Offset.DT_FireSmoke.m_nFlameFromAboveModelIndex);                     set => *(int*)(addr + Offset.DT_FireSmoke.m_nFlameFromAboveModelIndex) = value;                     }

        }

        public class EnvTonemapController : baseStructs
        {
            public static implicit operator EnvTonemapController(IntPtr ptr) => new EnvTonemapController() { addr = ptr                                                                                                                                          };
            public int m_bUseCustomAutoExposureMin {             get => *(int*)(addr + Offset.DT_EnvTonemapController.m_bUseCustomAutoExposureMin);          set => *(int*)(addr + Offset.DT_EnvTonemapController.m_bUseCustomAutoExposureMin) = value;          }
            public int m_bUseCustomAutoExposureMax {             get => *(int*)(addr + Offset.DT_EnvTonemapController.m_bUseCustomAutoExposureMax);          set => *(int*)(addr + Offset.DT_EnvTonemapController.m_bUseCustomAutoExposureMax) = value;          }
            public int m_bUseCustomBloomScale {                  get => *(int*)(addr + Offset.DT_EnvTonemapController.m_bUseCustomBloomScale);               set => *(int*)(addr + Offset.DT_EnvTonemapController.m_bUseCustomBloomScale) = value;               }
            public int m_flCustomAutoExposureMin {               get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomAutoExposureMin);            set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomAutoExposureMin) = value;            }
            public int m_flCustomAutoExposureMax {               get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomAutoExposureMax);            set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomAutoExposureMax) = value;            }
            public int m_flCustomBloomScale {                    get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomBloomScale);                 set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomBloomScale) = value;                 }
            public int m_flCustomBloomScaleMinimum {             get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomBloomScaleMinimum);          set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flCustomBloomScaleMinimum) = value;          }
            public int m_flBloomExponent {                       get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flBloomExponent);                    set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flBloomExponent) = value;                    }
            public int m_flBloomSaturation {                     get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flBloomSaturation);                  set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flBloomSaturation) = value;                  }
            public int m_flTonemapPercentTarget {                get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapPercentTarget);             set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapPercentTarget) = value;             }
            public int m_flTonemapPercentBrightPixels {          get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapPercentBrightPixels);       set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapPercentBrightPixels) = value;       }
            public int m_flTonemapMinAvgLum {                    get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapMinAvgLum);                 set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapMinAvgLum) = value;                 }
            public int m_flTonemapRate {                         get => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapRate);                      set => *(int*)(addr + Offset.DT_EnvTonemapController.m_flTonemapRate) = value;                      }

        }

        public class EnvScreenEffect : baseStructs
        {
            public static implicit operator EnvScreenEffect(IntPtr ptr) => new EnvScreenEffect() { addr = ptr                                                                                                                                                    };
            public int m_flDuration {                            get => *(int*)(addr + Offset.DT_EnvScreenEffect.m_flDuration);                              set => *(int*)(addr + Offset.DT_EnvScreenEffect.m_flDuration) = value;                              }
            public int m_nType {                                 get => *(int*)(addr + Offset.DT_EnvScreenEffect.m_nType);                                   set => *(int*)(addr + Offset.DT_EnvScreenEffect.m_nType) = value;                                   }

        }

        public class EnvScreenOverlay : baseStructs
        {
            public static implicit operator EnvScreenOverlay(IntPtr ptr) => new EnvScreenOverlay() { addr = ptr                                                                                                                                                  };
            public int m_iszOverlayNames_0 {                     get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_iszOverlayNames_0);                      set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_iszOverlayNames_0) = value;                      }
            public int m_iszOverlayNames {                       get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_iszOverlayNames);                        set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_iszOverlayNames) = value;                        }
            public int m_flOverlayTimes_0 {                      get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_flOverlayTimes_0);                       set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_flOverlayTimes_0) = value;                       }
            public int m_flOverlayTimes {                        get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_flOverlayTimes);                         set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_flOverlayTimes) = value;                         }
            public int m_flStartTime {                           get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_flStartTime);                            set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_flStartTime) = value;                            }
            public int m_iDesiredOverlay {                       get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_iDesiredOverlay);                        set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_iDesiredOverlay) = value;                        }
            public int m_bIsActive {                             get => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_bIsActive);                              set => *(int*)(addr + Offset.DT_EnvScreenOverlay.m_bIsActive) = value;                              }

        }

        public class EnvProjectedTexture : baseStructs
        {
            public static implicit operator EnvProjectedTexture(IntPtr ptr) => new EnvProjectedTexture() { addr = ptr                                                                                                                                            };
            public int m_hTargetEntity {                         get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_hTargetEntity);                       set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_hTargetEntity) = value;                       }
            public int m_bState {                                get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bState);                              set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bState) = value;                              }
            public int m_bAlwaysUpdate {                         get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bAlwaysUpdate);                       set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bAlwaysUpdate) = value;                       }
            public int m_flLightFOV {                            get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flLightFOV);                          set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flLightFOV) = value;                          }
            public int m_bEnableShadows {                        get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bEnableShadows);                      set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bEnableShadows) = value;                      }
            public int m_bSimpleProjection {                     get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bSimpleProjection);                   set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bSimpleProjection) = value;                   }
            public int m_bLightOnlyTarget {                      get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bLightOnlyTarget);                    set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bLightOnlyTarget) = value;                    }
            public int m_bLightWorld {                           get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bLightWorld);                         set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bLightWorld) = value;                         }
            public int m_bCameraSpace {                          get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bCameraSpace);                        set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_bCameraSpace) = value;                        }
            public int m_flBrightnessScale {                     get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flBrightnessScale);                   set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flBrightnessScale) = value;                   }
            public int m_LightColor {                            get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_LightColor);                          set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_LightColor) = value;                          }
            public int m_flColorTransitionTime {                 get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flColorTransitionTime);               set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flColorTransitionTime) = value;               }
            public int m_flAmbient {                             get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flAmbient);                           set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flAmbient) = value;                           }
            public int m_SpotlightTextureName {                  get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_SpotlightTextureName);                set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_SpotlightTextureName) = value;                }
            public int m_nSpotlightTextureFrame {                get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_nSpotlightTextureFrame);              set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_nSpotlightTextureFrame) = value;              }
            public int m_flNearZ {                               get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flNearZ);                             set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flNearZ) = value;                             }
            public int m_flFarZ {                                get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flFarZ);                              set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flFarZ) = value;                              }
            public int m_nShadowQuality {                        get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_nShadowQuality);                      set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_nShadowQuality) = value;                      }
            public int m_flProjectionSize {                      get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flProjectionSize);                    set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flProjectionSize) = value;                    }
            public int m_flRotation {                            get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flRotation);                          set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_flRotation) = value;                          }
            public int m_iStyle {                                get => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_iStyle);                              set => *(int*)(addr + Offset.DT_EnvProjectedTexture.m_iStyle) = value;                              }

        }

        public class EnvParticleScript : baseStructs
        {
            public static implicit operator EnvParticleScript(IntPtr ptr) => new EnvParticleScript() { addr = ptr                                                                                                                                                };
            public int m_flSequenceScale {                       get => *(int*)(addr + Offset.DT_EnvParticleScript.m_flSequenceScale);                       set => *(int*)(addr + Offset.DT_EnvParticleScript.m_flSequenceScale) = value;                       }

        }

        public class FogController : baseStructs
        {
            public static implicit operator FogController(IntPtr ptr) => new FogController() { addr = ptr                                                                                                                                                        };
            public int m_fog_enable {                            get => *(int*)(addr + Offset.DT_FogController.m_fog_enable);                                set => *(int*)(addr + Offset.DT_FogController.m_fog_enable) = value;                                }
            public int m_fog_blend {                             get => *(int*)(addr + Offset.DT_FogController.m_fog_blend);                                 set => *(int*)(addr + Offset.DT_FogController.m_fog_blend) = value;                                 }
            public int m_fog_dirPrimary {                        get => *(int*)(addr + Offset.DT_FogController.m_fog_dirPrimary);                            set => *(int*)(addr + Offset.DT_FogController.m_fog_dirPrimary) = value;                            }
            public int m_fog_colorPrimary {                      get => *(int*)(addr + Offset.DT_FogController.m_fog_colorPrimary);                          set => *(int*)(addr + Offset.DT_FogController.m_fog_colorPrimary) = value;                          }
            public int m_fog_colorSecondary {                    get => *(int*)(addr + Offset.DT_FogController.m_fog_colorSecondary);                        set => *(int*)(addr + Offset.DT_FogController.m_fog_colorSecondary) = value;                        }
            public int m_fog_start {                             get => *(int*)(addr + Offset.DT_FogController.m_fog_start);                                 set => *(int*)(addr + Offset.DT_FogController.m_fog_start) = value;                                 }
            public int m_fog_end {                               get => *(int*)(addr + Offset.DT_FogController.m_fog_end);                                   set => *(int*)(addr + Offset.DT_FogController.m_fog_end) = value;                                   }
            public int m_fog_farz {                              get => *(int*)(addr + Offset.DT_FogController.m_fog_farz);                                  set => *(int*)(addr + Offset.DT_FogController.m_fog_farz) = value;                                  }
            public int m_fog_maxdensity {                        get => *(int*)(addr + Offset.DT_FogController.m_fog_maxdensity);                            set => *(int*)(addr + Offset.DT_FogController.m_fog_maxdensity) = value;                            }
            public int m_fog_colorPrimaryLerpTo {                get => *(int*)(addr + Offset.DT_FogController.m_fog_colorPrimaryLerpTo);                    set => *(int*)(addr + Offset.DT_FogController.m_fog_colorPrimaryLerpTo) = value;                    }
            public int m_fog_colorSecondaryLerpTo {              get => *(int*)(addr + Offset.DT_FogController.m_fog_colorSecondaryLerpTo);                  set => *(int*)(addr + Offset.DT_FogController.m_fog_colorSecondaryLerpTo) = value;                  }
            public int m_fog_startLerpTo {                       get => *(int*)(addr + Offset.DT_FogController.m_fog_startLerpTo);                           set => *(int*)(addr + Offset.DT_FogController.m_fog_startLerpTo) = value;                           }
            public int m_fog_endLerpTo {                         get => *(int*)(addr + Offset.DT_FogController.m_fog_endLerpTo);                             set => *(int*)(addr + Offset.DT_FogController.m_fog_endLerpTo) = value;                             }
            public int m_fog_maxdensityLerpTo {                  get => *(int*)(addr + Offset.DT_FogController.m_fog_maxdensityLerpTo);                      set => *(int*)(addr + Offset.DT_FogController.m_fog_maxdensityLerpTo) = value;                      }
            public int m_fog_lerptime {                          get => *(int*)(addr + Offset.DT_FogController.m_fog_lerptime);                              set => *(int*)(addr + Offset.DT_FogController.m_fog_lerptime) = value;                              }
            public int m_fog_duration {                          get => *(int*)(addr + Offset.DT_FogController.m_fog_duration);                              set => *(int*)(addr + Offset.DT_FogController.m_fog_duration) = value;                              }
            public int m_fog_HDRColorScale {                     get => *(int*)(addr + Offset.DT_FogController.m_fog_HDRColorScale);                         set => *(int*)(addr + Offset.DT_FogController.m_fog_HDRColorScale) = value;                         }
            public int m_fog_ZoomFogScale {                      get => *(int*)(addr + Offset.DT_FogController.m_fog_ZoomFogScale);                          set => *(int*)(addr + Offset.DT_FogController.m_fog_ZoomFogScale) = value;                          }

        }

        public class EnvDOFController : baseStructs
        {
            public static implicit operator EnvDOFController(IntPtr ptr) => new EnvDOFController() { addr = ptr                                                                                                                                                  };
            public int m_bDOFEnabled {                           get => *(int*)(addr + Offset.DT_EnvDOFController.m_bDOFEnabled);                            set => *(int*)(addr + Offset.DT_EnvDOFController.m_bDOFEnabled) = value;                            }
            public int m_flNearBlurDepth {                       get => *(int*)(addr + Offset.DT_EnvDOFController.m_flNearBlurDepth);                        set => *(int*)(addr + Offset.DT_EnvDOFController.m_flNearBlurDepth) = value;                        }
            public int m_flNearFocusDepth {                      get => *(int*)(addr + Offset.DT_EnvDOFController.m_flNearFocusDepth);                       set => *(int*)(addr + Offset.DT_EnvDOFController.m_flNearFocusDepth) = value;                       }
            public int m_flFarFocusDepth {                       get => *(int*)(addr + Offset.DT_EnvDOFController.m_flFarFocusDepth);                        set => *(int*)(addr + Offset.DT_EnvDOFController.m_flFarFocusDepth) = value;                        }
            public int m_flFarBlurDepth {                        get => *(int*)(addr + Offset.DT_EnvDOFController.m_flFarBlurDepth);                         set => *(int*)(addr + Offset.DT_EnvDOFController.m_flFarBlurDepth) = value;                         }
            public int m_flNearBlurRadius {                      get => *(int*)(addr + Offset.DT_EnvDOFController.m_flNearBlurRadius);                       set => *(int*)(addr + Offset.DT_EnvDOFController.m_flNearBlurRadius) = value;                       }
            public int m_flFarBlurRadius {                       get => *(int*)(addr + Offset.DT_EnvDOFController.m_flFarBlurRadius);                        set => *(int*)(addr + Offset.DT_EnvDOFController.m_flFarBlurRadius) = value;                        }

        }

        public class CascadeLight : baseStructs
        {
            public static implicit operator CascadeLight(IntPtr ptr) => new CascadeLight() { addr = ptr                                                                                                                                                          };
            public int m_shadowDirection {                       get => *(int*)(addr + Offset.DT_CascadeLight.m_shadowDirection);                            set => *(int*)(addr + Offset.DT_CascadeLight.m_shadowDirection) = value;                            }
            public int m_envLightShadowDirection {               get => *(int*)(addr + Offset.DT_CascadeLight.m_envLightShadowDirection);                    set => *(int*)(addr + Offset.DT_CascadeLight.m_envLightShadowDirection) = value;                    }
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_CascadeLight.m_bEnabled);                                   set => *(int*)(addr + Offset.DT_CascadeLight.m_bEnabled) = value;                                   }
            public int m_bUseLightEnvAngles {                    get => *(int*)(addr + Offset.DT_CascadeLight.m_bUseLightEnvAngles);                         set => *(int*)(addr + Offset.DT_CascadeLight.m_bUseLightEnvAngles) = value;                         }
            public int m_LightColor {                            get => *(int*)(addr + Offset.DT_CascadeLight.m_LightColor);                                 set => *(int*)(addr + Offset.DT_CascadeLight.m_LightColor) = value;                                 }
            public int m_LightColorScale {                       get => *(int*)(addr + Offset.DT_CascadeLight.m_LightColorScale);                            set => *(int*)(addr + Offset.DT_CascadeLight.m_LightColorScale) = value;                            }
            public int m_flMaxShadowDist {                       get => *(int*)(addr + Offset.DT_CascadeLight.m_flMaxShadowDist);                            set => *(int*)(addr + Offset.DT_CascadeLight.m_flMaxShadowDist) = value;                            }

        }

        public class EnvAmbientLight : baseStructs
        {
            public static implicit operator EnvAmbientLight(IntPtr ptr) => new EnvAmbientLight() { addr = ptr                                                                                                                                                    };
            public int m_vecColor {                              get => *(int*)(addr + Offset.DT_EnvAmbientLight.m_vecColor);                                set => *(int*)(addr + Offset.DT_EnvAmbientLight.m_vecColor) = value;                                }

        }

        public class EntityParticleTrail : baseStructs
        {
            public static implicit operator EntityParticleTrail(IntPtr ptr) => new EntityParticleTrail() { addr = ptr                                                                                                                                            };
            public int m_iMaterialName {                         get => *(int*)(addr + Offset.DT_EntityParticleTrail.m_iMaterialName);                       set => *(int*)(addr + Offset.DT_EntityParticleTrail.m_iMaterialName) = value;                       }
            public int m_hConstraintEntity {                     get => *(int*)(addr + Offset.DT_EntityParticleTrail.m_hConstraintEntity);                   set => *(int*)(addr + Offset.DT_EntityParticleTrail.m_hConstraintEntity) = value;                   }
            public int m_flLifetime {                            get => *(int*)(addr + Offset.DT_EntityParticleTrail.m_flLifetime);                          set => *(int*)(addr + Offset.DT_EntityParticleTrail.m_flLifetime) = value;                          }
            public int m_flStartSize {                           get => *(int*)(addr + Offset.DT_EntityParticleTrail.m_flStartSize);                         set => *(int*)(addr + Offset.DT_EntityParticleTrail.m_flStartSize) = value;                         }
            public int m_flEndSize {                             get => *(int*)(addr + Offset.DT_EntityParticleTrail.m_flEndSize);                           set => *(int*)(addr + Offset.DT_EntityParticleTrail.m_flEndSize) = value;                           }
            public int m_Info {                                  get => *(int*)(addr + Offset.DT_EntityParticleTrail.m_Info);                                set => *(int*)(addr + Offset.DT_EntityParticleTrail.m_Info) = value;                                }

        }

        public class EntityFreezing : baseStructs
        {
            public static implicit operator EntityFreezing(IntPtr ptr) => new EntityFreezing() { addr = ptr                                                                                                                                                      };
            public int m_vFreezingOrigin {                       get => *(int*)(addr + Offset.DT_EntityFreezing.m_vFreezingOrigin);                          set => *(int*)(addr + Offset.DT_EntityFreezing.m_vFreezingOrigin) = value;                          }
            public int m_flFrozen {                              get => *(int*)(addr + Offset.DT_EntityFreezing.m_flFrozen);                                 set => *(int*)(addr + Offset.DT_EntityFreezing.m_flFrozen) = value;                                 }
            public int m_bFinishFreezing {                       get => *(int*)(addr + Offset.DT_EntityFreezing.m_bFinishFreezing);                          set => *(int*)(addr + Offset.DT_EntityFreezing.m_bFinishFreezing) = value;                          }
            public int m_flFrozenPerHitbox {                     get => *(int*)(addr + Offset.DT_EntityFreezing.m_flFrozenPerHitbox);                        set => *(int*)(addr + Offset.DT_EntityFreezing.m_flFrozenPerHitbox) = value;                        }

        }

        public class EntityFlame : baseStructs
        {
            public static implicit operator EntityFlame(IntPtr ptr) => new EntityFlame() { addr = ptr                                                                                                                                                            };
            public int m_hEntAttached {                          get => *(int*)(addr + Offset.DT_EntityFlame.m_hEntAttached);                                set => *(int*)(addr + Offset.DT_EntityFlame.m_hEntAttached) = value;                                }
            public int m_bCheapEffect {                          get => *(int*)(addr + Offset.DT_EntityFlame.m_bCheapEffect);                                set => *(int*)(addr + Offset.DT_EntityFlame.m_bCheapEffect) = value;                                }

        }

        public class EntityDissolve : baseStructs
        {
            public static implicit operator EntityDissolve(IntPtr ptr) => new EntityDissolve() { addr = ptr                                                                                                                                                      };
            public int m_flStartTime {                           get => *(int*)(addr + Offset.DT_EntityDissolve.m_flStartTime);                              set => *(int*)(addr + Offset.DT_EntityDissolve.m_flStartTime) = value;                              }
            public int m_flFadeOutStart {                        get => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutStart);                           set => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutStart) = value;                           }
            public int m_flFadeOutLength {                       get => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutLength);                          set => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutLength) = value;                          }
            public int m_flFadeOutModelStart {                   get => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutModelStart);                      set => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutModelStart) = value;                      }
            public int m_flFadeOutModelLength {                  get => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutModelLength);                     set => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeOutModelLength) = value;                     }
            public int m_flFadeInStart {                         get => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeInStart);                            set => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeInStart) = value;                            }
            public int m_flFadeInLength {                        get => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeInLength);                           set => *(int*)(addr + Offset.DT_EntityDissolve.m_flFadeInLength) = value;                           }
            public int m_nDissolveType {                         get => *(int*)(addr + Offset.DT_EntityDissolve.m_nDissolveType);                            set => *(int*)(addr + Offset.DT_EntityDissolve.m_nDissolveType) = value;                            }
            public int m_vDissolverOrigin {                      get => *(int*)(addr + Offset.DT_EntityDissolve.m_vDissolverOrigin);                         set => *(int*)(addr + Offset.DT_EntityDissolve.m_vDissolverOrigin) = value;                         }
            public int m_nMagnitude {                            get => *(int*)(addr + Offset.DT_EntityDissolve.m_nMagnitude);                               set => *(int*)(addr + Offset.DT_EntityDissolve.m_nMagnitude) = value;                               }

        }

        public class DynamicLight : baseStructs
        {
            public static implicit operator DynamicLight(IntPtr ptr) => new DynamicLight() { addr = ptr                                                                                                                                                          };
            public int m_Flags {                                 get => *(int*)(addr + Offset.DT_DynamicLight.m_Flags);                                      set => *(int*)(addr + Offset.DT_DynamicLight.m_Flags) = value;                                      }
            public int m_LightStyle {                            get => *(int*)(addr + Offset.DT_DynamicLight.m_LightStyle);                                 set => *(int*)(addr + Offset.DT_DynamicLight.m_LightStyle) = value;                                 }
            public int m_Radius {                                get => *(int*)(addr + Offset.DT_DynamicLight.m_Radius);                                     set => *(int*)(addr + Offset.DT_DynamicLight.m_Radius) = value;                                     }
            public int m_Exponent {                              get => *(int*)(addr + Offset.DT_DynamicLight.m_Exponent);                                   set => *(int*)(addr + Offset.DT_DynamicLight.m_Exponent) = value;                                   }
            public int m_InnerAngle {                            get => *(int*)(addr + Offset.DT_DynamicLight.m_InnerAngle);                                 set => *(int*)(addr + Offset.DT_DynamicLight.m_InnerAngle) = value;                                 }
            public int m_OuterAngle {                            get => *(int*)(addr + Offset.DT_DynamicLight.m_OuterAngle);                                 set => *(int*)(addr + Offset.DT_DynamicLight.m_OuterAngle) = value;                                 }
            public int m_SpotRadius {                            get => *(int*)(addr + Offset.DT_DynamicLight.m_SpotRadius);                                 set => *(int*)(addr + Offset.DT_DynamicLight.m_SpotRadius) = value;                                 }

        }

        public class ColorCorrectionVolume : baseStructs
        {
            public static implicit operator ColorCorrectionVolume(IntPtr ptr) => new ColorCorrectionVolume() { addr = ptr                                                                                                                                        };
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_bEnabled);                          set => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_bEnabled) = value;                          }
            public int m_MaxWeight {                             get => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_MaxWeight);                         set => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_MaxWeight) = value;                         }
            public int m_FadeDuration {                          get => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_FadeDuration);                      set => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_FadeDuration) = value;                      }
            public int m_Weight {                                get => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_Weight);                            set => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_Weight) = value;                            }
            public int m_lookupFilename {                        get => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_lookupFilename);                    set => *(int*)(addr + Offset.DT_ColorCorrectionVolume.m_lookupFilename) = value;                    }

        }

        public class ColorCorrection : baseStructs
        {
            public static implicit operator ColorCorrection(IntPtr ptr) => new ColorCorrection() { addr = ptr                                                                                                                                                    };
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_ColorCorrection.m_vecOrigin);                               set => *(int*)(addr + Offset.DT_ColorCorrection.m_vecOrigin) = value;                               }
            public int m_minFalloff {                            get => *(int*)(addr + Offset.DT_ColorCorrection.m_minFalloff);                              set => *(int*)(addr + Offset.DT_ColorCorrection.m_minFalloff) = value;                              }
            public int m_maxFalloff {                            get => *(int*)(addr + Offset.DT_ColorCorrection.m_maxFalloff);                              set => *(int*)(addr + Offset.DT_ColorCorrection.m_maxFalloff) = value;                              }
            public int m_flCurWeight {                           get => *(int*)(addr + Offset.DT_ColorCorrection.m_flCurWeight);                             set => *(int*)(addr + Offset.DT_ColorCorrection.m_flCurWeight) = value;                             }
            public int m_flMaxWeight {                           get => *(int*)(addr + Offset.DT_ColorCorrection.m_flMaxWeight);                             set => *(int*)(addr + Offset.DT_ColorCorrection.m_flMaxWeight) = value;                             }
            public int m_flFadeInDuration {                      get => *(int*)(addr + Offset.DT_ColorCorrection.m_flFadeInDuration);                        set => *(int*)(addr + Offset.DT_ColorCorrection.m_flFadeInDuration) = value;                        }
            public int m_flFadeOutDuration {                     get => *(int*)(addr + Offset.DT_ColorCorrection.m_flFadeOutDuration);                       set => *(int*)(addr + Offset.DT_ColorCorrection.m_flFadeOutDuration) = value;                       }
            public int m_netLookupFilename {                     get => *(int*)(addr + Offset.DT_ColorCorrection.m_netLookupFilename);                       set => *(int*)(addr + Offset.DT_ColorCorrection.m_netLookupFilename) = value;                       }
            public int m_bEnabled {                              get => *(int*)(addr + Offset.DT_ColorCorrection.m_bEnabled);                                set => *(int*)(addr + Offset.DT_ColorCorrection.m_bEnabled) = value;                                }
            public int m_bMaster {                               get => *(int*)(addr + Offset.DT_ColorCorrection.m_bMaster);                                 set => *(int*)(addr + Offset.DT_ColorCorrection.m_bMaster) = value;                                 }
            public int m_bClientSide {                           get => *(int*)(addr + Offset.DT_ColorCorrection.m_bClientSide);                             set => *(int*)(addr + Offset.DT_ColorCorrection.m_bClientSide) = value;                             }
            public int m_bExclusive {                            get => *(int*)(addr + Offset.DT_ColorCorrection.m_bExclusive);                              set => *(int*)(addr + Offset.DT_ColorCorrection.m_bExclusive) = value;                              }

        }

        public class BreakableProp : baseStructs
        {
            public static implicit operator BreakableProp(IntPtr ptr) => new BreakableProp() { addr = ptr                                                                                                                                                        };
            public int m_qPreferredPlayerCarryAngles {           get => *(int*)(addr + Offset.DT_BreakableProp.m_qPreferredPlayerCarryAngles);               set => *(int*)(addr + Offset.DT_BreakableProp.m_qPreferredPlayerCarryAngles) = value;               }
            public int m_bClientPhysics {                        get => *(int*)(addr + Offset.DT_BreakableProp.m_bClientPhysics);                            set => *(int*)(addr + Offset.DT_BreakableProp.m_bClientPhysics) = value;                            }

        }

        public class BeamSpotlight : baseStructs
        {
            public static implicit operator BeamSpotlight(IntPtr ptr) => new BeamSpotlight() { addr = ptr                                                                                                                                                        };
            public int m_nHaloIndex {                            get => *(int*)(addr + Offset.DT_BeamSpotlight.m_nHaloIndex);                                set => *(int*)(addr + Offset.DT_BeamSpotlight.m_nHaloIndex) = value;                                }
            public int m_bSpotlightOn {                          get => *(int*)(addr + Offset.DT_BeamSpotlight.m_bSpotlightOn);                              set => *(int*)(addr + Offset.DT_BeamSpotlight.m_bSpotlightOn) = value;                              }
            public int m_bHasDynamicLight {                      get => *(int*)(addr + Offset.DT_BeamSpotlight.m_bHasDynamicLight);                          set => *(int*)(addr + Offset.DT_BeamSpotlight.m_bHasDynamicLight) = value;                          }
            public int m_flSpotlightMaxLength {                  get => *(int*)(addr + Offset.DT_BeamSpotlight.m_flSpotlightMaxLength);                      set => *(int*)(addr + Offset.DT_BeamSpotlight.m_flSpotlightMaxLength) = value;                      }
            public int m_flSpotlightGoalWidth {                  get => *(int*)(addr + Offset.DT_BeamSpotlight.m_flSpotlightGoalWidth);                      set => *(int*)(addr + Offset.DT_BeamSpotlight.m_flSpotlightGoalWidth) = value;                      }
            public int m_flHDRColorScale {                       get => *(int*)(addr + Offset.DT_BeamSpotlight.m_flHDRColorScale);                           set => *(int*)(addr + Offset.DT_BeamSpotlight.m_flHDRColorScale) = value;                           }
            public int m_nRotationAxis {                         get => *(int*)(addr + Offset.DT_BeamSpotlight.m_nRotationAxis);                             set => *(int*)(addr + Offset.DT_BeamSpotlight.m_nRotationAxis) = value;                             }
            public int m_flRotationSpeed {                       get => *(int*)(addr + Offset.DT_BeamSpotlight.m_flRotationSpeed);                           set => *(int*)(addr + Offset.DT_BeamSpotlight.m_flRotationSpeed) = value;                           }

        }

        public class BaseButton : baseStructs
        {
            public static implicit operator BaseButton(IntPtr ptr) => new BaseButton() { addr = ptr                                                                                                                                                              };
            public int m_usable {                                get => *(int*)(addr + Offset.DT_BaseButton.m_usable);                                       set => *(int*)(addr + Offset.DT_BaseButton.m_usable) = value;                                       }

        }

        public class BaseToggle : baseStructs
        {
            public static implicit operator BaseToggle(IntPtr ptr) => new BaseToggle() { addr = ptr                                                                                                                                                              };
            public int m_vecFinalDest {                          get => *(int*)(addr + Offset.DT_BaseToggle.m_vecFinalDest);                                 set => *(int*)(addr + Offset.DT_BaseToggle.m_vecFinalDest) = value;                                 }
            public int m_movementType {                          get => *(int*)(addr + Offset.DT_BaseToggle.m_movementType);                                 set => *(int*)(addr + Offset.DT_BaseToggle.m_movementType) = value;                                 }
            public int m_flMoveTargetTime {                      get => *(int*)(addr + Offset.DT_BaseToggle.m_flMoveTargetTime);                             set => *(int*)(addr + Offset.DT_BaseToggle.m_flMoveTargetTime) = value;                             }

        }

        public class BasePlayer : CSPlayer
        {
            bool did = false;

            // Not working at all
            public Vector GetHitboxPos(Hitboxes hitbox)
            {
                return new Vector();

                if (!did)
                {
                    var matrix = Marshal.AllocHGlobal(48);
                    Console.WriteLine(matrix);
                    if(matrix != IntPtr.Zero)
                    {
                        Console.WriteLine("call with addr:" + matrix);
                        var a = SetupBone(matrix, 128, 256, 0.0f);
                        Console.WriteLine("ret:" + a);
                        Marshal.FreeHGlobal(matrix);
                    }

                    did = true;
                    return new Vector();
                }
                /*
                if (SetupBone(matrix, 128, 256, 0.0f))
                {
                    var studio_model = g_MdlInfo.GetStudioModel(GetModel());
                    var hitbox_id = studio_model->GetHitboxSet(0)->GetHitbox((int)hitbox);
                    Console.WriteLine(hitbox_id->bone);
                    Console.WriteLine(*(Vector*)matrix);

                    return new Vector();
                }
                */
                Console.WriteLine("failed");
                return new Vector();
            }


            public int BoneMatrix
            {
                get => this + Offset.dwBoneMatrix;
            }

            public Vector GetBonePos(int i) => new Vector(
                X: *(float*)(BoneMatrix + 0x30 * i + 0x0c),
                Y: *(float*)(BoneMatrix + 0x30 * i + 0x1c),
                Z: *(float*)(BoneMatrix + 0x30 * i + 0x2c));

            public Vector m_vecEyePos { get => m_vecOrigin + m_vecViewOffset; }
            public bool isAlive { get => m_iHealth > 0; }
            public bool isEnemy { get => m_iTeamNum != g_LocalPlayer.m_iTeamNum; }

            public static implicit operator BasePlayer(IntPtr ptr) => new BasePlayer() { addr = ptr                                                                                                                                                              };
            public int m_iFOV {                                  get => *(int*)(addr + Offset.DT_BasePlayer.m_iFOV);                                         set => *(int*)(addr + Offset.DT_BasePlayer.m_iFOV) = value;                                         }
            public int m_iFOVStart {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_iFOVStart);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_iFOVStart) = value;                                    }
            public int m_flFOVTime {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_flFOVTime);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_flFOVTime) = value;                                    }
            public int m_iDefaultFOV {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_iDefaultFOV);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_iDefaultFOV) = value;                                  }
            public int m_hZoomOwner {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_hZoomOwner);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_hZoomOwner) = value;                                   }
            public int m_afPhysicsFlags {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_afPhysicsFlags);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_afPhysicsFlags) = value;                               }
            public int m_hVehicle {                              get => *(int*)(addr + Offset.DT_BasePlayer.m_hVehicle);                                     set => *(int*)(addr + Offset.DT_BasePlayer.m_hVehicle) = value;                                     }
            public int m_hUseEntity {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_hUseEntity);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_hUseEntity) = value;                                   }
            public int m_hGroundEntity {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_hGroundEntity);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_hGroundEntity) = value;                                }
            public int m_iHealth {                               get => *(int*)(addr + Offset.DT_BasePlayer.m_iHealth);                                      set => *(int*)(addr + Offset.DT_BasePlayer.m_iHealth) = value;                                      }
            public int m_lifeState {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_lifeState);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_lifeState) = value;                                    }
            public int m_iBonusProgress {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_iBonusProgress);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_iBonusProgress) = value;                               }
            public int m_iBonusChallenge {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_iBonusChallenge);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_iBonusChallenge) = value;                              }
            public int m_flMaxspeed {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_flMaxspeed);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_flMaxspeed) = value;                                   }
            public int m_fFlags {                                get => *(int*)(addr + Offset.DT_BasePlayer.m_fFlags);                                       set => *(int*)(addr + Offset.DT_BasePlayer.m_fFlags) = value;                                       }
            public int m_iObserverMode {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_iObserverMode);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_iObserverMode) = value;                                }
            public int m_bActiveCameraMan {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_bActiveCameraMan);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_bActiveCameraMan) = value;                             }
            public int m_bCameraManXRay {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_bCameraManXRay);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_bCameraManXRay) = value;                               }
            public int m_bCameraManOverview {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_bCameraManOverview);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_bCameraManOverview) = value;                           }
            public int m_bCameraManScoreBoard {                  get => *(int*)(addr + Offset.DT_BasePlayer.m_bCameraManScoreBoard);                         set => *(int*)(addr + Offset.DT_BasePlayer.m_bCameraManScoreBoard) = value;                         }
            public int m_uCameraManGraphs {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_uCameraManGraphs);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_uCameraManGraphs) = value;                             }
            public int m_iDeathPostEffect {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_iDeathPostEffect);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_iDeathPostEffect) = value;                             }
            public int m_hObserverTarget {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_hObserverTarget);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_hObserverTarget) = value;                              }
            public int m_hViewModel_0 {                          get => *(int*)(addr + Offset.DT_BasePlayer.m_hViewModel_0);                                 set => *(int*)(addr + Offset.DT_BasePlayer.m_hViewModel_0) = value;                                 }
            public int m_hViewModel {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_hViewModel);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_hViewModel) = value;                                   }
            public int m_iCoachingTeam {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_iCoachingTeam);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_iCoachingTeam) = value;                                }
            public int m_szLastPlaceName {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_szLastPlaceName);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_szLastPlaceName) = value;                              }
            public int m_vecLadderNormal {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_vecLadderNormal);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_vecLadderNormal) = value;                              }
            public int m_ladderSurfaceProps {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_ladderSurfaceProps);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_ladderSurfaceProps) = value;                           }
            public int m_ubEFNoInterpParity {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_ubEFNoInterpParity);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_ubEFNoInterpParity) = value;                           }
            public int m_hPostProcessCtrl {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_hPostProcessCtrl);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_hPostProcessCtrl) = value;                             }
            public int m_hColorCorrectionCtrl {                  get => *(int*)(addr + Offset.DT_BasePlayer.m_hColorCorrectionCtrl);                         set => *(int*)(addr + Offset.DT_BasePlayer.m_hColorCorrectionCtrl) = value;                         }
            public int m_PlayerFog_m_hCtrl {                     get => *(int*)(addr + Offset.DT_BasePlayer.m_PlayerFog_m_hCtrl);                            set => *(int*)(addr + Offset.DT_BasePlayer.m_PlayerFog_m_hCtrl) = value;                            }
            public int m_vphysicsCollisionState {                get => *(int*)(addr + Offset.DT_BasePlayer.m_vphysicsCollisionState);                       set => *(int*)(addr + Offset.DT_BasePlayer.m_vphysicsCollisionState) = value;                       }
            public int m_hViewEntity {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_hViewEntity);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_hViewEntity) = value;                                  }
            public int m_bShouldDrawPlayerWhileUsingViewEntity { get => *(int*)(addr + Offset.DT_BasePlayer.m_bShouldDrawPlayerWhileUsingViewEntity);        set => *(int*)(addr + Offset.DT_BasePlayer.m_bShouldDrawPlayerWhileUsingViewEntity) = value;        }
            public int m_flDuckAmount {                          get => *(int*)(addr + Offset.DT_BasePlayer.m_flDuckAmount);                                 set => *(int*)(addr + Offset.DT_BasePlayer.m_flDuckAmount) = value;                                 }
            public int m_flDuckSpeed {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_flDuckSpeed);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_flDuckSpeed) = value;                                  }
            public int m_nWaterLevel {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_nWaterLevel);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_nWaterLevel) = value;                                  }
            public Vector m_vecViewOffset {                      get => *(Vector*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_0);                           set => *(Vector*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_0) = value;                           }
            public int m_vecViewOffset_0 {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_0);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_0) = value;                              }
            public int m_vecViewOffset_1 {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_1);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_1) = value;                              }
            public int m_vecViewOffset_2 {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_2);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_vecViewOffset_2) = value;                              }
            public int m_flFriction {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_flFriction);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_flFriction) = value;                                   }
            public int m_fOnTarget {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_fOnTarget);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_fOnTarget) = value;                                    }
            public int m_nTickBase {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_nTickBase);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_nTickBase) = value;                                    }
            public int m_nNextThinkTick {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_nNextThinkTick);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_nNextThinkTick) = value;                               }
            public int m_hLastWeapon {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_hLastWeapon);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_hLastWeapon) = value;                                  }
            public int m_vecVelocity_0 {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_vecVelocity_0);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_vecVelocity_0) = value;                                }
            public int m_vecVelocity_1 {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_vecVelocity_1);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_vecVelocity_1) = value;                                }
            public int m_vecVelocity_2 {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_vecVelocity_2);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_vecVelocity_2) = value;                                }
            public int m_vecBaseVelocity {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_vecBaseVelocity);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_vecBaseVelocity) = value;                              }
            public int m_hConstraintEntity {                     get => *(int*)(addr + Offset.DT_BasePlayer.m_hConstraintEntity);                            set => *(int*)(addr + Offset.DT_BasePlayer.m_hConstraintEntity) = value;                            }
            public int m_vecConstraintCenter {                   get => *(int*)(addr + Offset.DT_BasePlayer.m_vecConstraintCenter);                          set => *(int*)(addr + Offset.DT_BasePlayer.m_vecConstraintCenter) = value;                          }
            public int m_flConstraintRadius {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_flConstraintRadius);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_flConstraintRadius) = value;                           }
            public int m_flConstraintWidth {                     get => *(int*)(addr + Offset.DT_BasePlayer.m_flConstraintWidth);                            set => *(int*)(addr + Offset.DT_BasePlayer.m_flConstraintWidth) = value;                            }
            public int m_flConstraintSpeedFactor {               get => *(int*)(addr + Offset.DT_BasePlayer.m_flConstraintSpeedFactor);                      set => *(int*)(addr + Offset.DT_BasePlayer.m_flConstraintSpeedFactor) = value;                      }
            public int m_bConstraintPastRadius {                 get => *(int*)(addr + Offset.DT_BasePlayer.m_bConstraintPastRadius);                        set => *(int*)(addr + Offset.DT_BasePlayer.m_bConstraintPastRadius) = value;                        }
            public int m_flDeathTime {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_flDeathTime);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_flDeathTime) = value;                                  }
            public int m_flNextDecalTime {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_flNextDecalTime);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_flNextDecalTime) = value;                              }
            public int m_fForceTeam {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_fForceTeam);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_fForceTeam) = value;                                   }
            public int m_flLaggedMovementValue {                 get => *(int*)(addr + Offset.DT_BasePlayer.m_flLaggedMovementValue);                        set => *(int*)(addr + Offset.DT_BasePlayer.m_flLaggedMovementValue) = value;                        }
            public int m_hTonemapController {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_hTonemapController);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_hTonemapController) = value;                           }
            public int m_iHideHUD {                              get => *(int*)(addr + Offset.DT_BasePlayer.m_iHideHUD);                                     set => *(int*)(addr + Offset.DT_BasePlayer.m_iHideHUD) = value;                                     }
            public int m_flFOVRate {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_flFOVRate);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_flFOVRate) = value;                                    }
            public int m_bDucked {                               get => *(int*)(addr + Offset.DT_BasePlayer.m_bDucked);                                      set => *(int*)(addr + Offset.DT_BasePlayer.m_bDucked) = value;                                      }
            public int m_bDucking {                              get => *(int*)(addr + Offset.DT_BasePlayer.m_bDucking);                                     set => *(int*)(addr + Offset.DT_BasePlayer.m_bDucking) = value;                                     }
            public int m_flLastDuckTime {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_flLastDuckTime);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_flLastDuckTime) = value;                               }
            public int m_bInDuckJump {                           get => *(int*)(addr + Offset.DT_BasePlayer.m_bInDuckJump);                                  set => *(int*)(addr + Offset.DT_BasePlayer.m_bInDuckJump) = value;                                  }
            public int m_nDuckTimeMsecs {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_nDuckTimeMsecs);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_nDuckTimeMsecs) = value;                               }
            public int m_nDuckJumpTimeMsecs {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_nDuckJumpTimeMsecs);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_nDuckJumpTimeMsecs) = value;                           }
            public int m_nJumpTimeMsecs {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_nJumpTimeMsecs);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_nJumpTimeMsecs) = value;                               }
            public int m_flFallVelocity {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_flFallVelocity);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_flFallVelocity) = value;                               }
            public int m_viewPunchAngle {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_viewPunchAngle);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_viewPunchAngle) = value;                               }
            public Vector m_aimPunchAngle {                         get => *(Vector*)(addr + Offset.DT_BasePlayer.m_aimPunchAngle);                                set => *(Vector*)(addr + Offset.DT_BasePlayer.m_aimPunchAngle) = value;                                }
            public int m_aimPunchAngleVel {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_aimPunchAngleVel);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_aimPunchAngleVel) = value;                             }
            public int m_bDrawViewmodel {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_bDrawViewmodel);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_bDrawViewmodel) = value;                               }
            public int m_bWearingSuit {                          get => *(int*)(addr + Offset.DT_BasePlayer.m_bWearingSuit);                                 set => *(int*)(addr + Offset.DT_BasePlayer.m_bWearingSuit) = value;                                 }
            public int m_bPoisoned {                             get => *(int*)(addr + Offset.DT_BasePlayer.m_bPoisoned);                                    set => *(int*)(addr + Offset.DT_BasePlayer.m_bPoisoned) = value;                                    }
            public int m_flStepSize {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_flStepSize);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_flStepSize) = value;                                   }
            public int m_bAllowAutoMovement {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_bAllowAutoMovement);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_bAllowAutoMovement) = value;                           }
            public int m_skybox3d_scale {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_scale);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_scale) = value;                               }
            public int m_skybox3d_origin {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_origin);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_origin) = value;                              }
            public int m_skybox3d_area {                         get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_area);                                set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_area) = value;                                }
            public int m_skybox3d_fog_enable {                   get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_enable);                          set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_enable) = value;                          }
            public int m_skybox3d_fog_blend {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_blend);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_blend) = value;                           }
            public int m_skybox3d_fog_dirPrimary {               get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_dirPrimary);                      set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_dirPrimary) = value;                      }
            public int m_skybox3d_fog_colorPrimary {             get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_colorPrimary);                    set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_colorPrimary) = value;                    }
            public int m_skybox3d_fog_colorSecondary {           get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_colorSecondary);                  set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_colorSecondary) = value;                  }
            public int m_skybox3d_fog_start {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_start);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_start) = value;                           }
            public int m_skybox3d_fog_end {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_end);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_end) = value;                             }
            public int m_skybox3d_fog_maxdensity {               get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_maxdensity);                      set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_maxdensity) = value;                      }
            public int m_skybox3d_fog_HDRColorScale {            get => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_HDRColorScale);                   set => *(int*)(addr + Offset.DT_BasePlayer.m_skybox3d_fog_HDRColorScale) = value;                   }
            public int m_audio_localSound_0 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_0);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_0) = value;                           }
            public int m_audio_localSound_1 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_1);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_1) = value;                           }
            public int m_audio_localSound_2 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_2);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_2) = value;                           }
            public int m_audio_localSound_3 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_3);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_3) = value;                           }
            public int m_audio_localSound_4 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_4);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_4) = value;                           }
            public int m_audio_localSound_5 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_5);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_5) = value;                           }
            public int m_audio_localSound_6 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_6);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_6) = value;                           }
            public int m_audio_localSound_7 {                    get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_7);                           set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localSound_7) = value;                           }
            public int m_audio_soundscapeIndex {                 get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_soundscapeIndex);                        set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_soundscapeIndex) = value;                        }
            public int m_audio_localBits {                       get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localBits);                              set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_localBits) = value;                              }
            public int m_audio_entIndex {                        get => *(int*)(addr + Offset.DT_BasePlayer.m_audio_entIndex);                               set => *(int*)(addr + Offset.DT_BasePlayer.m_audio_entIndex) = value;                               }
            public int m_chAreaBits {                            get => *(int*)(addr + Offset.DT_BasePlayer.m_chAreaBits);                                   set => *(int*)(addr + Offset.DT_BasePlayer.m_chAreaBits) = value;                                   }
            public int m_chAreaPortalBits {                      get => *(int*)(addr + Offset.DT_BasePlayer.m_chAreaPortalBits);                             set => *(int*)(addr + Offset.DT_BasePlayer.m_chAreaPortalBits) = value;                             }
            public int m_Local {                                 get => *(int*)(addr + Offset.DT_BasePlayer.m_Local);                                        set => *(int*)(addr + Offset.DT_BasePlayer.m_Local) = value;                                        }
            public int localdata {                               get => *(int*)(addr + Offset.DT_BasePlayer.localdata);                                      set => *(int*)(addr + Offset.DT_BasePlayer.localdata) = value;                                      }
            public int deadflag {                                get => *(int*)(addr + Offset.DT_BasePlayer.deadflag);                                       set => *(int*)(addr + Offset.DT_BasePlayer.deadflag) = value;                                       }
            public int pl {                                      get => *(int*)(addr + Offset.DT_BasePlayer.pl);                                             set => *(int*)(addr + Offset.DT_BasePlayer.pl) = value;                                             }
            public int m_iAmmo {                                 get => *(int*)(addr + Offset.DT_BasePlayer.m_iAmmo);                                        set => *(int*)(addr + Offset.DT_BasePlayer.m_iAmmo) = value;                                        }

            public IntPtr* m_hMyWeapons { get => (IntPtr*)(addr + Offset.DT_BaseCombatCharacter.m_hMyWeapons); }
        }

        public class BaseFlex : baseStructs
        {
            public static implicit operator BaseFlex(IntPtr ptr) => new BaseFlex() { addr = ptr                                                                                                                                                                  };
            public int m_blinktoggle {                           get => *(int*)(addr + Offset.DT_BaseFlex.m_blinktoggle);                                    set => *(int*)(addr + Offset.DT_BaseFlex.m_blinktoggle) = value;                                    }
            public int m_viewtarget {                            get => *(int*)(addr + Offset.DT_BaseFlex.m_viewtarget);                                     set => *(int*)(addr + Offset.DT_BaseFlex.m_viewtarget) = value;                                     }
            public int m_flexWeight {                            get => *(int*)(addr + Offset.DT_BaseFlex.m_flexWeight);                                     set => *(int*)(addr + Offset.DT_BaseFlex.m_flexWeight) = value;                                     }

        }

        public class BaseEntity : IClientNetworkable
        {
            public static implicit operator BaseEntity(IntPtr ptr) => new BaseEntity() { addr = ptr                                                                                                                                                              };
            public int m_flSimulationTime {                      get => *(int*)(addr + Offset.DT_BaseEntity.m_flSimulationTime);                             set => *(int*)(addr + Offset.DT_BaseEntity.m_flSimulationTime) = value;                             }
            public int m_cellbits {                              get => *(int*)(addr + Offset.DT_BaseEntity.m_cellbits);                                     set => *(int*)(addr + Offset.DT_BaseEntity.m_cellbits) = value;                                     }
            public int m_cellX {                                 get => *(int*)(addr + Offset.DT_BaseEntity.m_cellX);                                        set => *(int*)(addr + Offset.DT_BaseEntity.m_cellX) = value;                                        }
            public int m_cellY {                                 get => *(int*)(addr + Offset.DT_BaseEntity.m_cellY);                                        set => *(int*)(addr + Offset.DT_BaseEntity.m_cellY) = value;                                        }
            public int m_cellZ {                                 get => *(int*)(addr + Offset.DT_BaseEntity.m_cellZ);                                        set => *(int*)(addr + Offset.DT_BaseEntity.m_cellZ) = value;                                        }
            public Vector m_vecOrigin {                          get => *(Vector*)(addr + Offset.DT_BaseEntity.m_vecOrigin);                                 set => *(Vector*)(addr + Offset.DT_BaseEntity.m_vecOrigin) = value;                                 }
            public int m_angRotation {                           get => *(int*)(addr + Offset.DT_BaseEntity.m_angRotation);                                  set => *(int*)(addr + Offset.DT_BaseEntity.m_angRotation) = value;                                  }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_BaseEntity.m_nModelIndex);                                  set => *(int*)(addr + Offset.DT_BaseEntity.m_nModelIndex) = value;                                  }
            public int m_fEffects {                              get => *(int*)(addr + Offset.DT_BaseEntity.m_fEffects);                                     set => *(int*)(addr + Offset.DT_BaseEntity.m_fEffects) = value;                                     }
            public int m_nRenderMode {                           get => *(int*)(addr + Offset.DT_BaseEntity.m_nRenderMode);                                  set => *(int*)(addr + Offset.DT_BaseEntity.m_nRenderMode) = value;                                  }
            public int m_nRenderFX {                             get => *(int*)(addr + Offset.DT_BaseEntity.m_nRenderFX);                                    set => *(int*)(addr + Offset.DT_BaseEntity.m_nRenderFX) = value;                                    }
            public int m_clrRender {                             get => *(int*)(addr + Offset.DT_BaseEntity.m_clrRender);                                    set => *(int*)(addr + Offset.DT_BaseEntity.m_clrRender) = value;                                    }
            public int m_iTeamNum {                              get => *(int*)(addr + Offset.DT_BaseEntity.m_iTeamNum);                                     set => *(int*)(addr + Offset.DT_BaseEntity.m_iTeamNum) = value;                                     }
            public int m_iPendingTeamNum {                       get => *(int*)(addr + Offset.DT_BaseEntity.m_iPendingTeamNum);                              set => *(int*)(addr + Offset.DT_BaseEntity.m_iPendingTeamNum) = value;                              }
            public int m_CollisionGroup {                        get => *(int*)(addr + Offset.DT_BaseEntity.m_CollisionGroup);                               set => *(int*)(addr + Offset.DT_BaseEntity.m_CollisionGroup) = value;                               }
            public int m_flElasticity {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_flElasticity);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_flElasticity) = value;                                 }
            public int m_flShadowCastDistance {                  get => *(int*)(addr + Offset.DT_BaseEntity.m_flShadowCastDistance);                         set => *(int*)(addr + Offset.DT_BaseEntity.m_flShadowCastDistance) = value;                         }
            public int m_hOwnerEntity {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_hOwnerEntity);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_hOwnerEntity) = value;                                 }
            public int m_hEffectEntity {                         get => *(int*)(addr + Offset.DT_BaseEntity.m_hEffectEntity);                                set => *(int*)(addr + Offset.DT_BaseEntity.m_hEffectEntity) = value;                                }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_BaseEntity.moveparent);                                     set => *(int*)(addr + Offset.DT_BaseEntity.moveparent) = value;                                     }
            public int m_iParentAttachment {                     get => *(int*)(addr + Offset.DT_BaseEntity.m_iParentAttachment);                            set => *(int*)(addr + Offset.DT_BaseEntity.m_iParentAttachment) = value;                            }
            public int m_iName {                                 get => *(int*)(addr + Offset.DT_BaseEntity.m_iName);                                        set => *(int*)(addr + Offset.DT_BaseEntity.m_iName) = value;                                        }
            public int movetype {                                get => *(int*)(addr + Offset.DT_BaseEntity.movetype);                                       set => *(int*)(addr + Offset.DT_BaseEntity.movetype) = value;                                       }
            public int movecollide {                             get => *(int*)(addr + Offset.DT_BaseEntity.movecollide);                                    set => *(int*)(addr + Offset.DT_BaseEntity.movecollide) = value;                                    }
            public int m_iTextureFrameIndex {                    get => *(int*)(addr + Offset.DT_BaseEntity.m_iTextureFrameIndex);                           set => *(int*)(addr + Offset.DT_BaseEntity.m_iTextureFrameIndex) = value;                           }
            public int m_bSimulatedEveryTick {                   get => *(int*)(addr + Offset.DT_BaseEntity.m_bSimulatedEveryTick);                          set => *(int*)(addr + Offset.DT_BaseEntity.m_bSimulatedEveryTick) = value;                          }
            public int m_bAnimatedEveryTick {                    get => *(int*)(addr + Offset.DT_BaseEntity.m_bAnimatedEveryTick);                           set => *(int*)(addr + Offset.DT_BaseEntity.m_bAnimatedEveryTick) = value;                           }
            public int m_bAlternateSorting {                     get => *(int*)(addr + Offset.DT_BaseEntity.m_bAlternateSorting);                            set => *(int*)(addr + Offset.DT_BaseEntity.m_bAlternateSorting) = value;                            }
            public int m_bSpotted {                              get => *(int*)(addr + Offset.DT_BaseEntity.m_bSpotted);                                     set => *(int*)(addr + Offset.DT_BaseEntity.m_bSpotted) = value;                                     }
            public int m_bIsAutoaimTarget {                      get => *(int*)(addr + Offset.DT_BaseEntity.m_bIsAutoaimTarget);                             set => *(int*)(addr + Offset.DT_BaseEntity.m_bIsAutoaimTarget) = value;                             }
            public int m_fadeMinDist {                           get => *(int*)(addr + Offset.DT_BaseEntity.m_fadeMinDist);                                  set => *(int*)(addr + Offset.DT_BaseEntity.m_fadeMinDist) = value;                                  }
            public int m_fadeMaxDist {                           get => *(int*)(addr + Offset.DT_BaseEntity.m_fadeMaxDist);                                  set => *(int*)(addr + Offset.DT_BaseEntity.m_fadeMaxDist) = value;                                  }
            public int m_flFadeScale {                           get => *(int*)(addr + Offset.DT_BaseEntity.m_flFadeScale);                                  set => *(int*)(addr + Offset.DT_BaseEntity.m_flFadeScale) = value;                                  }
            public int m_nMinCPULevel {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_nMinCPULevel);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_nMinCPULevel) = value;                                 }
            public int m_nMaxCPULevel {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_nMaxCPULevel);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_nMaxCPULevel) = value;                                 }
            public int m_nMinGPULevel {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_nMinGPULevel);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_nMinGPULevel) = value;                                 }
            public int m_nMaxGPULevel {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_nMaxGPULevel);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_nMaxGPULevel) = value;                                 }
            public int m_flUseLookAtAngle {                      get => *(int*)(addr + Offset.DT_BaseEntity.m_flUseLookAtAngle);                             set => *(int*)(addr + Offset.DT_BaseEntity.m_flUseLookAtAngle) = value;                             }
            public int m_flLastMadeNoiseTime {                   get => *(int*)(addr + Offset.DT_BaseEntity.m_flLastMadeNoiseTime);                          set => *(int*)(addr + Offset.DT_BaseEntity.m_flLastMadeNoiseTime) = value;                          }
            public int m_flMaxFallVelocity {                     get => *(int*)(addr + Offset.DT_BaseEntity.m_flMaxFallVelocity);                            set => *(int*)(addr + Offset.DT_BaseEntity.m_flMaxFallVelocity) = value;                            }
            public int m_bEligibleForScreenHighlight {           get => *(int*)(addr + Offset.DT_BaseEntity.m_bEligibleForScreenHighlight);                  set => *(int*)(addr + Offset.DT_BaseEntity.m_bEligibleForScreenHighlight) = value;                  }
            public int m_flAnimTime {                            get => *(int*)(addr + Offset.DT_BaseEntity.m_flAnimTime);                                   set => *(int*)(addr + Offset.DT_BaseEntity.m_flAnimTime) = value;                                   }
            public int AnimTimeMustBeFirst {                     get => *(int*)(addr + Offset.DT_BaseEntity.AnimTimeMustBeFirst);                            set => *(int*)(addr + Offset.DT_BaseEntity.AnimTimeMustBeFirst) = value;                            }
            public int m_vecMins {                               get => *(int*)(addr + Offset.DT_BaseEntity.m_vecMins);                                      set => *(int*)(addr + Offset.DT_BaseEntity.m_vecMins) = value;                                      }
            public int m_vecMaxs {                               get => *(int*)(addr + Offset.DT_BaseEntity.m_vecMaxs);                                      set => *(int*)(addr + Offset.DT_BaseEntity.m_vecMaxs) = value;                                      }
            public int m_nSolidType {                            get => *(int*)(addr + Offset.DT_BaseEntity.m_nSolidType);                                   set => *(int*)(addr + Offset.DT_BaseEntity.m_nSolidType) = value;                                   }
            public int m_usSolidFlags {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_usSolidFlags);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_usSolidFlags) = value;                                 }
            public int m_nSurroundType {                         get => *(int*)(addr + Offset.DT_BaseEntity.m_nSurroundType);                                set => *(int*)(addr + Offset.DT_BaseEntity.m_nSurroundType) = value;                                }
            public int m_triggerBloat {                          get => *(int*)(addr + Offset.DT_BaseEntity.m_triggerBloat);                                 set => *(int*)(addr + Offset.DT_BaseEntity.m_triggerBloat) = value;                                 }
            public int m_vecSpecifiedSurroundingMins {           get => *(int*)(addr + Offset.DT_BaseEntity.m_vecSpecifiedSurroundingMins);                  set => *(int*)(addr + Offset.DT_BaseEntity.m_vecSpecifiedSurroundingMins) = value;                  }
            public int m_vecSpecifiedSurroundingMaxs {           get => *(int*)(addr + Offset.DT_BaseEntity.m_vecSpecifiedSurroundingMaxs);                  set => *(int*)(addr + Offset.DT_BaseEntity.m_vecSpecifiedSurroundingMaxs) = value;                  }
            public int m_Collision {                             get => *(int*)(addr + Offset.DT_BaseEntity.m_Collision);                                    set => *(int*)(addr + Offset.DT_BaseEntity.m_Collision) = value;                                    }
            public int m_bSpottedBy {                            get => *(int*)(addr + Offset.DT_BaseEntity.m_bSpottedBy);                                   set => *(int*)(addr + Offset.DT_BaseEntity.m_bSpottedBy) = value;                                   }
            public int m_bSpottedByMask {                        get => *(int*)(addr + Offset.DT_BaseEntity.m_bSpottedByMask);                               set => *(int*)(addr + Offset.DT_BaseEntity.m_bSpottedByMask) = value;                               }

        }

        public class BaseDoor : baseStructs
        {
            public static implicit operator BaseDoor(IntPtr ptr) => new BaseDoor() { addr = ptr                                                                                                                                                                  };
            public int m_flWaveHeight {                          get => *(int*)(addr + Offset.DT_BaseDoor.m_flWaveHeight);                                   set => *(int*)(addr + Offset.DT_BaseDoor.m_flWaveHeight) = value;                                   }

        }

        public class BaseCombatCharacter : BaseEntity
        {
            public static implicit operator BaseCombatCharacter(IntPtr ptr) => new BaseCombatCharacter() { addr = ptr                                                                                                                                            };
            public int m_LastHitGroup {                          get => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_LastHitGroup);                        set => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_LastHitGroup) = value;                        }
            public int m_hActiveWeapon {                         get => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_hActiveWeapon);                       set => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_hActiveWeapon) = value;                       }
            public int m_flTimeOfLastInjury {                    get => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_flTimeOfLastInjury);                  set => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_flTimeOfLastInjury) = value;                  }
            public int m_nRelativeDirectionOfLastInjury {        get => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_nRelativeDirectionOfLastInjury);      set => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_nRelativeDirectionOfLastInjury) = value;      }
            public int m_flNextAttack {                          get => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_flNextAttack);                        set => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_flNextAttack) = value;                        }
            public int bcc_localdata {                           get => *(int*)(addr + Offset.DT_BaseCombatCharacter.bcc_localdata);                         set => *(int*)(addr + Offset.DT_BaseCombatCharacter.bcc_localdata) = value;                         }
            public int bcc_nonlocaldata {                        get => *(int*)(addr + Offset.DT_BaseCombatCharacter.bcc_nonlocaldata);                      set => *(int*)(addr + Offset.DT_BaseCombatCharacter.bcc_nonlocaldata) = value;                      }
            public int m_hMyWeapons {                            get => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_hMyWeapons);                          set => *(int*)(addr + Offset.DT_BaseCombatCharacter.m_hMyWeapons) = value;                          }
            public IntPtr* m_hMyWearables {                      get => (IntPtr*)(addr + Offset.DT_BaseCombatCharacter.m_hMyWearables); }

        }

        public class BoneFollower : baseStructs
        {
            public static implicit operator BoneFollower(IntPtr ptr) => new BoneFollower() { addr = ptr                                                                                                                                                          };
            public int m_modelIndex {                            get => *(int*)(addr + Offset.DT_BoneFollower.m_modelIndex);                                 set => *(int*)(addr + Offset.DT_BoneFollower.m_modelIndex) = value;                                 }
            public int m_solidIndex {                            get => *(int*)(addr + Offset.DT_BoneFollower.m_solidIndex);                                 set => *(int*)(addr + Offset.DT_BoneFollower.m_solidIndex) = value;                                 }

        }

        public class BaseAnimating : baseStructs
        {
            public static implicit operator BaseAnimating(IntPtr ptr) => new BaseAnimating() { addr = ptr                                                                                                                                                        };
            public int m_nSequence {                             get => *(int*)(addr + Offset.DT_BaseAnimating.m_nSequence);                                 set => *(int*)(addr + Offset.DT_BaseAnimating.m_nSequence) = value;                                 }
            public int m_nForceBone {                            get => *(int*)(addr + Offset.DT_BaseAnimating.m_nForceBone);                                set => *(int*)(addr + Offset.DT_BaseAnimating.m_nForceBone) = value;                                }
            public int m_vecForce {                              get => *(int*)(addr + Offset.DT_BaseAnimating.m_vecForce);                                  set => *(int*)(addr + Offset.DT_BaseAnimating.m_vecForce) = value;                                  }
            public int m_nSkin {                                 get => *(int*)(addr + Offset.DT_BaseAnimating.m_nSkin);                                     set => *(int*)(addr + Offset.DT_BaseAnimating.m_nSkin) = value;                                     }
            public int m_nBody {                                 get => *(int*)(addr + Offset.DT_BaseAnimating.m_nBody);                                     set => *(int*)(addr + Offset.DT_BaseAnimating.m_nBody) = value;                                     }
            public int m_nHitboxSet {                            get => *(int*)(addr + Offset.DT_BaseAnimating.m_nHitboxSet);                                set => *(int*)(addr + Offset.DT_BaseAnimating.m_nHitboxSet) = value;                                }
            public int m_flModelScale {                          get => *(int*)(addr + Offset.DT_BaseAnimating.m_flModelScale);                              set => *(int*)(addr + Offset.DT_BaseAnimating.m_flModelScale) = value;                              }
            public int m_flPlaybackRate {                        get => *(int*)(addr + Offset.DT_BaseAnimating.m_flPlaybackRate);                            set => *(int*)(addr + Offset.DT_BaseAnimating.m_flPlaybackRate) = value;                            }
            public int m_bClientSideAnimation {                  get => *(int*)(addr + Offset.DT_BaseAnimating.m_bClientSideAnimation);                      set => *(int*)(addr + Offset.DT_BaseAnimating.m_bClientSideAnimation) = value;                      }
            public int m_bClientSideFrameReset {                 get => *(int*)(addr + Offset.DT_BaseAnimating.m_bClientSideFrameReset);                     set => *(int*)(addr + Offset.DT_BaseAnimating.m_bClientSideFrameReset) = value;                     }
            public int m_bClientSideRagdoll {                    get => *(int*)(addr + Offset.DT_BaseAnimating.m_bClientSideRagdoll);                        set => *(int*)(addr + Offset.DT_BaseAnimating.m_bClientSideRagdoll) = value;                        }
            public int m_nNewSequenceParity {                    get => *(int*)(addr + Offset.DT_BaseAnimating.m_nNewSequenceParity);                        set => *(int*)(addr + Offset.DT_BaseAnimating.m_nNewSequenceParity) = value;                        }
            public int m_nResetEventsParity {                    get => *(int*)(addr + Offset.DT_BaseAnimating.m_nResetEventsParity);                        set => *(int*)(addr + Offset.DT_BaseAnimating.m_nResetEventsParity) = value;                        }
            public int m_nMuzzleFlashParity {                    get => *(int*)(addr + Offset.DT_BaseAnimating.m_nMuzzleFlashParity);                        set => *(int*)(addr + Offset.DT_BaseAnimating.m_nMuzzleFlashParity) = value;                        }
            public int m_hLightingOrigin {                       get => *(int*)(addr + Offset.DT_BaseAnimating.m_hLightingOrigin);                           set => *(int*)(addr + Offset.DT_BaseAnimating.m_hLightingOrigin) = value;                           }
            public int m_flFrozen {                              get => *(int*)(addr + Offset.DT_BaseAnimating.m_flFrozen);                                  set => *(int*)(addr + Offset.DT_BaseAnimating.m_flFrozen) = value;                                  }
            public int m_ScaleType {                             get => *(int*)(addr + Offset.DT_BaseAnimating.m_ScaleType);                                 set => *(int*)(addr + Offset.DT_BaseAnimating.m_ScaleType) = value;                                 }
            public int m_bSuppressAnimSounds {                   get => *(int*)(addr + Offset.DT_BaseAnimating.m_bSuppressAnimSounds);                       set => *(int*)(addr + Offset.DT_BaseAnimating.m_bSuppressAnimSounds) = value;                       }
            public int m_nHighlightColorR {                      get => *(int*)(addr + Offset.DT_BaseAnimating.m_nHighlightColorR);                          set => *(int*)(addr + Offset.DT_BaseAnimating.m_nHighlightColorR) = value;                          }
            public int m_nHighlightColorG {                      get => *(int*)(addr + Offset.DT_BaseAnimating.m_nHighlightColorG);                          set => *(int*)(addr + Offset.DT_BaseAnimating.m_nHighlightColorG) = value;                          }
            public int m_nHighlightColorB {                      get => *(int*)(addr + Offset.DT_BaseAnimating.m_nHighlightColorB);                          set => *(int*)(addr + Offset.DT_BaseAnimating.m_nHighlightColorB) = value;                          }
            public int m_flPoseParameter {                       get => *(int*)(addr + Offset.DT_BaseAnimating.m_flPoseParameter);                           set => *(int*)(addr + Offset.DT_BaseAnimating.m_flPoseParameter) = value;                           }
            public int m_flEncodedController {                   get => *(int*)(addr + Offset.DT_BaseAnimating.m_flEncodedController);                       set => *(int*)(addr + Offset.DT_BaseAnimating.m_flEncodedController) = value;                       }
            public int m_flCycle {                               get => *(int*)(addr + Offset.DT_BaseAnimating.m_flCycle);                                   set => *(int*)(addr + Offset.DT_BaseAnimating.m_flCycle) = value;                                   }
            public int serveranimdata {                          get => *(int*)(addr + Offset.DT_BaseAnimating.serveranimdata);                              set => *(int*)(addr + Offset.DT_BaseAnimating.serveranimdata) = value;                              }

        }

        public class AI_BaseNPC : baseStructs
        {
            public static implicit operator AI_BaseNPC(IntPtr ptr) => new AI_BaseNPC() { addr = ptr                                                                                                                                                              };
            public int m_lifeState {                             get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_lifeState);                                    set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_lifeState) = value;                                    }
            public int m_bPerformAvoidance {                     get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bPerformAvoidance);                            set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bPerformAvoidance) = value;                            }
            public int m_bIsMoving {                             get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bIsMoving);                                    set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bIsMoving) = value;                                    }
            public int m_bFadeCorpse {                           get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bFadeCorpse);                                  set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bFadeCorpse) = value;                                  }
            public int m_iDeathPose {                            get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iDeathPose);                                   set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iDeathPose) = value;                                   }
            public int m_iDeathFrame {                           get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iDeathFrame);                                  set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iDeathFrame) = value;                                  }
            public int m_iSpeedModRadius {                       get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iSpeedModRadius);                              set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iSpeedModRadius) = value;                              }
            public int m_iSpeedModSpeed {                        get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iSpeedModSpeed);                               set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_iSpeedModSpeed) = value;                               }
            public int m_bSpeedModActive {                       get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bSpeedModActive);                              set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bSpeedModActive) = value;                              }
            public int m_bImportanRagdoll {                      get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bImportanRagdoll);                             set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_bImportanRagdoll) = value;                             }
            public int m_flTimePingEffect {                      get => *(int*)(addr + Offset.DT_AI_BaseNPC.m_flTimePingEffect);                             set => *(int*)(addr + Offset.DT_AI_BaseNPC.m_flTimePingEffect) = value;                             }

        }

        public class Beam : baseStructs
        {
            public static implicit operator Beam(IntPtr ptr) => new Beam() { addr = ptr                                                                                                                                                                          };
            public int m_nBeamType {                             get => *(int*)(addr + Offset.DT_Beam.m_nBeamType);                                          set => *(int*)(addr + Offset.DT_Beam.m_nBeamType) = value;                                          }
            public int m_nBeamFlags {                            get => *(int*)(addr + Offset.DT_Beam.m_nBeamFlags);                                         set => *(int*)(addr + Offset.DT_Beam.m_nBeamFlags) = value;                                         }
            public int m_nNumBeamEnts {                          get => *(int*)(addr + Offset.DT_Beam.m_nNumBeamEnts);                                       set => *(int*)(addr + Offset.DT_Beam.m_nNumBeamEnts) = value;                                       }
            public int m_nHaloIndex {                            get => *(int*)(addr + Offset.DT_Beam.m_nHaloIndex);                                         set => *(int*)(addr + Offset.DT_Beam.m_nHaloIndex) = value;                                         }
            public int m_fHaloScale {                            get => *(int*)(addr + Offset.DT_Beam.m_fHaloScale);                                         set => *(int*)(addr + Offset.DT_Beam.m_fHaloScale) = value;                                         }
            public int m_fWidth {                                get => *(int*)(addr + Offset.DT_Beam.m_fWidth);                                             set => *(int*)(addr + Offset.DT_Beam.m_fWidth) = value;                                             }
            public int m_fEndWidth {                             get => *(int*)(addr + Offset.DT_Beam.m_fEndWidth);                                          set => *(int*)(addr + Offset.DT_Beam.m_fEndWidth) = value;                                          }
            public int m_fFadeLength {                           get => *(int*)(addr + Offset.DT_Beam.m_fFadeLength);                                        set => *(int*)(addr + Offset.DT_Beam.m_fFadeLength) = value;                                        }
            public int m_fAmplitude {                            get => *(int*)(addr + Offset.DT_Beam.m_fAmplitude);                                         set => *(int*)(addr + Offset.DT_Beam.m_fAmplitude) = value;                                         }
            public int m_fStartFrame {                           get => *(int*)(addr + Offset.DT_Beam.m_fStartFrame);                                        set => *(int*)(addr + Offset.DT_Beam.m_fStartFrame) = value;                                        }
            public int m_fSpeed {                                get => *(int*)(addr + Offset.DT_Beam.m_fSpeed);                                             set => *(int*)(addr + Offset.DT_Beam.m_fSpeed) = value;                                             }
            public int m_flFrameRate {                           get => *(int*)(addr + Offset.DT_Beam.m_flFrameRate);                                        set => *(int*)(addr + Offset.DT_Beam.m_flFrameRate) = value;                                        }
            public int m_flHDRColorScale {                       get => *(int*)(addr + Offset.DT_Beam.m_flHDRColorScale);                                    set => *(int*)(addr + Offset.DT_Beam.m_flHDRColorScale) = value;                                    }
            public int m_clrRender {                             get => *(int*)(addr + Offset.DT_Beam.m_clrRender);                                          set => *(int*)(addr + Offset.DT_Beam.m_clrRender) = value;                                          }
            public int m_nRenderFX {                             get => *(int*)(addr + Offset.DT_Beam.m_nRenderFX);                                          set => *(int*)(addr + Offset.DT_Beam.m_nRenderFX) = value;                                          }
            public int m_nRenderMode {                           get => *(int*)(addr + Offset.DT_Beam.m_nRenderMode);                                        set => *(int*)(addr + Offset.DT_Beam.m_nRenderMode) = value;                                        }
            public int m_flFrame {                               get => *(int*)(addr + Offset.DT_Beam.m_flFrame);                                            set => *(int*)(addr + Offset.DT_Beam.m_flFrame) = value;                                            }
            public int m_nClipStyle {                            get => *(int*)(addr + Offset.DT_Beam.m_nClipStyle);                                         set => *(int*)(addr + Offset.DT_Beam.m_nClipStyle) = value;                                         }
            public int m_vecEndPos {                             get => *(int*)(addr + Offset.DT_Beam.m_vecEndPos);                                          set => *(int*)(addr + Offset.DT_Beam.m_vecEndPos) = value;                                          }
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_Beam.m_nModelIndex);                                        set => *(int*)(addr + Offset.DT_Beam.m_nModelIndex) = value;                                        }
            public int m_vecOrigin {                             get => *(int*)(addr + Offset.DT_Beam.m_vecOrigin);                                          set => *(int*)(addr + Offset.DT_Beam.m_vecOrigin) = value;                                          }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_Beam.moveparent);                                           set => *(int*)(addr + Offset.DT_Beam.moveparent) = value;                                           }
            public int m_hAttachEntity {                         get => *(int*)(addr + Offset.DT_Beam.m_hAttachEntity);                                      set => *(int*)(addr + Offset.DT_Beam.m_hAttachEntity) = value;                                      }
            public int m_nAttachIndex {                          get => *(int*)(addr + Offset.DT_Beam.m_nAttachIndex);                                       set => *(int*)(addr + Offset.DT_Beam.m_nAttachIndex) = value;                                       }

        }

        public class BaseViewModel : baseStructs
        {
            public static implicit operator BaseViewModel(IntPtr ptr) => new BaseViewModel() { addr = ptr                                                                                                                                                        };
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_BaseViewModel.m_nModelIndex);                               set => *(int*)(addr + Offset.DT_BaseViewModel.m_nModelIndex) = value;                               }
            public int m_hWeapon {                               get => *(int*)(addr + Offset.DT_BaseViewModel.m_hWeapon);                                   set => *(int*)(addr + Offset.DT_BaseViewModel.m_hWeapon) = value;                                   }
            public int m_nSkin {                                 get => *(int*)(addr + Offset.DT_BaseViewModel.m_nSkin);                                     set => *(int*)(addr + Offset.DT_BaseViewModel.m_nSkin) = value;                                     }
            public int m_nBody {                                 get => *(int*)(addr + Offset.DT_BaseViewModel.m_nBody);                                     set => *(int*)(addr + Offset.DT_BaseViewModel.m_nBody) = value;                                     }
            public int m_nSequence {                             get => *(int*)(addr + Offset.DT_BaseViewModel.m_nSequence);                                 set => *(int*)(addr + Offset.DT_BaseViewModel.m_nSequence) = value;                                 }
            public int m_nViewModelIndex {                       get => *(int*)(addr + Offset.DT_BaseViewModel.m_nViewModelIndex);                           set => *(int*)(addr + Offset.DT_BaseViewModel.m_nViewModelIndex) = value;                           }
            public int m_flPlaybackRate {                        get => *(int*)(addr + Offset.DT_BaseViewModel.m_flPlaybackRate);                            set => *(int*)(addr + Offset.DT_BaseViewModel.m_flPlaybackRate) = value;                            }
            public int m_fEffects {                              get => *(int*)(addr + Offset.DT_BaseViewModel.m_fEffects);                                  set => *(int*)(addr + Offset.DT_BaseViewModel.m_fEffects) = value;                                  }
            public int m_nAnimationParity {                      get => *(int*)(addr + Offset.DT_BaseViewModel.m_nAnimationParity);                          set => *(int*)(addr + Offset.DT_BaseViewModel.m_nAnimationParity) = value;                          }
            public int m_hOwner {                                get => *(int*)(addr + Offset.DT_BaseViewModel.m_hOwner);                                    set => *(int*)(addr + Offset.DT_BaseViewModel.m_hOwner) = value;                                    }
            public int m_nNewSequenceParity {                    get => *(int*)(addr + Offset.DT_BaseViewModel.m_nNewSequenceParity);                        set => *(int*)(addr + Offset.DT_BaseViewModel.m_nNewSequenceParity) = value;                        }
            public int m_nResetEventsParity {                    get => *(int*)(addr + Offset.DT_BaseViewModel.m_nResetEventsParity);                        set => *(int*)(addr + Offset.DT_BaseViewModel.m_nResetEventsParity) = value;                        }
            public int m_nMuzzleFlashParity {                    get => *(int*)(addr + Offset.DT_BaseViewModel.m_nMuzzleFlashParity);                        set => *(int*)(addr + Offset.DT_BaseViewModel.m_nMuzzleFlashParity) = value;                        }
            public int m_bShouldIgnoreOffsetAndAccuracy {        get => *(int*)(addr + Offset.DT_BaseViewModel.m_bShouldIgnoreOffsetAndAccuracy);            set => *(int*)(addr + Offset.DT_BaseViewModel.m_bShouldIgnoreOffsetAndAccuracy) = value;            }

        }

        public class BaseGrenade : baseStructs
        {
            public static implicit operator BaseGrenade(IntPtr ptr) => new BaseGrenade() { addr = ptr                                                                                                                                                            };
            public int m_flDamage {                              get => *(int*)(addr + Offset.DT_BaseGrenade.m_flDamage);                                    set => *(int*)(addr + Offset.DT_BaseGrenade.m_flDamage) = value;                                    }
            public int m_DmgRadius {                             get => *(int*)(addr + Offset.DT_BaseGrenade.m_DmgRadius);                                   set => *(int*)(addr + Offset.DT_BaseGrenade.m_DmgRadius) = value;                                   }
            public int m_bIsLive {                               get => *(int*)(addr + Offset.DT_BaseGrenade.m_bIsLive);                                     set => *(int*)(addr + Offset.DT_BaseGrenade.m_bIsLive) = value;                                     }
            public int m_hThrower {                              get => *(int*)(addr + Offset.DT_BaseGrenade.m_hThrower);                                    set => *(int*)(addr + Offset.DT_BaseGrenade.m_hThrower) = value;                                    }
            public int m_vecVelocity {                           get => *(int*)(addr + Offset.DT_BaseGrenade.m_vecVelocity);                                 set => *(int*)(addr + Offset.DT_BaseGrenade.m_vecVelocity) = value;                                 }
            public int m_fFlags {                                get => *(int*)(addr + Offset.DT_BaseGrenade.m_fFlags);                                      set => *(int*)(addr + Offset.DT_BaseGrenade.m_fFlags) = value;                                      }

        }

        public class BaseCombatWeapon : BaseEntity
        {
            public static implicit operator BaseCombatWeapon(IntPtr ptr) => new BaseCombatWeapon() { addr = ptr                                                                                                                                                  };
            public int m_iViewModelIndex {                       get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iViewModelIndex);                        set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iViewModelIndex) = value;                        }
            public int m_iWorldModelIndex {                      get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWorldModelIndex);                       set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWorldModelIndex) = value;                       }
            public int m_iWorldDroppedModelIndex {               get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWorldDroppedModelIndex);                set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWorldDroppedModelIndex) = value;                }
            public int m_iState {                                get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iState);                                 set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iState) = value;                                 }
            public int m_hOwner {                                get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_hOwner);                                 set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_hOwner) = value;                                 }
            public int m_iClip1 {                                get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iClip1);                                 set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iClip1) = value;                                 }
            public int m_iClip2 {                                get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iClip2);                                 set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iClip2) = value;                                 }
            public int m_iPrimaryReserveAmmoCount {              get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iPrimaryReserveAmmoCount);               set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iPrimaryReserveAmmoCount) = value;               }
            public int m_iSecondaryReserveAmmoCount {            get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iSecondaryReserveAmmoCount);             set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iSecondaryReserveAmmoCount) = value;             }
            public IntPtr m_hWeaponWorldModel {                  get => *(IntPtr*)(addr + Offset.DT_BaseCombatWeapon.m_hWeaponWorldModel);                   set => *(IntPtr*)(addr + Offset.DT_BaseCombatWeapon.m_hWeaponWorldModel) = value;                      }
            public int m_iNumEmptyAttacks {                      get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iNumEmptyAttacks);                       set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iNumEmptyAttacks) = value;                       }
            public int m_iPrimaryAmmoType {                      get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iPrimaryAmmoType);                       set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iPrimaryAmmoType) = value;                       }
            public int m_iSecondaryAmmoType {                    get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iSecondaryAmmoType);                     set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iSecondaryAmmoType) = value;                     }
            public int m_nViewModelIndex {                       get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_nViewModelIndex);                        set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_nViewModelIndex) = value;                        }
            public int m_bFlipViewModel {                        get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_bFlipViewModel);                         set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_bFlipViewModel) = value;                         }
            public int m_iWeaponOrigin {                         get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWeaponOrigin);                          set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWeaponOrigin) = value;                          }
            public int m_iWeaponModule {                         get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWeaponModule);                          set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_iWeaponModule) = value;                          }
            public int LocalWeaponData {                         get => *(int*)(addr + Offset.DT_BaseCombatWeapon.LocalWeaponData);                          set => *(int*)(addr + Offset.DT_BaseCombatWeapon.LocalWeaponData) = value;                          }
            public int m_flNextPrimaryAttack {                   get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_flNextPrimaryAttack);                    set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_flNextPrimaryAttack) = value;                    }
            public int m_flNextSecondaryAttack {                 get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_flNextSecondaryAttack);                  set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_flNextSecondaryAttack) = value;                  }
            public int m_nNextThinkTick {                        get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_nNextThinkTick);                         set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_nNextThinkTick) = value;                         }
            public int m_flTimeWeaponIdle {                      get => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_flTimeWeaponIdle);                       set => *(int*)(addr + Offset.DT_BaseCombatWeapon.m_flTimeWeaponIdle) = value;                       }
            public int LocalActiveWeaponData {                   get => *(int*)(addr + Offset.DT_BaseCombatWeapon.LocalActiveWeaponData);                    set => *(int*)(addr + Offset.DT_BaseCombatWeapon.LocalActiveWeaponData) = value;                    }

        }

        public class BaseWeaponWorldModel : baseStructs
        {
            public static implicit operator BaseWeaponWorldModel(IntPtr ptr) => new BaseWeaponWorldModel() { addr = ptr                                                                                                                                          };
            public int m_nModelIndex {                           get => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_nModelIndex);                        set => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_nModelIndex) = value;                        }
            public int m_nBody {                                 get => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_nBody);                              set => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_nBody) = value;                              }
            public int m_fEffects {                              get => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_fEffects);                           set => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_fEffects) = value;                           }
            public int moveparent {                              get => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.moveparent);                           set => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.moveparent) = value;                           }
            public int m_hCombatWeaponParent {                   get => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_hCombatWeaponParent);                set => *(int*)(addr + Offset.DT_BaseWeaponWorldModel.m_hCombatWeaponParent) = value;                }

        }
        #endregion
    }

    class Offset
    {
        public static int dwBoneMatrix = 0;

        #region Offsets
        public class DT_TestTraceline
        {
            static DT_TestTraceline() { }
            public static Int32 m_clrRender                             = g_NtvMngr.GetOffset("DT_TestTraceline"             , "m_clrRender"                            );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TestTraceline"             , "m_vecOrigin"                            );
            public static Int32 m_angRotation_0                         = g_NtvMngr.GetOffset("DT_TestTraceline"             , "m_angRotation[0]"                       );
            public static Int32 m_angRotation_1                         = g_NtvMngr.GetOffset("DT_TestTraceline"             , "m_angRotation[1]"                       );
            public static Int32 m_angRotation_2                         = g_NtvMngr.GetOffset("DT_TestTraceline"             , "m_angRotation[2]"                       );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_TestTraceline"             , "moveparent"                             );
        }

        public class DT_TEWorldDecal
        {
            static DT_TEWorldDecal() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEWorldDecal"              , "m_vecOrigin"                            );
            public static Int32 m_nIndex                                = g_NtvMngr.GetOffset("DT_TEWorldDecal"              , "m_nIndex"                               );
        }

        public class DT_TESpriteSpray
        {
            static DT_TESpriteSpray() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TESpriteSpray"             , "m_vecOrigin"                            );
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_TESpriteSpray"             , "m_vecDirection"                         );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TESpriteSpray"             , "m_nModelIndex"                          );
            public static Int32 m_fNoise                                = g_NtvMngr.GetOffset("DT_TESpriteSpray"             , "m_fNoise"                               );
            public static Int32 m_nCount                                = g_NtvMngr.GetOffset("DT_TESpriteSpray"             , "m_nCount"                               );
            public static Int32 m_nSpeed                                = g_NtvMngr.GetOffset("DT_TESpriteSpray"             , "m_nSpeed"                               );
        }

        public class DT_TESprite
        {
            static DT_TESprite() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TESprite"                  , "m_vecOrigin"                            );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TESprite"                  , "m_nModelIndex"                          );
            public static Int32 m_fScale                                = g_NtvMngr.GetOffset("DT_TESprite"                  , "m_fScale"                               );
            public static Int32 m_nBrightness                           = g_NtvMngr.GetOffset("DT_TESprite"                  , "m_nBrightness"                          );
        }

        public class DT_TESparks
        {
            static DT_TESparks() { }
            public static Int32 m_nMagnitude                            = g_NtvMngr.GetOffset("DT_TESparks"                  , "m_nMagnitude"                           );
            public static Int32 m_nTrailLength                          = g_NtvMngr.GetOffset("DT_TESparks"                  , "m_nTrailLength"                         );
            public static Int32 m_vecDir                                = g_NtvMngr.GetOffset("DT_TESparks"                  , "m_vecDir"                               );
        }

        public class DT_TESmoke
        {
            static DT_TESmoke() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TESmoke"                   , "m_vecOrigin"                            );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TESmoke"                   , "m_nModelIndex"                          );
            public static Int32 m_fScale                                = g_NtvMngr.GetOffset("DT_TESmoke"                   , "m_fScale"                               );
            public static Int32 m_nFrameRate                            = g_NtvMngr.GetOffset("DT_TESmoke"                   , "m_nFrameRate"                           );
        }

        public class DT_TEShowLine
        {
            static DT_TEShowLine() { }
            public static Int32 m_vecEnd                                = g_NtvMngr.GetOffset("DT_TEShowLine"                , "m_vecEnd"                               );
        }

        public class DT_TEProjectedDecal
        {
            static DT_TEProjectedDecal() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEProjectedDecal"          , "m_vecOrigin"                            );
            public static Int32 m_angRotation                           = g_NtvMngr.GetOffset("DT_TEProjectedDecal"          , "m_angRotation"                          );
            public static Int32 m_flDistance                            = g_NtvMngr.GetOffset("DT_TEProjectedDecal"          , "m_flDistance"                           );
            public static Int32 m_nIndex                                = g_NtvMngr.GetOffset("DT_TEProjectedDecal"          , "m_nIndex"                               );
        }

        public class DT_FEPlayerDecal
        {
            static DT_FEPlayerDecal() { }
            public static Int32 m_nUniqueID                             = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_nUniqueID"                            );
            public static Int32 m_unAccountID                           = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_unAccountID"                          );
            public static Int32 m_unTraceID                             = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_unTraceID"                            );
            public static Int32 m_rtGcTime                              = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_rtGcTime"                             );
            public static Int32 m_vecEndPos                             = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_vecEndPos"                            );
            public static Int32 m_vecStart                              = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_vecStart"                             );
            public static Int32 m_vecRight                              = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_vecRight"                             );
            public static Int32 m_vecNormal                             = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_vecNormal"                            );
            public static Int32 m_nEntity                               = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_nEntity"                              );
            public static Int32 m_nPlayer                               = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_nPlayer"                              );
            public static Int32 m_nHitbox                               = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_nHitbox"                              );
            public static Int32 m_nTintID                               = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_nTintID"                              );
            public static Int32 m_flCreationTime                        = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_flCreationTime"                       );
            public static Int32 m_nVersion                              = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_nVersion"                             );
            public static Int32 m_ubSignature                           = g_NtvMngr.GetOffset("DT_FEPlayerDecal"             , "m_ubSignature"                          );
        }

        public class DT_TEPlayerDecal
        {
            static DT_TEPlayerDecal() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEPlayerDecal"             , "m_vecOrigin"                            );
            public static Int32 m_vecStart                              = g_NtvMngr.GetOffset("DT_TEPlayerDecal"             , "m_vecStart"                             );
            public static Int32 m_vecRight                              = g_NtvMngr.GetOffset("DT_TEPlayerDecal"             , "m_vecRight"                             );
            public static Int32 m_nEntity                               = g_NtvMngr.GetOffset("DT_TEPlayerDecal"             , "m_nEntity"                              );
            public static Int32 m_nPlayer                               = g_NtvMngr.GetOffset("DT_TEPlayerDecal"             , "m_nPlayer"                              );
            public static Int32 m_nHitbox                               = g_NtvMngr.GetOffset("DT_TEPlayerDecal"             , "m_nHitbox"                              );
        }

        public class DT_TEPhysicsProp
        {
            static DT_TEPhysicsProp() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_vecOrigin"                            );
            public static Int32 m_angRotation_0                         = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_angRotation[0]"                       );
            public static Int32 m_angRotation_1                         = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_angRotation[1]"                       );
            public static Int32 m_angRotation_2                         = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_angRotation[2]"                       );
            public static Int32 m_vecVelocity                           = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_vecVelocity"                          );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_nModelIndex"                          );
            public static Int32 m_nFlags                                = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_nFlags"                               );
            public static Int32 m_nSkin                                 = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_nSkin"                                );
            public static Int32 m_nEffects                              = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_nEffects"                             );
            public static Int32 m_clrRender                             = g_NtvMngr.GetOffset("DT_TEPhysicsProp"             , "m_clrRender"                            );
        }

        public class DT_TEParticleSystem
        {
            static DT_TEParticleSystem() { }
            public static Int32 m_vecOrigin_0                           = g_NtvMngr.GetOffset("DT_TEParticleSystem"          , "m_vecOrigin[0]"                         );
            public static Int32 m_vecOrigin_1                           = g_NtvMngr.GetOffset("DT_TEParticleSystem"          , "m_vecOrigin[1]"                         );
            public static Int32 m_vecOrigin_2                           = g_NtvMngr.GetOffset("DT_TEParticleSystem"          , "m_vecOrigin[2]"                         );
        }

        public class DT_TEMuzzleFlash
        {
            static DT_TEMuzzleFlash() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEMuzzleFlash"             , "m_vecOrigin"                            );
            public static Int32 m_vecAngles                             = g_NtvMngr.GetOffset("DT_TEMuzzleFlash"             , "m_vecAngles"                            );
            public static Int32 m_flScale                               = g_NtvMngr.GetOffset("DT_TEMuzzleFlash"             , "m_flScale"                              );
            public static Int32 m_nType                                 = g_NtvMngr.GetOffset("DT_TEMuzzleFlash"             , "m_nType"                                );
        }

        public class DT_TELargeFunnel
        {
            static DT_TELargeFunnel() { }
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TELargeFunnel"             , "m_nModelIndex"                          );
            public static Int32 m_nReversed                             = g_NtvMngr.GetOffset("DT_TELargeFunnel"             , "m_nReversed"                            );
        }

        public class DT_TEKillPlayerAttachments
        {
            static DT_TEKillPlayerAttachments() { }
            public static Int32 m_nPlayer                               = g_NtvMngr.GetOffset("DT_TEKillPlayerAttachments"   , "m_nPlayer"                              );
        }

        public class DT_TEImpact
        {
            static DT_TEImpact() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEImpact"                  , "m_vecOrigin"                            );
            public static Int32 m_vecNormal                             = g_NtvMngr.GetOffset("DT_TEImpact"                  , "m_vecNormal"                            );
            public static Int32 m_iType                                 = g_NtvMngr.GetOffset("DT_TEImpact"                  , "m_iType"                                );
            public static Int32 m_ucFlags                               = g_NtvMngr.GetOffset("DT_TEImpact"                  , "m_ucFlags"                              );
        }

        public class DT_TEGlowSprite
        {
            static DT_TEGlowSprite() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEGlowSprite"              , "m_vecOrigin"                            );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEGlowSprite"              , "m_nModelIndex"                          );
            public static Int32 m_fScale                                = g_NtvMngr.GetOffset("DT_TEGlowSprite"              , "m_fScale"                               );
            public static Int32 m_fLife                                 = g_NtvMngr.GetOffset("DT_TEGlowSprite"              , "m_fLife"                                );
            public static Int32 m_nBrightness                           = g_NtvMngr.GetOffset("DT_TEGlowSprite"              , "m_nBrightness"                          );
        }

        public class DT_TEShatterSurface
        {
            static DT_TEShatterSurface() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_vecOrigin"                            );
            public static Int32 m_vecAngles                             = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_vecAngles"                            );
            public static Int32 m_vecForce                              = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_vecForce"                             );
            public static Int32 m_vecForcePos                           = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_vecForcePos"                          );
            public static Int32 m_flWidth                               = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_flWidth"                              );
            public static Int32 m_flHeight                              = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_flHeight"                             );
            public static Int32 m_flShardSize                           = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_flShardSize"                          );
            public static Int32 m_nSurfaceType                          = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_nSurfaceType"                         );
            public static Int32 m_uchFrontColor_0                       = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_uchFrontColor[0]"                     );
            public static Int32 m_uchFrontColor_1                       = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_uchFrontColor[1]"                     );
            public static Int32 m_uchFrontColor_2                       = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_uchFrontColor[2]"                     );
            public static Int32 m_uchBackColor_0                        = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_uchBackColor[0]"                      );
            public static Int32 m_uchBackColor_1                        = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_uchBackColor[1]"                      );
            public static Int32 m_uchBackColor_2                        = g_NtvMngr.GetOffset("DT_TEShatterSurface"          , "m_uchBackColor[2]"                      );
        }

        public class DT_TEFootprintDecal
        {
            static DT_TEFootprintDecal() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEFootprintDecal"          , "m_vecOrigin"                            );
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_TEFootprintDecal"          , "m_vecDirection"                         );
            public static Int32 m_nEntity                               = g_NtvMngr.GetOffset("DT_TEFootprintDecal"          , "m_nEntity"                              );
            public static Int32 m_nIndex                                = g_NtvMngr.GetOffset("DT_TEFootprintDecal"          , "m_nIndex"                               );
            public static Int32 m_chMaterialType                        = g_NtvMngr.GetOffset("DT_TEFootprintDecal"          , "m_chMaterialType"                       );
        }

        public class DT_TEFizz
        {
            static DT_TEFizz() { }
            public static Int32 m_nEntity                               = g_NtvMngr.GetOffset("DT_TEFizz"                    , "m_nEntity"                              );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEFizz"                    , "m_nModelIndex"                          );
            public static Int32 m_nDensity                              = g_NtvMngr.GetOffset("DT_TEFizz"                    , "m_nDensity"                             );
            public static Int32 m_nCurrent                              = g_NtvMngr.GetOffset("DT_TEFizz"                    , "m_nCurrent"                             );
        }

        public class DT_TEExplosion
        {
            static DT_TEExplosion() { }
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_nModelIndex"                          );
            public static Int32 m_fScale                                = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_fScale"                               );
            public static Int32 m_nFrameRate                            = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_nFrameRate"                           );
            public static Int32 m_nFlags                                = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_nFlags"                               );
            public static Int32 m_vecNormal                             = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_vecNormal"                            );
            public static Int32 m_chMaterialType                        = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_chMaterialType"                       );
            public static Int32 m_nRadius                               = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_nRadius"                              );
            public static Int32 m_nMagnitude                            = g_NtvMngr.GetOffset("DT_TEExplosion"               , "m_nMagnitude"                           );
        }

        public class DT_TEEnergySplash
        {
            static DT_TEEnergySplash() { }
            public static Int32 m_vecPos                                = g_NtvMngr.GetOffset("DT_TEEnergySplash"            , "m_vecPos"                               );
            public static Int32 m_vecDir                                = g_NtvMngr.GetOffset("DT_TEEnergySplash"            , "m_vecDir"                               );
            public static Int32 m_bExplosive                            = g_NtvMngr.GetOffset("DT_TEEnergySplash"            , "m_bExplosive"                           );
        }

        public class DT_TEDynamicLight
        {
            static DT_TEDynamicLight() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "m_vecOrigin"                            );
            public static Int32 r                                       = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "r"                                      );
            public static Int32 g                                       = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "g"                                      );
            public static Int32 b                                       = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "b"                                      );
            public static Int32 exponent                                = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "exponent"                               );
            public static Int32 m_fRadius                               = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "m_fRadius"                              );
            public static Int32 m_fTime                                 = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "m_fTime"                                );
            public static Int32 m_fDecay                                = g_NtvMngr.GetOffset("DT_TEDynamicLight"            , "m_fDecay"                               );
        }

        public class DT_TEDecal
        {
            static DT_TEDecal() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEDecal"                   , "m_vecOrigin"                            );
            public static Int32 m_vecStart                              = g_NtvMngr.GetOffset("DT_TEDecal"                   , "m_vecStart"                             );
            public static Int32 m_nEntity                               = g_NtvMngr.GetOffset("DT_TEDecal"                   , "m_nEntity"                              );
            public static Int32 m_nHitbox                               = g_NtvMngr.GetOffset("DT_TEDecal"                   , "m_nHitbox"                              );
            public static Int32 m_nIndex                                = g_NtvMngr.GetOffset("DT_TEDecal"                   , "m_nIndex"                               );
        }

        public class DT_TEClientProjectile
        {
            static DT_TEClientProjectile() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEClientProjectile"        , "m_vecOrigin"                            );
            public static Int32 m_vecVelocity                           = g_NtvMngr.GetOffset("DT_TEClientProjectile"        , "m_vecVelocity"                          );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEClientProjectile"        , "m_nModelIndex"                          );
            public static Int32 m_nLifeTime                             = g_NtvMngr.GetOffset("DT_TEClientProjectile"        , "m_nLifeTime"                            );
            public static Int32 m_hOwner                                = g_NtvMngr.GetOffset("DT_TEClientProjectile"        , "m_hOwner"                               );
        }

        public class DT_TEBubbleTrail
        {
            static DT_TEBubbleTrail() { }
            public static Int32 m_vecMins                               = g_NtvMngr.GetOffset("DT_TEBubbleTrail"             , "m_vecMins"                              );
            public static Int32 m_vecMaxs                               = g_NtvMngr.GetOffset("DT_TEBubbleTrail"             , "m_vecMaxs"                              );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEBubbleTrail"             , "m_nModelIndex"                          );
            public static Int32 m_flWaterZ                              = g_NtvMngr.GetOffset("DT_TEBubbleTrail"             , "m_flWaterZ"                             );
            public static Int32 m_nCount                                = g_NtvMngr.GetOffset("DT_TEBubbleTrail"             , "m_nCount"                               );
            public static Int32 m_fSpeed                                = g_NtvMngr.GetOffset("DT_TEBubbleTrail"             , "m_fSpeed"                               );
        }

        public class DT_TEBubbles
        {
            static DT_TEBubbles() { }
            public static Int32 m_vecMins                               = g_NtvMngr.GetOffset("DT_TEBubbles"                 , "m_vecMins"                              );
            public static Int32 m_vecMaxs                               = g_NtvMngr.GetOffset("DT_TEBubbles"                 , "m_vecMaxs"                              );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEBubbles"                 , "m_nModelIndex"                          );
            public static Int32 m_fHeight                               = g_NtvMngr.GetOffset("DT_TEBubbles"                 , "m_fHeight"                              );
            public static Int32 m_nCount                                = g_NtvMngr.GetOffset("DT_TEBubbles"                 , "m_nCount"                               );
            public static Int32 m_fSpeed                                = g_NtvMngr.GetOffset("DT_TEBubbles"                 , "m_fSpeed"                               );
        }

        public class DT_TEBSPDecal
        {
            static DT_TEBSPDecal() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEBSPDecal"                , "m_vecOrigin"                            );
            public static Int32 m_nEntity                               = g_NtvMngr.GetOffset("DT_TEBSPDecal"                , "m_nEntity"                              );
            public static Int32 m_nIndex                                = g_NtvMngr.GetOffset("DT_TEBSPDecal"                , "m_nIndex"                               );
        }

        public class DT_TEBreakModel
        {
            static DT_TEBreakModel() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_vecOrigin"                            );
            public static Int32 m_angRotation_0                         = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_angRotation[0]"                       );
            public static Int32 m_angRotation_1                         = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_angRotation[1]"                       );
            public static Int32 m_angRotation_2                         = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_angRotation[2]"                       );
            public static Int32 m_vecSize                               = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_vecSize"                              );
            public static Int32 m_vecVelocity                           = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_vecVelocity"                          );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_nModelIndex"                          );
            public static Int32 m_nRandomization                        = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_nRandomization"                       );
            public static Int32 m_nCount                                = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_nCount"                               );
            public static Int32 m_fTime                                 = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_fTime"                                );
            public static Int32 m_nFlags                                = g_NtvMngr.GetOffset("DT_TEBreakModel"              , "m_nFlags"                               );
        }

        public class DT_TEBloodStream
        {
            static DT_TEBloodStream() { }
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_TEBloodStream"             , "m_vecDirection"                         );
            public static Int32 r                                       = g_NtvMngr.GetOffset("DT_TEBloodStream"             , "r"                                      );
            public static Int32 g                                       = g_NtvMngr.GetOffset("DT_TEBloodStream"             , "g"                                      );
            public static Int32 b                                       = g_NtvMngr.GetOffset("DT_TEBloodStream"             , "b"                                      );
            public static Int32 a                                       = g_NtvMngr.GetOffset("DT_TEBloodStream"             , "a"                                      );
            public static Int32 m_nAmount                               = g_NtvMngr.GetOffset("DT_TEBloodStream"             , "m_nAmount"                              );
        }

        public class DT_TEBloodSprite
        {
            static DT_TEBloodSprite() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "m_vecOrigin"                            );
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "m_vecDirection"                         );
            public static Int32 r                                       = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "r"                                      );
            public static Int32 g                                       = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "g"                                      );
            public static Int32 b                                       = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "b"                                      );
            public static Int32 a                                       = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "a"                                      );
            public static Int32 m_nSprayModel                           = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "m_nSprayModel"                          );
            public static Int32 m_nDropModel                            = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "m_nDropModel"                           );
            public static Int32 m_nSize                                 = g_NtvMngr.GetOffset("DT_TEBloodSprite"             , "m_nSize"                                );
        }

        public class DT_TEBeamSpline
        {
            static DT_TEBeamSpline() { }
            public static Int32 m_nPoints                               = g_NtvMngr.GetOffset("DT_TEBeamSpline"              , "m_nPoints"                              );
            public static Int32 m_vecPoints_0                           = g_NtvMngr.GetOffset("DT_TEBeamSpline"              , "m_vecPoints[0]"                         );
            public static Int32 m_vecPoints                             = g_NtvMngr.GetOffset("DT_TEBeamSpline"              , "m_vecPoints"                            );
        }

        public class DT_TEBeamRingPoint
        {
            static DT_TEBeamRingPoint() { }
            public static Int32 m_vecCenter                             = g_NtvMngr.GetOffset("DT_TEBeamRingPoint"           , "m_vecCenter"                            );
            public static Int32 m_flStartRadius                         = g_NtvMngr.GetOffset("DT_TEBeamRingPoint"           , "m_flStartRadius"                        );
            public static Int32 m_flEndRadius                           = g_NtvMngr.GetOffset("DT_TEBeamRingPoint"           , "m_flEndRadius"                          );
        }

        public class DT_TEBeamRing
        {
            static DT_TEBeamRing() { }
            public static Int32 m_nStartEntity                          = g_NtvMngr.GetOffset("DT_TEBeamRing"                , "m_nStartEntity"                         );
            public static Int32 m_nEndEntity                            = g_NtvMngr.GetOffset("DT_TEBeamRing"                , "m_nEndEntity"                           );
        }

        public class DT_TEBeamPoints
        {
            static DT_TEBeamPoints() { }
            public static Int32 m_vecStartPoint                         = g_NtvMngr.GetOffset("DT_TEBeamPoints"              , "m_vecStartPoint"                        );
            public static Int32 m_vecEndPoint                           = g_NtvMngr.GetOffset("DT_TEBeamPoints"              , "m_vecEndPoint"                          );
        }

        public class DT_TEBeamLaser
        {
            static DT_TEBeamLaser() { }
            public static Int32 m_nStartEntity                          = g_NtvMngr.GetOffset("DT_TEBeamLaser"               , "m_nStartEntity"                         );
            public static Int32 m_nEndEntity                            = g_NtvMngr.GetOffset("DT_TEBeamLaser"               , "m_nEndEntity"                           );
        }

        public class DT_TEBeamFollow
        {
            static DT_TEBeamFollow() { }
            public static Int32 m_iEntIndex                             = g_NtvMngr.GetOffset("DT_TEBeamFollow"              , "m_iEntIndex"                            );
        }

        public class DT_TEBeamEnts
        {
            static DT_TEBeamEnts() { }
            public static Int32 m_nStartEntity                          = g_NtvMngr.GetOffset("DT_TEBeamEnts"                , "m_nStartEntity"                         );
            public static Int32 m_nEndEntity                            = g_NtvMngr.GetOffset("DT_TEBeamEnts"                , "m_nEndEntity"                           );
        }

        public class DT_TEBeamEntPoint
        {
            static DT_TEBeamEntPoint() { }
            public static Int32 m_nStartEntity                          = g_NtvMngr.GetOffset("DT_TEBeamEntPoint"            , "m_nStartEntity"                         );
            public static Int32 m_nEndEntity                            = g_NtvMngr.GetOffset("DT_TEBeamEntPoint"            , "m_nEndEntity"                           );
            public static Int32 m_vecStartPoint                         = g_NtvMngr.GetOffset("DT_TEBeamEntPoint"            , "m_vecStartPoint"                        );
            public static Int32 m_vecEndPoint                           = g_NtvMngr.GetOffset("DT_TEBeamEntPoint"            , "m_vecEndPoint"                          );
        }

        public class DT_BaseBeam
        {
            static DT_BaseBeam() { }
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nModelIndex"                          );
            public static Int32 m_nHaloIndex                            = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nHaloIndex"                           );
            public static Int32 m_nStartFrame                           = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nStartFrame"                          );
            public static Int32 m_nFrameRate                            = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nFrameRate"                           );
            public static Int32 m_fLife                                 = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_fLife"                                );
            public static Int32 m_fWidth                                = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_fWidth"                               );
            public static Int32 m_fEndWidth                             = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_fEndWidth"                            );
            public static Int32 m_nFadeLength                           = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nFadeLength"                          );
            public static Int32 m_fAmplitude                            = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_fAmplitude"                           );
            public static Int32 m_nSpeed                                = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nSpeed"                               );
            public static Int32 r                                       = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "r"                                      );
            public static Int32 g                                       = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "g"                                      );
            public static Int32 b                                       = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "b"                                      );
            public static Int32 a                                       = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "a"                                      );
            public static Int32 m_nFlags                                = g_NtvMngr.GetOffset("DT_BaseBeam"                  , "m_nFlags"                               );
        }

        public class DT_TEMetalSparks
        {
            static DT_TEMetalSparks() { }
            public static Int32 m_vecPos                                = g_NtvMngr.GetOffset("DT_TEMetalSparks"             , "m_vecPos"                               );
            public static Int32 m_vecDir                                = g_NtvMngr.GetOffset("DT_TEMetalSparks"             , "m_vecDir"                               );
        }

        public class DT_SteamJet
        {
            static DT_SteamJet() { }
            public static Int32 m_SpreadSpeed                           = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_SpreadSpeed"                          );
            public static Int32 m_Speed                                 = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_Speed"                                );
            public static Int32 m_StartSize                             = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_StartSize"                            );
            public static Int32 m_EndSize                               = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_EndSize"                              );
            public static Int32 m_Rate                                  = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_Rate"                                 );
            public static Int32 m_JetLength                             = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_JetLength"                            );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_bEmit"                                );
            public static Int32 m_bFaceLeft                             = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_bFaceLeft"                            );
            public static Int32 m_nType                                 = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_nType"                                );
            public static Int32 m_spawnflags                            = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_spawnflags"                           );
            public static Int32 m_flRollSpeed                           = g_NtvMngr.GetOffset("DT_SteamJet"                  , "m_flRollSpeed"                          );
        }

        public class DT_SmokeStack
        {
            static DT_SmokeStack() { }
            public static Int32 m_SpreadSpeed                           = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_SpreadSpeed"                          );
            public static Int32 m_Speed                                 = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_Speed"                                );
            public static Int32 m_StartSize                             = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_StartSize"                            );
            public static Int32 m_EndSize                               = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_EndSize"                              );
            public static Int32 m_Rate                                  = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_Rate"                                 );
            public static Int32 m_JetLength                             = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_JetLength"                            );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_bEmit"                                );
            public static Int32 m_flBaseSpread                          = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_flBaseSpread"                         );
            public static Int32 m_flTwist                               = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_flTwist"                              );
            public static Int32 m_flRollSpeed                           = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_flRollSpeed"                          );
            public static Int32 m_iMaterialModel                        = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_iMaterialModel"                       );
            public static Int32 m_AmbientLight_m_vPos                   = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_AmbientLight.m_vPos"                  );
            public static Int32 m_AmbientLight_m_vColor                 = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_AmbientLight.m_vColor"                );
            public static Int32 m_AmbientLight_m_flIntensity            = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_AmbientLight.m_flIntensity"           );
            public static Int32 m_DirLight_m_vPos                       = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_DirLight.m_vPos"                      );
            public static Int32 m_DirLight_m_vColor                     = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_DirLight.m_vColor"                    );
            public static Int32 m_DirLight_m_flIntensity                = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_DirLight.m_flIntensity"               );
            public static Int32 m_vWind                                 = g_NtvMngr.GetOffset("DT_SmokeStack"                , "m_vWind"                                );
        }

        public class DT_DustTrail
        {
            static DT_DustTrail() { }
            public static Int32 m_SpawnRate                             = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_SpawnRate"                            );
            public static Int32 m_Color                                 = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_Color"                                );
            public static Int32 m_ParticleLifetime                      = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_ParticleLifetime"                     );
            public static Int32 m_StopEmitTime                          = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_StopEmitTime"                         );
            public static Int32 m_MinSpeed                              = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_MinSpeed"                             );
            public static Int32 m_MaxSpeed                              = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_MaxSpeed"                             );
            public static Int32 m_MinDirectedSpeed                      = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_MinDirectedSpeed"                     );
            public static Int32 m_MaxDirectedSpeed                      = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_MaxDirectedSpeed"                     );
            public static Int32 m_StartSize                             = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_StartSize"                            );
            public static Int32 m_EndSize                               = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_EndSize"                              );
            public static Int32 m_SpawnRadius                           = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_SpawnRadius"                          );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_bEmit"                                );
            public static Int32 m_Opacity                               = g_NtvMngr.GetOffset("DT_DustTrail"                 , "m_Opacity"                              );
        }

        public class DT_FireTrail
        {
            static DT_FireTrail() { }
            public static Int32 m_nAttachment                           = g_NtvMngr.GetOffset("DT_FireTrail"                 , "m_nAttachment"                          );
            public static Int32 m_flLifetime                            = g_NtvMngr.GetOffset("DT_FireTrail"                 , "m_flLifetime"                           );
        }

        public class DT_SporeTrail
        {
            static DT_SporeTrail() { }
            public static Int32 m_flSpawnRate                           = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_flSpawnRate"                          );
            public static Int32 m_vecEndColor                           = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_vecEndColor"                          );
            public static Int32 m_flParticleLifetime                    = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_flParticleLifetime"                   );
            public static Int32 m_flStartSize                           = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_flStartSize"                          );
            public static Int32 m_flEndSize                             = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_flEndSize"                            );
            public static Int32 m_flSpawnRadius                         = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_flSpawnRadius"                        );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_SporeTrail"                , "m_bEmit"                                );
        }

        public class DT_SporeExplosion
        {
            static DT_SporeExplosion() { }
            public static Int32 m_flSpawnRate                           = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_flSpawnRate"                          );
            public static Int32 m_flParticleLifetime                    = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_flParticleLifetime"                   );
            public static Int32 m_flStartSize                           = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_flStartSize"                          );
            public static Int32 m_flEndSize                             = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_flEndSize"                            );
            public static Int32 m_flSpawnRadius                         = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_flSpawnRadius"                        );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_bEmit"                                );
            public static Int32 m_bDontRemove                           = g_NtvMngr.GetOffset("DT_SporeExplosion"            , "m_bDontRemove"                          );
        }

        public class DT_RocketTrail
        {
            static DT_RocketTrail() { }
            public static Int32 m_SpawnRate                             = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_SpawnRate"                            );
            public static Int32 m_StartColor                            = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_StartColor"                           );
            public static Int32 m_EndColor                              = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_EndColor"                             );
            public static Int32 m_ParticleLifetime                      = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_ParticleLifetime"                     );
            public static Int32 m_StopEmitTime                          = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_StopEmitTime"                         );
            public static Int32 m_MinSpeed                              = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_MinSpeed"                             );
            public static Int32 m_MaxSpeed                              = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_MaxSpeed"                             );
            public static Int32 m_StartSize                             = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_StartSize"                            );
            public static Int32 m_EndSize                               = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_EndSize"                              );
            public static Int32 m_SpawnRadius                           = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_SpawnRadius"                          );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_bEmit"                                );
            public static Int32 m_nAttachment                           = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_nAttachment"                          );
            public static Int32 m_Opacity                               = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_Opacity"                              );
            public static Int32 m_bDamaged                              = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_bDamaged"                             );
            public static Int32 m_flFlareScale                          = g_NtvMngr.GetOffset("DT_RocketTrail"               , "m_flFlareScale"                         );
        }

        public class DT_SmokeTrail
        {
            static DT_SmokeTrail() { }
            public static Int32 m_SpawnRate                             = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_SpawnRate"                            );
            public static Int32 m_StartColor                            = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_StartColor"                           );
            public static Int32 m_EndColor                              = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_EndColor"                             );
            public static Int32 m_ParticleLifetime                      = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_ParticleLifetime"                     );
            public static Int32 m_StopEmitTime                          = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_StopEmitTime"                         );
            public static Int32 m_MinSpeed                              = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_MinSpeed"                             );
            public static Int32 m_MaxSpeed                              = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_MaxSpeed"                             );
            public static Int32 m_MinDirectedSpeed                      = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_MinDirectedSpeed"                     );
            public static Int32 m_MaxDirectedSpeed                      = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_MaxDirectedSpeed"                     );
            public static Int32 m_StartSize                             = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_StartSize"                            );
            public static Int32 m_EndSize                               = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_EndSize"                              );
            public static Int32 m_SpawnRadius                           = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_SpawnRadius"                          );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_bEmit"                                );
            public static Int32 m_nAttachment                           = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_nAttachment"                          );
            public static Int32 m_Opacity                               = g_NtvMngr.GetOffset("DT_SmokeTrail"                , "m_Opacity"                              );
        }

        public class DT_PropVehicleDriveable
        {
            static DT_PropVehicleDriveable() { }
            public static Int32 m_hPlayer                               = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_hPlayer"                              );
            public static Int32 m_nSpeed                                = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_nSpeed"                               );
            public static Int32 m_nRPM                                  = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_nRPM"                                 );
            public static Int32 m_flThrottle                            = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_flThrottle"                           );
            public static Int32 m_nBoostTimeLeft                        = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_nBoostTimeLeft"                       );
            public static Int32 m_nHasBoost                             = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_nHasBoost"                            );
            public static Int32 m_nScannerDisabledWeapons               = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_nScannerDisabledWeapons"              );
            public static Int32 m_nScannerDisabledVehicle               = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_nScannerDisabledVehicle"              );
            public static Int32 m_bEnterAnimOn                          = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_bEnterAnimOn"                         );
            public static Int32 m_bExitAnimOn                           = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_bExitAnimOn"                          );
            public static Int32 m_bUnableToFire                         = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_bUnableToFire"                        );
            public static Int32 m_vecEyeExitEndpoint                    = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_vecEyeExitEndpoint"                   );
            public static Int32 m_bHasGun                               = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_bHasGun"                              );
            public static Int32 m_vecGunCrosshair                       = g_NtvMngr.GetOffset("DT_PropVehicleDriveable"      , "m_vecGunCrosshair"                      );
        }

        public class DT_ParticleSmokeGrenade
        {
            static DT_ParticleSmokeGrenade() { }
            public static Int32 m_flSpawnTime                           = g_NtvMngr.GetOffset("DT_ParticleSmokeGrenade"      , "m_flSpawnTime"                          );
            public static Int32 m_FadeStartTime                         = g_NtvMngr.GetOffset("DT_ParticleSmokeGrenade"      , "m_FadeStartTime"                        );
            public static Int32 m_FadeEndTime                           = g_NtvMngr.GetOffset("DT_ParticleSmokeGrenade"      , "m_FadeEndTime"                          );
            public static Int32 m_MinColor                              = g_NtvMngr.GetOffset("DT_ParticleSmokeGrenade"      , "m_MinColor"                             );
            public static Int32 m_MaxColor                              = g_NtvMngr.GetOffset("DT_ParticleSmokeGrenade"      , "m_MaxColor"                             );
            public static Int32 m_CurrentStage                          = g_NtvMngr.GetOffset("DT_ParticleSmokeGrenade"      , "m_CurrentStage"                         );
        }

        public class DT_ParticleFire
        {
            static DT_ParticleFire() { }
            public static Int32 m_vOrigin                               = g_NtvMngr.GetOffset("DT_ParticleFire"              , "m_vOrigin"                              );
            public static Int32 m_vDirection                            = g_NtvMngr.GetOffset("DT_ParticleFire"              , "m_vDirection"                           );
        }

        public class DT_TEGaussExplosion
        {
            static DT_TEGaussExplosion() { }
            public static Int32 m_nType                                 = g_NtvMngr.GetOffset("DT_TEGaussExplosion"          , "m_nType"                                );
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_TEGaussExplosion"          , "m_vecDirection"                         );
        }

        public class DT_QuadraticBeam
        {
            static DT_QuadraticBeam() { }
            public static Int32 m_targetPosition                        = g_NtvMngr.GetOffset("DT_QuadraticBeam"             , "m_targetPosition"                       );
            public static Int32 m_controlPosition                       = g_NtvMngr.GetOffset("DT_QuadraticBeam"             , "m_controlPosition"                      );
            public static Int32 m_scrollRate                            = g_NtvMngr.GetOffset("DT_QuadraticBeam"             , "m_scrollRate"                           );
            public static Int32 m_flWidth                               = g_NtvMngr.GetOffset("DT_QuadraticBeam"             , "m_flWidth"                              );
        }

        public class DT_Embers
        {
            static DT_Embers() { }
            public static Int32 m_nDensity                              = g_NtvMngr.GetOffset("DT_Embers"                    , "m_nDensity"                             );
            public static Int32 m_nLifetime                             = g_NtvMngr.GetOffset("DT_Embers"                    , "m_nLifetime"                            );
            public static Int32 m_nSpeed                                = g_NtvMngr.GetOffset("DT_Embers"                    , "m_nSpeed"                               );
            public static Int32 m_bEmit                                 = g_NtvMngr.GetOffset("DT_Embers"                    , "m_bEmit"                                );
        }

        public class DT_Precipitation
        {
            static DT_Precipitation() { }
            public static Int32 m_nPrecipType                           = g_NtvMngr.GetOffset("DT_Precipitation"             , "m_nPrecipType"                          );
        }

        public class DT_BaseAttributableItem
        {
            static DT_BaseAttributableItem() { }
            public static Int32 m_OriginalOwnerXuidLow                  = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_OriginalOwnerXuidLow"                 );
            public static Int32 m_OriginalOwnerXuidHigh                 = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_OriginalOwnerXuidHigh"                );
            public static Int32 m_nFallbackPaintKit                     = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_nFallbackPaintKit"                    );
            public static Int32 m_nFallbackSeed                         = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_nFallbackSeed"                        );
            public static Int32 m_flFallbackWear                        = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_flFallbackWear"                       );
            public static Int32 m_nFallbackStatTrak                     = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_nFallbackStatTrak"                    );
            public static Int32 m_hOuter                                = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_hOuter"                               );
            public static Int32 m_ProviderType                          = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_ProviderType"                         );
            public static Int32 m_iReapplyProvisionParity               = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iReapplyProvisionParity"              );
            public static Int32 m_iItemDefinitionIndex                  = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iItemDefinitionIndex"                 );
            public static Int32 m_iEntityLevel                          = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iEntityLevel"                         );
            public static Int32 m_iItemIDHigh                           = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iItemIDHigh"                          );
            public static Int32 m_iItemIDLow                            = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iItemIDLow"                           );
            public static Int32 m_iAccountID                            = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iAccountID"                           );
            public static Int32 m_iEntityQuality                        = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_iEntityQuality"                       );
            public static Int32 m_bInitialized                          = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_bInitialized"                         );
            public static Int32 m_szCustomName                          = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_szCustomName"                         );
            public static Int32 m_NetworkedDynamicAttributesForDemos    = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_NetworkedDynamicAttributesForDemos"   );

            public static Int32 m_Item                                  = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_Item"                                 );

            public static Int32 m_AttributeManager                      = g_NtvMngr.GetOffset("DT_BaseAttributableItem"      , "m_AttributeManager"                     );
        }

        public class DT_EconEntity
        {
            static DT_EconEntity() { }
            public static Int32 m_OriginalOwnerXuidLow                  = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_OriginalOwnerXuidLow"                 );
            public static Int32 m_OriginalOwnerXuidHigh                 = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_OriginalOwnerXuidHigh"                );
            public static Int32 m_nFallbackPaintKit                     = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_nFallbackPaintKit"                    );
            public static Int32 m_nFallbackSeed                         = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_nFallbackSeed"                        );
            public static Int32 m_flFallbackWear                        = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_flFallbackWear"                       );
            public static Int32 m_nFallbackStatTrak                     = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_nFallbackStatTrak"                    );
            public static Int32 m_hOuter                                = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_hOuter"                               );
            public static Int32 m_ProviderType                          = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_ProviderType"                         );
            public static Int32 m_iReapplyProvisionParity               = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iReapplyProvisionParity"              );
            public static Int32 m_iItemDefinitionIndex                  = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iItemDefinitionIndex"                 );
            public static Int32 m_iEntityLevel                          = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iEntityLevel"                         );
            public static Int32 m_iItemIDHigh                           = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iItemIDHigh"                          );
            public static Int32 m_iItemIDLow                            = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iItemIDLow"                           );
            public static Int32 m_iAccountID                            = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iAccountID"                           );
            public static Int32 m_iEntityQuality                        = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_iEntityQuality"                       );
            public static Int32 m_bInitialized                          = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_bInitialized"                         );
            public static Int32 m_szCustomName                          = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_szCustomName"                         );
            public static Int32 m_NetworkedDynamicAttributesForDemos    = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_NetworkedDynamicAttributesForDemos"   );

            public static Int32 m_Item                                  = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_Item"                                 );

            public static Int32 m_AttributeManager                      = g_NtvMngr.GetOffset("DT_EconEntity"                , "m_AttributeManager"                     );
        }

        public class DT_WeaponXM1014
        {
            static DT_WeaponXM1014() { }
            public static Int32 m_reloadState                           = g_NtvMngr.GetOffset("DT_WeaponXM1014"              , "m_reloadState"                          );
        }

        public class DT_WeaponTaser
        {
            static DT_WeaponTaser() { }
            public static Int32 m_fFireTime                             = g_NtvMngr.GetOffset("DT_WeaponTaser"               , "m_fFireTime"                            );
        }

        public class DT_WeaponTablet
        {
            static DT_WeaponTablet() { }
            public static Int32 m_flUpgradeExpirationTime_0             = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_flUpgradeExpirationTime[0]"           );
            public static Int32 m_flUpgradeExpirationTime               = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_flUpgradeExpirationTime"              );
            public static Int32 m_vecLocalHexFlags_0                    = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecLocalHexFlags[0]"                  );
            public static Int32 m_vecLocalHexFlags                      = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecLocalHexFlags"                     );
            public static Int32 m_nContractKillGridIndex                = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_nContractKillGridIndex"               );
            public static Int32 m_nContractKillGridHighResIndex         = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_nContractKillGridHighResIndex"        );
            public static Int32 m_bTabletReceptionIsBlocked             = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_bTabletReceptionIsBlocked"            );
            public static Int32 m_flScanProgress                        = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_flScanProgress"                       );
            public static Int32 m_flBootTime                            = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_flBootTime"                           );
            public static Int32 m_flShowMapTime                         = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_flShowMapTime"                        );
            public static Int32 m_vecNotificationIds_0                  = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecNotificationIds[0]"                );
            public static Int32 m_vecNotificationIds                    = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecNotificationIds"                   );
            public static Int32 m_vecNotificationTimestamps_0           = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecNotificationTimestamps[0]"         );
            public static Int32 m_vecNotificationTimestamps             = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecNotificationTimestamps"            );
            public static Int32 m_vecPlayerPositionHistory_0            = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecPlayerPositionHistory[0]"          );
            public static Int32 m_vecPlayerPositionHistory              = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecPlayerPositionHistory"             );
            public static Int32 m_nLastPurchaseIndex                    = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_nLastPurchaseIndex"                   );
            public static Int32 m_vecNearestMetalCratePos               = g_NtvMngr.GetOffset("DT_WeaponTablet"              , "m_vecNearestMetalCratePos"              );
        }

        public class DT_WeaponSawedoff
        {
            static DT_WeaponSawedoff() { }
            public static Int32 m_reloadState                           = g_NtvMngr.GetOffset("DT_WeaponSawedoff"            , "m_reloadState"                          );
        }

        public class DT_WeaponNOVA
        {
            static DT_WeaponNOVA() { }
            public static Int32 m_reloadState                           = g_NtvMngr.GetOffset("DT_WeaponNOVA"                , "m_reloadState"                          );
        }

        public class DT_WeaponMelee
        {
            static DT_WeaponMelee() { }
            public static Int32 m_flThrowAt                             = g_NtvMngr.GetOffset("DT_WeaponMelee"               , "m_flThrowAt"                            );
        }

        public class DT_WeaponM3
        {
            static DT_WeaponM3() { }
            public static Int32 m_reloadState                           = g_NtvMngr.GetOffset("DT_WeaponM3"                  , "m_reloadState"                          );
        }

        public class DT_WeaponFists
        {
            static DT_WeaponFists() { }
            public static Int32 m_bPlayingUninterruptableAct            = g_NtvMngr.GetOffset("DT_WeaponFists"               , "m_bPlayingUninterruptableAct"           );
        }

        public class DT_WeaponCSBaseGun
        {
            static DT_WeaponCSBaseGun() { }
            public static Int32 m_zoomLevel                             = g_NtvMngr.GetOffset("DT_WeaponCSBaseGun"           , "m_zoomLevel"                            );
            public static Int32 m_iBurstShotsRemaining                  = g_NtvMngr.GetOffset("DT_WeaponCSBaseGun"           , "m_iBurstShotsRemaining"                 );
        }

        public class DT_WeaponCSBase
        {
            static DT_WeaponCSBase() { }
            public static Int32 m_weaponMode                            = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_weaponMode"                           );
            public static Int32 m_fAccuracyPenalty                      = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_fAccuracyPenalty"                     );
            public static Int32 m_fLastShotTime                         = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_fLastShotTime"                        );
            public static Int32 m_iRecoilIndex                          = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_iRecoilIndex"                         );
            public static Int32 m_flRecoilIndex                         = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_flRecoilIndex"                        );
            public static Int32 m_hPrevOwner                            = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_hPrevOwner"                           );
            public static Int32 m_bBurstMode                            = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_bBurstMode"                           );
            public static Int32 m_flPostponeFireReadyTime               = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_flPostponeFireReadyTime"              );
            public static Int32 m_bReloadVisuallyComplete               = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_bReloadVisuallyComplete"              );
            public static Int32 m_bSilencerOn                           = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_bSilencerOn"                          );
            public static Int32 m_flDoneSwitchingSilencer               = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_flDoneSwitchingSilencer"              );
            public static Int32 m_iOriginalTeamNumber                   = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_iOriginalTeamNumber"                  );
            public static Int32 m_iIronSightMode                        = g_NtvMngr.GetOffset("DT_WeaponCSBase"              , "m_iIronSightMode"                       );
        }

        public class DT_WeaponC4
        {
            static DT_WeaponC4() { }
            public static Int32 m_bStartedArming                        = g_NtvMngr.GetOffset("DT_WeaponC4"                  , "m_bStartedArming"                       );
            public static Int32 m_bBombPlacedAnimation                  = g_NtvMngr.GetOffset("DT_WeaponC4"                  , "m_bBombPlacedAnimation"                 );
            public static Int32 m_fArmedTime                            = g_NtvMngr.GetOffset("DT_WeaponC4"                  , "m_fArmedTime"                           );
            public static Int32 m_bShowC4LED                            = g_NtvMngr.GetOffset("DT_WeaponC4"                  , "m_bShowC4LED"                           );
            public static Int32 m_bIsPlantingViaUse                     = g_NtvMngr.GetOffset("DT_WeaponC4"                  , "m_bIsPlantingViaUse"                    );
        }

        public class DT_BumpMineProjectile
        {
            static DT_BumpMineProjectile() { }
            public static Int32 m_nParentBoneIndex                      = g_NtvMngr.GetOffset("DT_BumpMineProjectile"        , "m_nParentBoneIndex"                     );
            public static Int32 m_vecParentBonePos                      = g_NtvMngr.GetOffset("DT_BumpMineProjectile"        , "m_vecParentBonePos"                     );
            public static Int32 m_bArmed                                = g_NtvMngr.GetOffset("DT_BumpMineProjectile"        , "m_bArmed"                               );
        }

        public class DT_BreachChargeProjectile
        {
            static DT_BreachChargeProjectile() { }
            public static Int32 m_bShouldExplode                        = g_NtvMngr.GetOffset("DT_BreachChargeProjectile"    , "m_bShouldExplode"                       );
            public static Int32 m_weaponThatThrewMe                     = g_NtvMngr.GetOffset("DT_BreachChargeProjectile"    , "m_weaponThatThrewMe"                    );
            public static Int32 m_nParentBoneIndex                      = g_NtvMngr.GetOffset("DT_BreachChargeProjectile"    , "m_nParentBoneIndex"                     );
            public static Int32 m_vecParentBonePos                      = g_NtvMngr.GetOffset("DT_BreachChargeProjectile"    , "m_vecParentBonePos"                     );
        }

        public class DT_WeaponBaseItem
        {
            static DT_WeaponBaseItem() { }
            public static Int32 m_bRedraw                               = g_NtvMngr.GetOffset("DT_WeaponBaseItem"            , "m_bRedraw"                              );
        }

        public class DT_BaseCSGrenade
        {
            static DT_BaseCSGrenade() { }
            public static Int32 m_bRedraw                               = g_NtvMngr.GetOffset("DT_BaseCSGrenade"             , "m_bRedraw"                              );
            public static Int32 m_bIsHeldByPlayer                       = g_NtvMngr.GetOffset("DT_BaseCSGrenade"             , "m_bIsHeldByPlayer"                      );
            public static Int32 m_bPinPulled                            = g_NtvMngr.GetOffset("DT_BaseCSGrenade"             , "m_bPinPulled"                           );
            public static Int32 m_fThrowTime                            = g_NtvMngr.GetOffset("DT_BaseCSGrenade"             , "m_fThrowTime"                           );
            public static Int32 m_bLoopingSoundPlaying                  = g_NtvMngr.GetOffset("DT_BaseCSGrenade"             , "m_bLoopingSoundPlaying"                 );
            public static Int32 m_flThrowStrength                       = g_NtvMngr.GetOffset("DT_BaseCSGrenade"             , "m_flThrowStrength"                      );
        }

        public class DT_SmokeGrenadeProjectile
        {
            static DT_SmokeGrenadeProjectile() { }
            public static Int32 m_bDidSmokeEffect                       = g_NtvMngr.GetOffset("DT_SmokeGrenadeProjectile"    , "m_bDidSmokeEffect"                      );
            public static Int32 m_nSmokeEffectTickBegin                 = g_NtvMngr.GetOffset("DT_SmokeGrenadeProjectile"    , "m_nSmokeEffectTickBegin"                );
        }

        public class DT_MolotovProjectile
        {
            static DT_MolotovProjectile() { }
            public static Int32 m_bIsIncGrenade                         = g_NtvMngr.GetOffset("DT_MolotovProjectile"         , "m_bIsIncGrenade"                        );
        }

        public class DT_ItemDogtags
        {
            static DT_ItemDogtags() { }
            public static Int32 m_OwningPlayer                          = g_NtvMngr.GetOffset("DT_ItemDogtags"               , "m_OwningPlayer"                         );
            public static Int32 m_KillingPlayer                         = g_NtvMngr.GetOffset("DT_ItemDogtags"               , "m_KillingPlayer"                        );
        }

        public class DT_PhysPropLootCrate
        {
            static DT_PhysPropLootCrate() { }
            public static Int32 m_bRenderInPSPM                         = g_NtvMngr.GetOffset("DT_PhysPropLootCrate"         , "m_bRenderInPSPM"                        );
            public static Int32 m_bRenderInTablet                       = g_NtvMngr.GetOffset("DT_PhysPropLootCrate"         , "m_bRenderInTablet"                      );
            public static Int32 m_iHealth                               = g_NtvMngr.GetOffset("DT_PhysPropLootCrate"         , "m_iHealth"                              );
            public static Int32 m_iMaxHealth                            = g_NtvMngr.GetOffset("DT_PhysPropLootCrate"         , "m_iMaxHealth"                           );
        }

        public class DT_EnvGasCanister
        {
            static DT_EnvGasCanister() { }
            public static Int32 m_flFlightSpeed                         = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flFlightSpeed"                        );
            public static Int32 m_flLaunchTime                          = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flLaunchTime"                         );
            public static Int32 m_vecParabolaDirection                  = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecParabolaDirection"                 );
            public static Int32 m_flFlightTime                          = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flFlightTime"                         );
            public static Int32 m_flWorldEnterTime                      = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flWorldEnterTime"                     );
            public static Int32 m_flInitialZSpeed                       = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flInitialZSpeed"                      );
            public static Int32 m_flZAcceleration                       = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flZAcceleration"                      );
            public static Int32 m_flHorizSpeed                          = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flHorizSpeed"                         );
            public static Int32 m_bLaunchedFromWithinWorld              = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_bLaunchedFromWithinWorld"             );
            public static Int32 m_vecImpactPosition                     = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecImpactPosition"                    );
            public static Int32 m_vecStartPosition                      = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecStartPosition"                     );
            public static Int32 m_vecEnterWorldPosition                 = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecEnterWorldPosition"                );
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecDirection"                         );
            public static Int32 m_vecStartAngles                        = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecStartAngles"                       );
            public static Int32 m_vecSkyboxOrigin                       = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecSkyboxOrigin"                      );
            public static Int32 m_flSkyboxScale                         = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_flSkyboxScale"                        );
            public static Int32 m_bInSkybox                             = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_bInSkybox"                            );
            public static Int32 m_bDoImpactEffects                      = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_bDoImpactEffects"                     );
            public static Int32 m_bLanded                               = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_bLanded"                              );
            public static Int32 m_hSkyboxCopy                           = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_hSkyboxCopy"                          );
            public static Int32 m_nMyZoneIndex                          = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_nMyZoneIndex"                         );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecOrigin"                            );
            public static Int32 m_vecOrigin_2                           = g_NtvMngr.GetOffset("DT_EnvGasCanister"            , "m_vecOrigin[2]"                         );
        }

        public class DT_Dronegun
        {
            static DT_Dronegun() { }
            public static Int32 m_vecAttentionTarget                    = g_NtvMngr.GetOffset("DT_Dronegun"                  , "m_vecAttentionTarget"                   );
            public static Int32 m_vecTargetOffset                       = g_NtvMngr.GetOffset("DT_Dronegun"                  , "m_vecTargetOffset"                      );
            public static Int32 m_iHealth                               = g_NtvMngr.GetOffset("DT_Dronegun"                  , "m_iHealth"                              );
            public static Int32 m_bHasTarget                            = g_NtvMngr.GetOffset("DT_Dronegun"                  , "m_bHasTarget"                           );
        }

        public class DT_ParadropChopper
        {
            static DT_ParadropChopper() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_ParadropChopper"           , "m_vecOrigin"                            );
            public static Int32 m_vecOrigin_2                           = g_NtvMngr.GetOffset("DT_ParadropChopper"           , "m_vecOrigin[2]"                         );
            public static Int32 m_hCallingPlayer                        = g_NtvMngr.GetOffset("DT_ParadropChopper"           , "m_hCallingPlayer"                       );
        }

        public class DT_SurvivalSpawnChopper
        {
            static DT_SurvivalSpawnChopper() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_SurvivalSpawnChopper"      , "m_vecOrigin"                            );
            public static Int32 m_vecOrigin_2                           = g_NtvMngr.GetOffset("DT_SurvivalSpawnChopper"      , "m_vecOrigin[2]"                         );
        }

        public class DT_BRC4Target
        {
            static DT_BRC4Target() { }
            public static Int32 m_bBrokenOpen                           = g_NtvMngr.GetOffset("DT_BRC4Target"                , "m_bBrokenOpen"                          );
            public static Int32 m_flRadius                              = g_NtvMngr.GetOffset("DT_BRC4Target"                , "m_flRadius"                             );
        }

        public class DT_InfoMapRegion
        {
            static DT_InfoMapRegion() { }
            public static Int32 m_flRadius                              = g_NtvMngr.GetOffset("DT_InfoMapRegion"             , "m_flRadius"                             );
            public static Int32 m_szLocToken                            = g_NtvMngr.GetOffset("DT_InfoMapRegion"             , "m_szLocToken"                           );
        }

        public class DT_Inferno
        {
            static DT_Inferno() { }
            public static Int32 m_nFireEffectTickBegin                  = g_NtvMngr.GetOffset("DT_Inferno"                   , "m_nFireEffectTickBegin"                 );
            public static Int32 m_fireCount                             = g_NtvMngr.GetOffset("DT_Inferno"                   , "m_fireCount"                            );
            public static Int32 m_fireXDelta                            = g_NtvMngr.GetOffset("DT_Inferno"                   , "m_fireXDelta"                           );
            public static Int32 m_fireYDelta                            = g_NtvMngr.GetOffset("DT_Inferno"                   , "m_fireYDelta"                           );
            public static Int32 m_fireZDelta                            = g_NtvMngr.GetOffset("DT_Inferno"                   , "m_fireZDelta"                           );
            public static Int32 m_bFireIsBurning                        = g_NtvMngr.GetOffset("DT_Inferno"                   , "m_bFireIsBurning"                       );
        }

        public class DT_CChicken
        {
            static DT_CChicken() { }
            public static Int32 m_jumpedThisFrame                       = g_NtvMngr.GetOffset("DT_CChicken"                  , "m_jumpedThisFrame"                      );
            public static Int32 m_leader                                = g_NtvMngr.GetOffset("DT_CChicken"                  , "m_leader"                               );
        }

        public class DT_Drone
        {
            static DT_Drone() { }
            public static Int32 m_hMoveToThisEntity                     = g_NtvMngr.GetOffset("DT_Drone"                     , "m_hMoveToThisEntity"                    );
            public static Int32 m_hDeliveryCargo                        = g_NtvMngr.GetOffset("DT_Drone"                     , "m_hDeliveryCargo"                       );
            public static Int32 m_bPilotTakeoverAllowed                 = g_NtvMngr.GetOffset("DT_Drone"                     , "m_bPilotTakeoverAllowed"                );
            public static Int32 m_hPotentialCargo                       = g_NtvMngr.GetOffset("DT_Drone"                     , "m_hPotentialCargo"                      );
            public static Int32 m_hCurrentPilot                         = g_NtvMngr.GetOffset("DT_Drone"                     , "m_hCurrentPilot"                        );
            public static Int32 m_vecTagPositions_0                     = g_NtvMngr.GetOffset("DT_Drone"                     , "m_vecTagPositions[0]"                   );
            public static Int32 m_vecTagPositions                       = g_NtvMngr.GetOffset("DT_Drone"                     , "m_vecTagPositions"                      );
            public static Int32 m_vecTagIncrements_0                    = g_NtvMngr.GetOffset("DT_Drone"                     , "m_vecTagIncrements[0]"                  );
            public static Int32 m_vecTagIncrements                      = g_NtvMngr.GetOffset("DT_Drone"                     , "m_vecTagIncrements"                     );
        }

        public class DT_FootstepControl
        {
            static DT_FootstepControl() { }
            public static Int32 m_source                                = g_NtvMngr.GetOffset("DT_FootstepControl"           , "m_source"                               );
            public static Int32 m_destination                           = g_NtvMngr.GetOffset("DT_FootstepControl"           , "m_destination"                          );
        }

        public class DT_TEPlantBomb
        {
            static DT_TEPlantBomb() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEPlantBomb"               , "m_vecOrigin"                            );
            public static Int32 m_iPlayer                               = g_NtvMngr.GetOffset("DT_TEPlantBomb"               , "m_iPlayer"                              );
            public static Int32 m_option                                = g_NtvMngr.GetOffset("DT_TEPlantBomb"               , "m_option"                               );
        }

        public class DT_TEFireBullets
        {
            static DT_TEFireBullets() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_vecOrigin"                            );
            public static Int32 m_vecAngles_0                           = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_vecAngles[0]"                         );
            public static Int32 m_vecAngles_1                           = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_vecAngles[1]"                         );
            public static Int32 m_iWeaponID                             = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_iWeaponID"                            );
            public static Int32 m_weapon                                = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_weapon"                               );
            public static Int32 m_iMode                                 = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_iMode"                                );
            public static Int32 m_iSeed                                 = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_iSeed"                                );
            public static Int32 m_iPlayer                               = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_iPlayer"                              );
            public static Int32 m_fInaccuracy                           = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_fInaccuracy"                          );
            public static Int32 m_fSpread                               = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_fSpread"                              );
            public static Int32 m_nItemDefIndex                         = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_nItemDefIndex"                        );
            public static Int32 m_iSoundType                            = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_iSoundType"                           );
            public static Int32 m_flRecoilIndex                         = g_NtvMngr.GetOffset("DT_TEFireBullets"             , "m_flRecoilIndex"                        );
        }

        public class DT_TERadioIcon
        {
            static DT_TERadioIcon() { }
            public static Int32 m_iAttachToClient                       = g_NtvMngr.GetOffset("DT_TERadioIcon"               , "m_iAttachToClient"                      );
        }

        public class DT_PlantedC4
        {
            static DT_PlantedC4() { }
            public static Int32 m_bBombTicking                          = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_bBombTicking"                         );
            public static Int32 m_nBombSite                             = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_nBombSite"                            );
            public static Int32 m_flC4Blow                              = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_flC4Blow"                             );
            public static Int32 m_flTimerLength                         = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_flTimerLength"                        );
            public static Int32 m_flDefuseLength                        = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_flDefuseLength"                       );
            public static Int32 m_flDefuseCountDown                     = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_flDefuseCountDown"                    );
            public static Int32 m_bBombDefused                          = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_bBombDefused"                         );
            public static Int32 m_hBombDefuser                          = g_NtvMngr.GetOffset("DT_PlantedC4"                 , "m_hBombDefuser"                         );
        }

        public class DT_CSPlayerResource
        {
            static DT_CSPlayerResource() { }
            public static Int32 m_iPlayerC4                             = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iPlayerC4"                            );
            public static Int32 m_iPlayerVIP                            = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iPlayerVIP"                           );
            public static Int32 m_bombsiteCenterA                       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bombsiteCenterA"                      );
            public static Int32 m_bombsiteCenterB                       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bombsiteCenterB"                      );
            public static Int32 m_bEndMatchNextMapAllVoted              = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bEndMatchNextMapAllVoted"             );
            public static Int32 m_bHostageAlive                         = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bHostageAlive"                        );
            public static Int32 m_isHostageFollowingSomeone             = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_isHostageFollowingSomeone"            );
            public static Int32 m_iHostageEntityIDs                     = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iHostageEntityIDs"                    );
            public static Int32 m_hostageRescueX                        = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_hostageRescueX"                       );
            public static Int32 m_hostageRescueY                        = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_hostageRescueY"                       );
            public static Int32 m_hostageRescueZ                        = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_hostageRescueZ"                       );
            public static Int32 m_iMVPs                                 = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMVPs"                                );
            public static Int32 m_iArmor                                = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iArmor"                               );
            public static Int32 m_bHasHelmet                            = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bHasHelmet"                           );
            public static Int32 m_bHasDefuser                           = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bHasDefuser"                          );
            public static Int32 m_iScore                                = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iScore"                               );
            public static Int32 m_iCompetitiveRanking                   = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iCompetitiveRanking"                  );
            public static Int32 m_iCompetitiveWins                      = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iCompetitiveWins"                     );
            public static Int32 m_iCompetitiveRankType                  = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iCompetitiveRankType"                 );
            public static Int32 m_iCompTeammateColor                    = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iCompTeammateColor"                   );
            public static Int32 m_iLifetimeStart                        = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iLifetimeStart"                       );
            public static Int32 m_iLifetimeEnd                          = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iLifetimeEnd"                         );
            public static Int32 m_bControllingBot                       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_bControllingBot"                      );
            public static Int32 m_iControlledPlayer                     = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iControlledPlayer"                    );
            public static Int32 m_iControlledByPlayer                   = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iControlledByPlayer"                  );
            public static Int32 m_iBotDifficulty                        = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iBotDifficulty"                       );
            public static Int32 m_szClan                                = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_szClan"                               );
            public static Int32 m_nCharacterDefIndex                    = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nCharacterDefIndex"                   );
            public static Int32 m_iTotalCashSpent                       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iTotalCashSpent"                      );
            public static Int32 m_iGunGameLevel                         = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iGunGameLevel"                        );
            public static Int32 m_iCashSpentThisRound                   = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iCashSpentThisRound"                  );
            public static Int32 m_nEndMatchNextMapVotes                 = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nEndMatchNextMapVotes"                );
            public static Int32 m_nActiveCoinRank                       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nActiveCoinRank"                      );
            public static Int32 m_nMusicID                              = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nMusicID"                             );
            public static Int32 m_nPersonaDataPublicLevel               = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nPersonaDataPublicLevel"              );
            public static Int32 m_nPersonaDataPublicCommendsLeader      = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nPersonaDataPublicCommendsLeader"     );
            public static Int32 m_nPersonaDataPublicCommendsTeacher     = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nPersonaDataPublicCommendsTeacher"    );
            public static Int32 m_nPersonaDataPublicCommendsFriendly    = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_nPersonaDataPublicCommendsFriendly"   );
            public static Int32 m_iMatchStats_Kills_Total               = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_Kills_Total"              );
            public static Int32 m_iMatchStats_5k_Total                  = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_5k_Total"                 );
            public static Int32 m_iMatchStats_4k_Total                  = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_4k_Total"                 );
            public static Int32 m_iMatchStats_3k_Total                  = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_3k_Total"                 );
            public static Int32 m_iMatchStats_Damage_Total              = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_Damage_Total"             );
            public static Int32 m_iMatchStats_EquipmentValue_Total      = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_EquipmentValue_Total"     );
            public static Int32 m_iMatchStats_KillReward_Total          = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_KillReward_Total"         );
            public static Int32 m_iMatchStats_LiveTime_Total            = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_LiveTime_Total"           );
            public static Int32 m_iMatchStats_Deaths_Total              = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_Deaths_Total"             );
            public static Int32 m_iMatchStats_Assists_Total             = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_Assists_Total"            );
            public static Int32 m_iMatchStats_HeadShotKills_Total       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_HeadShotKills_Total"      );
            public static Int32 m_iMatchStats_Objective_Total           = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_Objective_Total"          );
            public static Int32 m_iMatchStats_CashEarned_Total          = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_CashEarned_Total"         );
            public static Int32 m_iMatchStats_UtilityDamage_Total       = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_UtilityDamage_Total"      );
            public static Int32 m_iMatchStats_EnemiesFlashed_Total      = g_NtvMngr.GetOffset("DT_CSPlayerResource"          , "m_iMatchStats_EnemiesFlashed_Total"     );
        }

        public class DT_CSPlayer
        {
            static DT_CSPlayer() { }
            public static Int32 m_angEyeAngles_0                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_angEyeAngles[0]"                      );
            public static Int32 m_angEyeAngles_1                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_angEyeAngles[1]"                      );
            public static Int32 m_iAddonBits                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iAddonBits"                           );
            public static Int32 m_iPrimaryAddon                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iPrimaryAddon"                        );
            public static Int32 m_iSecondaryAddon                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iSecondaryAddon"                      );
            public static Int32 m_iThrowGrenadeCounter                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iThrowGrenadeCounter"                 );
            public static Int32 m_bWaitForNoAttack                      = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bWaitForNoAttack"                     );
            public static Int32 m_bIsRespawningForDMBonus               = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsRespawningForDMBonus"              );
            public static Int32 m_iPlayerState                          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iPlayerState"                         );
            public static Int32 m_iAccount                              = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iAccount"                             );
            public static Int32 m_iStartAccount                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iStartAccount"                        );
            public static Int32 m_totalHitsOnServer                     = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_totalHitsOnServer"                    );
            public static Int32 m_bInBombZone                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bInBombZone"                          );
            public static Int32 m_bInBuyZone                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bInBuyZone"                           );
            public static Int32 m_bInNoDefuseArea                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bInNoDefuseArea"                      );
            public static Int32 m_bKilledByTaser                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bKilledByTaser"                       );
            public static Int32 m_iMoveState                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMoveState"                           );
            public static Int32 m_iClass                                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iClass"                               );
            public static Int32 m_ArmorValue                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_ArmorValue"                           );
            public static Int32 m_angEyeAngles                          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_angEyeAngles"                         );
            public static Int32 m_bHasDefuser                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasDefuser"                          );
            public static Int32 m_bNightVisionOn                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bNightVisionOn"                       );
            public static Int32 m_bHasNightVision                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasNightVision"                      );
            public static Int32 m_bInHostageRescueZone                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bInHostageRescueZone"                 );
            public static Int32 m_bIsDefusing                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsDefusing"                          );
            public static Int32 m_bIsGrabbingHostage                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsGrabbingHostage"                   );
            public static Int32 m_iBlockingUseActionInProgress          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iBlockingUseActionInProgress"         );
            public static Int32 m_bIsScoped                             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsScoped"                            );
            public static Int32 m_bIsWalking                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsWalking"                           );
            public static Int32 m_nIsAutoMounting                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nIsAutoMounting"                      );
            public static Int32 m_bResumeZoom                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bResumeZoom"                          );
            public static Int32 m_fImmuneToGunGameDamageTime            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_fImmuneToGunGameDamageTime"           );
            public static Int32 m_bGunGameImmunity                      = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bGunGameImmunity"                     );
            public static Int32 m_bHasMovedSinceSpawn                   = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasMovedSinceSpawn"                  );
            public static Int32 m_bMadeFinalGunGameProgressiveKill      = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bMadeFinalGunGameProgressiveKill"     );
            public static Int32 m_iGunGameProgressiveWeaponIndex        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iGunGameProgressiveWeaponIndex"       );
            public static Int32 m_iNumGunGameTRKillPoints               = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iNumGunGameTRKillPoints"              );
            public static Int32 m_iNumGunGameKillsWithCurrentWeapon     = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iNumGunGameKillsWithCurrentWeapon"    );
            public static Int32 m_iNumRoundKills                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iNumRoundKills"                       );
            public static Int32 m_fMolotovUseTime                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_fMolotovUseTime"                      );
            public static Int32 m_fMolotovDamageTime                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_fMolotovDamageTime"                   );
            public static Int32 m_szArmsModel                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_szArmsModel"                          );
            public static Int32 m_hCarriedHostage                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_hCarriedHostage"                      );
            public static Int32 m_hCarriedHostageProp                   = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_hCarriedHostageProp"                  );
            public static Int32 m_bIsRescuing                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsRescuing"                          );
            public static Int32 m_flGroundAccelLinearFracLastTime       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flGroundAccelLinearFracLastTime"      );
            public static Int32 m_bCanMoveDuringFreezePeriod            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bCanMoveDuringFreezePeriod"           );
            public static Int32 m_isCurrentGunGameLeader                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_isCurrentGunGameLeader"               );
            public static Int32 m_isCurrentGunGameTeamLeader            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_isCurrentGunGameTeamLeader"           );
            public static Int32 m_flGuardianTooFarDistFrac              = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flGuardianTooFarDistFrac"             );
            public static Int32 m_flDetectedByEnemySensorTime           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flDetectedByEnemySensorTime"          );
            public static Int32 m_bIsPlayerGhost                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsPlayerGhost"                       );
            public static Int32 m_bHasParachute                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasParachute"                        );
            public static Int32 m_unMusicID                             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_unMusicID"                            );
            public static Int32 m_bHasHelmet                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasHelmet"                           );
            public static Int32 m_bHasHeavyArmor                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasHeavyArmor"                       );
            public static Int32 m_nHeavyAssaultSuitCooldownRemaining    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nHeavyAssaultSuitCooldownRemaining"   );
            public static Int32 m_flFlashDuration                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flFlashDuration"                      );
            public static Int32 m_flFlashMaxAlpha                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flFlashMaxAlpha"                      );
            public static Int32 m_iProgressBarDuration                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iProgressBarDuration"                 );
            public static Int32 m_flProgressBarStartTime                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flProgressBarStartTime"               );
            public static Int32 m_hRagdoll                              = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_hRagdoll"                             );
            public static Int32 m_hPlayerPing                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_hPlayerPing"                          );
            public static Int32 m_cycleLatch                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_cycleLatch"                           );
            public static Int32 m_unCurrentEquipmentValue               = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_unCurrentEquipmentValue"              );
            public static Int32 m_unRoundStartEquipmentValue            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_unRoundStartEquipmentValue"           );
            public static Int32 m_unFreezetimeEndEquipmentValue         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_unFreezetimeEndEquipmentValue"        );
            public static Int32 m_bIsControllingBot                     = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsControllingBot"                    );
            public static Int32 m_bHasControlledBotThisRound            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHasControlledBotThisRound"           );
            public static Int32 m_bCanControlObservedBot                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bCanControlObservedBot"               );
            public static Int32 m_iControlledBotEntIndex                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iControlledBotEntIndex"               );
            public static Int32 m_vecAutomoveTargetEnd                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_vecAutomoveTargetEnd"                 );
            public static Int32 m_flAutoMoveStartTime                   = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flAutoMoveStartTime"                  );
            public static Int32 m_flAutoMoveTargetTime                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flAutoMoveTargetTime"                 );
            public static Int32 m_bIsAssassinationTarget                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsAssassinationTarget"               );
            public static Int32 m_bHud_MiniScoreHidden                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHud_MiniScoreHidden"                 );
            public static Int32 m_bHud_RadarHidden                      = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHud_RadarHidden"                     );
            public static Int32 m_nLastKillerIndex                      = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nLastKillerIndex"                     );
            public static Int32 m_nLastConcurrentKilled                 = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nLastConcurrentKilled"                );
            public static Int32 m_nDeathCamMusic                        = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nDeathCamMusic"                       );
            public static Int32 m_bIsHoldingLookAtWeapon                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsHoldingLookAtWeapon"               );
            public static Int32 m_bIsLookingAtWeapon                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsLookingAtWeapon"                   );
            public static Int32 m_iNumRoundKillsHeadshots               = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iNumRoundKillsHeadshots"              );
            public static Int32 m_unTotalRoundDamageDealt               = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_unTotalRoundDamageDealt"              );
            public static Int32 m_flLowerBodyYawTarget                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flLowerBodyYawTarget"                 );
            public static Int32 m_bStrafing                             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bStrafing"                            );
            public static Int32 m_flThirdpersonRecoil                   = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flThirdpersonRecoil"                  );
            public static Int32 m_bHideTargetID                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bHideTargetID"                        );
            public static Int32 m_bIsSpawnRappelling                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bIsSpawnRappelling"                   );
            public static Int32 m_vecSpawnRappellingRopeOrigin          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_vecSpawnRappellingRopeOrigin"         );
            public static Int32 m_nSurvivalTeam                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nSurvivalTeam"                        );
            public static Int32 m_hSurvivalAssassinationTarget          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_hSurvivalAssassinationTarget"         );
            public static Int32 m_flHealthShotBoostExpirationTime       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flHealthShotBoostExpirationTime"      );
            public static Int32 m_flLastExoJumpTime                     = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flLastExoJumpTime"                    );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_vecOrigin"                            );
            public static Int32 m_vecOrigin_2                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_vecOrigin[2]"                         );
            public static Int32 m_flStamina                             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flStamina"                            );
            public static Int32 m_iDirection                            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iDirection"                           );
            public static Int32 m_iShotsFired                           = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iShotsFired"                          );
            public static Int32 m_nNumFastDucks                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nNumFastDucks"                        );
            public static Int32 m_bDuckOverride                         = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bDuckOverride"                        );
            public static Int32 m_flVelocityModifier                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_flVelocityModifier"                   );
            public static Int32 m_unActiveQuestId                       = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_unActiveQuestId"                      );
            public static Int32 m_nQuestProgressReason                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_nQuestProgressReason"                 );
            public static Int32 m_bPlayerDominated                      = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bPlayerDominated"                     );
            public static Int32 m_bPlayerDominatingMe                   = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_bPlayerDominatingMe"                  );
            public static Int32 m_iWeaponPurchasesThisRound             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iWeaponPurchasesThisRound"            );

            public static Int32 cslocaldata                             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "cslocaldata"                            );

            public static Int32 csnonlocaldata                          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "csnonlocaldata"                         );
            public static Int32 csteamdata                              = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "csteamdata"                             );
            public static Int32 m_iMatchStats_Kills                     = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_Kills"                    );
            public static Int32 m_iMatchStats_Damage                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_Damage"                   );
            public static Int32 m_iMatchStats_EquipmentValue            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_EquipmentValue"           );
            public static Int32 m_iMatchStats_MoneySaved                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_MoneySaved"               );
            public static Int32 m_iMatchStats_KillReward                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_KillReward"               );
            public static Int32 m_iMatchStats_LiveTime                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_LiveTime"                 );
            public static Int32 m_iMatchStats_Deaths                    = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_Deaths"                   );
            public static Int32 m_iMatchStats_Assists                   = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_Assists"                  );
            public static Int32 m_iMatchStats_HeadShotKills             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_HeadShotKills"            );
            public static Int32 m_iMatchStats_Objective                 = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_Objective"                );
            public static Int32 m_iMatchStats_CashEarned                = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_CashEarned"               );
            public static Int32 m_iMatchStats_UtilityDamage             = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_UtilityDamage"            );
            public static Int32 m_iMatchStats_EnemiesFlashed            = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_iMatchStats_EnemiesFlashed"           );
            public static Int32 m_rank                                  = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_rank"                                 );
            public static Int32 m_passiveItems                          = g_NtvMngr.GetOffset("DT_CSPlayer"                  , "m_passiveItems"                         );
        }

        public class DT_PlayerPing
        {
            static DT_PlayerPing() { }
            public static Int32 m_hPlayer                               = g_NtvMngr.GetOffset("DT_PlayerPing"                , "m_hPlayer"                              );
            public static Int32 m_hPingedEntity                         = g_NtvMngr.GetOffset("DT_PlayerPing"                , "m_hPingedEntity"                        );
            public static Int32 m_iType                                 = g_NtvMngr.GetOffset("DT_PlayerPing"                , "m_iType"                                );
        }

        public class DT_CSRagdoll
        {
            static DT_CSRagdoll() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_vecOrigin"                            );
            public static Int32 m_vecRagdollOrigin                      = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_vecRagdollOrigin"                     );
            public static Int32 m_hPlayer                               = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_hPlayer"                              );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_nModelIndex"                          );
            public static Int32 m_nForceBone                            = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_nForceBone"                           );
            public static Int32 m_vecForce                              = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_vecForce"                             );
            public static Int32 m_vecRagdollVelocity                    = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_vecRagdollVelocity"                   );
            public static Int32 m_iDeathPose                            = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_iDeathPose"                           );
            public static Int32 m_iDeathFrame                           = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_iDeathFrame"                          );
            public static Int32 m_iTeamNum                              = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_iTeamNum"                             );
            public static Int32 m_bClientSideAnimation                  = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_bClientSideAnimation"                 );
            public static Int32 m_flDeathYaw                            = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_flDeathYaw"                           );
            public static Int32 m_flAbsYaw                              = g_NtvMngr.GetOffset("DT_CSRagdoll"                 , "m_flAbsYaw"                             );
        }

        public class DT_TEPlayerAnimEvent
        {
            static DT_TEPlayerAnimEvent() { }
            public static Int32 m_hPlayer                               = g_NtvMngr.GetOffset("DT_TEPlayerAnimEvent"         , "m_hPlayer"                              );
            public static Int32 m_iEvent                                = g_NtvMngr.GetOffset("DT_TEPlayerAnimEvent"         , "m_iEvent"                               );
            public static Int32 m_nData                                 = g_NtvMngr.GetOffset("DT_TEPlayerAnimEvent"         , "m_nData"                                );
        }

        public class DT_CHostage
        {
            static DT_CHostage() { }
            public static Int32 m_isRescued                             = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_isRescued"                            );
            public static Int32 m_jumpedThisFrame                       = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_jumpedThisFrame"                      );
            public static Int32 m_iHealth                               = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_iHealth"                              );
            public static Int32 m_iMaxHealth                            = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_iMaxHealth"                           );
            public static Int32 m_lifeState                             = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_lifeState"                            );
            public static Int32 m_fFlags                                = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_fFlags"                               );
            public static Int32 m_nHostageState                         = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_nHostageState"                        );
            public static Int32 m_flRescueStartTime                     = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_flRescueStartTime"                    );
            public static Int32 m_flGrabSuccessTime                     = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_flGrabSuccessTime"                    );
            public static Int32 m_flDropStartTime                       = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_flDropStartTime"                      );
            public static Int32 m_vel                                   = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_vel"                                  );
            public static Int32 m_leader                                = g_NtvMngr.GetOffset("DT_CHostage"                  , "m_leader"                               );
        }

        public class DT_BaseCSGrenadeProjectile
        {
            static DT_BaseCSGrenadeProjectile() { }
            public static Int32 m_vInitialVelocity                      = g_NtvMngr.GetOffset("DT_BaseCSGrenadeProjectile"   , "m_vInitialVelocity"                     );
            public static Int32 m_nBounces                              = g_NtvMngr.GetOffset("DT_BaseCSGrenadeProjectile"   , "m_nBounces"                             );
            public static Int32 m_nExplodeEffectIndex                   = g_NtvMngr.GetOffset("DT_BaseCSGrenadeProjectile"   , "m_nExplodeEffectIndex"                  );
            public static Int32 m_nExplodeEffectTickBegin               = g_NtvMngr.GetOffset("DT_BaseCSGrenadeProjectile"   , "m_nExplodeEffectTickBegin"              );
            public static Int32 m_vecExplodeEffectOrigin                = g_NtvMngr.GetOffset("DT_BaseCSGrenadeProjectile"   , "m_vecExplodeEffectOrigin"               );
        }

        public class DT_HandleTest
        {
            static DT_HandleTest() { }
            public static Int32 m_Handle                                = g_NtvMngr.GetOffset("DT_HandleTest"                , "m_Handle"                               );
            public static Int32 m_bSendHandle                           = g_NtvMngr.GetOffset("DT_HandleTest"                , "m_bSendHandle"                          );
        }

        public class DT_SpriteTrail
        {
            static DT_SpriteTrail() { }
            public static Int32 m_flLifeTime                            = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flLifeTime"                           );
            public static Int32 m_flStartWidth                          = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flStartWidth"                         );
            public static Int32 m_flEndWidth                            = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flEndWidth"                           );
            public static Int32 m_flStartWidthVariance                  = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flStartWidthVariance"                 );
            public static Int32 m_flTextureRes                          = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flTextureRes"                         );
            public static Int32 m_flMinFadeLength                       = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flMinFadeLength"                      );
            public static Int32 m_vecSkyboxOrigin                       = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_vecSkyboxOrigin"                      );
            public static Int32 m_flSkyboxScale                         = g_NtvMngr.GetOffset("DT_SpriteTrail"               , "m_flSkyboxScale"                        );
        }

        public class DT_Sprite
        {
            static DT_Sprite() { }
            public static Int32 m_hAttachedToEntity                     = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_hAttachedToEntity"                    );
            public static Int32 m_nAttachment                           = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_nAttachment"                          );
            public static Int32 m_flScaleTime                           = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flScaleTime"                          );
            public static Int32 m_flSpriteScale                         = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flSpriteScale"                        );
            public static Int32 m_flSpriteFramerate                     = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flSpriteFramerate"                    );
            public static Int32 m_flGlowProxySize                       = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flGlowProxySize"                      );
            public static Int32 m_flHDRColorScale                       = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flHDRColorScale"                      );
            public static Int32 m_flFrame                               = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flFrame"                              );
            public static Int32 m_flBrightnessTime                      = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_flBrightnessTime"                     );
            public static Int32 m_nBrightness                           = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_nBrightness"                          );
            public static Int32 m_bWorldSpaceScale                      = g_NtvMngr.GetOffset("DT_Sprite"                    , "m_bWorldSpaceScale"                     );
        }

        public class DT_Ragdoll_Attached
        {
            static DT_Ragdoll_Attached() { }
            public static Int32 m_boneIndexAttached                     = g_NtvMngr.GetOffset("DT_Ragdoll_Attached"          , "m_boneIndexAttached"                    );
            public static Int32 m_ragdollAttachedObjectIndex            = g_NtvMngr.GetOffset("DT_Ragdoll_Attached"          , "m_ragdollAttachedObjectIndex"           );
            public static Int32 m_attachmentPointBoneSpace              = g_NtvMngr.GetOffset("DT_Ragdoll_Attached"          , "m_attachmentPointBoneSpace"             );
            public static Int32 m_attachmentPointRagdollSpace           = g_NtvMngr.GetOffset("DT_Ragdoll_Attached"          , "m_attachmentPointRagdollSpace"          );
        }

        public class DT_Ragdoll
        {
            static DT_Ragdoll() { }
            public static Int32 m_ragAngles_0                           = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_ragAngles[0]"                         );
            public static Int32 m_ragAngles                             = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_ragAngles"                            );
            public static Int32 m_ragPos_0                              = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_ragPos[0]"                            );
            public static Int32 m_ragPos                                = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_ragPos"                               );
            public static Int32 m_hUnragdoll                            = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_hUnragdoll"                           );
            public static Int32 m_flBlendWeight                         = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_flBlendWeight"                        );
            public static Int32 m_nOverlaySequence                      = g_NtvMngr.GetOffset("DT_Ragdoll"                   , "m_nOverlaySequence"                     );
        }

        public class DT_PropCounter
        {
            static DT_PropCounter() { }
            public static Int32 m_flDisplayValue                        = g_NtvMngr.GetOffset("DT_PropCounter"               , "m_flDisplayValue"                       );
        }

        public class DT_PoseController
        {
            static DT_PoseController() { }
            public static Int32 m_bPoseValueParity                      = g_NtvMngr.GetOffset("DT_PoseController"            , "m_bPoseValueParity"                     );
            public static Int32 m_fPoseValue                            = g_NtvMngr.GetOffset("DT_PoseController"            , "m_fPoseValue"                           );
            public static Int32 m_fInterpolationTime                    = g_NtvMngr.GetOffset("DT_PoseController"            , "m_fInterpolationTime"                   );
            public static Int32 m_bInterpolationWrap                    = g_NtvMngr.GetOffset("DT_PoseController"            , "m_bInterpolationWrap"                   );
            public static Int32 m_fCycleFrequency                       = g_NtvMngr.GetOffset("DT_PoseController"            , "m_fCycleFrequency"                      );
            public static Int32 m_nFModType                             = g_NtvMngr.GetOffset("DT_PoseController"            , "m_nFModType"                            );
            public static Int32 m_fFModTimeOffset                       = g_NtvMngr.GetOffset("DT_PoseController"            , "m_fFModTimeOffset"                      );
            public static Int32 m_fFModRate                             = g_NtvMngr.GetOffset("DT_PoseController"            , "m_fFModRate"                            );
            public static Int32 m_fFModAmplitude                        = g_NtvMngr.GetOffset("DT_PoseController"            , "m_fFModAmplitude"                       );
            public static Int32 m_hProps                                = g_NtvMngr.GetOffset("DT_PoseController"            , "m_hProps"                               );
            public static Int32 m_chPoseIndex                           = g_NtvMngr.GetOffset("DT_PoseController"            , "m_chPoseIndex"                          );
        }

        public class DT_GrassBurn
        {
            static DT_GrassBurn() { }
            public static Int32 m_flGrassBurnClearTime                  = g_NtvMngr.GetOffset("DT_GrassBurn"                 , "m_flGrassBurnClearTime"                 );
        }

        public class DT_FuncLadder
        {
            static DT_FuncLadder() { }
            public static Int32 m_vecPlayerMountPositionTop             = g_NtvMngr.GetOffset("DT_FuncLadder"                , "m_vecPlayerMountPositionTop"            );
            public static Int32 m_vecPlayerMountPositionBottom          = g_NtvMngr.GetOffset("DT_FuncLadder"                , "m_vecPlayerMountPositionBottom"         );
            public static Int32 m_vecLadderDir                          = g_NtvMngr.GetOffset("DT_FuncLadder"                , "m_vecLadderDir"                         );
            public static Int32 m_bFakeLadder                           = g_NtvMngr.GetOffset("DT_FuncLadder"                , "m_bFakeLadder"                          );
        }

        public class DT_TEFoundryHelpers
        {
            static DT_TEFoundryHelpers() { }
            public static Int32 m_iEntity                               = g_NtvMngr.GetOffset("DT_TEFoundryHelpers"          , "m_iEntity"                              );
        }

        public class DT_DetailController
        {
            static DT_DetailController() { }
            public static Int32 m_flFadeStartDist                       = g_NtvMngr.GetOffset("DT_DetailController"          , "m_flFadeStartDist"                      );
            public static Int32 m_flFadeEndDist                         = g_NtvMngr.GetOffset("DT_DetailController"          , "m_flFadeEndDist"                        );
        }

        public class DT_DangerZone
        {
            static DT_DangerZone() { }
            public static Int32 m_vecDangerZoneOriginStartedAt          = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_vecDangerZoneOriginStartedAt"         );
            public static Int32 m_flBombLaunchTime                      = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_flBombLaunchTime"                     );
            public static Int32 m_flExtraRadius                         = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_flExtraRadius"                        );
            public static Int32 m_flExtraRadiusStartTime                = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_flExtraRadiusStartTime"               );
            public static Int32 m_flExtraRadiusTotalLerpTime            = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_flExtraRadiusTotalLerpTime"           );
            public static Int32 m_nDropOrder                            = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_nDropOrder"                           );
            public static Int32 m_iWave                                 = g_NtvMngr.GetOffset("DT_DangerZone"                , "m_iWave"                                );
        }

        public class DT_DangerZoneController
        {
            static DT_DangerZoneController() { }
            public static Int32 m_bDangerZoneControllerEnabled          = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_bDangerZoneControllerEnabled"         );
            public static Int32 m_bMissionControlledExplosions          = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_bMissionControlledExplosions"         );
            public static Int32 m_flStartTime                           = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_flStartTime"                          );
            public static Int32 m_flFinalExpansionTime                  = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_flFinalExpansionTime"                 );
            public static Int32 m_vecEndGameCircleStart                 = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_vecEndGameCircleStart"                );
            public static Int32 m_vecEndGameCircleEnd                   = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_vecEndGameCircleEnd"                  );
            public static Int32 m_hTheFinalZone                         = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_hTheFinalZone"                        );
            public static Int32 m_DangerZones                           = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_DangerZones"                          );
            public static Int32 m_flWaveEndTimes                        = g_NtvMngr.GetOffset("DT_DangerZoneController"      , "m_flWaveEndTimes"                       );
        }

        public class DT_WorldVguiText
        {
            static DT_WorldVguiText() { }
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_WorldVguiText"             , "m_bEnabled"                             );
            public static Int32 m_szDisplayText                         = g_NtvMngr.GetOffset("DT_WorldVguiText"             , "m_szDisplayText"                        );
            public static Int32 m_szDisplayTextOption                   = g_NtvMngr.GetOffset("DT_WorldVguiText"             , "m_szDisplayTextOption"                  );
            public static Int32 m_szFont                                = g_NtvMngr.GetOffset("DT_WorldVguiText"             , "m_szFont"                               );
            public static Int32 m_iTextPanelWidth                       = g_NtvMngr.GetOffset("DT_WorldVguiText"             , "m_iTextPanelWidth"                      );
            public static Int32 m_clrText                               = g_NtvMngr.GetOffset("DT_WorldVguiText"             , "m_clrText"                              );
        }

        public class DT_World
        {
            static DT_World() { }
            public static Int32 m_flWaveHeight                          = g_NtvMngr.GetOffset("DT_World"                     , "m_flWaveHeight"                         );
            public static Int32 m_WorldMins                             = g_NtvMngr.GetOffset("DT_World"                     , "m_WorldMins"                            );
            public static Int32 m_WorldMaxs                             = g_NtvMngr.GetOffset("DT_World"                     , "m_WorldMaxs"                            );
            public static Int32 m_bStartDark                            = g_NtvMngr.GetOffset("DT_World"                     , "m_bStartDark"                           );
            public static Int32 m_flMaxOccludeeArea                     = g_NtvMngr.GetOffset("DT_World"                     , "m_flMaxOccludeeArea"                    );
            public static Int32 m_flMinOccluderArea                     = g_NtvMngr.GetOffset("DT_World"                     , "m_flMinOccluderArea"                    );
            public static Int32 m_flMaxPropScreenSpaceWidth             = g_NtvMngr.GetOffset("DT_World"                     , "m_flMaxPropScreenSpaceWidth"            );
            public static Int32 m_flMinPropScreenSpaceWidth             = g_NtvMngr.GetOffset("DT_World"                     , "m_flMinPropScreenSpaceWidth"            );
            public static Int32 m_iszDetailSpriteMaterial               = g_NtvMngr.GetOffset("DT_World"                     , "m_iszDetailSpriteMaterial"              );
            public static Int32 m_bColdWorld                            = g_NtvMngr.GetOffset("DT_World"                     , "m_bColdWorld"                           );
            public static Int32 m_iTimeOfDay                            = g_NtvMngr.GetOffset("DT_World"                     , "m_iTimeOfDay"                           );
        }

        public class DT_WaterLODControl
        {
            static DT_WaterLODControl() { }
            public static Int32 m_flCheapWaterStartDistance             = g_NtvMngr.GetOffset("DT_WaterLODControl"           , "m_flCheapWaterStartDistance"            );
            public static Int32 m_flCheapWaterEndDistance               = g_NtvMngr.GetOffset("DT_WaterLODControl"           , "m_flCheapWaterEndDistance"              );
        }

        public class DT_VoteController
        {
            static DT_VoteController() { }
            public static Int32 m_iActiveIssueIndex                     = g_NtvMngr.GetOffset("DT_VoteController"            , "m_iActiveIssueIndex"                    );
            public static Int32 m_iOnlyTeamToVote                       = g_NtvMngr.GetOffset("DT_VoteController"            , "m_iOnlyTeamToVote"                      );
            public static Int32 m_nPotentialVotes                       = g_NtvMngr.GetOffset("DT_VoteController"            , "m_nPotentialVotes"                      );
            public static Int32 m_bIsYesNoVote                          = g_NtvMngr.GetOffset("DT_VoteController"            , "m_bIsYesNoVote"                         );
            public static Int32 m_nVoteOptionCount                      = g_NtvMngr.GetOffset("DT_VoteController"            , "m_nVoteOptionCount"                     );
        }

        public class DT_VGuiScreen
        {
            static DT_VGuiScreen() { }
            public static Int32 m_flWidth                               = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_flWidth"                              );
            public static Int32 m_flHeight                              = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_flHeight"                             );
            public static Int32 m_fScreenFlags                          = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_fScreenFlags"                         );
            public static Int32 m_nPanelName                            = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_nPanelName"                           );
            public static Int32 m_nAttachmentIndex                      = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_nAttachmentIndex"                     );
            public static Int32 m_nOverlayMaterial                      = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_nOverlayMaterial"                     );
            public static Int32 m_hPlayerOwner                          = g_NtvMngr.GetOffset("DT_VGuiScreen"                , "m_hPlayerOwner"                         );
        }

        public class DT_PropJeep
        {
            static DT_PropJeep() { }
            public static Int32 m_bHeadlightIsOn                        = g_NtvMngr.GetOffset("DT_PropJeep"                  , "m_bHeadlightIsOn"                       );
        }

        public class DT_PropVehicleChoreoGeneric
        {
            static DT_PropVehicleChoreoGeneric() { }
            public static Int32 m_hPlayer                               = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_hPlayer"                              );
            public static Int32 m_bEnterAnimOn                          = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_bEnterAnimOn"                         );
            public static Int32 m_bExitAnimOn                           = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_bExitAnimOn"                          );
            public static Int32 m_bForceEyesToAttachment                = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_bForceEyesToAttachment"               );
            public static Int32 m_vecEyeExitEndpoint                    = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vecEyeExitEndpoint"                   );
            public static Int32 m_vehicleView_bClampEyeAngles           = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.bClampEyeAngles"          );
            public static Int32 m_vehicleView_flPitchCurveZero          = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flPitchCurveZero"         );
            public static Int32 m_vehicleView_flPitchCurveLinear        = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flPitchCurveLinear"       );
            public static Int32 m_vehicleView_flRollCurveZero           = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flRollCurveZero"          );
            public static Int32 m_vehicleView_flRollCurveLinear         = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flRollCurveLinear"        );
            public static Int32 m_vehicleView_flFOV                     = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flFOV"                    );
            public static Int32 m_vehicleView_flYawMin                  = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flYawMin"                 );
            public static Int32 m_vehicleView_flYawMax                  = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flYawMax"                 );
            public static Int32 m_vehicleView_flPitchMin                = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flPitchMin"               );
            public static Int32 m_vehicleView_flPitchMax                = g_NtvMngr.GetOffset("DT_PropVehicleChoreoGeneric"  , "m_vehicleView.flPitchMax"               );
        }

        public class DT_TriggerSoundOperator
        {
            static DT_TriggerSoundOperator() { }
            public static Int32 m_nSoundOperator                        = g_NtvMngr.GetOffset("DT_TriggerSoundOperator"      , "m_nSoundOperator"                       );
        }

        public class DT_BaseTrigger
        {
            static DT_BaseTrigger() { }
            public static Int32 m_bClientSidePredicted                  = g_NtvMngr.GetOffset("DT_BaseTrigger"               , "m_bClientSidePredicted"                 );
            public static Int32 m_spawnflags                            = g_NtvMngr.GetOffset("DT_BaseTrigger"               , "m_spawnflags"                           );
        }

        public class DT_Tesla
        {
            static DT_Tesla() { }
            public static Int32 m_SoundName                             = g_NtvMngr.GetOffset("DT_Tesla"                     , "m_SoundName"                            );
            public static Int32 m_iszSpriteName                         = g_NtvMngr.GetOffset("DT_Tesla"                     , "m_iszSpriteName"                        );
        }

        public class DT_BaseTeamObjectiveResource
        {
            static DT_BaseTeamObjectiveResource() { }
            public static Int32 m_iTimerToShowInHUD                     = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iTimerToShowInHUD"                    );
            public static Int32 m_iStopWatchTimer                       = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iStopWatchTimer"                      );
            public static Int32 m_iNumControlPoints                     = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iNumControlPoints"                    );
            public static Int32 m_bPlayingMiniRounds                    = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_bPlayingMiniRounds"                   );
            public static Int32 m_bControlPointsReset                   = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_bControlPointsReset"                  );
            public static Int32 m_iUpdateCapHudParity                   = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iUpdateCapHudParity"                  );
            public static Int32 m_vCPPositions_0                        = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_vCPPositions[0]"                      );
            public static Int32 m_vCPPositions                          = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_vCPPositions"                         );
            public static Int32 m_iszWarnSound_0                        = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iszWarnSound[0]"                      );
            public static Int32 m_iszWarnSound                          = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iszWarnSound"                         );
            public static Int32 m_pszCapLayoutInHUD                     = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_pszCapLayoutInHUD"                    );
            public static Int32 m_bCPIsVisible                          = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_bCPIsVisible"                         );
            public static Int32 m_flLazyCapPerc                         = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_flLazyCapPerc"                        );
            public static Int32 m_iTeamIcons                            = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iTeamIcons"                           );
            public static Int32 m_iTeamOverlays                         = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iTeamOverlays"                        );
            public static Int32 m_iTeamReqCappers                       = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iTeamReqCappers"                      );
            public static Int32 m_flTeamCapTime                         = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_flTeamCapTime"                        );
            public static Int32 m_iPreviousPoints                       = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iPreviousPoints"                      );
            public static Int32 m_bTeamCanCap                           = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_bTeamCanCap"                          );
            public static Int32 m_iTeamBaseIcons                        = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iTeamBaseIcons"                       );
            public static Int32 m_iBaseControlPoints                    = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iBaseControlPoints"                   );
            public static Int32 m_bInMiniRound                          = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_bInMiniRound"                         );
            public static Int32 m_iWarnOnCap                            = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iWarnOnCap"                           );
            public static Int32 m_flPathDistance                        = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_flPathDistance"                       );
            public static Int32 m_iNumTeamMembers                       = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iNumTeamMembers"                      );
            public static Int32 m_iCappingTeam                          = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iCappingTeam"                         );
            public static Int32 m_iTeamInZone                           = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iTeamInZone"                          );
            public static Int32 m_bBlocked                              = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_bBlocked"                             );
            public static Int32 m_iOwner                                = g_NtvMngr.GetOffset("DT_BaseTeamObjectiveResource" , "m_iOwner"                               );
        }

        public class DT_Team
        {
            static DT_Team() { }
            public static Int32 m_iTeamNum                              = g_NtvMngr.GetOffset("DT_Team"                      , "m_iTeamNum"                             );
            public static Int32 m_bSurrendered                          = g_NtvMngr.GetOffset("DT_Team"                      , "m_bSurrendered"                         );
            public static Int32 m_scoreTotal                            = g_NtvMngr.GetOffset("DT_Team"                      , "m_scoreTotal"                           );
            public static Int32 m_scoreFirstHalf                        = g_NtvMngr.GetOffset("DT_Team"                      , "m_scoreFirstHalf"                       );
            public static Int32 m_scoreSecondHalf                       = g_NtvMngr.GetOffset("DT_Team"                      , "m_scoreSecondHalf"                      );
            public static Int32 m_scoreOvertime                         = g_NtvMngr.GetOffset("DT_Team"                      , "m_scoreOvertime"                        );
            public static Int32 m_iClanID                               = g_NtvMngr.GetOffset("DT_Team"                      , "m_iClanID"                              );
            public static Int32 m_szTeamname                            = g_NtvMngr.GetOffset("DT_Team"                      , "m_szTeamname"                           );
            public static Int32 m_szClanTeamname                        = g_NtvMngr.GetOffset("DT_Team"                      , "m_szClanTeamname"                       );
            public static Int32 m_szTeamFlagImage                       = g_NtvMngr.GetOffset("DT_Team"                      , "m_szTeamFlagImage"                      );
            public static Int32 m_szTeamLogoImage                       = g_NtvMngr.GetOffset("DT_Team"                      , "m_szTeamLogoImage"                      );
            public static Int32 m_szTeamMatchStat                       = g_NtvMngr.GetOffset("DT_Team"                      , "m_szTeamMatchStat"                      );
            public static Int32 m_nGGLeaderEntIndex_CT                  = g_NtvMngr.GetOffset("DT_Team"                      , "m_nGGLeaderEntIndex_CT"                 );
            public static Int32 m_nGGLeaderEntIndex_T                   = g_NtvMngr.GetOffset("DT_Team"                      , "m_nGGLeaderEntIndex_T"                  );
            public static Int32 m_numMapVictories                       = g_NtvMngr.GetOffset("DT_Team"                      , "m_numMapVictories"                      );
            public static Int32 player_array_element                    = g_NtvMngr.GetOffset("DT_Team"                      , "player_array_element"                   );
            public static Int32 player_array                            = g_NtvMngr.GetOffset("DT_Team"                      , "\"player_array\""                       );
}

        public class DT_SunlightShadowControl
        {
            static DT_SunlightShadowControl() { }
            public static Int32 m_shadowDirection                       = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_shadowDirection"                      );
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_bEnabled"                             );
            public static Int32 m_TextureName                           = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_TextureName"                          );
            public static Int32 m_LightColor                            = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_LightColor"                           );
            public static Int32 m_flColorTransitionTime                 = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_flColorTransitionTime"                );
            public static Int32 m_flSunDistance                         = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_flSunDistance"                        );
            public static Int32 m_flFOV                                 = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_flFOV"                                );
            public static Int32 m_flNearZ                               = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_flNearZ"                              );
            public static Int32 m_flNorthOffset                         = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_flNorthOffset"                        );
            public static Int32 m_bEnableShadows                        = g_NtvMngr.GetOffset("DT_SunlightShadowControl"     , "m_bEnableShadows"                       );
        }

        public class DT_Sun
        {
            static DT_Sun() { }
            public static Int32 m_clrRender                             = g_NtvMngr.GetOffset("DT_Sun"                       , "m_clrRender"                            );
            public static Int32 m_clrOverlay                            = g_NtvMngr.GetOffset("DT_Sun"                       , "m_clrOverlay"                           );
            public static Int32 m_vDirection                            = g_NtvMngr.GetOffset("DT_Sun"                       , "m_vDirection"                           );
            public static Int32 m_bOn                                   = g_NtvMngr.GetOffset("DT_Sun"                       , "m_bOn"                                  );
            public static Int32 m_nSize                                 = g_NtvMngr.GetOffset("DT_Sun"                       , "m_nSize"                                );
            public static Int32 m_nOverlaySize                          = g_NtvMngr.GetOffset("DT_Sun"                       , "m_nOverlaySize"                         );
            public static Int32 m_nMaterial                             = g_NtvMngr.GetOffset("DT_Sun"                       , "m_nMaterial"                            );
            public static Int32 m_nOverlayMaterial                      = g_NtvMngr.GetOffset("DT_Sun"                       , "m_nOverlayMaterial"                     );
            public static Int32 HDRColorScale                           = g_NtvMngr.GetOffset("DT_Sun"                       , "HDRColorScale"                          );
            public static Int32 glowDistanceScale                       = g_NtvMngr.GetOffset("DT_Sun"                       , "glowDistanceScale"                      );
        }

        public class DT_ParticlePerformanceMonitor
        {
            static DT_ParticlePerformanceMonitor() { }
            public static Int32 m_bMeasurePerf                          = g_NtvMngr.GetOffset("DT_ParticlePerformanceMonitor", "m_bMeasurePerf"                         );
            public static Int32 m_bDisplayPerf                          = g_NtvMngr.GetOffset("DT_ParticlePerformanceMonitor", "m_bDisplayPerf"                         );
        }

        public class DT_SpotlightEnd
        {
            static DT_SpotlightEnd() { }
            public static Int32 m_flLightScale                          = g_NtvMngr.GetOffset("DT_SpotlightEnd"              , "m_flLightScale"                         );
            public static Int32 m_Radius                                = g_NtvMngr.GetOffset("DT_SpotlightEnd"              , "m_Radius"                               );
        }

        public class DT_SpatialEntity
        {
            static DT_SpatialEntity() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_SpatialEntity"             , "m_vecOrigin"                            );
            public static Int32 m_minFalloff                            = g_NtvMngr.GetOffset("DT_SpatialEntity"             , "m_minFalloff"                           );
            public static Int32 m_maxFalloff                            = g_NtvMngr.GetOffset("DT_SpatialEntity"             , "m_maxFalloff"                           );
            public static Int32 m_flCurWeight                           = g_NtvMngr.GetOffset("DT_SpatialEntity"             , "m_flCurWeight"                          );
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_SpatialEntity"             , "m_bEnabled"                             );
        }

        public class DT_SlideshowDisplay
        {
            static DT_SlideshowDisplay() { }
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_bEnabled"                             );
            public static Int32 m_szDisplayText                         = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_szDisplayText"                        );
            public static Int32 m_szSlideshowDirectory                  = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_szSlideshowDirectory"                 );
            public static Int32 m_fMinSlideTime                         = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_fMinSlideTime"                        );
            public static Int32 m_fMaxSlideTime                         = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_fMaxSlideTime"                        );
            public static Int32 m_iCycleType                            = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_iCycleType"                           );
            public static Int32 m_bNoListRepeats                        = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_bNoListRepeats"                       );
            public static Int32 m_chCurrentSlideLists                   = g_NtvMngr.GetOffset("DT_SlideshowDisplay"          , "m_chCurrentSlideLists"                  );
        }

        public class DT_ShadowControl
        {
            static DT_ShadowControl() { }
            public static Int32 m_shadowDirection                       = g_NtvMngr.GetOffset("DT_ShadowControl"             , "m_shadowDirection"                      );
            public static Int32 m_shadowColor                           = g_NtvMngr.GetOffset("DT_ShadowControl"             , "m_shadowColor"                          );
            public static Int32 m_flShadowMaxDist                       = g_NtvMngr.GetOffset("DT_ShadowControl"             , "m_flShadowMaxDist"                      );
            public static Int32 m_bDisableShadows                       = g_NtvMngr.GetOffset("DT_ShadowControl"             , "m_bDisableShadows"                      );
            public static Int32 m_bEnableLocalLightShadows              = g_NtvMngr.GetOffset("DT_ShadowControl"             , "m_bEnableLocalLightShadows"             );
        }

        public class DT_SceneEntity
        {
            static DT_SceneEntity() { }
            public static Int32 m_nSceneStringIndex                     = g_NtvMngr.GetOffset("DT_SceneEntity"               , "m_nSceneStringIndex"                    );
            public static Int32 m_bIsPlayingBack                        = g_NtvMngr.GetOffset("DT_SceneEntity"               , "m_bIsPlayingBack"                       );
            public static Int32 m_bPaused                               = g_NtvMngr.GetOffset("DT_SceneEntity"               , "m_bPaused"                              );
            public static Int32 m_bMultiplayer                          = g_NtvMngr.GetOffset("DT_SceneEntity"               , "m_bMultiplayer"                         );
            public static Int32 m_flForceClientTime                     = g_NtvMngr.GetOffset("DT_SceneEntity"               , "m_flForceClientTime"                    );
            public static Int32 m_hActorList                            = g_NtvMngr.GetOffset("DT_SceneEntity"               , "m_hActorList"                           );
        }

        public class DT_RopeKeyframe
        {
            static DT_RopeKeyframe() { }
            public static Int32 m_nChangeCount                          = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_nChangeCount"                         );
            public static Int32 m_iRopeMaterialModelIndex               = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_iRopeMaterialModelIndex"              );
            public static Int32 m_hStartPoint                           = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_hStartPoint"                          );
            public static Int32 m_hEndPoint                             = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_hEndPoint"                            );
            public static Int32 m_iStartAttachment                      = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_iStartAttachment"                     );
            public static Int32 m_iEndAttachment                        = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_iEndAttachment"                       );
            public static Int32 m_fLockedPoints                         = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_fLockedPoints"                        );
            public static Int32 m_Slack                                 = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_Slack"                                );
            public static Int32 m_RopeLength                            = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_RopeLength"                           );
            public static Int32 m_RopeFlags                             = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_RopeFlags"                            );
            public static Int32 m_TextureScale                          = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_TextureScale"                         );
            public static Int32 m_nSegments                             = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_nSegments"                            );
            public static Int32 m_bConstrainBetweenEndpoints            = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_bConstrainBetweenEndpoints"           );
            public static Int32 m_Subdiv                                = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_Subdiv"                               );
            public static Int32 m_Width                                 = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_Width"                                );
            public static Int32 m_flScrollSpeed                         = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_flScrollSpeed"                        );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_vecOrigin"                            );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "moveparent"                             );
            public static Int32 m_iParentAttachment                     = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_iParentAttachment"                    );
            public static Int32 m_iDefaultRopeMaterialModelIndex        = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_iDefaultRopeMaterialModelIndex"       );
            public static Int32 m_nMinCPULevel                          = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_nMinCPULevel"                         );
            public static Int32 m_nMaxCPULevel                          = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_nMaxCPULevel"                         );
            public static Int32 m_nMinGPULevel                          = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_nMinGPULevel"                         );
            public static Int32 m_nMaxGPULevel                          = g_NtvMngr.GetOffset("DT_RopeKeyframe"              , "m_nMaxGPULevel"                         );
        }

        public class DT_RagdollManager
        {
            static DT_RagdollManager() { }
            public static Int32 m_iCurrentMaxRagdollCount               = g_NtvMngr.GetOffset("DT_RagdollManager"            , "m_iCurrentMaxRagdollCount"              );
        }

        public class DT_PhysicsPropMultiplayer
        {
            static DT_PhysicsPropMultiplayer() { }
            public static Int32 m_iPhysicsMode                          = g_NtvMngr.GetOffset("DT_PhysicsPropMultiplayer"    , "m_iPhysicsMode"                         );
            public static Int32 m_fMass                                 = g_NtvMngr.GetOffset("DT_PhysicsPropMultiplayer"    , "m_fMass"                                );
            public static Int32 m_collisionMins                         = g_NtvMngr.GetOffset("DT_PhysicsPropMultiplayer"    , "m_collisionMins"                        );
            public static Int32 m_collisionMaxs                         = g_NtvMngr.GetOffset("DT_PhysicsPropMultiplayer"    , "m_collisionMaxs"                        );
        }

        public class DT_PhysBoxMultiplayer
        {
            static DT_PhysBoxMultiplayer() { }
            public static Int32 m_iPhysicsMode                          = g_NtvMngr.GetOffset("DT_PhysBoxMultiplayer"        , "m_iPhysicsMode"                         );
            public static Int32 m_fMass                                 = g_NtvMngr.GetOffset("DT_PhysBoxMultiplayer"        , "m_fMass"                                );
        }

        public class DT_DynamicProp
        {
            static DT_DynamicProp() { }
            public static Int32 m_bUseHitboxesForRenderBox              = g_NtvMngr.GetOffset("DT_DynamicProp"               , "m_bUseHitboxesForRenderBox"             );
            public static Int32 m_flGlowMaxDist                         = g_NtvMngr.GetOffset("DT_DynamicProp"               , "m_flGlowMaxDist"                        );
            public static Int32 m_bShouldGlow                           = g_NtvMngr.GetOffset("DT_DynamicProp"               , "m_bShouldGlow"                          );
            public static Int32 m_clrGlow                               = g_NtvMngr.GetOffset("DT_DynamicProp"               , "m_clrGlow"                              );
            public static Int32 m_nGlowStyle                            = g_NtvMngr.GetOffset("DT_DynamicProp"               , "m_nGlowStyle"                           );
        }

        public class DT_Prop_Hallucination
        {
            static DT_Prop_Hallucination() { }
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_Prop_Hallucination"        , "m_bEnabled"                             );
            public static Int32 m_fVisibleTime                          = g_NtvMngr.GetOffset("DT_Prop_Hallucination"        , "m_fVisibleTime"                         );
            public static Int32 m_fRechargeTime                         = g_NtvMngr.GetOffset("DT_Prop_Hallucination"        , "m_fRechargeTime"                        );
        }

        public class DT_PostProcessController
        {
            static DT_PostProcessController() { }
            public static Int32 m_bMaster                               = g_NtvMngr.GetOffset("DT_PostProcessController"     , "m_bMaster"                              );
            public static Int32 m_flPostProcessParameters               = g_NtvMngr.GetOffset("DT_PostProcessController"     , "m_flPostProcessParameters"              );
        }

        public class DT_PointWorldText
        {
            static DT_PointWorldText() { }
            public static Int32 m_szText                                = g_NtvMngr.GetOffset("DT_PointWorldText"            , "m_szText"                               );
            public static Int32 m_flTextSize                            = g_NtvMngr.GetOffset("DT_PointWorldText"            , "m_flTextSize"                           );
            public static Int32 m_textColor                             = g_NtvMngr.GetOffset("DT_PointWorldText"            , "m_textColor"                            );
        }

        public class DT_PointCommentaryNode
        {
            static DT_PointCommentaryNode() { }
            public static Int32 m_bActive                               = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_bActive"                              );
            public static Int32 m_flStartTime                           = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_flStartTime"                          );
            public static Int32 m_iszCommentaryFile                     = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_iszCommentaryFile"                    );
            public static Int32 m_iszCommentaryFileNoHDR                = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_iszCommentaryFileNoHDR"               );
            public static Int32 m_iszSpeakers                           = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_iszSpeakers"                          );
            public static Int32 m_iNodeNumber                           = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_iNodeNumber"                          );
            public static Int32 m_iNodeNumberMax                        = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_iNodeNumberMax"                       );
            public static Int32 m_hViewPosition                         = g_NtvMngr.GetOffset("DT_PointCommentaryNode"       , "m_hViewPosition"                        );
        }

        public class DT_PointCamera
        {
            static DT_PointCamera() { }
            public static Int32 m_FOV                                   = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_FOV"                                  );
            public static Int32 m_Resolution                            = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_Resolution"                           );
            public static Int32 m_bFogEnable                            = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_bFogEnable"                           );
            public static Int32 m_FogColor                              = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_FogColor"                             );
            public static Int32 m_flFogStart                            = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_flFogStart"                           );
            public static Int32 m_flFogEnd                              = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_flFogEnd"                             );
            public static Int32 m_flFogMaxDensity                       = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_flFogMaxDensity"                      );
            public static Int32 m_bActive                               = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_bActive"                              );
            public static Int32 m_bUseScreenAspectRatio                 = g_NtvMngr.GetOffset("DT_PointCamera"               , "m_bUseScreenAspectRatio"                );
        }

        public class DT_Plasma
        {
            static DT_Plasma() { }
            public static Int32 m_flStartScale                          = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_flStartScale"                         );
            public static Int32 m_flScale                               = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_flScale"                              );
            public static Int32 m_flScaleTime                           = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_flScaleTime"                          );
            public static Int32 m_nFlags                                = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_nFlags"                               );
            public static Int32 m_nPlasmaModelIndex                     = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_nPlasmaModelIndex"                    );
            public static Int32 m_nPlasmaModelIndex2                    = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_nPlasmaModelIndex2"                   );
            public static Int32 m_nGlowModelIndex                       = g_NtvMngr.GetOffset("DT_Plasma"                    , "m_nGlowModelIndex"                      );
        }

        public class DT_PhysicsProp
        {
            static DT_PhysicsProp() { }
            public static Int32 m_bAwake                                = g_NtvMngr.GetOffset("DT_PhysicsProp"               , "m_bAwake"                               );
            public static Int32 m_spawnflags                            = g_NtvMngr.GetOffset("DT_PhysicsProp"               , "m_spawnflags"                           );
        }

        public class DT_StatueProp
        {
            static DT_StatueProp() { }
            public static Int32 m_hInitBaseAnimating                    = g_NtvMngr.GetOffset("DT_StatueProp"                , "m_hInitBaseAnimating"                   );
            public static Int32 m_bShatter                              = g_NtvMngr.GetOffset("DT_StatueProp"                , "m_bShatter"                             );
            public static Int32 m_nShatterFlags                         = g_NtvMngr.GetOffset("DT_StatueProp"                , "m_nShatterFlags"                        );
            public static Int32 m_vShatterPosition                      = g_NtvMngr.GetOffset("DT_StatueProp"                , "m_vShatterPosition"                     );
            public static Int32 m_vShatterForce                         = g_NtvMngr.GetOffset("DT_StatueProp"                , "m_vShatterForce"                        );
        }

        public class DT_PhysBox
        {
            static DT_PhysBox() { }
            public static Int32 m_mass                                  = g_NtvMngr.GetOffset("DT_PhysBox"                   , "m_mass"                                 );
        }

        public class DT_ParticleSystem
        {
            static DT_ParticleSystem() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_vecOrigin"                            );
            public static Int32 m_fEffects                              = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_fEffects"                             );
            public static Int32 m_hOwnerEntity                          = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_hOwnerEntity"                         );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "moveparent"                             );
            public static Int32 m_iParentAttachment                     = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_iParentAttachment"                    );
            public static Int32 m_angRotation                           = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_angRotation"                          );
            public static Int32 m_iEffectIndex                          = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_iEffectIndex"                         );
            public static Int32 m_bActive                               = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_bActive"                              );
            public static Int32 m_nStopType                             = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_nStopType"                            );
            public static Int32 m_flStartTime                           = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_flStartTime"                          );
            public static Int32 m_szSnapshotFileName                    = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_szSnapshotFileName"                   );
            public static Int32 m_vServerControlPoints                  = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_vServerControlPoints"                 );
            public static Int32 m_iServerControlPointAssignments        = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_iServerControlPointAssignments"       );
            public static Int32 m_hControlPointEnts                     = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_hControlPointEnts"                    );
            public static Int32 m_iControlPointParents                  = g_NtvMngr.GetOffset("DT_ParticleSystem"            , "m_iControlPointParents"                 );
        }

        public class DT_MovieDisplay
        {
            static DT_MovieDisplay() { }
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_bEnabled"                             );
            public static Int32 m_bLooping                              = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_bLooping"                             );
            public static Int32 m_szMovieFilename                       = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_szMovieFilename"                      );
            public static Int32 m_szGroupName                           = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_szGroupName"                          );
            public static Int32 m_bStretchToFill                        = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_bStretchToFill"                       );
            public static Int32 m_bForcedSlave                          = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_bForcedSlave"                         );
            public static Int32 m_bUseCustomUVs                         = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_bUseCustomUVs"                        );
            public static Int32 m_flUMin                                = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_flUMin"                               );
            public static Int32 m_flUMax                                = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_flUMax"                               );
            public static Int32 m_flVMin                                = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_flVMin"                               );
            public static Int32 m_flVMax                                = g_NtvMngr.GetOffset("DT_MovieDisplay"              , "m_flVMax"                               );
        }

        public class DT_MaterialModifyControl
        {
            static DT_MaterialModifyControl() { }
            public static Int32 m_szMaterialName                        = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_szMaterialName"                       );
            public static Int32 m_szMaterialVar                         = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_szMaterialVar"                        );
            public static Int32 m_szMaterialVarValue                    = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_szMaterialVarValue"                   );
            public static Int32 m_iFrameStart                           = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_iFrameStart"                          );
            public static Int32 m_iFrameEnd                             = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_iFrameEnd"                            );
            public static Int32 m_bWrap                                 = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_bWrap"                                );
            public static Int32 m_flFramerate                           = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_flFramerate"                          );
            public static Int32 m_bNewAnimCommandsSemaphore             = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_bNewAnimCommandsSemaphore"            );
            public static Int32 m_flFloatLerpStartValue                 = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_flFloatLerpStartValue"                );
            public static Int32 m_flFloatLerpEndValue                   = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_flFloatLerpEndValue"                  );
            public static Int32 m_flFloatLerpTransitionTime             = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_flFloatLerpTransitionTime"            );
            public static Int32 m_bFloatLerpWrap                        = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_bFloatLerpWrap"                       );
            public static Int32 m_nModifyMode                           = g_NtvMngr.GetOffset("DT_MaterialModifyControl"     , "m_nModifyMode"                          );
        }

        public class DT_LightGlow
        {
            static DT_LightGlow() { }
            public static Int32 m_clrRender                             = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_clrRender"                            );
            public static Int32 m_nHorizontalSize                       = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_nHorizontalSize"                      );
            public static Int32 m_nVerticalSize                         = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_nVerticalSize"                        );
            public static Int32 m_nMinDist                              = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_nMinDist"                             );
            public static Int32 m_nMaxDist                              = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_nMaxDist"                             );
            public static Int32 m_nOuterMaxDist                         = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_nOuterMaxDist"                        );
            public static Int32 m_spawnflags                            = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_spawnflags"                           );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_vecOrigin"                            );
            public static Int32 m_angRotation                           = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_angRotation"                          );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_LightGlow"                 , "moveparent"                             );
            public static Int32 m_flGlowProxySize                       = g_NtvMngr.GetOffset("DT_LightGlow"                 , "m_flGlowProxySize"                      );
            public static Int32 HDRColorScale                           = g_NtvMngr.GetOffset("DT_LightGlow"                 , "HDRColorScale"                          );
        }

        public class DT_ItemAssaultSuitUseable
        {
            static DT_ItemAssaultSuitUseable() { }
            public static Int32 m_nArmorValue                           = g_NtvMngr.GetOffset("DT_ItemAssaultSuitUseable"    , "m_nArmorValue"                          );
            public static Int32 m_bIsHeavyAssaultSuit                   = g_NtvMngr.GetOffset("DT_ItemAssaultSuitUseable"    , "m_bIsHeavyAssaultSuit"                  );
        }

        public class DT_Item
        {
            static DT_Item() { }
            public static Int32 m_bShouldGlow                           = g_NtvMngr.GetOffset("DT_Item"                      , "m_bShouldGlow"                          );
        }

        public class DT_InfoOverlayAccessor
        {
            static DT_InfoOverlayAccessor() { }
            public static Int32 m_iTextureFrameIndex                    = g_NtvMngr.GetOffset("DT_InfoOverlayAccessor"       , "m_iTextureFrameIndex"                   );
            public static Int32 m_iOverlayID                            = g_NtvMngr.GetOffset("DT_InfoOverlayAccessor"       , "m_iOverlayID"                           );
        }

        public class DT_FuncSmokeVolume
        {
            static DT_FuncSmokeVolume() { }
            public static Int32 m_Color1                                = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_Color1"                               );
            public static Int32 m_Color2                                = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_Color2"                               );
            public static Int32 m_MaterialName                          = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_MaterialName"                         );
            public static Int32 m_ParticleDrawWidth                     = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_ParticleDrawWidth"                    );
            public static Int32 m_ParticleSpacingDistance               = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_ParticleSpacingDistance"              );
            public static Int32 m_DensityRampSpeed                      = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_DensityRampSpeed"                     );
            public static Int32 m_RotationSpeed                         = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_RotationSpeed"                        );
            public static Int32 m_MovementSpeed                         = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_MovementSpeed"                        );
            public static Int32 m_Density                               = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_Density"                              );
            public static Int32 m_maxDrawDistance                       = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_maxDrawDistance"                      );
            public static Int32 m_spawnflags                            = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_spawnflags"                           );
            public static Int32 m_vecMins                               = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_vecMins"                              );
            public static Int32 m_vecMaxs                               = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_vecMaxs"                              );
            public static Int32 m_nSolidType                            = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_nSolidType"                           );
            public static Int32 m_usSolidFlags                          = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_usSolidFlags"                         );
            public static Int32 m_nSurroundType                         = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_nSurroundType"                        );
            public static Int32 m_triggerBloat                          = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_triggerBloat"                         );
            public static Int32 m_vecSpecifiedSurroundingMins           = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_vecSpecifiedSurroundingMins"          );
            public static Int32 m_vecSpecifiedSurroundingMaxs           = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_vecSpecifiedSurroundingMaxs"          );

            public static Int32 m_Collision                             = g_NtvMngr.GetOffset("DT_FuncSmokeVolume"           , "m_Collision"                            );
        }

        public class DT_FuncRotating
        {
            static DT_FuncRotating() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_FuncRotating"              , "m_vecOrigin"                            );
            public static Int32 m_angRotation_0                         = g_NtvMngr.GetOffset("DT_FuncRotating"              , "m_angRotation[0]"                       );
            public static Int32 m_angRotation_1                         = g_NtvMngr.GetOffset("DT_FuncRotating"              , "m_angRotation[1]"                       );
            public static Int32 m_angRotation_2                         = g_NtvMngr.GetOffset("DT_FuncRotating"              , "m_angRotation[2]"                       );
            public static Int32 m_flSimulationTime                      = g_NtvMngr.GetOffset("DT_FuncRotating"              , "m_flSimulationTime"                     );
        }

        public class DT_FuncOccluder
        {
            static DT_FuncOccluder() { }
            public static Int32 m_bActive                               = g_NtvMngr.GetOffset("DT_FuncOccluder"              , "m_bActive"                              );
            public static Int32 m_nOccluderIndex                        = g_NtvMngr.GetOffset("DT_FuncOccluder"              , "m_nOccluderIndex"                       );
        }

        public class DT_FuncMoveLinear
        {
            static DT_FuncMoveLinear() { }
            public static Int32 m_vecVelocity                           = g_NtvMngr.GetOffset("DT_FuncMoveLinear"            , "m_vecVelocity"                          );
            public static Int32 m_fFlags                                = g_NtvMngr.GetOffset("DT_FuncMoveLinear"            , "m_fFlags"                               );
        }

        public class DT_Func_LOD
        {
            static DT_Func_LOD() { }
            public static Int32 m_nDisappearMinDist                     = g_NtvMngr.GetOffset("DT_Func_LOD"                  , "m_nDisappearMinDist"                    );
            public static Int32 m_nDisappearMaxDist                     = g_NtvMngr.GetOffset("DT_Func_LOD"                  , "m_nDisappearMaxDist"                    );
        }

        public class DT_TEDust
        {
            static DT_TEDust() { }
            public static Int32 m_flSize                                = g_NtvMngr.GetOffset("DT_TEDust"                    , "m_flSize"                               );
            public static Int32 m_flSpeed                               = g_NtvMngr.GetOffset("DT_TEDust"                    , "m_flSpeed"                              );
            public static Int32 m_vecDirection                          = g_NtvMngr.GetOffset("DT_TEDust"                    , "m_vecDirection"                         );
        }

        public class DT_Func_Dust
        {
            static DT_Func_Dust() { }
            public static Int32 m_Color                                 = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_Color"                                );
            public static Int32 m_SpawnRate                             = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_SpawnRate"                            );
            public static Int32 m_flSizeMin                             = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_flSizeMin"                            );
            public static Int32 m_flSizeMax                             = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_flSizeMax"                            );
            public static Int32 m_LifetimeMin                           = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_LifetimeMin"                          );
            public static Int32 m_LifetimeMax                           = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_LifetimeMax"                          );
            public static Int32 m_DustFlags                             = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_DustFlags"                            );
            public static Int32 m_SpeedMax                              = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_SpeedMax"                             );
            public static Int32 m_DistMax                               = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_DistMax"                              );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_nModelIndex"                          );
            public static Int32 m_FallSpeed                             = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_FallSpeed"                            );
            public static Int32 m_bAffectedByWind                       = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_bAffectedByWind"                      );
            public static Int32 m_vecMins                               = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_vecMins"                              );
            public static Int32 m_vecMaxs                               = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_vecMaxs"                              );
            public static Int32 m_nSolidType                            = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_nSolidType"                           );
            public static Int32 m_usSolidFlags                          = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_usSolidFlags"                         );
            public static Int32 m_nSurroundType                         = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_nSurroundType"                        );
            public static Int32 m_triggerBloat                          = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_triggerBloat"                         );
            public static Int32 m_vecSpecifiedSurroundingMins           = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_vecSpecifiedSurroundingMins"          );
            public static Int32 m_vecSpecifiedSurroundingMaxs           = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_vecSpecifiedSurroundingMaxs"          );

            public static Int32 m_Collision                             = g_NtvMngr.GetOffset("DT_Func_Dust"                 , "m_Collision"                            );
        }

        public class DT_FuncConveyor
        {
            static DT_FuncConveyor() { }
            public static Int32 m_flConveyorSpeed                       = g_NtvMngr.GetOffset("DT_FuncConveyor"              , "m_flConveyorSpeed"                      );
        }

        public class DT_BreakableSurface
        {
            static DT_BreakableSurface() { }
            public static Int32 m_nNumWide                              = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_nNumWide"                             );
            public static Int32 m_nNumHigh                              = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_nNumHigh"                             );
            public static Int32 m_flPanelWidth                          = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_flPanelWidth"                         );
            public static Int32 m_flPanelHeight                         = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_flPanelHeight"                        );
            public static Int32 m_vNormal                               = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_vNormal"                              );
            public static Int32 m_vCorner                               = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_vCorner"                              );
            public static Int32 m_bIsBroken                             = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_bIsBroken"                            );
            public static Int32 m_nSurfaceType                          = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_nSurfaceType"                         );
            public static Int32 m_RawPanelBitVec                        = g_NtvMngr.GetOffset("DT_BreakableSurface"          , "m_RawPanelBitVec"                       );
        }

        public class DT_FuncAreaPortalWindow
        {
            static DT_FuncAreaPortalWindow() { }
            public static Int32 m_flFadeStartDist                       = g_NtvMngr.GetOffset("DT_FuncAreaPortalWindow"      , "m_flFadeStartDist"                      );
            public static Int32 m_flFadeDist                            = g_NtvMngr.GetOffset("DT_FuncAreaPortalWindow"      , "m_flFadeDist"                           );
            public static Int32 m_flTranslucencyLimit                   = g_NtvMngr.GetOffset("DT_FuncAreaPortalWindow"      , "m_flTranslucencyLimit"                  );
            public static Int32 m_iBackgroundModelIndex                 = g_NtvMngr.GetOffset("DT_FuncAreaPortalWindow"      , "m_iBackgroundModelIndex"                );
        }

        public class DT_CFish
        {
            static DT_CFish() { }
            public static Int32 m_poolOrigin                            = g_NtvMngr.GetOffset("DT_CFish"                     , "m_poolOrigin"                           );
            public static Int32 m_x                                     = g_NtvMngr.GetOffset("DT_CFish"                     , "m_x"                                    );
            public static Int32 m_y                                     = g_NtvMngr.GetOffset("DT_CFish"                     , "m_y"                                    );
            public static Int32 m_z                                     = g_NtvMngr.GetOffset("DT_CFish"                     , "m_z"                                    );
            public static Int32 m_angle                                 = g_NtvMngr.GetOffset("DT_CFish"                     , "m_angle"                                );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_CFish"                     , "m_nModelIndex"                          );
            public static Int32 m_lifeState                             = g_NtvMngr.GetOffset("DT_CFish"                     , "m_lifeState"                            );
            public static Int32 m_waterLevel                            = g_NtvMngr.GetOffset("DT_CFish"                     , "m_waterLevel"                           );
        }

        public class DT_FireSmoke
        {
            static DT_FireSmoke() { }
            public static Int32 m_flStartScale                          = g_NtvMngr.GetOffset("DT_FireSmoke"                 , "m_flStartScale"                         );
            public static Int32 m_flScale                               = g_NtvMngr.GetOffset("DT_FireSmoke"                 , "m_flScale"                              );
            public static Int32 m_flScaleTime                           = g_NtvMngr.GetOffset("DT_FireSmoke"                 , "m_flScaleTime"                          );
            public static Int32 m_nFlags                                = g_NtvMngr.GetOffset("DT_FireSmoke"                 , "m_nFlags"                               );
            public static Int32 m_nFlameModelIndex                      = g_NtvMngr.GetOffset("DT_FireSmoke"                 , "m_nFlameModelIndex"                     );
            public static Int32 m_nFlameFromAboveModelIndex             = g_NtvMngr.GetOffset("DT_FireSmoke"                 , "m_nFlameFromAboveModelIndex"            );
        }

        public class DT_EnvTonemapController
        {
            static DT_EnvTonemapController() { }
            public static Int32 m_bUseCustomAutoExposureMin             = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_bUseCustomAutoExposureMin"            );
            public static Int32 m_bUseCustomAutoExposureMax             = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_bUseCustomAutoExposureMax"            );
            public static Int32 m_bUseCustomBloomScale                  = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_bUseCustomBloomScale"                 );
            public static Int32 m_flCustomAutoExposureMin               = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flCustomAutoExposureMin"              );
            public static Int32 m_flCustomAutoExposureMax               = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flCustomAutoExposureMax"              );
            public static Int32 m_flCustomBloomScale                    = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flCustomBloomScale"                   );
            public static Int32 m_flCustomBloomScaleMinimum             = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flCustomBloomScaleMinimum"            );
            public static Int32 m_flBloomExponent                       = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flBloomExponent"                      );
            public static Int32 m_flBloomSaturation                     = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flBloomSaturation"                    );
            public static Int32 m_flTonemapPercentTarget                = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flTonemapPercentTarget"               );
            public static Int32 m_flTonemapPercentBrightPixels          = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flTonemapPercentBrightPixels"         );
            public static Int32 m_flTonemapMinAvgLum                    = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flTonemapMinAvgLum"                   );
            public static Int32 m_flTonemapRate                         = g_NtvMngr.GetOffset("DT_EnvTonemapController"      , "m_flTonemapRate"                        );
        }

        public class DT_EnvScreenEffect
        {
            static DT_EnvScreenEffect() { }
            public static Int32 m_flDuration                            = g_NtvMngr.GetOffset("DT_EnvScreenEffect"           , "m_flDuration"                           );
            public static Int32 m_nType                                 = g_NtvMngr.GetOffset("DT_EnvScreenEffect"           , "m_nType"                                );
        }

        public class DT_EnvScreenOverlay
        {
            static DT_EnvScreenOverlay() { }
            public static Int32 m_iszOverlayNames_0                     = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_iszOverlayNames[0]"                   );
            public static Int32 m_iszOverlayNames                       = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_iszOverlayNames"                      );
            public static Int32 m_flOverlayTimes_0                      = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_flOverlayTimes[0]"                    );
            public static Int32 m_flOverlayTimes                        = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_flOverlayTimes"                       );
            public static Int32 m_flStartTime                           = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_flStartTime"                          );
            public static Int32 m_iDesiredOverlay                       = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_iDesiredOverlay"                      );
            public static Int32 m_bIsActive                             = g_NtvMngr.GetOffset("DT_EnvScreenOverlay"          , "m_bIsActive"                            );
        }

        public class DT_EnvProjectedTexture
        {
            static DT_EnvProjectedTexture() { }
            public static Int32 m_hTargetEntity                         = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_hTargetEntity"                        );
            public static Int32 m_bState                                = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bState"                               );
            public static Int32 m_bAlwaysUpdate                         = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bAlwaysUpdate"                        );
            public static Int32 m_flLightFOV                            = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flLightFOV"                           );
            public static Int32 m_bEnableShadows                        = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bEnableShadows"                       );
            public static Int32 m_bSimpleProjection                     = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bSimpleProjection"                    );
            public static Int32 m_bLightOnlyTarget                      = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bLightOnlyTarget"                     );
            public static Int32 m_bLightWorld                           = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bLightWorld"                          );
            public static Int32 m_bCameraSpace                          = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_bCameraSpace"                         );
            public static Int32 m_flBrightnessScale                     = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flBrightnessScale"                    );
            public static Int32 m_LightColor                            = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_LightColor"                           );
            public static Int32 m_flColorTransitionTime                 = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flColorTransitionTime"                );
            public static Int32 m_flAmbient                             = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flAmbient"                            );
            public static Int32 m_SpotlightTextureName                  = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_SpotlightTextureName"                 );
            public static Int32 m_nSpotlightTextureFrame                = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_nSpotlightTextureFrame"               );
            public static Int32 m_flNearZ                               = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flNearZ"                              );
            public static Int32 m_flFarZ                                = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flFarZ"                               );
            public static Int32 m_nShadowQuality                        = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_nShadowQuality"                       );
            public static Int32 m_flProjectionSize                      = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flProjectionSize"                     );
            public static Int32 m_flRotation                            = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_flRotation"                           );
            public static Int32 m_iStyle                                = g_NtvMngr.GetOffset("DT_EnvProjectedTexture"       , "m_iStyle"                               );
        }

        public class DT_EnvParticleScript
        {
            static DT_EnvParticleScript() { }
            public static Int32 m_flSequenceScale                       = g_NtvMngr.GetOffset("DT_EnvParticleScript"         , "m_flSequenceScale"                      );
        }

        public class DT_FogController
        {
            static DT_FogController() { }
            public static Int32 m_fog_enable                            = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.enable"                           );
            public static Int32 m_fog_blend                             = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.blend"                            );
            public static Int32 m_fog_dirPrimary                        = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.dirPrimary"                       );
            public static Int32 m_fog_colorPrimary                      = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.colorPrimary"                     );
            public static Int32 m_fog_colorSecondary                    = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.colorSecondary"                   );
            public static Int32 m_fog_start                             = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.start"                            );
            public static Int32 m_fog_end                               = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.end"                              );
            public static Int32 m_fog_farz                              = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.farz"                             );
            public static Int32 m_fog_maxdensity                        = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.maxdensity"                       );
            public static Int32 m_fog_colorPrimaryLerpTo                = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.colorPrimaryLerpTo"               );
            public static Int32 m_fog_colorSecondaryLerpTo              = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.colorSecondaryLerpTo"             );
            public static Int32 m_fog_startLerpTo                       = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.startLerpTo"                      );
            public static Int32 m_fog_endLerpTo                         = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.endLerpTo"                        );
            public static Int32 m_fog_maxdensityLerpTo                  = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.maxdensityLerpTo"                 );
            public static Int32 m_fog_lerptime                          = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.lerptime"                         );
            public static Int32 m_fog_duration                          = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.duration"                         );
            public static Int32 m_fog_HDRColorScale                     = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.HDRColorScale"                    );
            public static Int32 m_fog_ZoomFogScale                      = g_NtvMngr.GetOffset("DT_FogController"             , "m_fog.ZoomFogScale"                     );
        }

        public class DT_EnvDOFController
        {
            static DT_EnvDOFController() { }
            public static Int32 m_bDOFEnabled                           = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_bDOFEnabled"                          );
            public static Int32 m_flNearBlurDepth                       = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_flNearBlurDepth"                      );
            public static Int32 m_flNearFocusDepth                      = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_flNearFocusDepth"                     );
            public static Int32 m_flFarFocusDepth                       = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_flFarFocusDepth"                      );
            public static Int32 m_flFarBlurDepth                        = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_flFarBlurDepth"                       );
            public static Int32 m_flNearBlurRadius                      = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_flNearBlurRadius"                     );
            public static Int32 m_flFarBlurRadius                       = g_NtvMngr.GetOffset("DT_EnvDOFController"          , "m_flFarBlurRadius"                      );
        }

        public class DT_CascadeLight
        {
            static DT_CascadeLight() { }
            public static Int32 m_shadowDirection                       = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_shadowDirection"                      );
            public static Int32 m_envLightShadowDirection               = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_envLightShadowDirection"              );
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_bEnabled"                             );
            public static Int32 m_bUseLightEnvAngles                    = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_bUseLightEnvAngles"                   );
            public static Int32 m_LightColor                            = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_LightColor"                           );
            public static Int32 m_LightColorScale                       = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_LightColorScale"                      );
            public static Int32 m_flMaxShadowDist                       = g_NtvMngr.GetOffset("DT_CascadeLight"              , "m_flMaxShadowDist"                      );
        }

        public class DT_EnvAmbientLight
        {
            static DT_EnvAmbientLight() { }
            public static Int32 m_vecColor                              = g_NtvMngr.GetOffset("DT_EnvAmbientLight"           , "m_vecColor"                             );
        }

        public class DT_EntityParticleTrail
        {
            static DT_EntityParticleTrail() { }
            public static Int32 m_iMaterialName                         = g_NtvMngr.GetOffset("DT_EntityParticleTrail"       , "m_iMaterialName"                        );
            public static Int32 m_hConstraintEntity                     = g_NtvMngr.GetOffset("DT_EntityParticleTrail"       , "m_hConstraintEntity"                    );
            public static Int32 m_flLifetime                            = g_NtvMngr.GetOffset("DT_EntityParticleTrail"       , "m_flLifetime"                           );
            public static Int32 m_flStartSize                           = g_NtvMngr.GetOffset("DT_EntityParticleTrail"       , "m_flStartSize"                          );
            public static Int32 m_flEndSize                             = g_NtvMngr.GetOffset("DT_EntityParticleTrail"       , "m_flEndSize"                            );

            public static Int32 m_Info                                  = g_NtvMngr.GetOffset("DT_EntityParticleTrail"       , "m_Info"                                 );
        }

        public class DT_EntityFreezing
        {
            static DT_EntityFreezing() { }
            public static Int32 m_vFreezingOrigin                       = g_NtvMngr.GetOffset("DT_EntityFreezing"            , "m_vFreezingOrigin"                      );
            public static Int32 m_flFrozen                              = g_NtvMngr.GetOffset("DT_EntityFreezing"            , "m_flFrozen"                             );
            public static Int32 m_bFinishFreezing                       = g_NtvMngr.GetOffset("DT_EntityFreezing"            , "m_bFinishFreezing"                      );
            public static Int32 m_flFrozenPerHitbox                     = g_NtvMngr.GetOffset("DT_EntityFreezing"            , "m_flFrozenPerHitbox"                    );
        }

        public class DT_EntityFlame
        {
            static DT_EntityFlame() { }
            public static Int32 m_hEntAttached                          = g_NtvMngr.GetOffset("DT_EntityFlame"               , "m_hEntAttached"                         );
            public static Int32 m_bCheapEffect                          = g_NtvMngr.GetOffset("DT_EntityFlame"               , "m_bCheapEffect"                         );
        }

        public class DT_EntityDissolve
        {
            static DT_EntityDissolve() { }
            public static Int32 m_flStartTime                           = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flStartTime"                          );
            public static Int32 m_flFadeOutStart                        = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flFadeOutStart"                       );
            public static Int32 m_flFadeOutLength                       = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flFadeOutLength"                      );
            public static Int32 m_flFadeOutModelStart                   = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flFadeOutModelStart"                  );
            public static Int32 m_flFadeOutModelLength                  = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flFadeOutModelLength"                 );
            public static Int32 m_flFadeInStart                         = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flFadeInStart"                        );
            public static Int32 m_flFadeInLength                        = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_flFadeInLength"                       );
            public static Int32 m_nDissolveType                         = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_nDissolveType"                        );
            public static Int32 m_vDissolverOrigin                      = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_vDissolverOrigin"                     );
            public static Int32 m_nMagnitude                            = g_NtvMngr.GetOffset("DT_EntityDissolve"            , "m_nMagnitude"                           );
        }

        public class DT_DynamicLight
        {
            static DT_DynamicLight() { }
            public static Int32 m_Flags                                 = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_Flags"                                );
            public static Int32 m_LightStyle                            = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_LightStyle"                           );
            public static Int32 m_Radius                                = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_Radius"                               );
            public static Int32 m_Exponent                              = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_Exponent"                             );
            public static Int32 m_InnerAngle                            = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_InnerAngle"                           );
            public static Int32 m_OuterAngle                            = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_OuterAngle"                           );
            public static Int32 m_SpotRadius                            = g_NtvMngr.GetOffset("DT_DynamicLight"              , "m_SpotRadius"                           );
        }

        public class DT_ColorCorrectionVolume
        {
            static DT_ColorCorrectionVolume() { }
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_ColorCorrectionVolume"     , "m_bEnabled"                             );
            public static Int32 m_MaxWeight                             = g_NtvMngr.GetOffset("DT_ColorCorrectionVolume"     , "m_MaxWeight"                            );
            public static Int32 m_FadeDuration                          = g_NtvMngr.GetOffset("DT_ColorCorrectionVolume"     , "m_FadeDuration"                         );
            public static Int32 m_Weight                                = g_NtvMngr.GetOffset("DT_ColorCorrectionVolume"     , "m_Weight"                               );
            public static Int32 m_lookupFilename                        = g_NtvMngr.GetOffset("DT_ColorCorrectionVolume"     , "m_lookupFilename"                       );
        }

        public class DT_ColorCorrection
        {
            static DT_ColorCorrection() { }
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_vecOrigin"                            );
            public static Int32 m_minFalloff                            = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_minFalloff"                           );
            public static Int32 m_maxFalloff                            = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_maxFalloff"                           );
            public static Int32 m_flCurWeight                           = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_flCurWeight"                          );
            public static Int32 m_flMaxWeight                           = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_flMaxWeight"                          );
            public static Int32 m_flFadeInDuration                      = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_flFadeInDuration"                     );
            public static Int32 m_flFadeOutDuration                     = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_flFadeOutDuration"                    );
            public static Int32 m_netLookupFilename                     = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_netLookupFilename"                    );
            public static Int32 m_bEnabled                              = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_bEnabled"                             );
            public static Int32 m_bMaster                               = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_bMaster"                              );
            public static Int32 m_bClientSide                           = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_bClientSide"                          );
            public static Int32 m_bExclusive                            = g_NtvMngr.GetOffset("DT_ColorCorrection"           , "m_bExclusive"                           );
        }

        public class DT_BreakableProp
        {
            static DT_BreakableProp() { }
            public static Int32 m_qPreferredPlayerCarryAngles           = g_NtvMngr.GetOffset("DT_BreakableProp"             , "m_qPreferredPlayerCarryAngles"          );
            public static Int32 m_bClientPhysics                        = g_NtvMngr.GetOffset("DT_BreakableProp"             , "m_bClientPhysics"                       );
        }

        public class DT_BeamSpotlight
        {
            static DT_BeamSpotlight() { }
            public static Int32 m_nHaloIndex                            = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_nHaloIndex"                           );
            public static Int32 m_bSpotlightOn                          = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_bSpotlightOn"                         );
            public static Int32 m_bHasDynamicLight                      = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_bHasDynamicLight"                     );
            public static Int32 m_flSpotlightMaxLength                  = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_flSpotlightMaxLength"                 );
            public static Int32 m_flSpotlightGoalWidth                  = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_flSpotlightGoalWidth"                 );
            public static Int32 m_flHDRColorScale                       = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_flHDRColorScale"                      );
            public static Int32 m_nRotationAxis                         = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_nRotationAxis"                        );
            public static Int32 m_flRotationSpeed                       = g_NtvMngr.GetOffset("DT_BeamSpotlight"             , "m_flRotationSpeed"                      );
        }

        public class DT_BaseButton
        {
            static DT_BaseButton() { }
            public static Int32 m_usable                                = g_NtvMngr.GetOffset("DT_BaseButton"                , "m_usable"                               );
        }

        public class DT_BaseToggle
        {
            static DT_BaseToggle() { }
            public static Int32 m_vecFinalDest                          = g_NtvMngr.GetOffset("DT_BaseToggle"                , "m_vecFinalDest"                         );
            public static Int32 m_movementType                          = g_NtvMngr.GetOffset("DT_BaseToggle"                , "m_movementType"                         );
            public static Int32 m_flMoveTargetTime                      = g_NtvMngr.GetOffset("DT_BaseToggle"                , "m_flMoveTargetTime"                     );
        }

        public class DT_BasePlayer
        {
            static DT_BasePlayer() { }
            public static Int32 m_iFOV                                  = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iFOV"                                 );
            public static Int32 m_iFOVStart                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iFOVStart"                            );
            public static Int32 m_flFOVTime                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flFOVTime"                            );
            public static Int32 m_iDefaultFOV                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iDefaultFOV"                          );
            public static Int32 m_hZoomOwner                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hZoomOwner"                           );
            public static Int32 m_afPhysicsFlags                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_afPhysicsFlags"                       );
            public static Int32 m_hVehicle                              = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hVehicle"                             );
            public static Int32 m_hUseEntity                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hUseEntity"                           );
            public static Int32 m_hGroundEntity                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hGroundEntity"                        );
            public static Int32 m_iHealth                               = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iHealth"                              );
            public static Int32 m_lifeState                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_lifeState"                            );
            public static Int32 m_iBonusProgress                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iBonusProgress"                       );
            public static Int32 m_iBonusChallenge                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iBonusChallenge"                      );
            public static Int32 m_flMaxspeed                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flMaxspeed"                           );
            public static Int32 m_fFlags                                = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_fFlags"                               );
            public static Int32 m_iObserverMode                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iObserverMode"                        );
            public static Int32 m_bActiveCameraMan                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bActiveCameraMan"                     );
            public static Int32 m_bCameraManXRay                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bCameraManXRay"                       );
            public static Int32 m_bCameraManOverview                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bCameraManOverview"                   );
            public static Int32 m_bCameraManScoreBoard                  = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bCameraManScoreBoard"                 );
            public static Int32 m_uCameraManGraphs                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_uCameraManGraphs"                     );
            public static Int32 m_iDeathPostEffect                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iDeathPostEffect"                     );
            public static Int32 m_hObserverTarget                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hObserverTarget"                      );
            public static Int32 m_hViewModel_0                          = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hViewModel[0]"                        );
            public static Int32 m_hViewModel                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hViewModel"                           );
            public static Int32 m_iCoachingTeam                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iCoachingTeam"                        );
            public static Int32 m_szLastPlaceName                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_szLastPlaceName"                      );
            public static Int32 m_vecLadderNormal                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecLadderNormal"                      );
            public static Int32 m_ladderSurfaceProps                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_ladderSurfaceProps"                   );
            public static Int32 m_ubEFNoInterpParity                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_ubEFNoInterpParity"                   );
            public static Int32 m_hPostProcessCtrl                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hPostProcessCtrl"                     );
            public static Int32 m_hColorCorrectionCtrl                  = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hColorCorrectionCtrl"                 );
            public static Int32 m_PlayerFog_m_hCtrl                     = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_PlayerFog.m_hCtrl"                    );
            public static Int32 m_vphysicsCollisionState                = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vphysicsCollisionState"               );
            public static Int32 m_hViewEntity                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hViewEntity"                          );
            public static Int32 m_bShouldDrawPlayerWhileUsingViewEntity = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bShouldDrawPlayerWhileUsingViewEntity");
            public static Int32 m_flDuckAmount                          = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flDuckAmount"                         );
            public static Int32 m_flDuckSpeed                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flDuckSpeed"                          );
            public static Int32 m_nWaterLevel                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_nWaterLevel"                          );
            public static Int32 m_vecViewOffset_0                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecViewOffset[0]"                     );
            public static Int32 m_vecViewOffset_1                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecViewOffset[1]"                     );
            public static Int32 m_vecViewOffset_2                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecViewOffset[2]"                     );
            public static Int32 m_flFriction                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flFriction"                           );
            public static Int32 m_fOnTarget                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_fOnTarget"                            );
            public static Int32 m_nTickBase                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_nTickBase"                            );
            public static Int32 m_nNextThinkTick                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_nNextThinkTick"                       );
            public static Int32 m_hLastWeapon                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hLastWeapon"                          );
            public static Int32 m_vecVelocity_0                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecVelocity[0]"                       );
            public static Int32 m_vecVelocity_1                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecVelocity[1]"                       );
            public static Int32 m_vecVelocity_2                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecVelocity[2]"                       );
            public static Int32 m_vecBaseVelocity                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecBaseVelocity"                      );
            public static Int32 m_hConstraintEntity                     = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hConstraintEntity"                    );
            public static Int32 m_vecConstraintCenter                   = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_vecConstraintCenter"                  );
            public static Int32 m_flConstraintRadius                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flConstraintRadius"                   );
            public static Int32 m_flConstraintWidth                     = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flConstraintWidth"                    );
            public static Int32 m_flConstraintSpeedFactor               = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flConstraintSpeedFactor"              );
            public static Int32 m_bConstraintPastRadius                 = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bConstraintPastRadius"                );
            public static Int32 m_flDeathTime                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flDeathTime"                          );
            public static Int32 m_flNextDecalTime                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flNextDecalTime"                      );
            public static Int32 m_fForceTeam                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_fForceTeam"                           );
            public static Int32 m_flLaggedMovementValue                 = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flLaggedMovementValue"                );
            public static Int32 m_hTonemapController                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_hTonemapController"                   );
            public static Int32 m_iHideHUD                              = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iHideHUD"                             );
            public static Int32 m_flFOVRate                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flFOVRate"                            );
            public static Int32 m_bDucked                               = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bDucked"                              );
            public static Int32 m_bDucking                              = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bDucking"                             );
            public static Int32 m_flLastDuckTime                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flLastDuckTime"                       );
            public static Int32 m_bInDuckJump                           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bInDuckJump"                          );
            public static Int32 m_nDuckTimeMsecs                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_nDuckTimeMsecs"                       );
            public static Int32 m_nDuckJumpTimeMsecs                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_nDuckJumpTimeMsecs"                   );
            public static Int32 m_nJumpTimeMsecs                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_nJumpTimeMsecs"                       );
            public static Int32 m_flFallVelocity                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flFallVelocity"                       );
            public static Int32 m_viewPunchAngle                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_viewPunchAngle"                       );
            public static Int32 m_aimPunchAngle                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_aimPunchAngle"                        );
            public static Int32 m_aimPunchAngleVel                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_aimPunchAngleVel"                     );
            public static Int32 m_bDrawViewmodel                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bDrawViewmodel"                       );
            public static Int32 m_bWearingSuit                          = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bWearingSuit"                         );
            public static Int32 m_bPoisoned                             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bPoisoned"                            );
            public static Int32 m_flStepSize                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_flStepSize"                           );
            public static Int32 m_bAllowAutoMovement                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_bAllowAutoMovement"                   );
            public static Int32 m_skybox3d_scale                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.scale"                       );
            public static Int32 m_skybox3d_origin                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.origin"                      );
            public static Int32 m_skybox3d_area                         = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.area"                        );
            public static Int32 m_skybox3d_fog_enable                   = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.enable"                  );
            public static Int32 m_skybox3d_fog_blend                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.blend"                   );
            public static Int32 m_skybox3d_fog_dirPrimary               = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.dirPrimary"              );
            public static Int32 m_skybox3d_fog_colorPrimary             = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.colorPrimary"            );
            public static Int32 m_skybox3d_fog_colorSecondary           = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.colorSecondary"          );
            public static Int32 m_skybox3d_fog_start                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.start"                   );
            public static Int32 m_skybox3d_fog_end                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.end"                     );
            public static Int32 m_skybox3d_fog_maxdensity               = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.maxdensity"              );
            public static Int32 m_skybox3d_fog_HDRColorScale            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_skybox3d.fog.HDRColorScale"           );
            public static Int32 m_audio_localSound_0                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[0]"                  );
            public static Int32 m_audio_localSound_1                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[1]"                  );
            public static Int32 m_audio_localSound_2                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[2]"                  );
            public static Int32 m_audio_localSound_3                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[3]"                  );
            public static Int32 m_audio_localSound_4                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[4]"                  );
            public static Int32 m_audio_localSound_5                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[5]"                  );
            public static Int32 m_audio_localSound_6                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[6]"                  );
            public static Int32 m_audio_localSound_7                    = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localSound[7]"                  );
            public static Int32 m_audio_soundscapeIndex                 = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.soundscapeIndex"                );
            public static Int32 m_audio_localBits                       = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.localBits"                      );
            public static Int32 m_audio_entIndex                        = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_audio.entIndex"                       );
            public static Int32 m_chAreaBits                            = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_chAreaBits"                           );
            public static Int32 m_chAreaPortalBits                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_chAreaPortalBits"                     );

            public static Int32 m_Local                                 = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_Local"                                );

            public static Int32 localdata                               = g_NtvMngr.GetOffset("DT_BasePlayer"                , "localdata"                              );
            public static Int32 deadflag                                = g_NtvMngr.GetOffset("DT_BasePlayer"                , "deadflag"                               );

            public static Int32 pl                                      = g_NtvMngr.GetOffset("DT_BasePlayer"                , "pl"                                     );
            public static Int32 m_iAmmo                                 = g_NtvMngr.GetOffset("DT_BasePlayer"                , "m_iAmmo"                                );
        }

        public class DT_BaseFlex
        {
            static DT_BaseFlex() { }
            public static Int32 m_blinktoggle                           = g_NtvMngr.GetOffset("DT_BaseFlex"                  , "m_blinktoggle"                          );
            public static Int32 m_viewtarget                            = g_NtvMngr.GetOffset("DT_BaseFlex"                  , "m_viewtarget"                           );
            public static Int32 m_flexWeight                            = g_NtvMngr.GetOffset("DT_BaseFlex"                  , "m_flexWeight"                           );
        }

        public class DT_BaseEntity
        {
            static DT_BaseEntity() { }
            public static Int32 m_flSimulationTime                      = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flSimulationTime"                     );
            public static Int32 m_cellbits                              = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_cellbits"                             );
            public static Int32 m_cellX                                 = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_cellX"                                );
            public static Int32 m_cellY                                 = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_cellY"                                );
            public static Int32 m_cellZ                                 = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_cellZ"                                );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_vecOrigin"                            );
            public static Int32 m_angRotation                           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_angRotation"                          );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nModelIndex"                          );
            public static Int32 m_fEffects                              = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_fEffects"                             );
            public static Int32 m_nRenderMode                           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nRenderMode"                          );
            public static Int32 m_nRenderFX                             = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nRenderFX"                            );
            public static Int32 m_clrRender                             = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_clrRender"                            );
            public static Int32 m_iTeamNum                              = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_iTeamNum"                             );
            public static Int32 m_iPendingTeamNum                       = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_iPendingTeamNum"                      );
            public static Int32 m_CollisionGroup                        = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_CollisionGroup"                       );
            public static Int32 m_flElasticity                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flElasticity"                         );
            public static Int32 m_flShadowCastDistance                  = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flShadowCastDistance"                 );
            public static Int32 m_hOwnerEntity                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_hOwnerEntity"                         );
            public static Int32 m_hEffectEntity                         = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_hEffectEntity"                        );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_BaseEntity"                , "moveparent"                             );
            public static Int32 m_iParentAttachment                     = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_iParentAttachment"                    );
            public static Int32 m_iName                                 = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_iName"                                );
            public static Int32 movetype                                = g_NtvMngr.GetOffset("DT_BaseEntity"                , "movetype"                               );
            public static Int32 movecollide                             = g_NtvMngr.GetOffset("DT_BaseEntity"                , "movecollide"                            );
            public static Int32 m_iTextureFrameIndex                    = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_iTextureFrameIndex"                   );
            public static Int32 m_bSimulatedEveryTick                   = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bSimulatedEveryTick"                  );
            public static Int32 m_bAnimatedEveryTick                    = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bAnimatedEveryTick"                   );
            public static Int32 m_bAlternateSorting                     = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bAlternateSorting"                    );
            public static Int32 m_bSpotted                              = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bSpotted"                             );
            public static Int32 m_bIsAutoaimTarget                      = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bIsAutoaimTarget"                     );
            public static Int32 m_fadeMinDist                           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_fadeMinDist"                          );
            public static Int32 m_fadeMaxDist                           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_fadeMaxDist"                          );
            public static Int32 m_flFadeScale                           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flFadeScale"                          );
            public static Int32 m_nMinCPULevel                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nMinCPULevel"                         );
            public static Int32 m_nMaxCPULevel                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nMaxCPULevel"                         );
            public static Int32 m_nMinGPULevel                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nMinGPULevel"                         );
            public static Int32 m_nMaxGPULevel                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nMaxGPULevel"                         );
            public static Int32 m_flUseLookAtAngle                      = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flUseLookAtAngle"                     );
            public static Int32 m_flLastMadeNoiseTime                   = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flLastMadeNoiseTime"                  );
            public static Int32 m_flMaxFallVelocity                     = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flMaxFallVelocity"                    );
            public static Int32 m_bEligibleForScreenHighlight           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bEligibleForScreenHighlight"          );
            public static Int32 m_flAnimTime                            = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_flAnimTime"                           );

            public static Int32 AnimTimeMustBeFirst                     = g_NtvMngr.GetOffset("DT_BaseEntity"                , "AnimTimeMustBeFirst"                    );
            public static Int32 m_vecMins                               = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_vecMins"                              );
            public static Int32 m_vecMaxs                               = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_vecMaxs"                              );
            public static Int32 m_nSolidType                            = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nSolidType"                           );
            public static Int32 m_usSolidFlags                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_usSolidFlags"                         );
            public static Int32 m_nSurroundType                         = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_nSurroundType"                        );
            public static Int32 m_triggerBloat                          = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_triggerBloat"                         );
            public static Int32 m_vecSpecifiedSurroundingMins           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_vecSpecifiedSurroundingMins"          );
            public static Int32 m_vecSpecifiedSurroundingMaxs           = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_vecSpecifiedSurroundingMaxs"          );

            public static Int32 m_Collision                             = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_Collision"                            );
            public static Int32 m_bSpottedBy                            = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bSpottedBy"                           );
            public static Int32 m_bSpottedByMask                        = g_NtvMngr.GetOffset("DT_BaseEntity"                , "m_bSpottedByMask"                       );
        }

        public class DT_BaseDoor
        {
            static DT_BaseDoor() { }
            public static Int32 m_flWaveHeight                          = g_NtvMngr.GetOffset("DT_BaseDoor"                  , "m_flWaveHeight"                         );
        }

        public class DT_BaseCombatCharacter
        {
            static DT_BaseCombatCharacter() { }
            public static Int32 m_LastHitGroup                          = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_LastHitGroup"                         );
            public static Int32 m_hActiveWeapon                         = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_hActiveWeapon"                        );
            public static Int32 m_flTimeOfLastInjury                    = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_flTimeOfLastInjury"                   );
            public static Int32 m_nRelativeDirectionOfLastInjury        = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_nRelativeDirectionOfLastInjury"       );
            public static Int32 m_flNextAttack                          = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_flNextAttack"                         );

            public static Int32 bcc_localdata                           = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "bcc_localdata"                          );
            public static Int32 bcc_nonlocaldata                        = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "bcc_nonlocaldata"                       );
            public static Int32 m_hMyWeapons                            = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_hMyWeapons"                           );
            public static Int32 m_hMyWearables                          = g_NtvMngr.GetOffset("DT_BaseCombatCharacter"       , "m_hMyWearables"                         );
        }

        public class DT_BoneFollower
        {
            static DT_BoneFollower() { }
            public static Int32 m_modelIndex                            = g_NtvMngr.GetOffset("DT_BoneFollower"              , "m_modelIndex"                           );
            public static Int32 m_solidIndex                            = g_NtvMngr.GetOffset("DT_BoneFollower"              , "m_solidIndex"                           );
        }

        public class DT_BaseAnimating
        {
            static DT_BaseAnimating() { }
            public static Int32 m_nSequence                             = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nSequence"                            );
            public static Int32 m_nForceBone                            = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nForceBone"                           );
            public static Int32 m_vecForce                              = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_vecForce"                             );
            public static Int32 m_nSkin                                 = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nSkin"                                );
            public static Int32 m_nBody                                 = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nBody"                                );
            public static Int32 m_nHitboxSet                            = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nHitboxSet"                           );
            public static Int32 m_flModelScale                          = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_flModelScale"                         );
            public static Int32 m_flPlaybackRate                        = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_flPlaybackRate"                       );
            public static Int32 m_bClientSideAnimation                  = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_bClientSideAnimation"                 );
            public static Int32 m_bClientSideFrameReset                 = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_bClientSideFrameReset"                );
            public static Int32 m_bClientSideRagdoll                    = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_bClientSideRagdoll"                   );
            public static Int32 m_nNewSequenceParity                    = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nNewSequenceParity"                   );
            public static Int32 m_nResetEventsParity                    = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nResetEventsParity"                   );
            public static Int32 m_nMuzzleFlashParity                    = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nMuzzleFlashParity"                   );
            public static Int32 m_hLightingOrigin                       = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_hLightingOrigin"                      );
            public static Int32 m_flFrozen                              = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_flFrozen"                             );
            public static Int32 m_ScaleType                             = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_ScaleType"                            );
            public static Int32 m_bSuppressAnimSounds                   = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_bSuppressAnimSounds"                  );
            public static Int32 m_nHighlightColorR                      = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nHighlightColorR"                     );
            public static Int32 m_nHighlightColorG                      = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nHighlightColorG"                     );
            public static Int32 m_nHighlightColorB                      = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_nHighlightColorB"                     );
            public static Int32 m_flPoseParameter                       = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_flPoseParameter"                      );
            public static Int32 m_flEncodedController                   = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_flEncodedController"                  );
            public static Int32 m_flCycle                               = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "m_flCycle"                              );

            public static Int32 serveranimdata                          = g_NtvMngr.GetOffset("DT_BaseAnimating"             , "serveranimdata"                         );
        }

        public class DT_AI_BaseNPC
        {
            static DT_AI_BaseNPC() { }
            public static Int32 m_lifeState                             = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_lifeState"                            );
            public static Int32 m_bPerformAvoidance                     = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_bPerformAvoidance"                    );
            public static Int32 m_bIsMoving                             = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_bIsMoving"                            );
            public static Int32 m_bFadeCorpse                           = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_bFadeCorpse"                          );
            public static Int32 m_iDeathPose                            = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_iDeathPose"                           );
            public static Int32 m_iDeathFrame                           = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_iDeathFrame"                          );
            public static Int32 m_iSpeedModRadius                       = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_iSpeedModRadius"                      );
            public static Int32 m_iSpeedModSpeed                        = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_iSpeedModSpeed"                       );
            public static Int32 m_bSpeedModActive                       = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_bSpeedModActive"                      );
            public static Int32 m_bImportanRagdoll                      = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_bImportanRagdoll"                     );
            public static Int32 m_flTimePingEffect                      = g_NtvMngr.GetOffset("DT_AI_BaseNPC"                , "m_flTimePingEffect"                     );
        }

        public class DT_Beam
        {
            static DT_Beam() { }
            public static Int32 m_nBeamType                             = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nBeamType"                            );
            public static Int32 m_nBeamFlags                            = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nBeamFlags"                           );
            public static Int32 m_nNumBeamEnts                          = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nNumBeamEnts"                         );
            public static Int32 m_nHaloIndex                            = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nHaloIndex"                           );
            public static Int32 m_fHaloScale                            = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fHaloScale"                           );
            public static Int32 m_fWidth                                = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fWidth"                               );
            public static Int32 m_fEndWidth                             = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fEndWidth"                            );
            public static Int32 m_fFadeLength                           = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fFadeLength"                          );
            public static Int32 m_fAmplitude                            = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fAmplitude"                           );
            public static Int32 m_fStartFrame                           = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fStartFrame"                          );
            public static Int32 m_fSpeed                                = g_NtvMngr.GetOffset("DT_Beam"                      , "m_fSpeed"                               );
            public static Int32 m_flFrameRate                           = g_NtvMngr.GetOffset("DT_Beam"                      , "m_flFrameRate"                          );
            public static Int32 m_flHDRColorScale                       = g_NtvMngr.GetOffset("DT_Beam"                      , "m_flHDRColorScale"                      );
            public static Int32 m_clrRender                             = g_NtvMngr.GetOffset("DT_Beam"                      , "m_clrRender"                            );
            public static Int32 m_nRenderFX                             = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nRenderFX"                            );
            public static Int32 m_nRenderMode                           = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nRenderMode"                          );
            public static Int32 m_flFrame                               = g_NtvMngr.GetOffset("DT_Beam"                      , "m_flFrame"                              );
            public static Int32 m_nClipStyle                            = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nClipStyle"                           );
            public static Int32 m_vecEndPos                             = g_NtvMngr.GetOffset("DT_Beam"                      , "m_vecEndPos"                            );
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nModelIndex"                          );
            public static Int32 m_vecOrigin                             = g_NtvMngr.GetOffset("DT_Beam"                      , "m_vecOrigin"                            );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_Beam"                      , "moveparent"                             );
            public static Int32 m_hAttachEntity                         = g_NtvMngr.GetOffset("DT_Beam"                      , "m_hAttachEntity"                        );
            public static Int32 m_nAttachIndex                          = g_NtvMngr.GetOffset("DT_Beam"                      , "m_nAttachIndex"                         );
        }

        public class DT_BaseViewModel
        {
            static DT_BaseViewModel() { }
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nModelIndex"                          );
            public static Int32 m_hWeapon                               = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_hWeapon"                              );
            public static Int32 m_nSkin                                 = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nSkin"                                );
            public static Int32 m_nBody                                 = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nBody"                                );
            public static Int32 m_nSequence                             = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nSequence"                            );
            public static Int32 m_nViewModelIndex                       = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nViewModelIndex"                      );
            public static Int32 m_flPlaybackRate                        = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_flPlaybackRate"                       );
            public static Int32 m_fEffects                              = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_fEffects"                             );
            public static Int32 m_nAnimationParity                      = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nAnimationParity"                     );
            public static Int32 m_hOwner                                = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_hOwner"                               );
            public static Int32 m_nNewSequenceParity                    = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nNewSequenceParity"                   );
            public static Int32 m_nResetEventsParity                    = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nResetEventsParity"                   );
            public static Int32 m_nMuzzleFlashParity                    = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_nMuzzleFlashParity"                   );
            public static Int32 m_bShouldIgnoreOffsetAndAccuracy        = g_NtvMngr.GetOffset("DT_BaseViewModel"             , "m_bShouldIgnoreOffsetAndAccuracy"       );
        }

        public class DT_BaseGrenade
        {
            static DT_BaseGrenade() { }
            public static Int32 m_flDamage                              = g_NtvMngr.GetOffset("DT_BaseGrenade"               , "m_flDamage"                             );
            public static Int32 m_DmgRadius                             = g_NtvMngr.GetOffset("DT_BaseGrenade"               , "m_DmgRadius"                            );
            public static Int32 m_bIsLive                               = g_NtvMngr.GetOffset("DT_BaseGrenade"               , "m_bIsLive"                              );
            public static Int32 m_hThrower                              = g_NtvMngr.GetOffset("DT_BaseGrenade"               , "m_hThrower"                             );
            public static Int32 m_vecVelocity                           = g_NtvMngr.GetOffset("DT_BaseGrenade"               , "m_vecVelocity"                          );
            public static Int32 m_fFlags                                = g_NtvMngr.GetOffset("DT_BaseGrenade"               , "m_fFlags"                               );
        }

        public class DT_BaseCombatWeapon
        {
            static DT_BaseCombatWeapon() { }
            public static Int32 m_iViewModelIndex                       = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iViewModelIndex"                      );
            public static Int32 m_iWorldModelIndex                      = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iWorldModelIndex"                     );
            public static Int32 m_iWorldDroppedModelIndex               = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iWorldDroppedModelIndex"              );
            public static Int32 m_iState                                = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iState"                               );
            public static Int32 m_hOwner                                = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_hOwner"                               );
            public static Int32 m_iClip1                                = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iClip1"                               );
            public static Int32 m_iClip2                                = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iClip2"                               );
            public static Int32 m_iPrimaryReserveAmmoCount              = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iPrimaryReserveAmmoCount"             );
            public static Int32 m_iSecondaryReserveAmmoCount            = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iSecondaryReserveAmmoCount"           );
            public static Int32 m_hWeaponWorldModel                     = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_hWeaponWorldModel"                    );
            public static Int32 m_iNumEmptyAttacks                      = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iNumEmptyAttacks"                     );
            public static Int32 m_iPrimaryAmmoType                      = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iPrimaryAmmoType"                     );
            public static Int32 m_iSecondaryAmmoType                    = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iSecondaryAmmoType"                   );
            public static Int32 m_nViewModelIndex                       = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_nViewModelIndex"                      );
            public static Int32 m_bFlipViewModel                        = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_bFlipViewModel"                       );
            public static Int32 m_iWeaponOrigin                         = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iWeaponOrigin"                        );
            public static Int32 m_iWeaponModule                         = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_iWeaponModule"                        );

            public static Int32 LocalWeaponData                         = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "LocalWeaponData"                        );
            public static Int32 m_flNextPrimaryAttack                   = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_flNextPrimaryAttack"                  );
            public static Int32 m_flNextSecondaryAttack                 = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_flNextSecondaryAttack"                );
            public static Int32 m_nNextThinkTick                        = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_nNextThinkTick"                       );
            public static Int32 m_flTimeWeaponIdle                      = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "m_flTimeWeaponIdle"                     );

            public static Int32 LocalActiveWeaponData                   = g_NtvMngr.GetOffset("DT_BaseCombatWeapon"          , "LocalActiveWeaponData"                  );
        }

        public class DT_BaseWeaponWorldModel
        {
            static DT_BaseWeaponWorldModel() { }
            public static Int32 m_nModelIndex                           = g_NtvMngr.GetOffset("DT_BaseWeaponWorldModel"      , "m_nModelIndex"                          );
            public static Int32 m_nBody                                 = g_NtvMngr.GetOffset("DT_BaseWeaponWorldModel"      , "m_nBody"                                );
            public static Int32 m_fEffects                              = g_NtvMngr.GetOffset("DT_BaseWeaponWorldModel"      , "m_fEffects"                             );
            public static Int32 moveparent                              = g_NtvMngr.GetOffset("DT_BaseWeaponWorldModel"      , "moveparent"                             );
            public static Int32 m_hCombatWeaponParent                   = g_NtvMngr.GetOffset("DT_BaseWeaponWorldModel"      , "m_hCombatWeaponParent"                  );
        }
        #endregion
    }

    public enum Hitboxes
    {
        HITBOX_HEAD,
        HITBOX_NECK,
        HITBOX_PELVIS,
        HITBOX_STOMACH,
        HITBOX_LOWER_CHEST,
        HITBOX_CHEST,
        HITBOX_UPPER_CHEST,
        HITBOX_RIGHT_THIGH,
        HITBOX_LEFT_THIGH,
        HITBOX_RIGHT_CALF,
        HITBOX_LEFT_CALF,
        HITBOX_RIGHT_FOOT,
        HITBOX_LEFT_FOOT,
        HITBOX_RIGHT_HAND,
        HITBOX_LEFT_HAND,
        HITBOX_RIGHT_UPPER_ARM,
        HITBOX_RIGHT_FOREARM,
        HITBOX_LEFT_UPPER_ARM,
        HITBOX_LEFT_FOREARM,
        HITBOX_MAX
    }
}