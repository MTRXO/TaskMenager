using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenagerModels
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
