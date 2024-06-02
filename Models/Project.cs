namespace ManagementSystemAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TaskModel> TasksModel { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
