using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();


            //This displays all grazing fields after purchasing animals
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                //Grazing field is an array.  + 1 will stop the list from starting at zero.
                Console.WriteLine($"{i + 1}. Grazing Field : Contains {farm.GrazingFields[i].animals.Count} Animals with {farm.GrazingFields[i].Capacity - farm.GrazingFields[i].animals.Count} Available Spots");
            }

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //-1 will set the choice back to the GrazinFields actual array index not the displayed "list" value.4

            farm.GrazingFields[choice - 1].AddResource(animal);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}