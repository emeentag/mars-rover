using System;

namespace Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = args[0];

            Cli cli = new Cli();
            cli.Execute(message);
        }
    }
}
