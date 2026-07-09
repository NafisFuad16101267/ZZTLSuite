namespace ZZTLSuite.Domain.Entities
{
    public class Terminal : BaseEntity
    {
        public int Id { get; set; }
        public int TerminalName { get; set; }
        public string ProductSerialNo { get; set; }
        public int ProductModelId { get; set; }
        public ProductModel ProductModel { get; set; }

        public ICollection<Terminal> Terminals { get; set; }

    }
}
