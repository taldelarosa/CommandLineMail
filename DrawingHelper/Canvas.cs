using System;
using System.Drawing;

namespace DrawingHelper
{
    public class Canvas
    {

        public Size CanvasSize;
        public Header Header;
        public Body body;
        public Footer footer;

        public Canvas(int Width,int Height)
        {
            this.CanvasSize = new Size(Width,Height);

            //Set default header size to just 1 if not specified
            this.Header = new Header(1);

        }
    }

}
