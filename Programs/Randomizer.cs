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
        private int data_size;
        private List<Byte[]> data_list;
        private List<Byte[]> overide_data_list = new List<Byte[]>();
        private Int32 data_offset;
        private List<int> overide = new List<int>();

        private bool shuffle = false;
        private bool same = false;

        private int mode;



        public void Initialise(int game, int mode, bool shuffle=false, bool same=false, bool on = true, bool lockon = false)
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
                    SFX.Initialise(game);
                    data_list = SFX.list;
                    data_size = SFX.size;
                    data_offset = SFX.offset;
                    break;
                case 2:
                    Music.Initialise(game);
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
                    break;
                case 3:
                    Rings.Initialise(game);
                    data_list = Rings.list;
                    data_size = Rings.size;
                    data_offset = Rings.offset;
                    break;
                case 4:
                    Objects.Initialise(game);
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
                    break;
                case 5:
                    LevelsCyclePalet.Initialise(game);
                    data_list = LevelsCyclePalet.list;
                    data_size = LevelsCyclePalet.size;
                    data_offset = LevelsCyclePalet.offset;
                    break;
                case 6:
                    LevelsPalet.Initialise(game);
                    data_list = LevelsPalet.list;
                    data_size = LevelsPalet.size;
                    data_offset = LevelsPalet.offset;
                    break;
                case 7:
                    Monitors.Initialise(game);
                    data_list = Monitors.list;
                    data_size = Monitors.size;
                    data_offset = Monitors.offset;
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

        public void Fixes(int game, int mode, bool on, int value = 0, bool lockon = false)
        {
            Program.writer = new BinaryWriter(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);
            int lock_offset = 0x00;
            switch (game)
            {
                
                case 1: // Sonic The Hedgehog Rev 1
                    Programs.Fixes.Initialise(game, mode, on, value, lockon);

                    // Knuckles LockOn
                    if (lockon)
                    {
                        lock_offset = 0x00200000;
                    }

                    for (int i = 0; i < Programs.Fixes.size; i++)
                    {
                        Program.writer.Seek(Programs.Fixes.offset[i] + lock_offset, SeekOrigin.Begin);
                        Functions.DataManager.writeData(Programs.Fixes.fixBytes[i]);
                    }

                    break;
                case 2: // Sonic The Hedgehog 2 Rev 2
                    Programs.Fixes.Initialise(game, mode, on, value, lockon);

                    // Knuckles LockOn
                    if (lockon)
                    {
                        lock_offset = 0x00200000;
                    }

                    for (int i = 0; i < Programs.Fixes.size; i++)
                    {
                        Program.writer.Seek(Programs.Fixes.offset[i] + lock_offset, SeekOrigin.Begin);
                        Functions.DataManager.writeData(Programs.Fixes.fixBytes[i]);
                    }
                    
                    break;
                default:
                    break;
            }
            Program.writer.Dispose();
        }
    }
}
