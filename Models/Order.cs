namespace SpeedyAirLy;

public class Order{
    // Order Number
    public string? Number {get; set;}

    // Scheduled Flight
    public Flight? Schedule {get; set;}

    // Arrival City
    public string? Arrival {get; set;}
  

    public override string ToString() { 
        if (Schedule == null)
            return $"order: {Number}, flightNumber: not scheduled";
        return $"order: {Number}, flightNumber: {Schedule.Number}, departure: {Schedule.DepartureCity}, arrival: {Schedule.ArrivalCity}, day: {Schedule.Day}";
    }
}

