using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubPartyAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<string> reservations = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();
            List<int> groupsOfPeople = new List<int>();

            int currentCapacity = 0;

            while (reservations.Count > 0)
            {
                string currentElement = reservations.Pop();

                bool isNumber = int.TryParse(currentElement, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }
                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (currentCapacity + parsedNumber > maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ",groupsOfPeople)}");
                        groupsOfPeople.Clear();
                        currentCapacity = 0;
                    }

                    if (halls.Count > 0)
                    {
                        groupsOfPeople.Add(parsedNumber);
                        currentCapacity += parsedNumber;
                    }
                }
            }
        }
    }
}
