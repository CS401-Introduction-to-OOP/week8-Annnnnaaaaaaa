namespace Week8;

class Program
{
    static void Main()
    {
        Letter letter1 = new Letter("let1111", 0.1);
        Letter letter2 = new Letter("let2222", 0.3);
        Parcel parcel1 = new Parcel("par1111", 2.5, "30x20x15");
        Parcel parcel2 = new Parcel("par2222", 5.0, "50x40x30");

        letter1.PrintInfo();
        parcel1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        Console.WriteLine($"Total delivery cost: {myCargo.GetTotalCost()}");
    }
}    