using System;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Closing the notebook");
            int windows = MyFindWindow.FindWindow("notepad", null).ToInt32();
            MySendMessage.SendMessage(windows, 0x0010, 0, 0);
            Console.WriteLine("notepad is closed");
            Console.Read();
        }
    }
}
