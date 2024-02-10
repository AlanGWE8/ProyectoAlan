using System;

namespace PruebaAlan
{
    /// <summary>
    /// Programa para ejecutar proceso de comisiones.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
         

            Console.WriteLine("Hello good afternoon, welcome to PriceTravel");
            Console.WriteLine("¿What's your name?");
            string Nombreinput = Console.ReadLine();
            Console.WriteLine($"Hello {Nombreinput}, I'm glad to assist you as your personal AI");
            Console.WriteLine("My name is Os");

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            ///Se eso la conversion de String a Int para la formula matematica///
            int userAge = Convert.ToInt32(ageInput);
            Console.WriteLine($"You are {ageInput} years old! Nice!!");

            Console.WriteLine("¿How long have you lived in Mexico?");
            string mexicoInput = Console.ReadLine();
            Console.WriteLine($"{mexicoInput} years!!! That's insane, awesome, you must know a lot from the culture indeed");
            Console.WriteLine("Do you want to know something interesting? (yes/no)");
            string Response = Console.ReadLine();

            double jupiterYears = 11.86;
            double jupiterAge = userAge / jupiterYears;

            if (Response.ToLower() == "yes")
                Console.WriteLine("That's awesome, Do you Know that If you were living in Jupider you will be much more younger than in Earth");
                else
                Console.WriteLine("Maybe next time");

            Console.WriteLine("Do you want to know your age in Jupinears years? (yes/no)");
            string YearsResponse = Console.ReadLine();

            if (Response.ToLower() == "yes")
                Console.WriteLine(jupiterAge);
            else
                Console.WriteLine("Okay,See you next time");
            
            /// EJERCICIO 5///
        }

    }
}

