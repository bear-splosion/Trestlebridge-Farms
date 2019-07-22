using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        //changed capacity to 20
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        public List<INatural> plants = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(INatural plant)
        {
            plants.Add(plant);
        }

        public void AddResource(List<INatural> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this.plants.Count} plants out of 60 plants.\n");
            this.plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}