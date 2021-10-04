using System;

namespace CodeChallengePreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.Write("Please enter a number between 1 - 10: ");
                string userResult = Console.ReadLine();

                int userNumber = Int32.Parse(userResult);

            }



        }
    }
}
