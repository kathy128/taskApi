namespace TaskApi.models;

public class Task{
    public long Id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public bool complete { get; set; }
} 