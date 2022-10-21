using System.ComponentModel.DataAnnotations;

namespace OnTask.BlazorWpf.Pages.Dialogs.AddComment;

public sealed class AddCommentModel
{
    [Required]
    public string Comment { get; set; }
}