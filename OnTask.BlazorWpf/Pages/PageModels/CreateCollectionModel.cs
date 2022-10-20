using System.ComponentModel.DataAnnotations;

namespace OnTask.BlazorWpf.Pages.PageModels;

public class CreateCollectionModel
{
    [Required]
    public string Name { get; set; }
}