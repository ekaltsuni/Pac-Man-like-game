using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace PACMAN_2218
{

    internal static class Program
    {
         /* getters/setters for username and highscore data to be able to
          * set and retrieve values between different forms (form1, form2, form3) */
        public static class Global
        {
            private static string _username;
            public static string username
            {
                get { return _username; }
                set { _username = value; }
            }
            private static string _high_score;
            public static string high_score
            {
                get { return _high_score; }
                set { _high_score = value; }
            }
        }  
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
