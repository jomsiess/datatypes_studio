using System;

namespace datatypesstudio
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            string input;
            double radius;
            double circumference;
            double diameter;
            string input2;
            double mpg;
            double trip; 

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            radius = double.Parse(input); 


            area = Math.PI * radius * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Math.Round(area, 2));

            circumference = 2 * Math.PI * radius;
            diameter = 2 * radius;
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + Math.Round(circumference, 2));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            Console.WriteLine("How many miles to the gallon does your car get?"); 
            input2 = Console.ReadLine();
            mpg = double.Parse(input2);

            trip = circumference / mpg;
            Console.WriteLine("You will use about " + Math.Round(trip, 2) + " gallon/s of gas on this trip."); 

        }
    }
}
