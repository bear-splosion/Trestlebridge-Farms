using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        public int plantsPerRow = 6;

        public int rowsOfPlants = 10;


        private Guid _id = Guid.NewGuid();

        public List<INatural> plants = new List<INatural>();

        public double Capacity => throw new NotImplementedException();

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

            output.Append($"Natural field {shortId} has {this.plants.Count} Rows with a total of {this.plants.Count * 6} Plants.\n");
            this.plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}