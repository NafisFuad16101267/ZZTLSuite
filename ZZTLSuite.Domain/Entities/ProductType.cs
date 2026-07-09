namespace ZZTLSuite.Domain.Entities
{
    public class ProductType : BaseEntity
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public ICollection<ProductModel> ProductModels { get; set; }
    }
}
