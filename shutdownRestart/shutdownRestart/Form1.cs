﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace shutdownRestart
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern void LockworkStation();

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(GraphicsUnit uflags, uint dwReason);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LockworkStation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }
    }
}
