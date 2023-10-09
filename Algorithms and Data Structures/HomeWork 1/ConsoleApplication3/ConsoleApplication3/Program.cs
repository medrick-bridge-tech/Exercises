using System;

namespace PHExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of letters: ");
            int letterCount = int.Parse(Console.ReadLine());
            string input = "";// Declare a string variable to store the input letters
            Console.Write("Please enter a letter from P or H: "); // Ask the user to enter a letter
            while (input.Length < letterCount)// Loop until the input length is equal to the letter count
            {
                char letter = char.ToUpper(Console.ReadKey().KeyChar);
                if (letter == 'P' || letter == 'H')// Check if the letter is P or H
                {
                    input += letter;// Append the letter to the input string
                }
                else
                {
                    Console.WriteLine("The entered letter is invalid. Please try again.");// Show an error message and ask again
                }
            }
            Console.WriteLine();
            int start, end;// Declare two integer variables to store the start and end points
            Console.Write("Please enter the start point : ");// Ask the user to enter the start point
            start = int.Parse(Console.ReadLine());
            Console.Write("Please enter the end point : ");// Ask the user to enter the end point
            end = int.Parse(Console.ReadLine());
            int hCount = 0; // Declare an integer variable to store the count of H letters
            bool hFound = false;// Declare a boolean variable to indicate if an H letter is found
            if (start < end)
            {
                for (int i = start - 1; i <= end - 1; i++) // Loop from the start point to the end point
                {
                    if (input[i] == 'H')// Check if the current letter is H
                    {
                        if (!hFound)// Check if an H letter is not found before
                        {
                            hCount++;// Increment the count of H letters
                            hFound = true;// Set the hFound variable to true
                        }
                    }
                    else
                    {
                        hFound = false;// Set the hFound variable to false
                        continue;
                    }
                }
            }
            else
            {
                for (int i = start - 1; i >= end - 1; i--) // Loop from the start point to the end point
                {
                    if (input[i] == 'H')// Check if the current letter is H
                    {
                        if (!hFound)// Check if an H letter is not found before
                        {
                            hCount--;// Increment the count of H letters
                            hFound = true;// Set the hFound variable to true
                        }
                    }
                    else
                    {
                        hFound = false;// Set the hFound variable to false
                        continue;
                    }
                }
            }
            Console.WriteLine("Between the start point {0} and the end point {1}, there are {2} H letters.", start, end, Math.Abs(hCount)); // Show the result to the user
        }
    }
}
