namespace Date.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
