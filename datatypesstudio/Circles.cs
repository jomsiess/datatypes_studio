using System;
namespace datatypesstudio
{
    public class Circles
    {
        public static double GetArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area; 
        }
        public static double GetCircumference(double radius)
        { 
            double circumference = 2 * Math.PI* radius;
            return circumference; 
        }
        public static double GetDiameter(double radius)
        {
            double diameter = 2 * radius;
            return diameter; 

        }
        public static double GetTrip(double mpg, double circumference)
        {
            double trip = circumference / mpg;
            return trip;
        }
    }
    }
