namespace SpeedyAirLy;

public class Flight{
    public int? Number {get; set;}
    public string? DepartureCity {get; set;}
    public string? ArrivalCity {get; set;}
    public int? Day {get; set;}

    public override string ToString() => 
        $"Flight: {Number}, departure: {DepartureCity}, arrival: {ArrivalCity}, day: {Day}";
}
