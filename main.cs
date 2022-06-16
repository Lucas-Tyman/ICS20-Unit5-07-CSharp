// Created by: Lucas Tyman
// Created on: May 2022
//
// This program performs a loop.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function performs a loop
        int userInput;
        int answer = 0;

        // input
        Console.WriteLine("The sum of natural numbers");

        Console.WriteLine("");
        Console.Write("Please enter a positive whole number: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        // process and output
        if (userInput < 0)
        {
            Console.WriteLine("Input a positive whole number.");
        }
        else
        {
            for (int counter = 1; counter <= userInput; counter++)
            {
                answer += counter;
            }

            Console.WriteLine("");
            Console.WriteLine("The answer is " + answer + ".");
        }

        Console.WriteLine("\nDone.");
    }
}