using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            BodyStatistics bodyStats = new BodyStatistics();
            CalorieCalculator calorieCalc = new CalorieCalculator();
            Menu menu = new Menu();
            menu.DisplayMenu();
            bodyStats.GetGender();
            bodyStats.GetAge();
            bodyStats.GetHeight();
            bodyStats.GetWeight();
            bodyStats.GetActivityLevel();
            calorieCalc.ComputeBmr();
            calorieCalc.ComputeTdee();
            Console.WriteLine("Press ESC to quit");

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                //Wait for user to quit
            }
        }
    }
}
