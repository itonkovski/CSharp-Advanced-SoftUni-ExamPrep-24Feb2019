﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    public class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<string> reservations = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();
            List<int> allGroups = new List<int>();

            int currentCapacity = 0;

            while (reservations.Count > 0)
            {
                string currentElemnt = reservations.Pop();

                bool isNumber = int.TryParse(currentElemnt, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currentElemnt);
                }
                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }
                    if (currentCapacity + parsedNumber > maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ",allGroups)}");
                        allGroups.Clear();
                        currentCapacity = 0;
                    }
                    if (halls.Count > 0 )
                    {
                        allGroups.Add(parsedNumber);
                        currentCapacity += parsedNumber;
                    }
                    
                }
            }
        }
    }
}