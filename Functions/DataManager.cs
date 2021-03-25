using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic_Randomizer.Functions
{
    static class DataManager
    {


        public static void writeData(Byte[] bytes, bool delete = false)
        {
            Program.writer.Write(bytes);
        }
        public static void writeData(Byte bytes, bool delete = false)
        {
            Program.writer.Write(bytes);
        }

        public static Byte[] readData(int length)
        {
            return Program.reader.ReadBytes(length);
        }
        public static Byte readData()
        {
            return Program.reader.ReadByte();
        }


        public static int Shuffle(List<Byte[]> data)
        {
            Random random = new Random();
            return random.Next(0, data.Count - 1);
        }

        public static void Same(List<Byte[]> data)
        {
            Random random = new Random();
            int i = random.Next(0, data.Count - 1);
        }

    }
}
