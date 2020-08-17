using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonic_Randomizer.Functions
{
    public static class MessageHandler
    {
        static string text;
        static string title;
        static MessageBoxButtons buttons;
        static MessageBoxIcon icon;

        public static void Message(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, buttons, icon);
        }

        public static void ErrorMessage(int error)
        {

            switch (error)
            {
                case 1:
                    text = "The application failed to load the ROM of the game.\n" +
                        "Please check that your ROM is in the correct path.";
                    title = "Error";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                    break;
                case 2:
                    text = "The application failed to patch the ROM.\n" +
                        "Please check that your ROM is a Sonic's game Bin/MD file\n" +
                        "and that you selected the correct game.";
                    title = "Error";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                    break;
                case 3:
                    text = "This game can't be patched in this version.\n" +
                        "Please check for updates if available";
                    title = "Error";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                    break;
                default:
                    text = "Unknown Error.\n" +
                        "Please report the error to the author.";
                    title = "Error";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                    break;
            }
            Message(text, title, buttons, icon);
        }

    }
}
