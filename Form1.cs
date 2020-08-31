using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sonic_Randomizer
{
    public partial class Form1 : Form
    {
        private Programs.Randomizer Randomizer = new Programs.Randomizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_game.SelectedIndex = 1;
            radio_SFX_None.Checked = true;
            radio_Music_None.Checked = true;
            chk_checksum.Checked = true;
        }

        private void cb_game_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_randomize_Click(object sender, EventArgs e)
        {


            try // Test if file is accessible...
            {
                Program.writer = new BinaryWriter(File.Open(Program.ROM, FileMode.Open), Encoding.UTF8);
                Program.writer.Dispose();
            }
            catch (Exception)
            {

                Functions.MessageHandler.ErrorMessage(1);
                if (Program.debug)
                    throw;
                return;
            }

            int game = cb_game.SelectedIndex + 1;
            bool lockon = cb_lockon.Checked;

            switch (game)   
            {
                case 2:
                    break;
                default:
                    Functions.MessageHandler.ErrorMessage(3);
                    return;
            }

            try
            {
                // SFX Randomizer
                Randomizer.Initialise(game, 1, radio_SFX_Random.Checked, radio_SFX_Same.Checked, true, lockon);

                // Music Randomizer
                Randomizer.Initialise(game, 2, radio_Music_Random.Checked, radio_Music_Same.Checked, true, lockon);

                // Rings Randomizer
                Randomizer.Initialise(game, 3, true, false, chk_rings.Checked, lockon);

                // Objects Randomizer
                Randomizer.Initialise(game, 4, true, false, chk_objects.Checked, lockon);

                // Palet Cycle Randomizer
                Randomizer.Initialise(game, 5, true, false, chk_paletCycle.Checked, lockon);

                // Palet Randomizer
                Randomizer.Initialise(game, 6, true, false, chk_palets.Checked, lockon);

                // Monitors Randomizer
                Randomizer.Initialise(game, 7, true, false, chk_monitors.Checked, lockon);


                // Select Level
                Randomizer.Fixes(game, 2, chk_levelselect.Checked, 0, lockon);

                // intro skip
                Randomizer.Fixes(game, 3, chk_intro.Checked, 0, lockon);

                // Checksum Bypass
                Randomizer.Fixes(game, 1, chk_checksum.Checked, 0, lockon);

                // Super Sonic
                Randomizer.Fixes(game, 4, chk_superSonic.Checked, 0, lockon);

                // Debug mode
                Randomizer.Fixes(game, 5, chk_debug.Checked, 0, lockon);

                // SSonic No music
                Randomizer.Fixes(game, 6, chk_SSonicMusic.Checked, 0, lockon);

                // SSonic Rings
                Randomizer.Fixes(game, 7, true, (int)num_SSonicRings.Value, lockon);

                // SSonic Rings Fixed
                Randomizer.Fixes(game, 8, chk_SSonicRingFix.Checked, 0, lockon);

                // Infinite Lifes
                Randomizer.Fixes(game, 9, chk_lifes.Checked, 0, lockon);
            }
            catch (Exception)
            {

                Functions.MessageHandler.ErrorMessage(2);
                if (Program.debug)
                    throw;
                return;
            }

           



        }

        private void btn_romselect_Click(object sender, EventArgs e)
        {
            txt_romselect.Text = FileSelect("ROM File", "ROM file|*.bin;*.md;|All files |*.*", Application.StartupPath, false, txt_romselect.Text);
        }

        private string FileSelect(string fileName, string filter, string dir, bool mode, string result)
        {
                openFile_Rom.FileName = fileName;
                openFile_Rom.Filter = filter;
                openFile_Rom.InitialDirectory = dir;
                openFile_Rom.RestoreDirectory = true;

                if (openFile_Rom.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFile_Rom.FileName))
                    {
                        result = openFile_Rom.FileName;
                    }
                }
            return result;
        }

        private void txt_romselect_TextChanged(object sender, EventArgs e)
        {
            Program.ROM = txt_romselect.Text;
        }

        private void form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void form_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                txt_romselect.Text = s[i];
        }

        private void radio_SFX_Random_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
