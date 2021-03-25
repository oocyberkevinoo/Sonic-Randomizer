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
            gameOptions();
        }

        private void gameOptions()
        {
            // Options depending of current selected game.
            switch (cb_game.SelectedIndex+1)
            {
                case 1:
                    // No Super Sonic in Sonic 1
                    chk_SSonicMusic.Enabled = false;
                    chk_SSonicRingFix.Enabled = false;
                    num_SSonicRings.Enabled = false;
                    chk_superSonic.Enabled = false;

                    // No Randomizer actually...
                    /*radio_Music_None.Enabled = false;
                    radio_Music_Random.Enabled = false;
                    radio_Music_Same.Enabled = false;
                    radio_SFX_None.Enabled = false;
                    radio_SFX_Random.Enabled = false;
                    radio_SFX_Same.Enabled = false;
                    chk_rings.Enabled = false;*/
                    break;

                case 2:
                    switch (cb_revision.SelectedIndex)
                    {
                        /*case 0:
                            chk_levelselect.Checked = false;
                            chk_levelselect.Enabled = false;
                            break;
                        default:
                            chk_levelselect.Enabled = true;
                            break;*/
                    }
                    break;

                default:
                    chk_SSonicMusic.Enabled = true;
                    chk_SSonicRingFix.Enabled = true;
                    num_SSonicRings.Enabled = true;
                    chk_superSonic.Enabled = true;

                    chk_levelselect.Enabled = true;
                    break;
            }



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
            int rev = cb_revision.SelectedIndex;
            bool lockon = cb_lockon.Checked;

            switch (game)   
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Functions.MessageHandler.ErrorMessage(3);
                    return;
            }

            try
            {
                // SFX Randomizer
                Randomizer.Initialise(game, 1, radio_SFX_Random.Checked, radio_SFX_Same.Checked, true, lockon, rev);

                // Music Randomizer
                Randomizer.Initialise(game, 2, radio_Music_Random.Checked, radio_Music_Same.Checked, true, lockon, rev);

                // Rings Randomizer
                Randomizer.Initialise(game, 3, true, false, chk_rings.Checked, lockon, rev);

                // Objects Randomizer
                Randomizer.Initialise(game, 4, true, false, chk_objects.Checked, lockon, rev);

                // Palet Cycle Randomizer
                Randomizer.Initialise(game, 5, true, false, chk_paletCycle.Checked, lockon, rev);

                // Palet Randomizer
                Randomizer.Initialise(game, 6, true, false, chk_palets.Checked, lockon, rev);

                // Monitors Randomizer
                Randomizer.Initialise(game, 7, true, false, chk_monitors.Checked, lockon, rev);


                // Select Level
                Randomizer.Fixes(game, 2, chk_levelselect.Checked, 0, lockon, rev);

                // intro skip
                Randomizer.Fixes(game, 3, chk_intro.Checked, 0, lockon, rev);

                // Checksum Bypass
                Randomizer.Fixes(game, 1, chk_checksum.Checked, 0, lockon, rev);

                // Super Sonic
                Randomizer.Fixes(game, 4, chk_superSonic.Checked, 0, lockon, rev);

                // Debug mode
                Randomizer.Fixes(game, 5, chk_debug.Checked, 0, lockon, rev);

                // SSonic No music
                Randomizer.Fixes(game, 6, chk_SSonicMusic.Checked, 0, lockon, rev);

                // SSonic Rings
                Randomizer.Fixes(game, 7, true, (int)num_SSonicRings.Value, lockon, rev);

                // SSonic Rings Fixed
                Randomizer.Fixes(game, 8, chk_SSonicRingFix.Checked, 0, lockon, rev);

                // Infinite Lifes
                Randomizer.Fixes(game, 9, chk_lifes.Checked, 0, lockon, rev);
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
            try
            {
                int[] romID = Randomizer.GameTest();
                cb_game.SelectedIndex = romID[0];
                cb_revision.SelectedIndex = romID[1];
                cb_lockon.Checked = romID[2]==1;


            }
            catch (Exception)
            {

                Functions.MessageHandler.ErrorMessage(1);
            }
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

        private void btn_compatible_Click(object sender, EventArgs e)
        {
            Functions.MessageHandler.ErrorMessage(5); // Compatibility List

        }

        private void cb_lockon_CheckedChanged(object sender, EventArgs e)
        {
            gameOptions();
        }

        private void cb_revision_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameOptions();
        }
    }
}
