﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Form1 form;
        [STAThread]
        static void Main()
        {
            form = new Form1();
            Application.EnableVisualStyles();
            Application.Run(form);
        }
    }
}
