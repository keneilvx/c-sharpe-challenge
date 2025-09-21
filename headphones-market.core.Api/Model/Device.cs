namespace headphones_market.core.Api.Model
{
    public class Device
    {
        public string? Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageFileName { get; set; }

        public bool Wireless { get; set; }

        public decimal Weight { get; set; }

        public bool IsMechincal { get; set; }

    }
}
