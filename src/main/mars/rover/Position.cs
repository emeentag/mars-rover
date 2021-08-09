using System;

namespace Mars
{
    public class Position
    {

        public Point Coordinates {get; set;} = null;
        public Direction Direction {get; set;} = Direction.E;

        public Position(Point coordinates, Direction direction)
        {
            this.Coordinates = coordinates;
            this.Direction = direction;
        }

        public override string ToString()
        {
            return this.Coordinates.X + " " + this.Coordinates.Y + " " + this.Direction;
        }
    }
}
