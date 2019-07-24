using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseSunFlowerField
    {
        public static void CollectInput(Farm farm, INatural taco)
        {Console.Clear();

        for (int i = 0; i < farm.PlowedFields.Count; i++)
        {
            if (farm.PlowedFields[i].rowsOfPlants > farm.PlowedFields[i].plants.Count) {
                Console.WriteLine($"{i + 1}. Plowed Field : Contains {farm.PlowedFields[i].plants.Count * 5} Plants with {farm.PlowedFields[i].rowsOfPlants - farm.PlowedFields[i].plants.Count} Rows Available");
            }
        }
            

        for (int i = 0; i < farm.NaturalFields.Count; i++)
        {
            if (farm.NaturalFields[i].rowsOfPlants > farm.NaturalFields[i].plants.Count) {
                 Console.WriteLine($"{i + 1 + farm.PlowedFields.Count}. Natural Field : Contains {farm.NaturalFields[i].plants.Count * 6} Plants with {farm.NaturalFields[i].rowsOfPlants - farm.NaturalFields[i].plants.Count} Rows Available");
                } 
        }
        Console.WriteLine($"Plant seeds where?");
        Console.Write("> ");

        int choice = Int32.Parse(Console.ReadLine());

        if (choice > farm.PlowedFields.Count) {
            farm.NaturalFields[choice - 1 - farm.PlowedFields.Count].AddResource(taco);
        }
           else {
            IPlowing resource = (IPlowing)taco;
            farm.PlowedFields[choice - 1].AddResource(resource);
           }
        }
    }

}