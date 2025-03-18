using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            Console.WriteLine("***** Working with Arrays *****");
            
            int[] randomNumbers = new int[50];
            
            FillArray(randomNumbers);
            
            Console.WriteLine($"First element: {randomNumbers[0]}");
            Console.WriteLine($"Last element: {randomNumbers[randomNumbers.Length - 1]}");
            
            Console.WriteLine("Original Array:");
            PrintCollection(randomNumbers);
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Reversed Array:");
            ReverseNumbers(randomNumbers);
            PrintCollection(randomNumbers);
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Multiples of 3 set to zero:");
            SetMultiplesOfThreeToZero(randomNumbers);
            PrintCollection(randomNumbers);
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Sorted Array:");
            Array.Sort(randomNumbers);
            PrintCollection(randomNumbers);
            Console.WriteLine("\n***** End of Array Operations *****\n");

            #endregion

            #region Lists
            Console.WriteLine("***** Working with Lists *****");
            
            List<int> numbersList = new List<int>();
            
            Console.WriteLine($"Initial list capacity: {numbersList.Capacity}");
            
            PopulateList(numbersList);
            
            Console.WriteLine($"List capacity after filling: {numbersList.Capacity}");
            Console.WriteLine("----------------------------");
            
            Console.Write("Enter a number to search in the list: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                CheckForNumber(numbersList, userInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("List of Numbers:");
            PrintCollection(numbersList);
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("List with only even numbers:");
            RemoveOdds(numbersList);
            PrintCollection(numbersList);
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Sorted Even Numbers:");
            numbersList.Sort();
            PrintCollection(numbersList);
            Console.WriteLine("----------------------------");
            
            int[] convertedArray = numbersList.ToArray();
            
            numbersList.Clear();
            Console.WriteLine("List has been cleared. Remaining count: " + numbersList.Count);

            Console.WriteLine("***** End of List Operations *****");
            #endregion
        }

        private static void SetMultiplesOfThreeToZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr[i] = 0;
                }
            }
        }

        private static void RemoveOdds(List<int> numList)
        {
            numList.RemoveAll(n => n % 2 != 0);
        }

        private static void CheckForNumber(List<int> numList, int num)
        {
            Console.WriteLine(numList.Contains(num)
                ? $"Yes, {num} is in the list!"
                : $"No, {num} is not in the list.");
        }

        private static void PopulateList(List<int> numList)
        {
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                numList.Add(rand.Next(0, 51));
            }
        }

        private static void FillArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 51);
            }
        }

        private static void ReverseNumbers(int[] arr)
        {
            Array.Reverse(arr);
        }

        private static void PrintCollection<T>(T collection) where T : IEnumerable<int>
        {
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}



