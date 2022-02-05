/*
Input:
2 2

Output:
3 5
.....
BWBW.
.....
*/

using System;
using System.Collections.Generic;

class Solution
{

    public static void Main(string[] args)
    {

        var n = Console.ReadLine().Split(' ');


        var n1 = Convert.ToInt32(n[0]);

        var n2 = Convert.ToInt32(n[1]);


        List<char> str = new List<char>();

        List<char> str2 = new List<char>();


        if (n1 == n2)
        {

			Console.WriteLine("3 " + (n1 * 2 + 1));

			Console.WriteLine(new String('.', n1 * 2 + 1));


			for (int i = 0; i < n1; i++)

			{

				str.Add('B');

				str.Add('W');

			}

			str.Add('.');

			Console.WriteLine(new string(str.ToArray()));

			Console.WriteLine(new String('.', n1 * 2 + 1));

        }
        else if ((n1 - n2 == 1) || (n2 - n1 == 1))

        {


            if (n1 > n2)

            {

                Console.WriteLine("1 " + (n2 * 2 + 1));

                for (int i = 0; i < n2; i++)

                {

                    str.Add('W');

                    str.Add('B');

                }

                str.Add('W');

            }
            else

            {

                Console.WriteLine("1 " + (n1 * 2 + 1));

                for (int i = 0; i < n1; i++)

                {

                    str.Add('B');

                    str.Add('W');

                }

                str.Add('B');

            }


            Console.WriteLine(new string(str.ToArray()));

        }

        else if ((n1 - n2 == 2) || (n2 - n1 == 2))
        {
            if (n1 > n2)
            {

                Console.WriteLine("2 " + (n2 * 2 + 1));

                str2.Add('.');

                str2.Add('W');

                for (int i = 0; i < (n2 * 2 - 1); i++)

                {

                    str2.Add('.');

                }

                for (int i = 0; i < n2; i++)

                {

                    str.Add('W');

                    str.Add('B');

                }

                str.Add('W');

                Console.WriteLine(new string(str2.ToArray()));

                Console.WriteLine(new string(str.ToArray()));

            }
            else
            {
                Console.WriteLine("2 " + (n1 * 2 + 1));

                str2.Add('.');

                str2.Add('B');

                for (int i = 0; i < (n1 * 2 - 1); i++)

                {

                    str2.Add('.');

                }

                for (int i = 0; i < n1; i++)

                {

                    str.Add('B');

                    str.Add('W');

                }

                str.Add('B');

                Console.WriteLine(new string(str2.ToArray()));

                Console.WriteLine(new string(str.ToArray()));

            }

        }

        else if ((n1 - n2 == 3) || (n2 - n1 == 3))
        {

            if (n1 > n2)
            {
                Console.WriteLine("3 " + (n2 * 2 + 1));

                str2.Add('.');

                str2.Add('W');

                for (int i = 0; i < (n2 * 2 - 1); i++)

                {

                    str2.Add('.');

                }

                for (int i = 0; i < n2; i++)

                {

                    str.Add('W');

                    str.Add('B');

                }

                str.Add('W');

                Console.WriteLine(new string(str2.ToArray()));

                Console.WriteLine(new string(str.ToArray()));

                Console.WriteLine(new string(str2.ToArray()));

            }
            else
            {
                Console.WriteLine("3 " + (n1 * 2 + 1));

                str2.Add('.');

                str2.Add('B');

                for (int i = 0; i < (n1 * 2 - 1); i++)

                {

                    str2.Add('.');

                }

                for (int i = 0; i < n1; i++)

                {

                    str.Add('B');

                    str.Add('W');

                }

                str.Add('B');

                Console.WriteLine(new string(str2.ToArray()));

                Console.WriteLine(new string(str.ToArray()));

                Console.WriteLine(new string(str2.ToArray()));

            }

        }

        else
        {

            Console.WriteLine("-1");

        }

    }

}