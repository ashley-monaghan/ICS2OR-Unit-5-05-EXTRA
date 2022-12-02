// Created by: Ashley Monaghan
// Created on: Nov 2022
//
//This program deducts what type of triangle you have

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int lengthA;
        int lengthB;
        int lengthC;
        double angleA;
        double angleB;
        double angleC;
        double sumOfAngles;

        Console.WriteLine("What type of triangle do you have?");
        Console.WriteLine("");

        Console.WriteLine("Enter the following lengths for each: ");
        Console.WriteLine("");
        Console.WriteLine("Length A: ");
        lengthA = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Length B: ");
        lengthB = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Length C: ");
        lengthC = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(" ");
         angleA = Math.Acos((Math.Pow(lengthB, 2) + Math.Pow(lengthC, 2) - Math.Pow(lengthA, 2)) / (2 * lengthB * lengthC)) * (180/Math.PI);
         angleB = Math.Acos((Math.Pow(lengthC, 2) + Math.Pow(lengthA, 2) - Math.Pow(lengthB, 2)) / (2 * lengthC * lengthA)) * (180/Math.PI);
         angleC = Math.Acos((Math.Pow(lengthA, 2) + Math.Pow(lengthB, 2) - Math.Pow(lengthC, 2)) / (2 * lengthA * lengthB)) * (180/Math.PI);

        sumOfAngles = angleA + angleB + angleC;
        Console.WriteLine("Sum of all angles: " + sumOfAngles.ToString("0.0"));
        Console.WriteLine(" ");

                      
        if (angleA == angleB && angleA == angleC) {
        Console.WriteLine("You have an equalatiral triangle!");
        } else if (angleA != angleB && angleA != angleC && angleB != angleC) {
        Console.WriteLine("You have an scalene triangle!");
        } else if ((angleA != angleB && angleA == angleC) || (angleA == angleB && angleA != angleC)) {
        Console.WriteLine("You have an isosceles triangle!");
        } else {
        Console.WriteLine("Umm. not a triangle");
        }

        Console.WriteLine("\nDone.");
    }
}