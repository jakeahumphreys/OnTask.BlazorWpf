using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnTask.BlazorWpf.Data.Activities;

namespace OnTask.BlazorWpf.Data.Tasks;

public class Task
{
    public Task()
    {
        Activities = new List<Activity>();
    }
    
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Status { get; set; }
    public List<Activity> Activities { get; set; }
}