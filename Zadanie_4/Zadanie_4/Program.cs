using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notepad Window Name Changes");
            var windows = MyFindWindow.FindWindow("notepad", null);
            MySendMessage.SendMessage(windows, 0x000C, 0, "notebook");
            Console.WriteLine("Name changed");
            Console.Read();
        }
    }
}
