namespace Trestlebridge.Interfaces
{
    public interface IQuackHouse
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}