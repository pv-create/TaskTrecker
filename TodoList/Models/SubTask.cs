using System.ComponentModel.DataAnnotations;

namespace TodoList.Models;

public class SubTask
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public int TaskId { get; set; }
    public TodoIthem Task { get; set; }  
}