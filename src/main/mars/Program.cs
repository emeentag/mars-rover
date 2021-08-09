using System;

namespace Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            Cli cli = new Cli();
            cli.Execute("5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM");
        }
    }
}
