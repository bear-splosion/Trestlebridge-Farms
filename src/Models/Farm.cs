using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        //Adds Duck House field when creating new facility.
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;

                // case "Chicken":
                //     ChickenHouses[index].AddResource((IClucking)resource);
                //     break;

                default:
                    break;
            }
        }

        //Adds Grazing field when purchasing new facility.
        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
            Console.WriteLine("Grazing Field Added");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }
        //Adds Duck House field when creating new facility.
        public void AddDuckHouse(DuckHouse house)
        {
            DuckHouses.Add(house);
            Console.WriteLine("Duck House Added");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        // Adds Plowed field when purchasing new facility
        public void AddPlowedField(PlowedField plowedField)
        {
            PlowedFields.Add(plowedField);
            Console.WriteLine("Plowed Field Added");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        public void AddChickenHouse(ChickenHouse coop)
        {
            ChickenHouses.Add(coop);
            Console.WriteLine("Chicken House Added");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }





        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
            Console.WriteLine("Natural Field Added");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            GrazingFields.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(dh => report.Append(dh));

            PlowedFields.ForEach(pf => report.Append(pf));

            NaturalFields.ForEach(nf => report.Append(nf));

            ChickenHouses.ForEach(ch => report.Append(ch));

            return report.ToString();
        }
        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */

        // add duck
        public void PurchaseResource<T>(IQuackHouse resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Duck":
                    DuckHouses[index].AddResource((IQuackHouse)resource);
                    break;
                default:
                    break;
            }
        }




    }
}