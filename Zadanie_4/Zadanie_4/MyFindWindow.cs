using System;
using System.Runtime.InteropServices;

namespace Zadanie_4
{
    class MyFindWindow
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    }
}
