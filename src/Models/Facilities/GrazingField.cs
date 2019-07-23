using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        //changed capacity to 20
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        public List<IGrazing> animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {   
            animals.Add(animal);
        }

        public void AddResource (List<IGrazing> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this.animals.Count} animals out of 20 spaces.\n");
            this.animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        } 
    }
}