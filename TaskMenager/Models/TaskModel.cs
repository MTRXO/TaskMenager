using System.ComponentModel.DataAnnotations;

namespace TaskMenager.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TaskTitle { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;  
    }
}
