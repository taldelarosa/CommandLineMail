using System;
using DrawingHelper;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();
            // Console.WriteLine("Hello World!");
            // Console.ReadKey(false);
            // Console.SetCursorPosition(0,0);

            Canvas window = new Canvas(Console.WindowWidth,Console.WindowHeight);

            window.header.sections[0].Update("Hello World!");
            Console.ReadKey();
        }
    }
}
