using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int birthMonth, siblings;
            string favColor;



            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine().ToUpper();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine().ToUpper();
            Console.WriteLine(Greeting(firstName, lastName) + "\n");

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth month as a number, for example February would be '2' or November would be '11'");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Type the first letter of your favorite ROYGBIV color? If you do not know the acronym ROYGBIV type 'HELP'");
            favColor = Console.ReadLine().ToUpper();

            while (favColor == "HELP")
            {
                Console.WriteLine("");
                Console.WriteLine("ROYGBIV or Roy G. Biv is an acronym for the sequence of hues commonly described as making up a rainbow.");
                Console.WriteLine("R = Red"); Console.WriteLine("O = Orange"); Console.WriteLine("Y = Yellow"); Console.WriteLine("G = Green");
                Console.WriteLine("B = Blue"); Console.WriteLine("I = Indigo"); Console.WriteLine("V = Violet \n");

                Console.WriteLine("Type the first letter of your favorite ROYGBIV color?");
                favColor = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());



            Console.WriteLine(Greeting(firstName, lastName) + " will retire in " + Retire(age) + " with "
                + Money(birthMonth) + " in the bank, a vacation home in " + Vacation(siblings) + " and a "
                + Vehicle(favColor) + " \n");

            Judgement();

           //Console.WriteLine(Retire(age));
           // Console.WriteLine(Vacation(siblings));
           // Console.WriteLine(Vehicle(favColor));
           // Console.WriteLine(Money(birthMonth));
           // Judgement();
        }

        static string Greeting(string first, string last)
        {
            return "Greetings, " + first + " " + last + ". I will tell you your fortune!";
        }

        static int Retire(int ageTwo)
        {
            int retire = 0;
            
            if ((ageTwo % 2) > 0)
            {
                retire = 22;
            }
            else
            {
                retire = 15;
            }
            return retire;
        }

        static string Vacation(int numSiblings)
        {
            string location = "";
            switch (numSiblings)
            {
                case 0:
                    return location = "San Diego";
                    //break;
                case 1:
                    return location = "Miami";
                    //break;
                case 2:
                   return location = "Hawaii";
                    //break;
                case 3:
                    return location = "Tahiti";
                    //break;
            }

            if (numSiblings < 0)
            {
                location = "Siberia";
            }
            else if (numSiblings > 3)
            {
                location = "Maui";
            }
            return location;
        }

        static string Vehicle(string color)
        {
            string car = "";
            switch (color)
            {
                case "R":
                    car = "Chevy Tahoe";
                    break;
                case "O":
                    car = "Mercedes Benz S550";
                    break;
                case "Y":
                    car = "BMW M5";
                    break;
                case "G":
                    car = "Dodge Challenger SRT8";
                    break;
                case "B":
                    car = "Toyota Camry";
                    break;
                case "I":
                    car = "Lamborghini";
                    break;
                case "V":
                    car = "Ford Fusion";
                    break;
            }
            return car;
        }

        static double Money(int month)
        {
            double retireMoney;

            if ((month >= 1) && (month <= 4))
            {
                retireMoney = 11460.32;
            }
            else if ((month >= 5) && (month <= 8))
            {
                retireMoney = 2634522.17;
            }
            else if ((month >= 9) && (month <= 12))
            {
                retireMoney = 372498.42;
            }
            else
            {
                retireMoney = 0.00;
            }
            return retireMoney;
        }

        static void Judgement()
        {
            int i;
            Random r = new Random();
            string[] rJudge = new string[3];

            rJudge[0] = "Your Fortune is Amazing";
            rJudge[1] = "Things Look Great";
            rJudge[2] = "You could definately do better";

            i = r.Next(0, 3);

            Console.WriteLine(rJudge[i]);
        }
    }
}
