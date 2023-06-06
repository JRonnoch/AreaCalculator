/*
 * Conner Hlade
 * This program prompts the user to input their name and measurements for a rectangle and square.
 * The program will then print the user name, area, and perimeter using the provided measurements.
 * 
 */
using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Please type your name.");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter the length of your rectangle."); 
            double rectLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the width of your rectangle.");
            double rectWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the length of your square.");
            double square = Convert.ToDouble(Console.ReadLine());
            int newSquare = Convert.ToInt32(square);

            //Math
            double areaRect = Math.Round(rectLength * rectWidth,2);
            double perimRect = Math.Round((2 * rectLength + 2 * rectWidth), 2);
            int areaSquare = newSquare * newSquare;
            int perimSquare = 4 * newSquare;
            double sumSquareRectArea = Math.Round(areaRect + areaSquare, 2);
            
            //Output
            Console.WriteLine();
            Console.WriteLine("Hello {0}!", userName);
            Console.WriteLine();
            Console.WriteLine("The area of your rectangle is {0} and the perimeter of your rectangle is {1}.", areaRect, perimRect);
            Console.WriteLine();
            Console.WriteLine("The area of your square is {0} and the perimeter of your square is {1}", areaSquare, perimSquare);
            Console.WriteLine();
            Console.WriteLine("The sum of the area for the rectangle and square is {0}.", sumSquareRectArea);
        }
    }
}
