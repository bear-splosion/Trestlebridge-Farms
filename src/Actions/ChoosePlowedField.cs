using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, IPlowing plowedField)
        {
            Console.Clear();


            //This displays all grazing fields after purchasing animals
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                //Grazing field is an array.  + 1 will stop the list from starting at zero.
                if (farm.PlowedFields[i].rowsOfPlants > farm.PlowedFields[i].plants.Count){
                Console.WriteLine($"{i + 1}. Plowed Field : Contains {farm.PlowedFields[i].plants.Count * 5} Plants with {farm.PlowedFields[i].rowsOfPlants - farm.PlowedFields[i].plants.Count} Rows Available");
                }
            }

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Plant seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //-1 will set the choice back to the GrazinFields actual array index not the displayed "list" value.4

            farm.PlowedFields[choice - 1].AddResource(plowedField);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}