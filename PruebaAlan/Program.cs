using System;

namespace PruebaAlan
{
    /// <summary>
    /// Programa para ejecutar proceso de comisiones.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Funcion de entrada del programa del programa
        /// </summary>
        public static void Main(string[] args)
        {
            Ejercicio1();
            int ages = Ejercicio2();
            int jupiterAge = (int)Ejercicio3(ages);
            Ejercicio4(jupiterAge);
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
        }

        private static void Ejercicio7()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio6()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio5()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio4(int jupiterAge)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ejercicio 1 del curso con valor Void
        /// </summary>
        private static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Hello good afternoon, welcome to PriceTravel");
            Console.WriteLine("¿What's your name?");
            string nombreinput = Console.ReadLine();
            Console.WriteLine($"Hello {nombreinput}, I'm glad to assist you as your personal AI");
            Console.WriteLine("My name is Os");
        }

        /// <summary>
        /// Ejercicio 2 del curso con valor Void
        /// </summary>
        private static int Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();

            // Se eso la conversion de String a Int para la formula matematica
            int userAge = Convert.ToInt32(ageInput);
            Console.WriteLine($"You are {ageInput} years old! Nice!!");

            return userAge;
        }

        /// <summary>
        /// Ejercicio 3 del curso con valor Void
        /// </summary>
        /// <param name="userAge">
        /// Scar la edad del usuario.
        /// </param>
        /// <returns>
        ///  Años en Jupiter <see cref="double"/>.
        /// </returns>
        private static double Ejercicio3(int userAge)
        {
            Console.WriteLine("¿How long have you lived in Mexico?");
            string mexicoInput = Console.ReadLine();
            Console.WriteLine($"{mexicoInput} years!!! That's insane, awesome, you must know a lot from the culture indeed");
            Console.WriteLine("Do you want to know something interesting? (yes/no)");
            string response = Console.ReadLine();

            double jupiterYears = 11.86;
            double jupiterAge = userAge / jupiterYears;

            return jupiterAge;
        }

        /// <summary>
        /// Ejercicio 4 del curso con valor Void
        /// </summary>
        private static void Ejercicio4(string response, double jupiterAge)
        {
            if (response.ToLower() == "yes")
            {
                Console.WriteLine("That's awesome, Do you Know that If you were living in Jupider you will be much more younger than in Earth");
            }
            else
            {
                Console.WriteLine("Maybe next time");
            }

            Console.WriteLine("Do you want to know your age in Jupinears years? (yes/no)");
            string yearsResponse = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.WriteLine(jupiterAge);
            }
            else
            {
                Console.WriteLine("Okay,See you next time");
            }
        }

        /// <summary>
        /// Ejercicio 5 del curso con valor Void
        /// </summary>
        private static void Ejercicio5(string[] args)
        {
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;
            Console.WriteLine(students % groupSize);

            // Does groupSize go evenly into students?
        }

        /// <summary>
        /// Ejercicio 6 del curso con valor Void
        /// </summary>
        private static void Ejercicio6(string[] args)
        {
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;
            Console.WriteLine(students % groupSize);

            // Does groupSize go evenly into students?
        }

        /// <summary>
        /// Ejercicio 7 del curso con valor Void
        /// </summary>
        private static void Ejercicio7(string[] args)
        {
            // Create variables
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));
        }
    }
}
