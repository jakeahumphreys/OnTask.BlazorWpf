using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using OnTask.BlazorWpf.Data.Activities;
using OnTask.BlazorWpf.Data.Activities.DTO;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Pages.PageModels;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages.Dialogs.AddComment;

public partial class AddCommentDialog
{
    [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
    
    [Inject] private CollectionService CollectionService { get; set; }
    [Inject] private ActivityService ActivityService { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    
    [Parameter] public string? ParentId { get; set; }
    [Parameter] public bool IsForCollection { get; set; }


    private AddCommentModel _model = new AddCommentModel();
    
    private void Cancel()
    {
        MudDialog.Cancel();
    }

    private void Submit()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }

    private void OnValidSubmit(EditContext context)
    {
        var parsedId = Guid.Parse(ParentId);
        if (IsForCollection)
        {
            CollectionService.AddComment(new AddCommentDto
            {
                ParentId = parsedId,
                Comment = _model.Comment
            });
            
            _navigationManager.NavigateTo($"/Collections/{ParentId}");
            StateHasChanged();
            Submit();
        }
    } 
}