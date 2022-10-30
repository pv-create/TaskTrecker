using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class TodoIthem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        
        [Key]
        [ForeignKey("Status")]
        public int StatusId { get; set; }
    }
}

