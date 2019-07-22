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


            NaturalFields.ForEach(nf => report.Append(nf));

            ChickenHouses.ForEach(ch => report.Append(ch));

            return report.ToString();
        }
    }
}