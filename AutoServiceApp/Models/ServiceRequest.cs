namespace AutoServiceApp.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}