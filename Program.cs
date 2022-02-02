using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Menu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static string Name = "امین احمدی";
        public static string Age = "32";
        public static string seed = "";
        public static string tools = "";
        public static string Tracktor = "استفاده نشده است";
        public static string weight = "-";
        public static string Power = "-";
        public static bool UseTracktor = false;

    }
}
