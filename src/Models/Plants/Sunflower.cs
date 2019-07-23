using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, IPlowing, INatural
    {
        private int _seedsProduced = 650;
        public string Type { get; } = "Sunflower";

        public int plantsPerRow => throw new NotImplementedException();

        public int rowsOfPlants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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