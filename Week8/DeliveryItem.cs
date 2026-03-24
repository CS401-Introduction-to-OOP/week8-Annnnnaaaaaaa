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

    public virtual string PrintInfo()
    {
        return $"Tracking number: {trackingNumber}, weight: {weight}";
    }
}