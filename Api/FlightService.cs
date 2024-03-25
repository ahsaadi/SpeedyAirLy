using Microsoft.VisualBasic;

namespace SpeedyAirLy;

public class FlightService{
    public void ListLoadedFlightsSchedule(){
        var flightList = new FlighRepository().GetFlights();
        foreach(var flight in flightList){
            Console.WriteLine(flight);
        }

    }
}