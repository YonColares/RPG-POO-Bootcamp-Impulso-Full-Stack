using System;
using DIO_PROJETO_DOTNET_IMPULSO.crc.Entities;

namespace DIO_PROJETO_DOTNET_IMPULSO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Knight = new Knight("Arus", 23, "Knight");
            Wizard Wizard1 = new Wizard("Jennica", 25, "White Wizard");
            Wizard Wizard2 = new Wizard("Crowley", 33, "Black Wizard");
            Ninja Ninja = new Ninja("Lee", 15, "Ninja");

            Console.WriteLine(Knight.Attack());
            Console.WriteLine(Wizard1.Attack());
            Console.WriteLine(Wizard2);
            Console.WriteLine(Ninja.Attack(7));
        }
    }
}