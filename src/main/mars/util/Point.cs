using System;

namespace Mars
{
    public class Point
    {

        public Int32 X {get; set;} = 0;
        public Int32 Y {get; set;} = 0;

        public Point(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }
    }
}
