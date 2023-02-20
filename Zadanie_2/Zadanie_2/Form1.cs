using System;
using System.Windows.Forms;

namespace Zadanie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox_namber.Text == "")
                MyMessageBox.MessageBox(IntPtr.Zero, "Вы не загадали число", "Message", 0);
            int namber = Convert.ToInt32(textBox_namber.Text);
            Random rnd = new Random();
            int value = rnd.Next(100);
            MyMessageBox.MessageBox(IntPtr.Zero, "Я загадал число = " + value, "PC", 0);
            if (value == namber)
                MyMessageBox.MessageBox(IntPtr.Zero, "Ура мы угадали одинаковые числа", "Message", 0);
            else
                MyMessageBox.MessageBox(IntPtr.Zero, "Увы мы загадали разные числа", "Message", 0);
            int namber2 = MyMessageBox.MessageBox(IntPtr.Zero, "Хотите попробовать заново", "Message", 3);
            if (namber2 == 6)
            {
                textBox_namber.Text = "";
            }
            else
                Application.Exit();
        }
    }
}
