using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part 1

            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine().ToUpper().Trim();
            
            Console.WriteLine("Please enter your age.");
            int userAge = int.Parse(Console.ReadLine());

            string retirementYears;

            if (userAge % 2 == 0)
            {
                retirementYears = "5";
            }

            else
            {
                retirementYears = "27";
            }

            Console.WriteLine("Please enter the month that you were born in numerical form. \n(Example= January would be entered as a '1.')");
            int birthMonth =int.Parse(Console.ReadLine());

            // do I have to use swith case and write in ALL numbers 12?
            // or is there an operational i can use= greater than or less than???

            string retirementMoney;

            if (birthMonth <= 4)
            {
                retirementMoney = "$24,000";
            }

            else if (birthMonth > 4 && birthMonth <= 8)
            {
                retirementMoney = "$36,000";
            }

            else if (birthMonth < 8 && birthMonth > 13)
            {
                retirementMoney = "$60,000";
            }

            else
            {
                retirementMoney = "$0";
            }

            // anything other than an integer 1-12, they have NOTHING in their bank account)

            Console.WriteLine("Please enter the number of siblings you have in numerical form.");
            int numberOfSibs= int.Parse(Console.ReadLine());

            string vacaHome;

            if (numberOfSibs == 1)
            {
                vacaHome = "Italy.";
            }

            else if (numberOfSibs == 2)
            {
                vacaHome = "Paris.";
            }

            else if (numberOfSibs == 3)
            {
                vacaHome = "Barcelona.";
            }

            else
            {
                vacaHome = "Toledo";
            }

            Console.WriteLine("Please enter the name of your favorite color using the colors of the acronym ROYGBIV. \nIf you are you unsure of the colors that comprise the acronym, please type the word 'HELP.'");
            string favColor=(Console.ReadLine().ToUpper());

            if (favColor == "HELP")
            {
                Console.WriteLine("The colors represented in ROYGBIV are as follows: \nR=RED, \nO=ORANGE, \nY=YELLOW, \nG=GREEN, \nB=BLUE, \nI=INDIGO, \nV=VIOLET. \nPlease enter a color listed above.");
                favColor=Console.ReadLine().ToUpper();
            }
             else
            {
                Console.WriteLine();
            }

            string transportMode; 

            switch (favColor)
            {
                case "RED":
                    transportMode =  "MOTORCYCLE";
                    break;

                case "ORANGE":
                    transportMode = "BUS";
                    break;

                case "YELLOW": 
                    transportMode = "FOOT";
                    break;

                case "GREEN":
                    transportMode = "BIKE";
                    break;

                case "BLUE":
                    transportMode = "JETSKI";
                    break;

                case "INDIGO":
                    transportMode = "HORSEBACK";
                    break;

                case "VIOLET":
                    transportMode = "INVISIBLE PLANE";
                    break;

                default:
                    transportMode = "EAGLE.";
                    break;
            }

            // case...switch to all same case...use swithcase??
            // red=motorcycle, orange=bus, yellow=on foot, green=bike, blue=jetski, indigo=horseback, violet=invisible plane


            // look up how to break up a line of text in writeline so that each sentence is on a line by itself
            // should be in escaping characters? in notes on strings
            // goal = top format ROYGBIV as a collumn

            // possible answers are "HELP" (Make all caps!) and names of colors (all caps)
            // if the answer "HELP" respond with the list of colors
            // if  enter a name of a color? no response? "Good choice!"

            //string userAnswer1  HELP;

            //if (userAnswer1 = HELP)
            //{
            //    Console.WriteLine("The colors represented by ROYGBIV are as follows: R=Red, O=Orange, Y=Yellow, G= Green, B=Blue, I=Indigo, V=Violet.");
            //}

            //esle
            //    { Console.WriteLine("Good choice!");
            //}

            // parse your intergers???
            //Part 3

            Console.WriteLine("Greetings, " + (firstName) + " " + (lastName)+ ". \nWelcome to Madame Teresa's. \nYour future has been revealed to me. \nYou will retire in " + (retirementYears) + " years with " + (retirementMoney) + " in the bank. \nYou will have a vacation home in " + (vacaHome) + " and travel by " + (transportMode) + " . \nEnjoy your future!") ;


        }
    }
}



