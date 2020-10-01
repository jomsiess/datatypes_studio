using System;

namespace datatypesstudio
{
    class Program
    {
        static void Main(string[] args)
        {
   
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


            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Math.Round(Circles.GetArea(radius), 2));
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + Math.Round(Circles.GetCircumference(radius), 2));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + Math.Round(Circles.GetDiameter(radius), 2));

            Console.WriteLine("How many miles to the gallon does your car get?");
            input2 = Console.ReadLine();
            mpg = double.Parse(input2);

            //Console.WriteLine("You will use about " + Math.Round, 2)) + " gallon/s of gas on this trip.");

        }
    }
}
