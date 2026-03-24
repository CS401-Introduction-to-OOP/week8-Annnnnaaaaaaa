namespace Week8;

public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        
    }
    
    public override void CalculateCost()
    {
        return 15 + weight * 10;
    }
}