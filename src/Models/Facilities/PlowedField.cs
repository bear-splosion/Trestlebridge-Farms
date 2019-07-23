using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowing>
    {
        private int _rowCapacity = 13;
        private int _plantCapacity = 5;
        private Guid _id = Guid.NewGuid();

        public List<IPlowing> plants = new List<IPlowing>();

        public double PlowedCapacity
        {

            get
            {
                return _plantCapacity;
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

            output.Append($"Plowed field {shortId} has {this.plants.Count} plants out of so many row.\n");
            this.plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}