using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Programs
{
    static class Fixes
    {
        static public Byte[] fixBytes;
        static public int size;
        static public Int32[] offset;


        static public void Initialise(int game, int mode, bool on, int value = 0, bool lockon = false)
        {

            switch (mode)
            {
                case 1:
                    ChecksumFix(game, on);
                    break;
                case 2:
                    StageSelectFix(game, on);
                    break;
                case 3:
                    IntroFix(game, on);
                    break;
                case 4:
                    SuperSonicFix(game, on);
                    break;
                case 5:
                    DebugMode(game, on);
                    break;
                case 6:
                    SSonicNoMusicFix(game, on);
                    break;
                case 7:
                    SSonicRings(game, on, value);
                    break;
                case 8:
                    SSonicRingsFix(game, on);
                    break;
                case 9:
                    InfiniteLife(game, on);
                    break;
                default:
                    break;
            }


        }

        static private void ChecksumFix(int game, bool on)
        {
            if (game == 2)
            {
                
                if (on)
                {
                    fixBytes = new Byte[] { 0x5E, 0x54 };
                }
                else
                {
                    fixBytes = new Byte[] { 0xF4, 0x0C };
                }
                
                offset = new Int32[] { 0x311, 0x31B };

                size = offset.Length;
            }
        }
        static private void StageSelectFix(int game, bool on)
        {
            if (game == 2)
            {
                
                if (on)
                {
                    fixBytes = new Byte[] { 0x4E, 0x71, 0x4E, 0x71 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x67, 0x10, 0x67, 0x22 };
                }
                
                offset = new Int32[] { 0x3CD2, 0x3CD3, 0x13C0, 0x13C1 };

                size = offset.Length;
            }
        }

        static private void SSonicNoMusicFix(int game, bool on)
        {
            if (game == 2)
            {

                if (on)
                {
                    fixBytes = new Byte[] { 0x4E, 0x71, 0x4E, 0x71, 0x4E, 0x71, 0x4E, 0x71, 0x4E, 0x71,
                                            0x00, 0x4E, 0x71};
                }
                else
                {
                    fixBytes = new Byte[] { 0x30, 0x3C, 0x00, 0x96, 0x4E, 0xF9, 0x00, 0x00, 0x13, 0x5E,
                                            0x3C, 0x00, 0x96};
                }

                offset = new Int32[] { 0x1AB9A, 0x1AB9B, 0x1AB9C, 0x1AB9D, 0x1AB9E, 0x1AB9F, 0x1ABA0, 0x1ABA1, 0x1ABA2, 0x1ABA3,
                                        0x1D845, 0x1D846, 0x1D847};

                size = offset.Length;
            }
        }
        static private void SSonicRingsFix(int game, bool on)
        {
            if (game == 2)
            {

                if (on)
                {
                    fixBytes = new Byte[] { 0x4E, 0x71, 0x4E, 0x71 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x53, 0x78, 0xFE, 0x20 };
                }

                offset = new Int32[] { 0x1ABEC, 0x1ABED, 0x1ABEE, 0x1ABEF };

                size = offset.Length;
            }
        }


        static private void IntroFix(int game, bool on)
        {
            if (game == 2)
            {
               
                if (on)
                {
                    fixBytes = new Byte[] { 0x35, 0xF4 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x34, 0x14 };
                }

                offset = new Int32[] { 0x3A4, 0x3A5 };

                size = offset.Length;
            }
        }

        static private void SuperSonicFix(int game, bool on)
        {
            if (game == 2)
            {
                // OLD FIX
                /*
                if (on)
                {
                    fixBytes = new Byte[] { 0x00, 0x65 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x07, 0x66 };
                }

                offset = new Int32[] { 0x1AB41, 0x1AB44 };
                */
                if (on)
                {
                    fixBytes = new Byte[] { 0x70, 0x07, 0x31, 0xC0, 0xFF, 0xB0, 0x4E, 0x71,
                                            0x31, 0x07, 0xFF, 0xB0};
                }
                else
                {
                    fixBytes = new Byte[] { 0x31, 0xC0, 0xFF, 0xB0, 0x21, 0xC0, 0xFF, 0xB2,
                                            0x11, 0xFC, 0x00, 0x03, 0xFE, 0xC6};
                }

                offset = new Int32[] { 0x3CE8, 0x3CE9, 0x3CEA, 0x3CEB, 0x3CEC, 0x3CED, 0x3CEE, 0x3CEF,
                                        0x9494, 0x9497, 0x9498, 0x9499};

                size = offset.Length;
            }
        }

        static private void DebugMode(int game, bool on)
        {
            if (game == 2)
            {

                // OLD FIX
                /*if (on)
                {
                    fixBytes = new Byte[] { 0x4E, 0x71 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x67, 0x14 };
                }

                offset = new Int32[] { 0x1A034, 0x1A035 };*/

                if (on)
                {
                    fixBytes = new Byte[] { 0x01 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x00 };
                }

                offset = new Int32[] { 0x3B99 };

                size = offset.Length;
            }
        }

        static private void SSonicRings(int game, bool on, int rings)
        {
            if (game == 2)
            {


                fixBytes = new Byte[] { (Byte) rings};

                offset = new Int32[] { 0x1AB49};

                size = offset.Length;
            }
        }

        static private void InfiniteLife(int game, bool on)
        {
            if (game == 2)
            {


                if (on)
                {
                    fixBytes = new Byte[] { 0x4E, 0x71, 0x4E, 0x71 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x53, 0x38, 0xFE, 0x12 };
                }

                offset = new Int32[] { 0x1B248, 0x1B249, 0x1B24A, 0x1B24B };

                size = offset.Length;
            }
        }

    }
}
