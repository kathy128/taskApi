using System.ComponentModel.DataAnnotations;

namespace TaskApi.models;

public class Task{
    [Key] 
    public Int32 Id { get; set; }
    
    public string Title { get; set; }
    public string Description { get; set; }
    public Int32 Complete { get; set; }
} 