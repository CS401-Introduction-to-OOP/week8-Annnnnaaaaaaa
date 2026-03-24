namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; private set; }

    public Letter(string trackingNumber, double weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }
    
    public override void CalculateCost()
    {
        return 50 + weight * 25;
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"{dimensions}");
    }
}