using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IQuackHouse
    {

        private Guid _id = Guid.NewGuid();
        // private double _meatProduced = 2.6;

        //this is where we'll implement eggs

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 2.3;
        public string Type { get; } = "Duck";

        // Methods
        public void Feed()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of duck feed");
        }

        // public double Butcher () {
        //     return _meatProduced;
        // }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}