using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IClucking chicken)
        {
            Console.Clear();

            for(int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if (farm.ChickenHouses[i].Capacity > farm.ChickenHouses[i].chickens.Count) {
                 Console.WriteLine($"{i + 1}. Chicken House : Contains {farm.ChickenHouses[i].chickens.Count} Chickens with {farm.ChickenHouses[i].Capacity - farm.ChickenHouses[i].chickens.Count} available Spots");
                }
            }

            Console.WriteLine($"Where do you wanna put this chicken?");

            Console.Write("> ");
            int choice =  Int32.Parse(Console.ReadLine());

            farm.ChickenHouses[choice - 1].AddResource(chicken);
        }
    }
}