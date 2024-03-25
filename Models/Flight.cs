namespace SpeedyAirLy;

public class Flight{
    private const int MaxCapacity = 20;

    // Flight Number
    public int? Number {get; set;}

    // City of Departure
    public string? DepartureCity {get; set;}

    // City of Arrival
    public string? ArrivalCity {get; set;}

    // The flight Day
    public int? Day {get; set;}

    // Number of Boxes already loaded
    // To be replaced by the list of Orders
    public int Loaded {get; set;} = 0;

    // Max Capacity of the Flight
    public int Capacity {get; set;} = MaxCapacity;

    public override string ToString() => 
        $"Flight: {Number}, departure: {DepartureCity}, arrival: {ArrivalCity}, day: {Day}";
}
