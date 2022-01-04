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
            int writeLength = (this.Bounds.Item3 - this.Bounds.Item1);

            Console.SetCursorPosition(this.Bounds.Item1,this.Bounds.Item2);

            if(this.Text.Length > writeLength )
            {
                string shortendText = this.Text.Substring(0,writeLength-1);
                Console.Write(shortendText+ "~");
            }
            else
            {
                Console.Write(this.Text);
            }
        }

    }
}