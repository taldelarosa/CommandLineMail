using System;
using System.Drawing;

namespace DrawingHelper
{
    public class Section
    {
        string Text;
        Bounds Bounds;

        public Section(int startingLocationX, int startingLocationY, int endingLocationX, int endingLocationY)
        {
            this.Bounds = new Bounds(startingLocationX,startingLocationY,endingLocationX,endingLocationY);
        }

        public void Update(string Text)
        {
            this.Text = Text;
            this.Redraw();
        }

        private void Redraw()
        {
            Console.SetCursorPosition(this.Bounds.Item1,this.Bounds.Item2);

            if(this.Text.Length > this.Bounds.Item1)
            {

            }

            //TODO: Dont write out if it would pass the bounds. Or only write out to the bounds
            Console.Write(this.Text);
        }

    }
}