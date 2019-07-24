using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IQuackHouse duck)
        {
            Console.Clear();


            //This displays all grazing fields after purchasing animals
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                //Grazing field is an array.  + 1 will stop the list from starting at zero.
                if (farm.DuckHouses[i].Capacity > farm.DuckHouses[i].ducks.Count)
                {
                    Console.WriteLine($"{i + 1}. Duck House : Contains {farm.DuckHouses[i].ducks.Count} Ducks");
                    if (farm.DuckHouses[i].Capacity > farm.DuckHouses[i].ducks.Count)
                    {
                        Console.WriteLine($"{i + 1}. DuckHouse : Contains {farm.DuckHouses[i].ducks.Count} Ducks with {farm.DuckHouses[i].Capacity - farm.DuckHouses[i].ducks.Count} available Spots.");
                    }
                }

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                //-1 will set the choice back to the GrazinFields actual array index not the displayed "list" value.4

                farm.DuckHouses[choice - 1].AddResource(duck);


                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);

            }
        }
    }
}