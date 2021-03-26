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
        static public Byte[] testBytes;


        static public void Initialise(int game, int rev = 0)
        {
            if(game == 2)
            {
                testBytes = new Byte[] { 0x4E, 0xFB, 0x00, 0x02 };
                switch (rev)
                {
                    case 0:
                        offset = 0x12950;
                        break;
                    case 1:
                        offset = 0x12924;
                        break;
                    default:
                        break;
                }
                
                list.Clear();
                switch (rev)
                {
                    case 0:
                        #region Monitors List Rev 0
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
                        data = new byte[] { 0x00, 0x9C };
                        list.Add(data);
                        data = new byte[] { 0x00, 0xE8 };
                        list.Add(data);
                        data = new byte[] { 0x01, 0x18 };
                        list.Add(data);
                        data = new byte[] { 0x01, 0x62 };
                        list.Add(data);
                        data = new byte[] { 0x03, 0x6E };
                        list.Add(data);
                        #endregion
                        break;
                    case 1:
                        #region Monitors List Rev 1
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
                        break;

                    default:
                        break;
                }
                
                size = list.Count;
            }


        }
    }
}
