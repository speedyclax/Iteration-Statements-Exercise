﻿namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            JumpByThrees();
            IsEqual(3,8);

        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintThousand()
    {
        for (int i = 1000; i >= -1000; i--)
        {
            Console.WriteLine(i);
        }
    }

    //Write a method that will print to the console numbers 3 through 999 by 3 each time

    public static void JumpByThrees()
    {
        for (int i = 3; i <= 999; i += 3)
        {
            Console.WriteLine(i);
        }
    }

    //Write a method to accept two integers as parameters and check whether they are equal or not
    public static bool IsEqual(int a, int b)
    {
        if (a == b)
        {
            var check = (a == b) ? true : false;
            return check;
        }
            else
            {
                return false;
            }
    }

    //Write a method to check whether a given number is even or odd

    //Write a method to check whether a given number is positive or negative

    //Write a method to read the age of a candidate and determine whether they can vote.
    //Hint: Use Parse or the safer TryParse() for an extra challenge
    //Parse()
    //TryParse()

    public static bool CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Congratulations. You are old enough to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry. {18 - age} is not old enough to vote.");
                return false;
            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below

    }
}
