using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pterodactyl.Managers
{
    public class ThemeManager
    {
        private const string FolderPath = "themes";
        public static int background_r;
        public static int background_g;
        public static int background_b;
        public static int text_r;
        public static int text_g;
        public static int text_b;
        public static int navbar_r;
        public static int navbar_g;
        public static int navbar_b;
        public static int btn_fillcolor_r;
        public static int btn_fillcolor_g;
        public static int btn_fillcolor_b;
        public static int btn_pressedcolor_r;
        public static int btn_pressedcolor_g;
        public static int btn_pressedcolor_b;
        public static int btn_bordercolor_r;
        public static int btn_bordercolor_g;
        public static int btn_bordercolor_b;
        public static int btn_forecolor_r;
        public static int btn_forecolor_g;
        public static int btn_forecolor_b;
        public static int backpanel_color_r;
        public static int backpanel_color_g;
        public static int backpanel_color_b;
        public static int cb_unchcked_bordercolor_r;
        public static int cb_unchcked_bordercolor_g;
        public static int cb_unchcked_bordercolor_b;
        public static int cb_unchcked_fillcolor_r;
        public static int cb_unchcked_fillcolor_g;
        public static int cb_unchcked_fillcolor_b;
        public static int cb_checkmarkcolor_r;
        public static int cb_checkmarkcolor_g;
        public static int cb_checkmarkcolor_b;
        public static int cb_checked_bordercolor_r;
        public static int cb_checked_bordercolor_g;
        public static int cb_checked_bordercolor_b;
        public static int cb_checked_fillcolor_r;
        public static int cb_checked_fillcolor_g;
        public static int cb_checked_fillcolor_b;
        public static int cb_forecolor_r;
        public static int cb_forecolor_g;
        public static int cb_forecolor_b;
        private static void CheckAndCreateThemeFolder()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Console.WriteLine("[{0:HH:mm:ss}] (Themes) Themes folder created successfully.", DateTime.Now);
            }
        }
        public static void initThemes()
        {
            CheckAndCreateThemeFolder();
            CheckTheme();
            loadTheme();
        }
        private static void loadTheme()
        {
            var cfg = new ConfigParser(Program.themes);
            string themename = cfg.GetValue("theme", "name");
            string themeversion = cfg.GetValue("theme", "version");
            string themenativeversion = cfg.GetValue("theme", "nativeversion");
            string themeauthor = cfg.GetValue("theme", "author");
            if (themenativeversion == Program.AppVersion)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (Themes) Loaded theme: '" + themename + "' version: '" + themeversion + "' by '" + themeauthor + "'.", DateTime.Now);
                background_r = int.Parse(cfg.GetValue("background", "r"));
                background_g = int.Parse(cfg.GetValue("background", "g"));
                background_b = int.Parse(cfg.GetValue("background", "b"));
                text_r = int.Parse(cfg.GetValue("text", "r"));
                text_g = int.Parse(cfg.GetValue("text", "g"));
                text_b = int.Parse(cfg.GetValue("text", "b"));
                navbar_r = int.Parse(cfg.GetValue("navbar", "r"));
                navbar_g = int.Parse(cfg.GetValue("navbar", "g"));
                navbar_b = int.Parse(cfg.GetValue("navbar", "b"));
                btn_fillcolor_r = int.Parse(cfg.GetValue("btn_fillcolor", "r"));
                btn_fillcolor_g = int.Parse(cfg.GetValue("btn_fillcolor", "g"));
                btn_fillcolor_b = int.Parse(cfg.GetValue("btn_fillcolor", "b"));
                btn_pressedcolor_r = int.Parse(cfg.GetValue("btn_pressedcolor", "r"));
                btn_pressedcolor_g = int.Parse(cfg.GetValue("btn_pressedcolor", "g"));
                btn_pressedcolor_b = int.Parse(cfg.GetValue("btn_pressedcolor", "b"));
                btn_bordercolor_r = int.Parse(cfg.GetValue("btn_bordercolor", "r"));
                btn_bordercolor_g = int.Parse(cfg.GetValue("btn_bordercolor", "g"));
                btn_bordercolor_b = int.Parse(cfg.GetValue("btn_bordercolor", "b"));
                btn_forecolor_r = int.Parse(cfg.GetValue("btn_forecolor", "r"));
                btn_forecolor_g = int.Parse(cfg.GetValue("btn_forecolor", "g"));
                btn_forecolor_b = int.Parse(cfg.GetValue("btn_forecolor", "b"));
                backpanel_color_r = int.Parse(cfg.GetValue("backpanel_color", "r"));
                backpanel_color_g = int.Parse(cfg.GetValue("backpanel_color", "g"));
                backpanel_color_b = int.Parse(cfg.GetValue("backpanel_color", "b"));
                cb_unchcked_bordercolor_r = int.Parse(cfg.GetValue("cb_unchcked_bordercolor", "r"));
                cb_unchcked_bordercolor_g = int.Parse(cfg.GetValue("cb_unchcked_bordercolor", "g"));
                cb_unchcked_bordercolor_b = int.Parse(cfg.GetValue("cb_unchcked_bordercolor", "b"));
                cb_unchcked_fillcolor_r = int.Parse(cfg.GetValue("cb_unchcked_fillcolor", "r"));
                cb_unchcked_fillcolor_g = int.Parse(cfg.GetValue("cb_unchcked_fillcolor", "g"));
                cb_unchcked_fillcolor_b = int.Parse(cfg.GetValue("cb_unchcked_fillcolor", "b"));
                cb_checkmarkcolor_r = int.Parse(cfg.GetValue("cb_checkmarkcolor", "r"));
                cb_checkmarkcolor_g = int.Parse(cfg.GetValue("cb_checkmarkcolor", "g"));
                cb_checkmarkcolor_b = int.Parse(cfg.GetValue("cb_checkmarkcolor", "b"));
                cb_checked_bordercolor_r = int.Parse(cfg.GetValue("cb_checked_bordercolor", "r"));
                cb_checked_bordercolor_g = int.Parse(cfg.GetValue("cb_checked_bordercolor", "g"));
                cb_checked_bordercolor_b = int.Parse(cfg.GetValue("cb_checked_bordercolor", "b"));
                cb_checked_fillcolor_r = int.Parse(cfg.GetValue("cb_checked_fillcolor", "r"));
                cb_checked_fillcolor_g = int.Parse(cfg.GetValue("cb_checked_fillcolor", "g"));
                cb_checked_fillcolor_b = int.Parse(cfg.GetValue("cb_checked_fillcolor", "b"));
                cb_forecolor_r = int.Parse(cfg.GetValue("cb_forecolor", "r"));
                cb_forecolor_g = int.Parse(cfg.GetValue("cb_forecolor", "g"));
                cb_forecolor_b = int.Parse(cfg.GetValue("cb_forecolor", "b"));
            }
            else
            {
                if (File.Exists(Program.themes))
                {

                }
                else
                {
                    File.Delete(Program.themes);
                    Application.Restart();
                }
            }
        }
        private static void CheckTheme()
        {
            if (File.Exists(Program.themes))
            {
            }
            else
            {
                var cfg = new ConfigParser(Program.themes);
                Console.WriteLine("[{0:HH:mm:ss}] (Themes) Default theme file created successfully.", DateTime.Now);
                cfg.SetValue("theme", "name", "StellarXDark");
                cfg.SetValue("theme", "version", "1.0.0.0");
                cfg.SetValue("theme", "nativeversion", Program.AppVersion);
                cfg.SetValue("theme", "author", "NaysKutzu");
                cfg.SetValue("background", "r", int.Parse("27"));
                cfg.SetValue("background", "g", int.Parse("28"));
                cfg.SetValue("background", "b", int.Parse("46"));
                cfg.SetValue("text", "r", int.Parse("236"));
                cfg.SetValue("text", "g", int.Parse("240"));
                cfg.SetValue("text", "b", int.Parse("243"));
                cfg.SetValue("navbar", "r", int.Parse("26"));
                cfg.SetValue("navbar", "g", int.Parse("21"));
                cfg.SetValue("navbar", "b", int.Parse("44"));
                cfg.SetValue("textbox_bordercolor", "r", int.Parse("42"));
                cfg.SetValue("textbox_bordercolor", "g", int.Parse("47"));
                cfg.SetValue("textbox_bordercolor", "b", int.Parse("65"));
                cfg.SetValue("textbox_fillcolor", "r", int.Parse("42"));
                cfg.SetValue("textbox_fillcolor", "g", int.Parse("47"));
                cfg.SetValue("textbox_fillcolor", "b", int.Parse("65"));
                cfg.SetValue("textbox_forecolor", "r", int.Parse("236"));
                cfg.SetValue("textbox_forecolor", "g", int.Parse("240"));
                cfg.SetValue("textbox_forecolor", "b", int.Parse("243"));
                cfg.SetValue("btn_fillcolor", "r", int.Parse("0"));
                cfg.SetValue("btn_fillcolor", "g", int.Parse("110"));
                cfg.SetValue("btn_fillcolor", "b", int.Parse("179"));
                cfg.SetValue("btn_pressedcolor", "r", int.Parse("0"));
                cfg.SetValue("btn_pressedcolor", "g", int.Parse("212"));
                cfg.SetValue("btn_pressedcolor", "b", int.Parse("240"));
                cfg.SetValue("btn_bordercolor", "r", int.Parse("34"));
                cfg.SetValue("btn_bordercolor", "g", int.Parse("39"));
                cfg.SetValue("btn_bordercolor", "b", int.Parse("57"));
                cfg.SetValue("btn_forecolor", "r", int.Parse("236"));
                cfg.SetValue("btn_forecolor", "g", int.Parse("240"));
                cfg.SetValue("btn_forecolor", "b", int.Parse("243"));
                cfg.SetValue("backpanel_color", "r", int.Parse("34"));
                cfg.SetValue("backpanel_color", "g", int.Parse("39"));
                cfg.SetValue("backpanel_color", "b", int.Parse("57"));
                cfg.SetValue("cb_unchcked_bordercolor", "r", int.Parse("125"));
                cfg.SetValue("cb_unchcked_bordercolor", "g", int.Parse("137"));
                cfg.SetValue("cb_unchcked_bordercolor", "b", int.Parse("149"));
                cfg.SetValue("cb_unchcked_fillcolor", "r", int.Parse("125"));
                cfg.SetValue("cb_unchcked_fillcolor", "g", int.Parse("137"));
                cfg.SetValue("cb_unchcked_fillcolor", "b", int.Parse("149"));
                cfg.SetValue("cb_checkmarkcolor", "r", int.Parse("42"));
                cfg.SetValue("cb_checkmarkcolor", "g", int.Parse("47"));
                cfg.SetValue("cb_checkmarkcolor", "b", int.Parse("65"));
                cfg.SetValue("cb_checked_bordercolor", "r", int.Parse("94"));
                cfg.SetValue("cb_checked_bordercolor", "g", int.Parse("148"));
                cfg.SetValue("cb_checked_bordercolor", "b", int.Parse("255"));
                cfg.SetValue("cb_checked_fillcolor", "r", int.Parse("94"));
                cfg.SetValue("cb_checked_fillcolor", "g", int.Parse("148"));
                cfg.SetValue("cb_checked_fillcolor", "b", int.Parse("255"));
                cfg.SetValue("cb_forecolor", "r", int.Parse("236"));
                cfg.SetValue("cb_forecolor", "g", int.Parse("240"));
                cfg.SetValue("cb_forecolor", "b", int.Parse("243"));
                cfg.Save();
            }
        }
    }
}
