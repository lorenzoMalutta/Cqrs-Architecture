namespace Utils.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string? UserIn { get; set; }
        public string? UserUpd { get; set; }
        public DateTime? DateUtcIn { get; set; }
        public DateTime? DateUtcUpd { get; set; }
    }
}
