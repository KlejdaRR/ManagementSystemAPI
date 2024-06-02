using Microsoft.CodeAnalysis;

namespace ManagementSystemAPI.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
