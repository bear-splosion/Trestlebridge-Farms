using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {

    public class ChickenHouse : IFacility<IClucking>
    {
        private int _capacity = 15;

        private Guid _id = Guid.NewGuid();

        public List<IClucking> chickens = new List<IClucking>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IClucking chicken)
        {
            chickens.Add(chicken);
        }

        public void AddResource (List<IClucking> chickens)
        {
            //TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId= $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this.chickens.Count} chickens out of 15 spaces. \n");
            this.chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}