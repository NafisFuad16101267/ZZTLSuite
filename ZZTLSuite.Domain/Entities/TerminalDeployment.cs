namespace ZZTLSuite.Domain.Entities
{
    public class TerminalDeployment : BaseEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string TerminalId { get; set; }
        public Terminal Terminal { get; set; }
    }
}
