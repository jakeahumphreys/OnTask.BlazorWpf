using System;

namespace OnTask.BlazorWpf.Data.Activities.DTO;

public sealed class AddCommentDto
{
    public Guid ParentId { get; set; }
    public string Comment { get; set; }
}