using System;

namespace Persona
{
    class Persona
    {
       string nombre; //atributo
       static public string colorSangre="Roja"; //static le pertenece a la clase, no static le pertenece al objeto


    public Persona(string nombre){ //metodo constructor 
                                    //metodo mayuscula variable minuscula

         this.nombre = nombre;

       }
    public void Sayhello (){ //metodo

       Console.WriteLine("Hola, mi nombre es "+this.nombre);

    }

    static public void PrintRace(){

        Console.WriteLine("Humana");

        
    }
 

    }
}