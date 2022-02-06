using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Form_Main Form;
        [STAThread]
        static void Main()
        {
            Form = new Form_Main();

            Application.EnableVisualStyles();
            Application.Run(Form);
        }
    }
}
