namespace afternoon.Models
{
    public class Vacation
    {
        public Vacation(string location, int price, string airline, int duration)
        {
        }

        public string Location { get; set; }
        public int Price { get; set; }
        public string Airline { get; set; }

        public int Duration { get; set; }
    }
}