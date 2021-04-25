namespace Core.Domain.Entities
{
    public record Contact
    {
        public string PhoneCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
