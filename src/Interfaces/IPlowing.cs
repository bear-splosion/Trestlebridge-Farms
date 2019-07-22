
namespace Trestlebridge.Interfaces
{
    public interface IPlowing
    {
        int plantsPerRow { get; set; }

        int rowsOfPlants { get; set; }

        // void Graze();
        void plantRowOfSeed();
    }
}