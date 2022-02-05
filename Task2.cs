/*
Input:
4
bcda

Output:
4

*/


using System;

using System.Collections.Generic;


class Solution
{

    private static char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

    public static void Main(string[] args)
    {

        int number = Convert.ToInt32(Console.ReadLine());

        string line = Console.ReadLine();

        String str = "abcdefghijklmnopqrstuvwxyz";

        if (str.Contains(GetCorrectString(line)))

        {

            Console.WriteLine(number);

        }

        else
        {

            Console.WriteLine(GetAmoutOfCorrectSymbols(GetCorrectString(line)));

        }

    }


    private static int GetIndex(char letter)

    {

        return Array.IndexOf(alphabet, letter);

    }


    private static string GetCorrectString(string line)

    {

        var charArr = line.ToCharArray();

        List<int> position = new List<int>();

        for (int i = 0; i < line.Length; i++)

        {

            position.Add(GetIndex(charArr[i]));

        }

        position.Sort();

        var index = Array.IndexOf(charArr, alphabet[position[0]]);

        List<char> newArr = new List<char>();

        for (int i = index; i < line.Length; i++)

        {

            newArr.Add(charArr[i]);

        }


        for (int i = 0; i < index; i++)

        {

            newArr.Add(charArr[i]);

        }




        return new string(newArr.ToArray());

    }


    private static int GetAmoutOfCorrectSymbols(string correctString)

    {

        List<int> positions = new List<int>();

        var charArr = correctString.ToCharArray();

        for (int i = 0; i < correctString.Length; i++)

        {

            positions.Add(GetIndex(charArr[i]));

        }


        List<int> a = new List<int>();

        int j = 1;

        for (int i = 0; i < correctString.Length - 1; i++)

        {

            if (positions[i] + 1 == positions[i + 1])

            {

                j++;

            }
            else
            {

                a.Add(j);

                j = 1;

            }

        }


        a.Sort();

        a.Reverse();


        return a[0];

    }

}