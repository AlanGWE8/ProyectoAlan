using System;
using System.Runtime.CompilerServices;
using System.Text;

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
            Ejercicio4("response", jupiterAge);
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
            Ejercicio27();
            Ejercicio28();
            Ejercicio29();
            Ejercicio30();
            Ejercicio31();
            Ejercicio32();
            Ejercicio33();
            Ejercicio34();
            Ejercicio35();
            Ejercicio36();
            Ejercicio37();
            Ejercicio38();
            Ejercicio39();
            Ejercicio40();
            Ejercicio41();
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
            Console.WriteLine($"Hello {nombreinput},My name is Os I'm glad to assist you as your personal AI");
        }

        /// <summary>
        /// Ejercicio 2 del curso con valor Void
        /// </summary>
        private static int Ejercicio2()
        {
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
            else if (response.ToLower() == "no")
            {
                Console.WriteLine("Maybe next time");
            }

            Console.WriteLine("Do you want to know your age in Jupinears years? (yes/no)");
            string yearsResponse = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.WriteLine(jupiterAge);
            }
            else if (response.ToLower() == "no")
            {
                Console.WriteLine("Okay,See you next time");
            }
        }

        /// <summary>
        /// Ejercicio 5 del curso con valor Void
        /// </summary>
        private static void Ejercicio5()
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
        private static void Ejercicio6()
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
        private static void Ejercicio7()
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
            Console.ReadLine();
        }

        /// <summary>
        /// Ejercicio 8 del curso con valor Void
        /// </summary>
        private static void Ejercicio8()
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
        private static void Ejercicio9()
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
        private static void Ejercicio10()
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
        private static void Ejercicio11()
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
        private static void Ejercicio12()
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
        private static void Ejercicio13()
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
        private static void Ejercicio14()
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
        private static void Ejercicio15()
        {
            bool answerOne = 500 < 20;

            bool respuestaTwo = 40 > 5;

            Console.WriteLine(answerOne && respuestaTwo);
        }

        /// <summary>
        /// Ejercicio 16 del curso con valor Void
        /// </summary>
        private static void Ejercicio16()
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
        private static void Ejercicio17()
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
        private static void Ejercicio18()
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
        private static void Ejercicio19()
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
        private static void Ejercicio20()
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
        private static void Ejercicio21()
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
        private static void Ejercicio22()
        {
            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? " ready!" : "wait a little longer";
            Console.WriteLine(message);
        }

        /// <summary>
        /// Ejercicio 23 del curso con valor Void
        /// </summary>
        private static void Ejercicio23()
        {
            Console.WriteLine(DecoratePlanet("Jupiter"));

            static string DecoratePlanet(string planet)
            {
                return $"*..*..* Welcome to {planet} *..*..*";
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Ejercicio 24 del curso con valor Void
        /// </summary>
        private static void Ejercicio24()
        {
            Console.WriteLine(DecoratePlanet("Mars"));
            Console.WriteLine("Is Pluto really a dwarf...?");
            Console.WriteLine(IsPlutoADwarf());
            Console.WriteLine("Then how many planets are there in the galaxy...?");
            Console.WriteLine(CountThePlanets());

            static string DecoratePlanet(string planet)
            {
                return $"*..*..* Welcome to {planet} *..*..*";
            }
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
        private static void Ejercicio25()
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

            outcome2 = int.TryParse(nameAsString, out nameAsInt);

            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);
        }

        /// <summary>
        /// Ejercicio 26 del curso con valor Void
        /// </summary>
        private static void Ejercicio26()
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

        /// <summary>
        /// Ejercicio 27 del curso con valor Void
        /// </summary>
        private static void Ejercicio27()
        {
            // Define variables
            string destination = "Neptune";
            string galaxyString = "8";
            int galaxyInt;
            string welcomeMessage;
            bool outcome;

            // Call DecoratePlanet() and TryParse() here
            welcomeMessage = DecoratePlanet(destination);

            outcome = int.TryParse(galaxyString, out galaxyInt);

            // Print results
            Console.WriteLine(welcomeMessage);
            Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");

            // Define a method that returns a string
            static string DecoratePlanet(string planet)
            {
                return $"*..*..* Welcome to {planet} *..*..*";
            }
        }

        /// <summary>
        /// Ejercicio 28 del curso con valor Void
        /// </summary>
        private static void Ejercicio28()
        {
            Welcome("Earth");
            double days = 500;
            double rotations = DaysToRotations(days);
            Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");

            static double DaysToRotations(double days) => days / 365;

            static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
        }

        /// <summary>
        /// Ejercicio 29 del curso con valor Void
        /// </summary>
        private static void Ejercicio29()
        {
            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

            Predicate<string> isLong = null;

            // Remove this line since it doesn't assign the result
            // Array.Find(adjectives, IsLong);
            string firstLongAdjective = Array.Find(adjectives, isLong);

            Console.WriteLine($"The first long word is: {firstLongAdjective}.");
        }

        /// <summary>
        /// Ejercicio 30 del curso con valor Void
        /// </summary>
        private static void Ejercicio30()
        {
            string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
        }

        /// <summary>
        /// Ejercicio 31 del curso con valor Void
        /// </summary>
        private static bool Ejercicio31()
        {
            string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

            bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }

            return makesContact;
        }

        /// <summary>
        /// Ejercicio 32 del curso con valor Void
        /// </summary>
        private static void Ejercicio32()
        {
            int[] nums = { 0, 555, 252, 3, 9, 101 };
            bool hasBigNum = Array.Exists(nums, IsBig);

            bool hasSmallNum = Array.Exists(nums, IsSmall);

            bool hasMediumNum = Array.Exists(nums, (n) => n >= 10 && n <= 100);

            Console.WriteLine($"Any big #s? {hasBigNum}");
            Console.WriteLine($"Any small #s? {hasSmallNum}");
            Console.WriteLine($"Any medium #s? {hasMediumNum}");

            static bool IsBig(int n) => n > 100;

            static bool IsSmall(int n) => n < 10;
        }

        private static void Ejercicio33()
        {
            string[] websites = { "twitter", "facebook", "gmail" };
            foreach (string website in websites)
            {
                Console.WriteLine(website);
            }
        }

        private static void Ejercicio34()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 9)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }

        private static void Ejercicio35()
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num :" + secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 & 10 :");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            }
            while (secretNumber != numberGuessed);
            Console.WriteLine("You guessed it it was {0}" + secretNumber);
        }

        private static void Ejercicio36()
        {
            StringBuilder myStringBuilder = new StringBuilder("Pato: Es una mascota comun");
            _ = myStringBuilder[0];
            Console.WriteLine(myStringBuilder.ToString());
            Console.ReadKey();
        }

        private static double Ejercicio37(double x = 1, double y = 1)
        {
            return x * y;
        }

        private static void Ejercicio38()
        {
            double x = 5;
            double y = 4;
            Console.WriteLine("5 * 4 = {0}" + Ejercicio37(x, y));
        }

        private static void Ejercicio39(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        private static void Ejercicio40()
        {
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num3, num4);
            Ejercicio39(ref num3, ref num4);
        }

        private static void Ejercicio41()
        {
            DateTime today = new DateTime(1998, 01, 18);
            Console.WriteLine("Day of the Week : {0}" + today.DayOfWeek);
            today = today.AddDays(1);
            today = today.AddMonths(3);
            today = today.AddYears(1);
            Console.WriteLine("New Date : {0}" + today);
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
        }
    }
}
