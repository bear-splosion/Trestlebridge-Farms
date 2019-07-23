using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IQuackHouse>
    {
        //changed capacity to 12
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        public List<IQuackHouse> ducks = new List<IQuackHouse>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IQuackHouse duck)
        {
            ducks.Add(duck);
        }

        public void AddResource(List<IQuackHouse> ducks)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this.ducks.Count} ducks out of 12 spaces.\n");
            this.ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}