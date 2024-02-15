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
        public static void Ejercicio18(string[] args)
        {
            Ejercicio1();
            int ages = Ejercicio2();
            int jupiterAge = (int)Ejercicio3(ages);
            Ejercicio4(jupiterAge);
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
            Ejercicio11();
            Ejercicio12();
            Ejercicio13();
            Ejercicio14();
            Ejercicio15();
            Ejercicio16();
            Ejercicio17();
            Ejercicio18();
            Ejercicio19();
            Ejercicio20();
            Ejercicio21();
            Ejercicio22();
            Ejercicio23();
            Ejercicio24();
            Ejercicio25();
            Ejercicio26();
        }

        private static void Ejercicio26()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio25()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio24()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio23()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio22()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio21()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio20()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio19()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio18()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio17()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio16()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio15()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio14()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio13()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio12()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio11()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio10()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio9()
        {
            throw new NotImplementedException();
        }

        private static void Ejercicio8()
        {
            throw new NotImplementedException();
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

        /// <summary>
        /// Ejercicio 8 del curso con valor Void
        /// </summary>
        private static void Ejercicio8(string[] args)
        {
            double numberOne = 6.5;
            double numberTwo = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));
        }

        /// <summary>
        /// Ejercicio 9 del curso con valor Void
        /// </summary>
        private static void Ejercicio9(string[] args)
        {
            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";

            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);

            // Print variable and newline
        }

        /// <summary>
        /// Ejercicio 10 del curso con valor Void
        /// </summary>
        private static void Ejercicio10(string[] args)
        {
            // Declare the variables
            string beginning = " Be aware the people from Mars are on their way to earth";
            string middle = "Came without any previous messeage, all of the sudden they were on your lands ";
            string end = " As how they came, that's how they went, and left the planet taking inside of their ships hostages ";

            // Concatenate the string and the variables
            string story = beginning + middle + " and hidding in the woods." + end + ".";

            // Print the story to the console
            Console.WriteLine(story);
        }

        /// <summary>
        /// Ejercicio 11 del curso con valor Void
        /// </summary>
        private static void Ejercicio11(string[] args)
        {
            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";

            // Print the story to the console
            Console.WriteLine(story);
        }

        /// <summary>
        /// Ejercicio 12 del curso con valor Void
        /// </summary>
        private static void Ejercicio12(string[] args)
        {
            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;

            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
        }

        /// <summary>
        /// Ejercicio 13 del curso con valor Void
        /// </summary>
        private static void Ejercicio13(string[] args)
        {
            // dna strand
            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);

            // DNA mutation search
            Console.WriteLine(dna[3]);
        }

        /// <summary>
        /// Ejercicio 14 del curso con valor Void
        /// </summary>
        private static void Ejercicio14(string[] args)
        {
            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE --" +
            " as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            Console.WriteLine(cameraDirections);

            // Print results
        }

        /// <summary>
        /// Ejercicio 15 del curso con valor Void
        /// </summary>
        private static void Ejercicio15(string[] args)
        {
            bool answerOne = 500 < 20;

            bool respuestaTwo = 40 > 5;

            Console.WriteLine(answerOne && respuestaTwo);
        }

        /// <summary>
        /// Ejercicio 16 del curso con valor Void
        /// </summary>
        private static void Ejercicio16(string[] args)
        {
            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;
            double tripDuration = distance / rate;
            bool answer = tripDuration <= timeToDinner;
            Console.WriteLine(answer);
        }

        /// <summary>
        /// Ejercicio 17 del curso con valor Void
        /// </summary>
        private static void Ejercicio17(string[] args)
        {
            bool beach = true;
            bool hiking = false;
            bool city = true;
            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;
            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine(tripDecision);
        }

        /// <summary>
        /// Ejercicio 18 del curso con valor Void
        /// </summary>
        private static void Ejercicio18(string[] args)
        {
            int socks = 6;
            if (socks <= 3)
            {
                Console.WriteLine("Time to do laundry!");
            }
        }

        /// <summary>
        /// Ejercicio 19 del curso con valor Void
        /// </summary>
        private static void Ejercicio19(string[] args)
        {
            int people = 12;
            string weather = "nice";
            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
            }
        }

        /// <summary>
        /// Ejercicio 20 del curso con valor Void
        /// </summary>
        private static void Ejercicio20(string[] args)
        {
            int guests = 0;
            if (guests >= 4)
            {
                Console.WriteLine("Catan");
            }
            else if (guests >= 1)
            {
                Console.WriteLine("Innovation");
            }
            else
            {
                Console.WriteLine("Solitaire");
            }
        }

        /// <summary>
        /// Ejercicio 21 del curso con valor Void
        /// </summary>
        private static void Ejercicio21(string[] args)
        {
            // Code from Checkpoint 1
            // string genre = "Horror";

            // Code from Checkpoint 5
            Console.WriteLine("Choose a movie genre: ");
            string genre = Console.ReadLine();

            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;

                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;

                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;

                case "Horror":
                    Console.WriteLine("Psycho");
                    break;

                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;

                default:
                    Console.WriteLine("No movie found");
                    break;
            }
        }

        /// <summary>
        /// Ejercicio 22 del curso con valor Void
        /// </summary>
        private static void Ejercicio22(string[] args)
        {
            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? " ready!" : "wait a little longer";
            Console.WriteLine(message);
        }

        /// <summary>
        /// Ejercicio 23 del curso con valor Void
        /// </summary>
        private static void Ejercicio23(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Jupiter"));
        }

        private static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }

        /// <summary>
        /// Ejercicio 24 del curso con valor Void
        /// </summary>
        private static void Ejercicio24(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Mars"));
            Console.WriteLine("Is Pluto really a dwarf...?");
            Console.WriteLine(IsPlutoADwarf());
            Console.WriteLine("Then how many planets are there in the galaxy...?");
            Console.WriteLine(CountThePlanets());
        }

        private static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }

        private static bool IsPlutoADwarf()
        {
            bool answer = true;
            return answer;
        }

        private static string CountThePlanets()
        {
            return "8 planets, usually";
        }

        /// <summary>
        /// Ejercicio 25 del curso con valor Void
        /// </summary>
        private static void Ejercicio25(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;

            outcome = int.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);

            int nameAsInt;
            bool outcome2;
            /// Return value outcome2///
            outcome2 = int.TryParse(nameAsString, out nameAsInt);
            /// Out variable is nameAsInt///
            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);
        }

        private static void Ejercicio26(string[] args)
        {
            string statement = "GARRRR";
            string murmur = Whisper(statement, out bool marker);
            Console.WriteLine(murmur);
        }

        private static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }
    }
}
