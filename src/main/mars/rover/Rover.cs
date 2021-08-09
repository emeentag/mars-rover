using System;

namespace Mars
{
    public class Rover
    {
        public Position Position { get; set; } = null;

        private Plateau Plateau;
        public Rover(Position position, Plateau plateau)
        {
            this.Position = position;
            this.Plateau = plateau;
        }

        public override string ToString()
        {
            return this.Position.ToString();
        }

        public void Move(string message)
        {
            foreach (char m in message)
            {
                Movement move = Enum.Parse<Movement>(m.ToString());

                switch (move)
                {
                    case Movement.M:
                        // Make move
                        this.MoveForward();
                        break;

                    case Movement.L:
                    case Movement.R:
                        // Make rotate
                        this.Rotate(move);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Rotate(Movement rotation)
        {
            Direction direction = this.Position.Direction;

            if (rotation == Movement.L)
            {
                switch (direction)
                {
                    case Direction.N:
                        // Rotate to west;
                        this.Position.Direction = Direction.W;
                        break;

                    case Direction.S:
                        // Rotate to east;
                        this.Position.Direction = Direction.E;
                        break;

                    case Direction.E:
                        // Rotate to north;
                        this.Position.Direction = Direction.N;
                        break;

                    case Direction.W:
                        // Rotate to south;
                        this.Position.Direction = Direction.S;
                        break;

                    default:
                        throw new NotImplementedException();
                }

            }
            else if (rotation == Movement.R)
            {
                switch (direction)
                {
                    case Direction.N:
                        // Rotate to east;
                        this.Position.Direction = Direction.E;
                        break;

                    case Direction.S:
                        // Rotate to west;
                        this.Position.Direction = Direction.W;
                        break;

                    case Direction.E:
                        // Rotate to south;
                        this.Position.Direction = Direction.S;
                        break;

                    case Direction.W:
                        // Rotate to north;
                        this.Position.Direction = Direction.N;
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void MoveForward()
        {
            Direction direction = this.Position.Direction;

            switch (direction)
            {
                case Direction.N:
                    // Increase Y axis with one grid;
                    this.Position.Coordinates.Y++;
                    break;

                case Direction.S:
                    // Decrease Y axis with one grid;
                    this.Position.Coordinates.Y--;
                    break;

                case Direction.E:
                    // Increase X axis with one grid;
                    this.Position.Coordinates.X++;
                    break;

                case Direction.W:
                    // Decrease X axis with one grid;
                    this.Position.Coordinates.X--;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
