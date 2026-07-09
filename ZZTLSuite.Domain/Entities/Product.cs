namespace ZZTLSuite.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        public ICollection<ProductType> ProductTypes { get; set; }
    }
}
