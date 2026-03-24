namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List <T > _objects = new List <T>();
    
    public void AddItem (T sm_object)
    {
        _objects.Add (sm_object);
        Console.WriteLine($"Added: {sm_object.TrackingNumber}");
    }
    
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var sm_object in _objects)
        {
            totalCost += sm_object.CalculateCost();
        }
        return totalCost;
    }
}