/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab7B
*/

using System;

class Lab7B
{

    public static void Main(string[] args)
    {
        Console.Write("Please enter a value for the size: ");
        int size= int.Parse(Console.ReadLine());
        Console.WriteLine("This is the requested "+size+"x"+size+" right-triangle:");
        for(int i = 1; i <= size;i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
