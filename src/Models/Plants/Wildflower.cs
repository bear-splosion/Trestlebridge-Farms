using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, INatural
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Wildflower";

        public int plantsPerRow => throw new NotImplementedException();

        public int rowsOfPlants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double NaturalRows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double NaturalPlants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public override string ToString()
        {
            return $"Wildflower. So pretty!";
        }
    }
}