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

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

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

        // Adds Plowed field when purchasing new facility
        public void AddPlowedField(PlowedField plowedField)
        {
            PlowedFields.Add(plowedField);
            Console.WriteLine("Plowed Field Added");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            PlowedFields.ForEach(pf => report.Append(pf));

            return report.ToString();
        }


    }
}