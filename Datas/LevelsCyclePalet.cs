﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Datas
{
    static class LevelsCyclePalet
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
                testBytes = new Byte[] { 0x4E, 0x75 };
                switch (rev)
                {
                    case 0:
                        offset = 0x19E8;
                        break;
                    case 1:
                        offset = 0x19F4;
                        break;
                    default:
                        break;
                }
                
                list.Clear();
                #region Levels List
                data = new byte[] { 0x00, 0x24 };
                list.Add(data);
                data = new byte[] { 0x00, 0x22 };
                list.Add(data);
                data = new byte[] { 0x00, 0x52 };
                list.Add(data);
                data = new byte[] { 0x00, 0x22 };
                list.Add(data);
                data = new byte[] { 0x00, 0x82 };
                list.Add(data);
                data = new byte[] { 0x00, 0x82 };
                list.Add(data);
                data = new byte[] { 0x03, 0xC2 };
                list.Add(data);
                data = new byte[] { 0x01, 0x18 };
                list.Add(data);
                data = new byte[] { 0x01, 0x5C };
                list.Add(data);
                data = new byte[] { 0x00, 0x22 };
                list.Add(data);
                data = new byte[] { 0x01, 0x9E };
                list.Add(data);
                data = new byte[] { 0x01, 0xCC };
                list.Add(data);
                data = new byte[] { 0x01, 0xFA };
                list.Add(data);
                data = new byte[] { 0x03, 0x22 };
                list.Add(data);
                data = new byte[] { 0x03, 0x22 };
                list.Add(data);
                data = new byte[] { 0x03, 0x94 };
                list.Add(data);
                data = new byte[] { 0x03, 0xC2 };
                list.Add(data);
                #endregion
                size = list.Count;
            }


        }
    }
}
