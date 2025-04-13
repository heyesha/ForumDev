﻿namespace ForumDev.Domain.Questions;

public class Answer
{
    public Guid Id { get; set; }
     
    public required Guid UserId { get; set; }
     
    public required string Text { get; set; }
     
    public required Question Question { get; set; }
    
    public required Answer Parent { get; set; }
    
    public List<Guid> Tags { get; set; } = [];
}