namespace Core.Domain.Entities
{
    public record Category
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Order { get; set; }
    }
}
