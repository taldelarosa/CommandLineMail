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

            Console.Clear();

            Canvas Window = new Canvas(Console.WindowWidth,Console.WindowHeight);

            Window.Header.Sections[0].Update("Header Info");
            Console.ReadKey();
        }
    }
}
