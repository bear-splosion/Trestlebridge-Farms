using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {

        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sunflower");
            Console.WriteLine("2. Wildflower");
            Console.WriteLine("3. Sesame");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                //Collect input within collect input?
                case 1:

                    ChooseSunFlowerField.CollectInput(farm, new Sunflower());
                    break;

                case 2:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    break;

                case 3:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;

                default:
                    break;
            }
        }
    }
}