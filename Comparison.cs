using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{

    // Comparison class to compare objects
    public static class Comparison
    {
        // Method to compare two objects
        public static void Compare(object object1, object object2)
        {
            // Logic to compare the objects and calculate difference
            double difference = CalculateDifference(object1, object2);

            // Display the comparison result
            DisplayComparisonResult(difference);
        }


        // Method to calculate difference between objects
        private static double CalculateDifference(object object1, object object2)
        {
            // Implement logic to calculate the difference
            double difference = 0.0;
            if (object1 is double && object2 is double)
            {
                difference = Math.Abs((double)object1 - (double)object2);
            }
            else if (object1 is int && object2 is int)
            {
                difference = Math.Abs((int)object1 - (int)object2);
            }
            else if (object1 is string && object2 is string)
            {
                difference = String.Compare((string)object1, (string)object2, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                // Handle other types of objects or throw an exception
                throw new ArgumentException("Unsupported object types for comparison");
            }

            return difference;
        }

        // Method to display the comparison result
        private static void DisplayComparisonResult(double difference)
        {
            if (difference == 0.0)
            {
                Console.WriteLine("The objects are identical.");
            }
            else
            {
                Console.WriteLine("The objects are different.");
            }
        }
    }

}
