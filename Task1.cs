using System;


class Solution
{

    public static void Main(string[] args)
    {
		/*
			Input:
			4 2 3 4
			
			Output:
			4
		
		*/
        var numbers = Console.ReadLine().Split(' ');

        int numberOfStudents = Convert.ToInt32(numbers[0]);

        int allowedAmountOfStudents = Convert.ToInt32(numbers[1]);

        int amountOfMins = Convert.ToInt32(numbers[2]);

        int timeBeforeOlymp = Convert.ToInt32(numbers[3]);

        int amountOfStudentsWhichEntered = 0;


        if (timeBeforeOlymp >= 0)
        {
            amountOfStudentsWhichEntered += allowedAmountOfStudents;

            while (true)
            {
                timeBeforeOlymp -= amountOfMins;

                if (timeBeforeOlymp >= 0)
                {

                    if (amountOfStudentsWhichEntered == numberOfStudents)
                    {
                        break;
                    }

                    amountOfStudentsWhichEntered += allowedAmountOfStudents;

                    if (amountOfStudentsWhichEntered > numberOfStudents)
                    {
                        amountOfStudentsWhichEntered = numberOfStudents;

                        break;
                    }

                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(amountOfStudentsWhichEntered);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}