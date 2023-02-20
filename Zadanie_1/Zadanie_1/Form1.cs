using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            MyMessageBox.MessageBox(IntPtr.Zero, "Hello, World!", "Hello", 0);
        }
    }
}
