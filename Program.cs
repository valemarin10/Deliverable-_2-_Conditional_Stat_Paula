//
    /* 
    Author: Paula Marin
    Date: 01/30/2020
    Comments: This C# console application code demonstrates the use of
    conditional statements 
    */

 
 
 
 using System;

namespace Deliverable__2__Conditional_Statemen_Paula
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask the user for input

            Console.WriteLine("What grade do you expect to get in ISM 4300? ");

            Console.WriteLine();

            try
            {
                int grade = int.Parse(Console.ReadLine());

                //conditional to make suire user enters an integer betwwen 0 - 100 
                if ((grade < 0) || (grade > 100))
                    Console.WriteLine("Please enter an Integer between 0 to 100 and try again");

                //execute the conditional statement to display letter grades 

                if ((grade >= 98) && (grade <= 100))

                {

                    Console.WriteLine("Letter grade of A+");

                }

                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("Letter grade of A");
                }

                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Letter grade of A-");
                }
                else if ((grade >= 88) && (grade <= 89))

                {
                    Console.WriteLine("Letter grade of B+");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Letter grade of B");
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Letter grade of B-");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Letter grade of C+");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Letter grade of C");
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Letter grade C-");
                }
                else if ((grade >= 69) && (grade< 0))
                {
                    Console.WriteLine("Letter grade D");

                }
            }
            catch
            {
                Console.WriteLine("values must not be less than 0 and not exceed 100");
                Console.WriteLine("Press ESC to exit");
                //catch errors
            }
                    
            }
        }
    }

