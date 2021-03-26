using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sonic_Randomizer.Datas;

namespace Sonic_Randomizer.Programs
{
    class Randomizer
    {
        private int counter;
        private int i;
        private Byte[] testBytes;
        private int data_size;
        private List<Byte[]> data_list;
        private List<Byte[]> overide_data_list = new List<Byte[]>();
        private Int32 data_offset;
        private List<int> overide = new List<int>();

        private bool shuffle = false;
        private bool same = false;

        private int mode;



        public void Initialise(int game, int mode, bool shuffle=false, bool same=false, bool on = true, bool lockon = false, int rev = 0)
        {
            this.mode = mode;
            counter = 0;
            this.shuffle = shuffle;
            this.same = same;
            if(overide.Count > 0)
                overide.Clear();
            if(overide_data_list.Count > 0)
                overide_data_list.Clear();
            switch (mode)
            {
                case 1:
                    SFX.Initialise(game, rev);
                    data_list = SFX.list;
                    data_size = SFX.size;
                    data_offset = SFX.offset;
                    testBytes = SFX.testBytes;
                    break;
                case 2:
                    Music.Initialise(game, rev);
                    if(!shuffle && !same)
                    {
                        data_list = Music.original;
                    }
                    else
                    {
                        data_list = Music.list;
                        
                    }
                    overide_data_list = Music.original;
                    data_size = Music.size;
                    data_offset = Music.offset;
                    overide = Music.overide;
                    testBytes = Music.testBytes;
                    break;
                case 3:
                    Rings.Initialise(game, rev);
                    data_list = Rings.list;
                    data_size = Rings.size;
                    data_offset = Rings.offset;
                    testBytes = Rings.testBytes;
                    break;
                case 4:
                    Objects.Initialise(game, rev);
                    if (!on)
                    {
                        data_list = Objects.original;
                    }
                    else
                    {
                        data_list = Objects.list;
                    }
                    data_size = Objects.size;
                    data_offset = Objects.offset;
                    testBytes = Objects.testBytes;
                    break;
                case 5:
                    LevelsCyclePalet.Initialise(game, rev);
                    data_list = LevelsCyclePalet.list;
                    data_size = LevelsCyclePalet.size;
                    data_offset = LevelsCyclePalet.offset;
                    testBytes = LevelsCyclePalet.testBytes;
                    break;
                case 6:
                    LevelsPalet.Initialise(game, rev);
                    data_list = LevelsPalet.list;
                    data_size = LevelsPalet.size;
                    data_offset = LevelsPalet.offset;
                    testBytes = LevelsPalet.testBytes;
                    break;
                case 7:
                    Monitors.Initialise(game, rev);
                    data_list = Monitors.list;
                    data_size = Monitors.size;
                    data_offset = Monitors.offset;
                    testBytes = Monitors.testBytes;
                    break;
                default:
                    break;
            }
            if (!on)
            {
                this.shuffle = false;
                this.same = false;
            }

            // Sonic & Knuckles LockOn Offset Shift
            if (lockon)
            {
                data_offset += 0x00200000;
            }

            bool valid = true;
            try
            {
                Program.reader = new BinaryReader(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);

                if (testBytes.Length != 0 && (game == 1 || game == 2))
                {
                    Program.reader.BaseStream.Position = data_offset - testBytes.Length;
                    Byte[] testedBytes = Program.reader.ReadBytes(testBytes.Length);
                    if (!testBytes.SequenceEqual(testedBytes) && testedBytes.Length != 0)
                    {
                        valid = false;
                    }
                }

            }
            catch (Exception)
            {

                valid = false;
            }
            Program.reader.Dispose();
            Program.reader.Close();

            if (valid)
                Randomize(on);

            

        }

