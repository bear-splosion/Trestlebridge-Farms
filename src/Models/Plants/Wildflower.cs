using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, INatural
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Wildflower";

        public int plantsPerRow { get; set; }

        public int rowsOfPlants { get; set; }
        public double NaturalRows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double NaturalPlants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public override string ToString()
        {
            return $"Wildflower. So pretty!";
        }
    }
}