namespace SpeedyAirLy;

using System.Data;
using System.Text.Json;
public class OrderRepository
{
    private const string DataUrl = "Data/coding-assigment-orders.json";
    public IList<Order> GetOrders(){

        string json = File.ReadAllText(DataUrl);
        //Console.WriteLine(json);
        var orderDictionary = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);

        var orders = new List<Order>();
        if (orderDictionary != null){
            foreach (var kvp in orderDictionary)
            {
                // TODO: check for errors
                var orderNumber = kvp.Key;

                var destination = kvp.Value.GetProperty("destination").GetString();

                var order = new Order
                {
                    Number = orderNumber,
                    Arrival = destination
                };

                orders.Add(order);
            }
        }
        return orders;
    }
}






