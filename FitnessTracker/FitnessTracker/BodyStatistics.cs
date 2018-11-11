using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class BodyStatistics
    {
        public static string[] validGender = new string[] { "male", "female", "Male", "Female" };
        public static string gender;
        public static double weightInKg, weight, height, age;
        public static int[] validActivityLevelInput = new int[] { 1, 2, 3 };
        public static int activityLevelInput;

        public void GetGender()
        {
            Console.WriteLine("Enter your gender as either 'Female' or 'Male': ");
            gender = (Console.ReadLine());
            while (!validGender.Contains(gender))
            {
                Console.WriteLine("Please Enter a valid gender!");
                Console.WriteLine("Enter your gender as either 'Female' or 'Male': ");
                gender = (Console.ReadLine());
            }
        }

        public void GetAge()
        {
            Console.WriteLine("Enter your age as a whole number: ");
            while (!double.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter your age as a whole number: ");
            }
        }

        public void GetHeight()
        {
            Console.WriteLine("Enter your height in cm: ");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter your height in cm: ");
            }
        }

        public void GetWeight()
        {
            Console.WriteLine("Enter your weight in lbs: ");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter your weight in lbs: ");
            }
            weightInKg = weight / 2.205;
        }

        public void GetActivityLevel()
        {
            Console.WriteLine("\nPlease select the number corresponding to your activity level: ");
            Console.WriteLine("1: Sedentary (no exercise): ");
            Console.WriteLine("2: Moderate activity (1-3 hours per week): ");
            Console.WriteLine("3: High activity (3-5 hours per week): ");
            while (!int.TryParse(Console.ReadLine(), out activityLevelInput))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("\nPlease select the number corresponding to your activity level: ");
                Console.WriteLine("1: Sedentary (no exercise): ");
                Console.WriteLine("2: Moderate activity (1-3 hours per week): ");
                Console.WriteLine("3: High activity (3-5 hours per week): ");
                while (!int.TryParse(Console.ReadLine(), out activityLevelInput)) ;
            }
            while (!validActivityLevelInput.Contains(activityLevelInput))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("\nPlease select the number corresponding to your activity level: ");
                Console.WriteLine("1: Sedentary (no exercise): ");
                Console.WriteLine("2: Moderate activity (1-3 hours per week): ");
                Console.WriteLine("3: High activity (3-5 hours per week): ");
                int.TryParse(Console.ReadLine(), out activityLevelInput);
            }
                
        }

    }
}