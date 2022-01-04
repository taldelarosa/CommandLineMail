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

            // Working on Header drawing starting with Anchoring Left

            //Window.Header.Sections[0].Update("Test Top Left");
                
            Console.ReadKey(false);
        }
    }
}
