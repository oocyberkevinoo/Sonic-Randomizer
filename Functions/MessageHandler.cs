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
                case 4:
                    text = "This is not a Sonic compatible Rom file.\n" +
                        "Please try with another Rom of Sonic 1, 2, 3, &Knuckles, or LockOn version.";
                    title = "ERROR: ROM not recognized";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                    break;
                case 5:
                    text = "Fully compatible:\n" +
                "- Sonic 2 [Rev 00,01] \n(Rev 00 note: Stage Select glitch whith Super Sonic fix)\n" +
                "\nFixes only:\n" +
                "- Sonic 1 [Rev 00] (Stage Select not available)\n" +
                "\nNot Compatible yet:\n" +
                "- Sonic 1 [Rev 01]\n"+
                "- Sonic 3\n" +
                "- Sonic & Knuckles";
                    title = "Compatibility";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Information;
                    break;
                case 6:
                    text = "This ROM's Revision is not fully compatible.\n" +
                        "Please check the compatibility list for more details.";
                    title = "Revision not compatible.";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Warning;
                    break;
                case 7:
                    text = "Lock On technology is partially supported only.\n";
                    title = "Lock On detected";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Warning;
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
