using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Datas
{
    static class Music
    {
        static private Byte[] data;
        static public List<Byte[]> list = new List<byte[]>();
        static public List<Byte[]> original = new List<byte[]>();
        static public int size;
        static public Int32 offset;
        static public List<int> overide = new List<int>();


        static public void Initialise(int game, int rev = 0)
        {
            
            overide.Add(0);
            overide.Add(5);
            overide.Add(21);
            overide.Add(24);
            overide.Add(26);
            overide.Add(29);

            if(game == 2)
            {
                offset = 0xF8000;
                list.Clear();
                original.Clear();
                #region Music List
                // CRASH GAME 2P
                data = new byte[] { 0xF6, 0x84 };
                //data = new byte[] { 0xEE, 0x8D };
                list.Add(data);
                data = new byte[] { 0xC4, 0x88 };
                list.Add(data);
                data = new byte[] { 0xEE, 0x8D };
                list.Add(data);
                data = new byte[] { 0x7B, 0x91 };
                list.Add(data);
                data = new byte[] { 0x64, 0x96 };
                list.Add(data);
                // CRASH GAME 2P
                data = new byte[] { 0x3C, 0x9A };
                //data = new byte[] { 0x64, 0x96 };
                list.Add(data);
                data = new byte[] { 0x69, 0x9D };
                list.Add(data);
                data = new byte[] { 0x6B, 0xA3 };
                list.Add(data);
                data = new byte[] { 0xED, 0xA6 };
                list.Add(data);
                data = new byte[] { 0xC4, 0xAA };
                list.Add(data);
                data = new byte[] { 0x3C, 0xAC };
                list.Add(data);
                data = new byte[] { 0x24, 0xB1 };
                list.Add(data);
                data = new byte[] { 0xF7, 0xB3 };
                list.Add(data);
                data = new byte[] { 0x1E, 0xB8 };
                list.Add(data);
                data = new byte[] { 0x6F, 0xBA };
                list.Add(data);
                data = new byte[] { 0x8C, 0xBD };
                list.Add(data);
                data = new byte[] { 0x46, 0xC1 };
                list.Add(data);
                data = new byte[] { 0xBC, 0xCB };
                list.Add(data);
                data = new byte[] { 0x74, 0xCE };
                list.Add(data);
                data = new byte[] { 0xBC, 0xCB };
                list.Add(data);
                data = new byte[] { 0x74, 0xCE };
                list.Add(data);
                // Extra Life | CRASH THE GAME
                //data = new byte[] { 0x8D, 0xD4 };
                list.Add(data);
                data = new byte[] { 0x93, 0xD1 };
                list.Add(data);
                data = new byte[] { 0x5E, 0xD3 };
                list.Add(data);
                // GameOver Music | CRASH THE GAME
                //data = new byte[] { 0x7A, 0xD5 };
                    data = new byte[] { 0x59, 0x83 };
                list.Add(data);
                data = new byte[] { 0x59, 0x83 };
                list.Add(data);
                // Emerald Music | CRASH THE GAME
                //data = new byte[] { 0xC9, 0xD6 };
                    data = new byte[] { 0x3C, 0x80 };
                list.Add(data);
                data = new byte[] { 0x3C, 0x80 };
                list.Add(data);
                data = new byte[] { 0x3B, 0x82 };
                list.Add(data);
                // Credits Music | CRASH THE GAME
                //data = new byte[] { 0x97, 0xD7 };
                    data = new byte[] { 0x3B, 0x82 };
                list.Add(data);
                #endregion
                size = list.Count;
                #region Original Music List
                data = new byte[] { 0xF6, 0x84 };
                original.Add(data);
                data = new byte[] { 0xC4, 0x88 };
                original.Add(data);
                data = new byte[] { 0xEE, 0x8D };
                original.Add(data);
                data = new byte[] { 0x7B, 0x91 };
                original.Add(data);
                data = new byte[] { 0x64, 0x96 };
                original.Add(data);
                data = new byte[] { 0x3C, 0x9A };
                original.Add(data);
                data = new byte[] { 0x69, 0x9D };
                original.Add(data);
                data = new byte[] { 0x6B, 0xA3 };
                original.Add(data);
                data = new byte[] { 0xED, 0xA6 };
                original.Add(data);
                data = new byte[] { 0xC4, 0xAA };
                original.Add(data);
                data = new byte[] { 0x3C, 0xAC };
                original.Add(data);
                data = new byte[] { 0x24, 0xB1 };
                original.Add(data);
                data = new byte[] { 0xF7, 0xB3 };
                original.Add(data);
                data = new byte[] { 0x1E, 0xB8 };
                original.Add(data);
                data = new byte[] { 0x6F, 0xBA };
                original.Add(data);
                data = new byte[] { 0x8C, 0xBD };
                original.Add(data);
                data = new byte[] { 0x46, 0xC1 };
                original.Add(data);
                data = new byte[] { 0x80, 0xC4 };
                original.Add(data);
                data = new byte[] { 0x24, 0xC8 };
                original.Add(data);
                data = new byte[] { 0xBC, 0xCB };
                original.Add(data);
                data = new byte[] { 0x74, 0xCE };
                original.Add(data);
                data = new byte[] { 0x8D, 0xD4 };
                original.Add(data);
                data = new byte[] { 0x93, 0xD1 };
                original.Add(data);
                data = new byte[] { 0x5E, 0xD3 };
                original.Add(data);
                data = new byte[] { 0x7A, 0xD5 };
                original.Add(data);
                data = new byte[] { 0x59, 0x83 };
                original.Add(data);
                data = new byte[] { 0xC9, 0xD6 };
                original.Add(data);
                data = new byte[] { 0x3C, 0x80 };
                original.Add(data);
                data = new byte[] { 0x3B, 0x82 };
                original.Add(data);
                data = new byte[] { 0x97, 0xD7 };
                original.Add(data);
                #endregion
            }


        }
    }
}
