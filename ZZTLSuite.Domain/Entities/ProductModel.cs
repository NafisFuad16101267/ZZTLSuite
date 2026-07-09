namespace ZZTLSuite.Domain.Entities
{
    public class ProductModel : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ProductModelName { get; set; }
        public string ProductModelImage { get; set; }
        public int ProductTypeId { get; set; }
        public int ManufactureId { get; set; }
        public ProductType ProductType { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public ICollection<Terminal> terminals { get; set; }  
    }
}
