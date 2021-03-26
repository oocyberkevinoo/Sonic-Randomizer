using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Datas
{
    static class Objects
    {
        static private Byte[] data;
        static public List<Byte[]> list = new List<byte[]>();
        static public List<Byte[]> original = new List<byte[]>();
        static public int size;
        static public Int32 offset;
        static public Byte[] testBytes;


        static public void Initialise(int game, int rev = 0)
        {
            if(game == 2)
            {
                testBytes = new Byte[] { 0x00, 0x00, 0x00, 0x00 };
                offset = 0xE6800;
                list.Clear();
                #region Objects List
                data = new byte[] { 0x00, 0x4A };
                list.Add(data);
                data = new byte[] { 0x03, 0x7A };
                list.Add(data);
                data = new byte[] { 0x07, 0x34 };
                list.Add(data);
                data = new byte[] { 0x0B, 0xC0 };
                list.Add(data);
                data = new byte[] { 0x10, 0xEE };
                list.Add(data);
                data = new byte[] { 0x10, 0xEE };
                list.Add(data);
                data = new byte[] { 0x17, 0x48 };
                list.Add(data);
                data = new byte[] { 0x1A, 0xFC };
                list.Add(data);
                data = new byte[] { 0x1B, 0x02 };
                list.Add(data);
                data = new byte[] { 0x1E, 0x68 };
                list.Add(data);
                data = new byte[] { 0x24, 0x80 };
                list.Add(data);
                data = new byte[] { 0x25, 0x94 };
                list.Add(data);
                data = new byte[] { 0x25, 0xA0 };
                list.Add(data);
                data = new byte[] { 0x2A, 0x14 };
                list.Add(data);
                data = new byte[] { 0x2E, 0x8E };
                list.Add(data);
                data = new byte[] { 0x31, 0xA0 };
                list.Add(data);
                data = new byte[] { 0x35, 0x1E };
                list.Add(data);
                data = new byte[] { 0x3B, 0xD8 };
                list.Add(data);
                data = new byte[] { 0x41, 0xD2 };
                list.Add(data);
                data = new byte[] { 0x45, 0x6E };
                list.Add(data);
                data = new byte[] { 0x4A, 0x30 };
                list.Add(data);
                data = new byte[] { 0x4A, 0x54 };
                list.Add(data);
                data = new byte[] { 0x4A, 0x5A };
                list.Add(data);
                data = new byte[] { 0x4E, 0xA4 };
                list.Add(data);
                data = new byte[] { 0x53, 0xDE };
                list.Add(data);
                data = new byte[] { 0x55, 0x4C };
                list.Add(data);
                data = new byte[] { 0x25, 0x94 };
                list.Add(data);
                data = new byte[] { 0x24, 0x80 };
                list.Add(data);
                data = new byte[] { 0x1E, 0x68 };
                list.Add(data);
                data = new byte[] { 0x17, 0x48 };
                list.Add(data);
                data = new byte[] { 0x17, 0x48 };
                list.Add(data);
                data = new byte[] { 0x4E, 0xA4 };
                list.Add(data);
                data = new byte[] { 0x53, 0xDE };
                list.Add(data);
                data = new byte[] { 0x55, 0x4C };
                list.Add(data);
                #endregion
                size = list.Count;
                #region Original Objects List
                data = new byte[] { 0x00, 0x4A };
                original.Add(data);
                data = new byte[] { 0x03, 0x7A };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x07, 0x34 };
                original.Add(data);
                data = new byte[] { 0x0B, 0xC0 };
                original.Add(data);
                data = new byte[] { 0x10, 0xEE };
                original.Add(data);
                data = new byte[] { 0x10, 0xEE };
                original.Add(data);
                data = new byte[] { 0x17, 0x48 };
                original.Add(data);
                data = new byte[] { 0x1A, 0xFC };
                original.Add(data);
                data = new byte[] { 0x1B, 0x02 };
                original.Add(data);
                data = new byte[] { 0x1E, 0x68 };
                original.Add(data);
                data = new byte[] { 0x24, 0x80 };
                original.Add(data);
                data = new byte[] { 0x25, 0x94 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x55, 0x52 };
                original.Add(data);
                data = new byte[] { 0x25, 0xA0 };
                original.Add(data);
                data = new byte[] { 0x2A, 0x14 };
                original.Add(data);
                data = new byte[] { 0x2E, 0x8E };
                original.Add(data);
                data = new byte[] { 0x31, 0xA0 };
                original.Add(data);
                data = new byte[] { 0x35, 0x1E };
                original.Add(data);
                data = new byte[] { 0x3B, 0xD8 };
                original.Add(data);
                data = new byte[] { 0x41, 0xD2 };
                original.Add(data);
                data = new byte[] { 0x45, 0x6E };
                original.Add(data);
                data = new byte[] { 0x4A, 0x30 };
                original.Add(data);
                data = new byte[] { 0x4A, 0x54 };
                original.Add(data);
                data = new byte[] { 0x4A, 0x5A };
                original.Add(data);
                data = new byte[] { 0x4E, 0xA4 };
                original.Add(data);
                data = new byte[] { 0x53, 0xDE };
                original.Add(data);
                data = new byte[] { 0x55, 0x4C };
                original.Add(data);
                #endregion
            }


        }
    }
}
