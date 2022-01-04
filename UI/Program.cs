using System;
using DrawingHelper;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Canvas Window = new Canvas(Console.WindowWidth,Console.WindowHeight);

            Window.Header.Sections[0].Update("Header InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader InfoHeader Info");
            Console.ReadKey(false);
        }
    }
}
