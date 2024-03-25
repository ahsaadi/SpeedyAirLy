

namespace SpeedyAirLy;

public class OrderService{
    public void GenerateFlightItineraries(IList<Order> batch){
        var flightList = new FlighRepository().GetFlights();
        var flightByArrival = new Dictionary<string, List<Flight>>();
        foreach(var flight in flightList){
            if (flight.ArrivalCity == null)
                continue;
            if (flightByArrival.ContainsKey(flight.ArrivalCity)){
                flightByArrival[flight.ArrivalCity].Add(flight);
            }
            else{
                flightByArrival[flight.ArrivalCity] = new List<Flight>{flight};
            }
        }
        foreach(var order in batch){
            if (order.Arrival == null 
                || !flightByArrival.ContainsKey(order.Arrival)){
                continue;
            }

            foreach(var flight in flightByArrival[order.Arrival])
            {
                if (flight.Loaded < flight.Capacity){
                    order.Schedule = flight;
                    flight.Loaded += 1;

                   // Console.WriteLine(flight.Loaded);
                    break;
                }
            }

        }

        foreach(var order in batch){
            Console.WriteLine(order);
        }

    }
}