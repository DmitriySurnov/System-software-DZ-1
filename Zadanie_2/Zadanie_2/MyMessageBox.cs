using System;
using System.Runtime.InteropServices;

namespace Zadanie_2
{
    class MyMessageBox
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
    }
}
