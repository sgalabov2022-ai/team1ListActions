using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

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
                    Console.Write("Num1: ");
                    int addNum1 = int.Parse(Console.ReadLine());
                    Console.Write("Num2: ");
                    int addNum2 = int.Parse(Console.ReadLine());
                    nums.Add(addNum1 + addNum2);    
                    break;
                case "ins":
                    Console.Write("Enter num: ");
                    int insNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter index: ");
                    int insIndex = int.Parse(Console.ReadLine());
                    nums.Insert(insNum, insIndex);
                    break;
                case "contains":
                    Console.Write("Element: ");
                    int contains = int.Parse(Console.ReadLine());
                    if (nums.Contains(contains))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                        break;
                //devA

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
                //devB

                case "print":
                    Console.WriteLine(string.Join(", ", nums));
                    break;
                case "countOdds":
                    Console.WriteLine(nums.Count());
                    break;
                //devC

                default:
                    break;
            }
        }
    }
}
