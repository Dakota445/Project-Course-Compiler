using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Course_Compiler
{
    internal static class Program
    {
        public static string GlobalConsstring = "Server=localhost; Database=virgil_pcc_database; Uid=root; Pwd=123456;";
        public static string username;
        public static string yearlevel;
        public static string department;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Intro_Form());
        }
    }
}
