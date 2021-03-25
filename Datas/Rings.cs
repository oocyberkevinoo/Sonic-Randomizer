using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Datas
{
    static class Rings
    {
        static private Byte[] data;
        static public List<Byte[]> list = new List<byte[]>();
        static public List<Byte[]> original = new List<byte[]>();
        static public int size;
        static public Int32 offset;


        static public void Initialise(int game, int rev = 0)
        {
            if(game == 2)
            {
                offset = 0xE4300;
                list.Clear();
                original.Clear();
                #region Rings List
                data = new byte[] { 0x00, 0x44 };
                list.Add(data);
                data = new byte[] { 0x02, 0x6A };
                list.Add(data);
                data = new byte[] { 0x04, 0xAC };
                list.Add(data);
                data = new byte[] { 0x04, 0xAE };
                list.Add(data);
                data = new byte[] { 0x04, 0xB0 };
                list.Add(data);
                data = new byte[] { 0x04, 0xB2 };
                list.Add(data);
                data = new byte[] { 0x04, 0xB4 };
                list.Add(data);
                data = new byte[] { 0x04, 0xB6 };
                list.Add(data);
                data = new byte[] { 0x04, 0xB8 };
                list.Add(data);
                data = new byte[] { 0x07, 0x2A };
                list.Add(data);
                data = new byte[] { 0x09, 0x48 };
                list.Add(data);
                data = new byte[] { 0x0A, 0x72 };
                list.Add(data);
                data = new byte[] { 0x1E, 0x54 };
                list.Add(data);
                data = new byte[] { 0x1F, 0x92 };
                list.Add(data);
                data = new byte[] { 0x0A, 0x74 };
                list.Add(data);
                data = new byte[] { 0x0B, 0xAA };
                list.Add(data);
                data = new byte[] { 0x0D, 0xE8 };
                list.Add(data);
                data = new byte[] { 0x0F, 0x5A };
                list.Add(data);
                data = new byte[] { 0x0F, 0x5C };
                list.Add(data);
                data = new byte[] { 0x0F, 0x5E };
                list.Add(data);
                data = new byte[] { 0x0F, 0x60 };
                list.Add(data);
                data = new byte[] { 0x11, 0x22 };
                list.Add(data);
                data = new byte[] { 0x12, 0x98 };
                list.Add(data);
                data = new byte[] { 0x14, 0x0E };
                list.Add(data);
                data = new byte[] { 0x16, 0x44 };
                list.Add(data);
                data = new byte[] { 0x18, 0x7E };
                list.Add(data);
                data = new byte[] { 0x1B, 0x2C };
                list.Add(data);
                data = new byte[] { 0x1C, 0x9E };
                list.Add(data);
                data = new byte[] { 0x1E, 0x50 };
                list.Add(data);
                data = new byte[] { 0x1E, 0x52 };
                list.Add(data);
                data = new byte[] { 0x1F, 0x94 };
                list.Add(data);
                data = new byte[] { 0x21, 0x2E };
                list.Add(data);
                data = new byte[] { 0x23, 0x84 };
                list.Add(data);
                data = new byte[] { 0x23, 0xD6 };
                list.Add(data);
                #endregion
                size = list.Count;

                #region original Rings List
                data = new byte[] { 0x00, 0x44 };
                original.Add(data);
                data = new byte[] { 0x02, 0x6A };
                original.Add(data);
                data = new byte[] { 0x04, 0xAC };
                original.Add(data);
                data = new byte[] { 0x04, 0xAE };
                original.Add(data);
                data = new byte[] { 0x04, 0xB0 };
                original.Add(data);
                data = new byte[] { 0x04, 0xB2 };
                original.Add(data);
                data = new byte[] { 0x04, 0xB4 };
                original.Add(data);
                data = new byte[] { 0x04, 0xB6 };
                original.Add(data);
                data = new byte[] { 0x04, 0xB8 };
                original.Add(data);
                data = new byte[] { 0x07, 0x2A };
                original.Add(data);
                data = new byte[] { 0x09, 0x48 };
                original.Add(data);
                data = new byte[] { 0x0A, 0x72 };
                original.Add(data);
                data = new byte[] { 0x1E, 0x54 };
                original.Add(data);
                data = new byte[] { 0x1F, 0x92 };
                original.Add(data);
                data = new byte[] { 0x0A, 0x74 };
                original.Add(data);
                data = new byte[] { 0x0B, 0xAA };
                original.Add(data);
                data = new byte[] { 0x0D, 0xE8 };
                original.Add(data);
                data = new byte[] { 0x0F, 0x5A };
                original.Add(data);
                data = new byte[] { 0x0F, 0x5C };
                original.Add(data);
                data = new byte[] { 0x0F, 0x5E };
                original.Add(data);
                data = new byte[] { 0x0F, 0x60 };
                original.Add(data);
                data = new byte[] { 0x11, 0x22 };
                original.Add(data);
                data = new byte[] { 0x12, 0x98 };
                original.Add(data);
                data = new byte[] { 0x14, 0x0E };
                original.Add(data);
                data = new byte[] { 0x16, 0x44 };
                original.Add(data);
                data = new byte[] { 0x18, 0x7E };
                original.Add(data);
                data = new byte[] { 0x1B, 0x2C };
                original.Add(data);
                data = new byte[] { 0x1C, 0x9E };
                original.Add(data);
                data = new byte[] { 0x1E, 0x50 };
                original.Add(data);
                data = new byte[] { 0x1E, 0x52 };
                original.Add(data);
                data = new byte[] { 0x1F, 0x94 };
                original.Add(data);
                data = new byte[] { 0x21, 0x2E };
                original.Add(data);
                data = new byte[] { 0x23, 0x84 };
                original.Add(data);
                data = new byte[] { 0x23, 0xD6 };
                original.Add(data);
                #endregion
            }


        }
    }
}
