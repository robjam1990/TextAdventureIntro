using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public static class Recognition
    {
        // Recognize method to identify and record objects
        public static void Recognize(string objectName, Dictionary<string, string[]>? propertiesConfig)
        {
            // Check if the object is already recognized
            if (Encyclopedia.ContainsKey(objectName))
            {
                return; // Object already recognized, no need to process further
            }

            // Record the object with its properties
            Record(objectName, propertiesConfig!);
        }

        // Logic to record the object with its properties
        private static void Record(string objectName, Dictionary<string, string[]> propertiesConfig)
        {
            // Create a new entry in the encyclopedia for the object
            Encyclopedia.Add(objectName, propertiesConfig);

            // Additional logic such as saving the recorded object to a file or database
            SaveRecordedObjectToFile(objectName, propertiesConfig);
        }

        // Method to save the recorded object to a file
        private static void SaveRecordedObjectToFile(string objectName, Dictionary<string, string[]> propertiesConfig)
        {
            string filePath = "/path/to/recorded_objects.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Object Name: {objectName}");
                writer.WriteLine("Properties:");
                foreach (var property in propertiesConfig)
                {
                    writer.WriteLine($"{property.Key}: {string.Join(", ", property.Value)}");
                }
                writer.WriteLine();
            }
        }
    }

}
