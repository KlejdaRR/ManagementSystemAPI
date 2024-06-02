namespace ManagementSystemAPI.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }
        public string AssignedUserId { get; set; }
        //public ApplicationUser AssignedUser { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
