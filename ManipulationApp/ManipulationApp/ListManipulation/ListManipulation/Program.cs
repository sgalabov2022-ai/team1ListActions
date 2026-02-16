using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split().ToArray();          

            switch (cmd[0])
            {
                case "add":
                    break;
                case "ins":
                    break;
                case "contains":                    
                    break;

                case "delete":
                    Console.Write("Element: ");
                    int element = int.Parse(Console.ReadLine());
                    nums.Remove(element);
                    break;
                case "remove":
                    Console.Write("Index: ");
                    int index = int.Parse(Console.ReadLine());
                    nums.RemoveAt(index);
                    break;

                case "print":
                    break;
                case "countOdds": 
                    break;
                default:
                    break;
            }
        }
    }
}
