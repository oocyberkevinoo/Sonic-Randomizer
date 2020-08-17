using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Datas
{
    static class SFX
    {
        static private Byte[] data;
        static public List<Byte[]> list = new List<byte[]>();
        static public List<Byte[]> original = new List<byte[]>();
        static public int size;
        static public Int32 offset;


        static public void Initialise(int game)
        {
            if(game == 2)
            {
                offset = 0xFEE91;
                list.Clear();
                #region SFX List
                data = new byte[] { 0x33, 0xEF };
                list.Add(data);
                data = new byte[] { 0x49, 0xEF };
                list.Add(data);
                data = new byte[] { 0x73, 0xEF };
                list.Add(data);
                data = new byte[] { 0x92, 0xEF };
                list.Add(data);
                data = new byte[] { 0xC4, 0xEF };
                list.Add(data);
                data = new byte[] { 0xF9, 0xEF };
                list.Add(data);
                data = new byte[] { 0x25, 0xF0 };
                list.Add(data);
                data = new byte[] { 0x54, 0xF0 };
                list.Add(data);
                data = new byte[] { 0x80, 0xF0 };
                list.Add(data);
                data = new byte[] { 0x8F, 0xF0 };
                list.Add(data);
                data = new byte[] { 0xA1, 0xF0 };
                list.Add(data);
                data = new byte[] { 0xE2, 0xF0 };
                list.Add(data);
                data = new byte[] { 0x01, 0xF1 };
                list.Add(data);
                data = new byte[] { 0x35, 0xF1 };
                list.Add(data);
                data = new byte[] { 0x6B, 0xF1 };
                list.Add(data);
                data = new byte[] { 0xB5, 0xF1 };
                list.Add(data);
                data = new byte[] { 0xE2, 0xF1 };
                list.Add(data);
                data = new byte[] { 0x13, 0xF2 };
                list.Add(data);
                data = new byte[] { 0x3F, 0xF2 };
                list.Add(data);
                data = new byte[] { 0x8E, 0xF2 };
                list.Add(data);
                data = new byte[] { 0xBF, 0xF2 };
                list.Add(data);
                data = new byte[] { 0x1A, 0xF3 };
                list.Add(data);
                data = new byte[] { 0x2F, 0xF3 };
                list.Add(data);
                data = new byte[] { 0x4C, 0xF3 };
                list.Add(data);
                data = new byte[] { 0x87, 0xF3 };
                list.Add(data);
                data = new byte[] { 0xA4, 0xF3 };
                list.Add(data);
                data = new byte[] { 0xEE, 0xF3 };
                list.Add(data);
                data = new byte[] { 0x16, 0xF4 };
                list.Add(data);
                data = new byte[] { 0x41, 0xF4 };
                list.Add(data);
                data = new byte[] { 0x82, 0xF4 };
                list.Add(data);
                data = new byte[] { 0xD5, 0xF4 };
                list.Add(data);
                data = new byte[] { 0x0F, 0xF5 };
                list.Add(data);
                data = new byte[] { 0x81, 0xF5 };
                list.Add(data);
                data = new byte[] { 0x9A, 0xF5 };
                list.Add(data);
                data = new byte[] { 0xD4, 0xF5 };
                list.Add(data);
                data = new byte[] { 0xE5, 0xF5 };
                list.Add(data);
                data = new byte[] { 0x5F, 0xF6 };
                list.Add(data);
                data = new byte[] { 0x87, 0xF6 };
                list.Add(data);
                data = new byte[] { 0xEE, 0xF6 };
                list.Add(data);
                data = new byte[] { 0x16, 0xF7 };
                list.Add(data);
                data = new byte[] { 0x44, 0xF7 };
                list.Add(data);
                data = new byte[] { 0x55, 0xF7 };
                list.Add(data);
                data = new byte[] { 0x82, 0xF7 };
                list.Add(data);
                data = new byte[] { 0xAF, 0xF7 };
                list.Add(data);
                data = new byte[] { 0xE2, 0xF7 };
                list.Add(data);
                data = new byte[] { 0x1C, 0xF8 };
                list.Add(data);
                data = new byte[] { 0x29, 0xF8 };
                list.Add(data);
                data = new byte[] { 0x3E, 0xF8 };
                list.Add(data);
                data = new byte[] { 0x75, 0xF8 };
                list.Add(data);
                data = new byte[] { 0xA8, 0xF8 };
                list.Add(data);
                data = new byte[] { 0xE1, 0xF8 };
                list.Add(data);
                data = new byte[] { 0x1E, 0xF9 };
                list.Add(data);
                data = new byte[] { 0x5D, 0xF9 };
                list.Add(data);
                data = new byte[] { 0x9E, 0xF9 };
                list.Add(data);
                data = new byte[] { 0xC8, 0xF9 };
                list.Add(data);
                data = new byte[] { 0x0D, 0xFA };
                list.Add(data);
                data = new byte[] { 0x35, 0xFA };
                list.Add(data);
                data = new byte[] { 0x5F, 0xFA };
                list.Add(data);
                data = new byte[] { 0xB8, 0xFA };
                list.Add(data);
                data = new byte[] { 0xE5, 0xFA };
                list.Add(data);
                data = new byte[] { 0x19, 0xFB };
                list.Add(data);
                data = new byte[] { 0x60, 0xFB };
                list.Add(data);
                data = new byte[] { 0x88, 0xFB };
                list.Add(data);
                data = new byte[] { 0xC2, 0xFB };
                list.Add(data);
                data = new byte[] { 0x5E, 0xFC };
                list.Add(data);
                data = new byte[] { 0x99, 0xFC };
                list.Add(data);
                data = new byte[] { 0xF6, 0xFC };
                list.Add(data);
                data = new byte[] { 0x2D, 0xFD };
                list.Add(data);
                data = new byte[] { 0x5C, 0xFD };
                list.Add(data);
                data = new byte[] { 0x84, 0xFD };
                list.Add(data);
                data = new byte[] { 0xA5, 0xFD };
                list.Add(data);
                data = new byte[] { 0xDF, 0xFD };
                list.Add(data);
                data = new byte[] { 0x00, 0xFE };
                list.Add(data);
                data = new byte[] { 0x2A, 0xFE };
                list.Add(data);
                data = new byte[] { 0x67, 0xFE };
                list.Add(data);
                data = new byte[] { 0x92, 0xFE };
                list.Add(data);
                data = new byte[] { 0xBC, 0xFE };
                list.Add(data);
                data = new byte[] { 0x27, 0xFF };
                list.Add(data);
                data = new byte[] { 0x53, 0xFF };
                list.Add(data);
                data = new byte[] { 0x91, 0xFF };
                list.Add(data);
                data = new byte[] { 0xD4, 0xFF };
                list.Add(data);
                #endregion
                size = list.Count;

            }


        }
    }
}
