using System;
using System.Drawing;

namespace DrawingHelper
{
    public class Section
    {
        string text;
        Bounds bounds;

        public Section(int startingLocationX, int startingLocationY, int endingLocationX, int endingLocationY)
        {
            bounds = new Bounds(startingLocationX,startingLocationY,endingLocationX,endingLocationY);
        }

        public void Update(string Text)
        {
            text = Text;
            this.Redraw();
        }

        private void Redraw()
        {
            Console.SetCursorPosition(bounds.Item1,bounds.Item2);

            //TODO: Dont write out if it would pass the bounds. Or only write out to the bounds
            Console.Write(this.text);
        }

    }
}