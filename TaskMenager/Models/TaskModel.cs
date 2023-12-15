using System.ComponentModel.DataAnnotations;

namespace TaskMenager.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string TaskTitle { get; set; }
        [Required]
        [MaxLength(150)]
        public string TaskDescription { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;  
    }
}
