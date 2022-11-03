using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class TodoIthem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime Finish { get; set; }
        
        public List<SubTask> Users { get; set; } = new List<SubTask>();
        
        
        [ForeignKey("Status")]
        [Required]
        public int StatusId { get; set; }
    }
}

