using System;
using System.Drawing;

namespace DrawingHelper
{
    public class Canvas
    {

        public Size canvasSize;
        public Header header;
        public Body body;
        public Footer footer;

        public Canvas(int Width,int Height)
        {
            canvasSize = new Size(Width,Height);

            //Set default header size to just 1 if not specified
            header = new Header(1);

        }
    }

}
