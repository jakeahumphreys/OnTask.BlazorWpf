using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnTask.BlazorWpf.Data.Activities;
using OnTask.BlazorWpf.Data.Tasks;

namespace OnTask.BlazorWpf.Data.Collections;

public class Collection
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
    public virtual ICollection<Activity> Activities { get; set; }
    public bool IsFocused { get; set; }
    public bool IsArchived { get; set; }
}