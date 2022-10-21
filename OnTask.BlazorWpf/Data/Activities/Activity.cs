using System;
using System.ComponentModel.DataAnnotations;

namespace OnTask.BlazorWpf.Data.Activities;

public class Activity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Type { get; set; }
    public string Content { get; set; }
    public Guid? CollectionId { get; set; }
    public Guid? TaskId { get; set; }
}