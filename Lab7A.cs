/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab7A
*/

using System;

class Lab7A
{

    public static void Main(string[] args)
    {
        Console.Write("Please enter a value for the size: ");
        int dimension = int.Parse(Console.ReadLine());
        Console.WriteLine("This is the requested "+dimension+"x"+dimension+" box:");
        for(int i =1;i<= dimension; i++)
        {
            
            for(int j = 1;j<= dimension; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
