using System;
using System.Linq;
using System.Collections.Generic;

namespace ClubPartyAgainAgainAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsMaxCapacity = int.Parse(Console.ReadLine());
            string[] inputLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<string> reservationsList = new Stack<string>(inputLine);
            Queue<string> hallsList = new Queue<string>();
            List<int> groupsOfPeople = new List<int>();

            int currentCapacity = 0;

            while(reservationsList.Count > 0)
            {
                string currentReservation = reservationsList.Pop();
                bool isNumber = int.TryParse(currentReservation, out int parsedNumber);

                if(!isNumber)
                {
                    hallsList.Enqueue(currentReservation);
                }
                else
                {
                    if (hallsList.Count == 0)
                    {
                        continue;
                    }
                    if (currentCapacity + parsedNumber > hallsMaxCapacity)
                    {
                        Console.WriteLine($"{hallsList.Dequeue()} -> {string.Join(", ",groupsOfPeople)}");
                        groupsOfPeople.Clear();
                        currentCapacity = 0;
                    }
                    if (hallsList.Count > 0)
                    {
                        groupsOfPeople.Add(parsedNumber);
                        currentCapacity += parsedNumber;
                    }
                }
            }
        }
    }
}
