namespace headphones_market.core.Api.Model;

public class Headphone : Device
{
    public int Id { get; set; }
    public string Manufacturer { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public string Type { get; set; }
    public string BatteryLife { get; set; }
    public string NoiseCancellationType { get; set; }
    public string Weight { get; set; }
    public bool Mic { get; set; }
}