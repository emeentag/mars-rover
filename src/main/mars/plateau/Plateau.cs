using System;

namespace Mars
{
    public class Plateau
    {

        public Point UpperRight {get; set;} = null;
        public Point LowerLeft {get; set;} = null;

        public Plateau(Point UpperRight)
        {
            this.UpperRight = UpperRight;
            this.LowerLeft = new Point(0, 0);
        }
    }
}
