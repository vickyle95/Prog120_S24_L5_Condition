using System.Collections.Concurrent;

namespace Prog120_S24_L5_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vicky Le
            // Programming 120
            // 4/16/24

            // Conditions
            // Keywords: if, else if, else
            // Concepts: Comparison Operators
            // ==, !=, >, <, >=, <=, !
            // Logical Operators
            // &&, || , ! 
            // Decision Trees
            // Nested Loops
            // Menu
            // Type: boolean - bool
            // This is always true or false
            // What is a Markup language? - HTML
            // Menu();

            switch("word")
            {
                case "word":
                    Console.WriteLine("This ");
                    break;
            }
                
            Console.WriteLine("What example do you want to run?");
            Console.WriteLine("1 - Age Example");
            Console.WriteLine("2 - Date Time 1");
            Console.WriteLine("3 - Date Time 2");
            Console.WriteLine("4 - Weather");
            Console.WriteLine("5 - Operators");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("Enter your choice: ");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                AgeExample();
            }
            else if (userInput == "2") 
            {
                DateExample1();
            }
            else if (userInput == "3") 
            {
                DateTime2();
            }
            else if (userInput == "4") 
            {
                WeatherExample();
            }
            else if (userInput == "5")
            {
                AltitudeExample();
            }
            else
            {
                Console.WriteLine("Thank you and have a great day!");
                Console.ReadKey();
            }


        } // Main

        public static void AltitudeExample()
        {
            int currentAltitude = 350;
            int minAltitude = 400;

            // If the current altitude is no tbelow min Altitude

            if (!(currentAltitude < minAltitude))
            {
                Console.WriteLine("Warning");
            }
        }
        public static void WeatherExample()
        {
            Console.WriteLine("What is the weather?");
            Console.WriteLine("1 - Is Sunny");
            Console.WriteLine("2 - Is Rainy");
            Console.WriteLine("3 - Is Windy");
            Console.WriteLine("4 - Is Exploded");
            Console.Write("What is the weather?");
            Console.WriteLine("Is it sunny?");

            string userResponse = Console.ReadLine();
            // const ( variable modifier )
            const string ifSunny = "is Sunny";

            // Comparison operators with strings are case sensitive, BY DEFAULT
            userResponse = userResponse.ToLower();

            bool isSunny = userResponse == "1";

            Console.WriteLine($"Is it sunny? {isSunny}");


            bool bringUmbrella = false;

            // -----
            // Keyword if
            //if (condition) { code block }

            // Condition always has to resolve to true or false
            Console.WriteLine("Before Our If Statement");
            if (isSunny)
            {
                Console.WriteLine("It is sunny");
            }
            // else
            else
            {
                Console.WriteLine("It's Gonna Rain!");
                bringUmbrella = true;
            }
            //Console.WriteLine("After If Our Statement");

            // ------
            // First Comparison Operator
            // Review ( Operators )
            // Assignment Operators =
            // Math Operators ( + - * / % )
            // Compound Operators ( +=, -=, *=, /=, %/ )
            // Comparison Operators
            // ALWAYS ALWAYS return true or false
            // >=, <=, >, <, == ( Are the same ), != ( Not Equal )
            // ( )
            // Logical Ones
            // - And &&
            // - Or || 
            // - Not !

            if (bringUmbrella == true)
            {
                Console.WriteLine("Getting an umbrella");
            }

            // if
            // else

            // if
            // if
            // if

        }
        public static void DateExample1()
        {
            string test = "ToLowerCase".ToLower();

            // mm/dd/year

            Console.WriteLine("What month?");
            Console.WriteLine("Enter a number between 1 and 12");

            Console.Write("Please enter in the month: ");
            int userMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What Day? ");
            Console.WriteLine("Enter a number between 1 and 31");
            int userDay = int.Parse(Console.ReadLine());

            Console.WriteLine("What Year? ");

            // > <, NON INCLUSIVE (Does not include the number we are comparing to)
            // <=, >=, Inclusive (This means includes th enumber we are comparing to)


            // | 2 ------------------- 11 |
            // && <------ AND

            // | 1 ---------------------------
            bool isGreaterOrEqualTo1 = userMonth >= 1;
            // | ----------------------------- 12
            bool isLessThanOrEqualTo12 = userMonth <= 12;

            // IF GREAT Than E 1 == True
            // IF LESS Than E 12 == True
            // && is ONLY TRUE if both the first condition and last condition are true
            // | 1 ------------------ 12 
            bool between1And12 = isGreaterOrEqualTo1 && isLessThanOrEqualTo12;

            // ------------ | 1 False 12 | --------------
            bool isNOTBetween1And12 = !between1And12;

            if (!between1And12)
            {
                Console.WriteLine("Please Enter a Valid Month");
                userMonth = 1;
            }

            Console.WriteLine(userMonth > 1 && userMonth < 12);
            // >=, <=, >, <



            // 01/01/2024
            // 01.01.20244
            // 1.1.24
            // 01.1.2024
        }

        public static void DateTime2()
        {
            string test = "ToLowerCase".ToLower();

            // mm/dd/year

            Console.WriteLine("What month?");
            Console.WriteLine("Enter a number between 1 and 12");

            Console.Write("Please enter in the month: ");
            int userMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What Day? ");
            Console.WriteLine("Enter a number between 1 and 31");
            int userDay = int.Parse(Console.ReadLine());

            Console.WriteLine("What Year? ");
            int userYear = int.Parse(Console.ReadLine());

            // Check for month
            bool isGreaterOrEqualTo1 = userMonth >= 1;
            bool isLessThanOrEqualTo12 = userMonth <= 12;
            bool between1And12 = isGreaterOrEqualTo1 && isLessThanOrEqualTo12;
            bool isNOTBetween1And12 = !between1And12;

            string userDate = $"{userMonth}/{userDay}/{userYear}";

            if (!between1And12)
            {
                Console.WriteLine("Please Enter a Valid Month");
                userMonth = 1;
            }

            // Validating users number is between 1 and 31 days
            if (!(userDay >= 1 && userDay <= 31))
            {
                Console.WriteLine("Enter a valid");
                userDay = 1;
            }

            if (!(userYear >= 1900 && userYear <= 2024))
            {
                Console.WriteLine("Enter a valid year");
                userDay = 1900;
            }

            DateTime newDatetime = new DateTime(userYear, userMonth, userDay);
            Console.WriteLine(newDatetime.ToShortDateString());

        }
        public static void AgeExample()
        {
            int age = 20;
            // | 22 ------------------------------
            if (age >= 21)
            {
                Console.WriteLine("Congratulations - You are old enough to drink and vote");
            }
            // else if(condition)
            // | 18 -- 21
            else if (age >= 18)
            {
                Console.WriteLine("Congratulation - You can vote. PLEASE DO");
            }
            else
            {
                Console.WriteLine("Sorry you are not old enough to vote or drink :(");
            }
        }
    } // class

} // namespace
