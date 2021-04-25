using System;

namespace Core.Domain.Entities
{
    public class Company
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public Uri Logo { get; set; }
    }
}