        private void Randomize(bool on = true)
        {
            Program.writer = new BinaryWriter(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);
            Program.writer.Seek(data_offset, SeekOrigin.Begin);

            i = 0;
            if (same)
                i = Functions.DataManager.Shuffle(data_list);

            while (counter < data_size)
            {
                if (shuffle)
                    i = Functions.DataManager.Shuffle(data_list);
                if(overide.Count > 0 && overide.Contains(counter) && shuffle) {
                    Functions.DataManager.writeData(overide_data_list[counter]);
                }
                else
                {
                    Functions.DataManager.writeData(data_list[i]);
                }
                
                if (!same)
                    data_list.RemoveAt(i);

                counter++;
            }

            Program.writer.Dispose();
            
            
        }

        public void Fixes(int game, int mode, bool on, int value = 0, bool lockon = false, int rev = 0)
        {
            
            Program.reader = new BinaryReader(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);
            int lock_offset = 0x00;
            if (lockon)
            {
                lock_offset = 0x00200000; // Knuckles Lock On
            }

            if(game == 1 || game == 2) // Game compatible
            {

                Programs.Fixes.Initialise(game, mode, on, value, lockon, rev);
                bool valid = true;
                try
                {
                    if(Programs.Fixes.offset != null)
                    {
                        Program.reader.BaseStream.Position = (Programs.Fixes.offset[0] + lock_offset) - Programs.Fixes.testBytes.Length;
                        Byte[] testedBytes = Program.reader.ReadBytes(Programs.Fixes.testBytes.Length);
                        if (!Programs.Fixes.testBytes.SequenceEqual(testedBytes) && testedBytes.Length != 0)
                        {
                            valid = false;
                        }
                    }
                    
                }
                catch (Exception)
                {

                    valid = false;
                }
                
                Program.reader.Dispose();
                Program.reader.Close();

                Program.writer = new BinaryWriter(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);
                if (valid)
                {
                    for (int i = 0; i < Programs.Fixes.size; i++)
                    {
                    
                            Program.writer.Seek(Programs.Fixes.offset[i] + lock_offset, SeekOrigin.Begin);
                            Functions.DataManager.writeData(Programs.Fixes.fixBytes[i]);
                    }
                }

            }

            Program.writer.Dispose();
            Program.writer.Close();
        }

        public int[] GameTest()
        {
            int gameSelection = -1;
            int revSelection = -1;
            int lockon = 0;
            int offset = Datas.Games.offset;

            Program.reader = new BinaryReader(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);
            if(Program.reader.BaseStream.Length > 0x00200000)
            {
                lockon = 1;
                offset += 0x00200000;
                Functions.MessageHandler.ErrorMessage(7);
            }

            Program.reader.BaseStream.Position = offset;

            Byte[] gameID = Functions.DataManager.readData(0x08);
            Byte[] revID = Functions.DataManager.readData(0x03);

            
            Program.reader.Dispose();
            Program.reader.Close();

            // What game it is, and what Rev ?
            if (revID.SequenceEqual(Datas.Games.rev0))
                revSelection = 0;
            else if (revID.SequenceEqual(Datas.Games.rev1))
                revSelection = 1;
            else if (revID.SequenceEqual(Datas.Games.rev2))
                revSelection = 2;

            if (gameID.SequenceEqual(Datas.Games.sonic1))
            {
                Functions.MessageHandler.Message("Sonic 1 can't be Randomized for now, but fixes are working.", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                gameSelection = 0;
                if (revSelection != 0)
                    Functions.MessageHandler.ErrorMessage(6);
            }
            else if (gameID.SequenceEqual(Datas.Games.sonic2)){
                gameSelection = 1;
            }
            else if (gameID.SequenceEqual(Datas.Games.sonic3))
            {
                Functions.MessageHandler.Message("Sonic 3 can't be Randomized for now.", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                gameSelection = 2;
            }
            else if (gameID.SequenceEqual(Datas.Games.sonicK))
            {
                Functions.MessageHandler.Message("Sonic & Knuckles can't be Randomized for now.", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                gameSelection = 3;
            }
            else
            {
                Functions.MessageHandler.ErrorMessage(4);

            }
            


            return new int[] { gameSelection, revSelection, lockon };
        }
    }
}
