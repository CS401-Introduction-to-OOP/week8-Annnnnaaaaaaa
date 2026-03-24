namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get ; }
    public double Weight { get; }
    
    public DeliveryItem (string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost(); // повертає вартість доставки

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Tracking number: {TrackingNumber}, weight: {Weight}");
        
    }
}