using System;
using System.Runtime.InteropServices;

namespace Zadanie_4
{
    class MySendMessage
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, string lParam);
    }
}
