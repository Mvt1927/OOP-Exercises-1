using System;
using static Exercise_1.Dice;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new(100);
            //Initialize object "Dice" with face number of 100
            Console.WriteLine(dice.Roll());
            //Print to console result after used method Roll
        }
    }
}