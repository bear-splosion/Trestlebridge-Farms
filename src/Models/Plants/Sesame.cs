using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing, IPlowing
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sesame";

        public int plantsPerRow => throw new NotImplementedException();

        public int rowsOfPlants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sesame. Yum!";
        }
    }
}