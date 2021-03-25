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


        static public void Initialise(int game, int mode, bool on, int value = 0, bool lockon = false, int rev = 0)
        {

            switch (mode)
            {
                case 1:
                    ChecksumFix(game, on, rev);
                    break;
                case 2:
                    StageSelectFix(game, on, rev);
                    break;
                case 3:
                    IntroFix(game, on, rev);
                    break;
                case 4:
                    SuperSonicFix(game, on, rev);
                    break;
                case 5:
                    DebugMode(game, on, rev);
                    break;
                case 6:
                    SSonicNoMusicFix(game, on, rev);
                    break;
                case 7:
                    SSonicRings(game, on, value, rev);
                    break;
                case 8:
                    SSonicRingsFix(game, on, rev);
                    break;
                case 9:
                    InfiniteLife(game, on, rev);
                    break;
                default:
                    break;
            }


        }

        static private void ChecksumFix(int game, bool on, int rev = 0)
        {
           
            if (game == 2 && rev == 1) // Sonic 2 Rev 1
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
            }
            else if((game == 1 || game == 2) && rev == 0) // Sonic 1 Rev 0 AND Sonic 2 Rev 0
            {
                if (on)
                {
                    fixBytes = new Byte[] { 0x5E, 0x54 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x04, 0x0C };
                }

                offset = new Int32[] { 0x305, 0x30F };
            }

            size = offset.Length;
        }
        static private void StageSelectFix(int game, bool on, int rev = 0)
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

                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x3CC6, 0x3CC7, 0x13B4, 0x13B5 };
                        break;
                    case 1:
                        offset = new Int32[] { 0x3CD2, 0x3CD3, 0x13C0, 0x13C1 };
                        break;
                    default:
                        break;
                }
                size = offset.Length;
            }
        }

        static private void SSonicNoMusicFix(int game, bool on, int rev = 0)
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
                    if (rev == 0)
                        fixBytes[9] = 0x52;
                }

                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x1ABA6, 0x1ABA7, 0x1ABA8, 0x1ABA9, 0x1ABAA, 0x1ABAB, 0x1ABAC, 0x1ABAD, 0x1ABAE, 0x1ABAF,
                                        0x1D835, 0x1D836, 0x1D837};
                        break;
                    case 1:
                        offset = new Int32[] { 0x1AB9A, 0x1AB9B, 0x1AB9C, 0x1AB9D, 0x1AB9E, 0x1AB9F, 0x1ABA0, 0x1ABA1, 0x1ABA2, 0x1ABA3,
                                        0x1D845, 0x1D846, 0x1D847};
                        break;

                    default:
                        break;
                }

                

                size = offset.Length;
            }
        }
        static private void SSonicRingsFix(int game, bool on, int rev = 0)
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
                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x1ABF8, 0x1ABF9, 0x1ABFA, 0x1ABFB };
                        break;
                    case 1:
                        offset = new Int32[] { 0x1ABEC, 0x1ABED, 0x1ABEE, 0x1ABEF };
                        break;
                    default:
                        break;
                }
                

                size = offset.Length;
            }
        }


        static private void IntroFix(int game, bool on, int rev = 0)
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

                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x398, 0x399 };
                        break;
                    case 1:
                        offset = new Int32[] { 0x3A4, 0x3A5 };
                        break;

                    default:
                        break;
                }
                

                size = offset.Length;
            }
            else if (game == 1)
            {

                if (on)
                {
                    fixBytes = new Byte[] { 0x2B };
                }
                else
                {
                    fixBytes = new Byte[] { 0x2A };
                }

                offset = new Int32[] { 0x398 };

                size = offset.Length;
            }
        }

        static private void SuperSonicFix(int game, bool on, int rev = 0)
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
                                            0x11, 0xFC, 0x00, 0x03/*, 0xFE, 0xC6*/};
                }

                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x3CDC, 0x3CDD, 0x3CDE, 0x3CDF, 0x3CE0, 0x3CE1, 0x3CE2, 0x3CE3,
                                        0x9488, 0x9489, 0x948A, 0x948B};
                        break;
                    case 1:
                        offset = new Int32[] { 0x3CE8, 0x3CE9, 0x3CEA, 0x3CEB, 0x3CEC, 0x3CED, 0x3CEE, 0x3CEF,
                                        0x9494, 0x9497, 0x9498, 0x9499};
                        break;

                    default:
                        break;
                }

                

                size = offset.Length;
            }
        }

        static private void DebugMode(int game, bool on, int rev = 0)
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

                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x3B8D };
                        break;
                    case 1:
                        offset = new Int32[] { 0x3B99 };
                        break;

                    default:
                        break;
                }
                

                size = offset.Length;
            }
            else if (game == 1)
            {

                if (on)
                {
                    fixBytes = new Byte[] {0x01, 0x4E, 0x71, 0x4E, 0x71 };
                }
                else
                {
                    fixBytes = new Byte[] {0x00, 0x67, 0x0E, 0x67, 0x22 };
                }

                offset = new Int32[] {0x310B, 0x3986, 0x3987, 0x13D8, 0x13D9 };

                size = offset.Length;
            }
        }

        static private void SSonicRings(int game, bool on, int rings, int rev = 0)
        {
            if (game == 2)
            {


                fixBytes = new Byte[] { (Byte) rings};

                
                switch (rev)
                {
                    case 0:
                        offset = new Int32[] { 0x1AB55 };
                        break;
                    case 1:
                        offset = new Int32[] { 0x1AB49 };
                        break;
                    default:
                        break;
                }
                size = offset.Length;
            }
        }

        static private void InfiniteLife(int game, bool on, int rev = 0)
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

                switch (rev)
                {

                    case 0:
                        offset = new Int32[] { 0x1B254, 0x1B255, 0x1B256, 0x1B257 };
                        break;
                    case 1:
                        offset = new Int32[] { 0x1B248, 0x1B249, 0x1B24A, 0x1B24B };
                        break;
                    default:
                        break;
                }
                

                size = offset.Length;
            } 
            else if (game == 1)
            {


                if (on)
                {
                    fixBytes = new Byte[] { 0x4E, 0x71, 0x4E, 0x71 };
                }
                else
                {
                    fixBytes = new Byte[] { 0x53, 0x38, 0xFE, 0x12 };
                }

                offset = new Int32[] { 0x138A0, 0x138A1, 0x138A2, 0x138A3 };

                size = offset.Length;
            }
        }

    }
}
