using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, INatural naturalField)
        {
            Console.Clear();


            //This displays all grazing fields after purchasing animals
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                //Grazing field is an array.  + 1 will stop the list from starting at zero.
                if (farm.NaturalFields[i].rowsOfPlants > farm.NaturalFields[i].plants.Count)
                {
                Console.WriteLine($"{i + 1}. Plowed Field : Contains {farm.NaturalFields[i].plants.Count * 6} Plants with {farm.NaturalFields[i].rowsOfPlants - farm.NaturalFields[i].plants.Count} Rows Available");
                }
            }

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //-1 will set the choice back to the GrazinFields actual array index not the displayed "list" value.4

            farm.NaturalFields[choice - 1].AddResource(naturalField);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}