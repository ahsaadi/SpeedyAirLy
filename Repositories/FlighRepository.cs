namespace SpeedyAirLy;

public class FlighRepository
{
    public IList<Flight> GetFlights(){
        return new List<Flight>()
        {
            new (){Number = 1, DepartureCity = "YUL", ArrivalCity = "YYZ", Day = 1},
            new (){Number = 2, DepartureCity = "YUL", ArrivalCity = "YYC", Day = 1},
            new (){Number = 3, DepartureCity = "YUL", ArrivalCity = "YVR", Day = 1},
            new (){Number = 4, DepartureCity = "YUL", ArrivalCity = "YYC", Day = 2},
            new (){Number = 5, DepartureCity = "YUL", ArrivalCity = "YYZ", Day = 2},
            new (){Number = 6, DepartureCity = "YUL", ArrivalCity = "YVR", Day = 2},
     
        };
    }
}