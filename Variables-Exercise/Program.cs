using System.Runtime.CompilerServices;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ryan Wetmore";

            string sport = "Play Basketball";


            int age = 22;


            char middleInitial = 'A';


            bool isOldEnough = false;


            double currentTemp = 65.4;


            decimal currentPrice = 500.00m;


            Console.WriteLine($"My name is {name}, I am {age} years old, I like to {sport}, only when it is atleast {currentTemp} degrees outside");
            Console.WriteLine($"Its insane i paid {currentPrice} for this basketball and its too cold outside!");
            Console.WriteLine($"Maybe one day it will be {currentTemp} outside and I will be able to play basketetball, hopefully by my {age}th birthday");


        }
    }
}
