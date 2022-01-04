using System;

namespace DrawingHelper
{
    class Bounds : Tuple <int, int, int, int>
    {
        public Bounds (int startingLocationX, int startingLocationY, int endingLocationX, int endingLocationY)
            : base (startingLocationX, startingLocationY, endingLocationX, endingLocationY)
            {
                
            }

    }
}