using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowing>
    {
        public int plantsPerRow = 5;
        public int rowsOfPlants = 13;
        private Guid _id = Guid.NewGuid();

        public List<IPlowing> plants = new List<IPlowing>();

        public double PlowedCapacity
        {

            get
            {
                return plantsPerRow * rowsOfPlants;
            }
        }

        public double Capacity => throw new NotImplementedException();

        public void AddResource(IPlowing plant)
        {
            plants.Add(plant);
        }

        public void AddResource(List<IPlowing> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this.plants.Count} Rows with a total of {this.plants.Count * 5} Plants.\n");
            this.plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}