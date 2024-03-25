namespace SpeedyAirLy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nRunning User Stories 1:\n");
        //User Story 1
        new FlightService().ListLoadedFlightsSchedule();

         Console.WriteLine("\nRunning User Stories 2:\n");
        //User Story 2
        var bach = new OrderRepository().GetOrders();
        new OrderService().GenerateFlightItineraries(bach);
    }
}
