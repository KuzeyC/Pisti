﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisti
{
    static class Program
    {
        public static Menu menu = new Menu();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(menu);
        }
    }
}
