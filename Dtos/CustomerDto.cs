namespace ProductCatalog.Dtos
{
    public record CustomerDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string City { get; init; }
        public string PhoneNumber { get; init; }

    }
}