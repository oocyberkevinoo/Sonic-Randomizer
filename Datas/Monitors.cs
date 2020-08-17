using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Datas
{
    static class Monitors
    {
        static private Byte[] data;
        static public List<Byte[]> list = new List<byte[]>();
        static public int size;
        static public Int32 offset;


        static public void Initialise(int game)
        {
            if(game == 2)
            {
               
                offset = 0x12924;
                list.Clear();
                #region Monitors List
                data = new byte[] { 0x00, 0x14 };
                list.Add(data);
                data = new byte[] { 0x00, 0x1A };
                list.Add(data);
                data = new byte[] { 0x00, 0x30 };
                list.Add(data);
                data = new byte[] { 0x00, 0x14 };
                list.Add(data);
                data = new byte[] { 0x00, 0x46 };
                list.Add(data);
                data = new byte[] { 0x00, 0xBC };
                list.Add(data);
                data = new byte[] { 0x01, 0x08 };
                list.Add(data);
                data = new byte[] { 0x01, 0x38 };
                list.Add(data);
                data = new byte[] { 0x01, 0x82 };
                list.Add(data);
                data = new byte[] { 0x03, 0x9A };
                list.Add(data);
                #endregion
                size = list.Count;
            }


        }
    }
}
