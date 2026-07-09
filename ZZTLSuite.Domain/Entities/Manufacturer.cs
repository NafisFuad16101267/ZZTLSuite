namespace ZZTLSuite.Domain.Entities
{
    public class Manufacturer : BaseEntity
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }

        public ICollection<ProductModel> ProductModels { get; set; }
    }
}
