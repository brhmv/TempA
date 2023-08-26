namespace SchoolBus.Models.Abstracts
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        
        public DateTime CreatedTime { get; set; }
        
        public DateTime ModifiedTime { get; set; }
    }
}