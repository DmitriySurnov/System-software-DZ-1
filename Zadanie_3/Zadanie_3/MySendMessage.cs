using System;
using System.Runtime.InteropServices;

namespace Zadanie_3
{
    class MySendMessage
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);
    }
}
