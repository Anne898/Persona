using System;

namespace Persona
{
    class Program
    {
       static void Main(string[] args)
        {

          Persona Anne = new Persona("Anne");
          Anne.Sayhello();

          Persona Diana = new Persona("Diana");
          Diana.Sayhello();

        Console.WriteLine(Persona.colorSangre);
        Persona.PrintRace();
        
        }
    }
}
