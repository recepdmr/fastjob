namespace Core.Domain.Entities
{
    public record Location
    {
        public Place Country { get; set; }
        public Place City { get; set; }
        public Place District { get; set; }
        public Place Town { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
    }
}
