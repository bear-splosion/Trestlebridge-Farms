using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, IPlowing, INatural
    {
        private int _seedsProduced = 650;
        public string Type { get; } = "Sunflower";

        public int plantsPerRow  { get; set; }

        public int rowsOfPlants { get; set; }
        public double NaturalRows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double NaturalPlants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sunflower. Yum!";
        }
    }
}