namespace NetCoreApi.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string? Names { get; set; }
        public string? Description { get; set; } = null;
    }
}
