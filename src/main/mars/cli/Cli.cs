using System;

namespace Mars
{
    public class Cli
    {
        public Cli()
        {

        }

        public void Execute(String input)
        {
            Plateau plateau = null;
            String[] messages = input.Split(Environment.NewLine);

            for (int i = 0; i < messages.Length; i++)
            {
                var message = messages[i];

                if (i == 0)
                {
                    // Plateau message detected.
                    plateau = GetPlateau(message);
                }
                else if (i % 2 == 0)
                {
                    // A Rover message detected.
                    Rover rover = GetRover(plateau, messages[i - 1]);
                    rover.Move(message);

                    Console.WriteLine(rover);
                }
            }
        }

        private Plateau GetPlateau(String border)
        {
            String[] plateauUpperRight = border.Split(' ');

            return new Plateau(new Point(Int32.Parse(plateauUpperRight[0]), Int32.Parse(plateauUpperRight[1])));
        }

        private Rover GetRover(Plateau plateau, String positionMessage)
        {
            String[] roverPosition = positionMessage.Split(' ');

            Point coordinates = new Point(Int32.Parse(roverPosition[0]), Int32.Parse(roverPosition[1]));
            Direction direction = Enum.Parse<Direction>(roverPosition[2]);
            Position position = new Position(coordinates, direction);
            Rover rover = new Rover(position, plateau);

            return rover;
        }
    }
}