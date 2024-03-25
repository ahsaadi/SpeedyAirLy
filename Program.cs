namespace SpeedyAirLy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will run User Stories 1 and 2");
        //User Story 1
        new FlightService().ListLoadedFlightsSchedule();
    }
}
