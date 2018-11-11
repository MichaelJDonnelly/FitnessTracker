using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class CalorieCalculator
    {
        BodyStatistics bodyStats = new BodyStatistics();
        public double bmr, tdee;
        public void ComputeBmr()
        {
            int bmrMultiplier = 10;
            double heightMultiplier = 6.25;
            if (BodyStatistics.gender.Equals("female", StringComparison.InvariantCultureIgnoreCase))
            {
                bmr = (BodyStatistics.weightInKg * bmrMultiplier) + (heightMultiplier * BodyStatistics.height) - (5 * BodyStatistics.age) - 161;
                Console.WriteLine("Your weight in KGs: " + BodyStatistics.weightInKg);
                Console.WriteLine("Your BMR is: " + bmr);
            }

            if (BodyStatistics.gender.Equals("male", StringComparison.InvariantCultureIgnoreCase))
            {
                bmr = (BodyStatistics.weightInKg * bmrMultiplier) + (heightMultiplier * BodyStatistics.height) - (5 * BodyStatistics.age) + 5;
                Console.WriteLine("Your BMR is: " + bmr);
            }
        }

        public void ComputeTdee()
        {
            double sedentaryModifier = 1.2;
            double moderateModifier = 1.55;
            double highModifier = 1.725;
            if (BodyStatistics.activityLevelInput == 1)
            {
                tdee = (bmr * sedentaryModifier);
            }
            if (BodyStatistics.activityLevelInput == 2)
            {
                tdee = (bmr * moderateModifier);
            }
            if (BodyStatistics.activityLevelInput == 3)
            {
                tdee = (bmr * highModifier);
            }
            Console.WriteLine("Your TDEE based on your activity level is: " + tdee);
        }
    }
}
