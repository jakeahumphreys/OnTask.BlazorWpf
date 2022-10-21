using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using OnTask.BlazorWpf.Data.Activities;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages.Dialogs.AddComment;

public partial class AddCommentDialog
{
    [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
    
    [Inject] private CollectionService CollectionService { get; set; }
    [Inject] private ActivityService ActivityService { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IMessageService MessageService { get; set; }

    [Parameter] public string? ParentId { get; set; }
    [Parameter] public bool IsForCollection { get; set; }
    [Parameter] public CollectionPage ParentPage { get; set; }


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
            ActivityService.AddActivity(new Activity
            {
                Content = _model.Comment,
                Id = Guid.NewGuid(),
                Type = (int)ActivityTypeEnum.Comment,
                CreatedAt = DateTime.Now,
                CollectionId = parsedId
            });
            
            // _navigationManager.NavigateTo($"/Collection/{ParentId}", true);
            SendMessage();
            Submit();
        }
    }

    private void SendMessage()
    {
        MessageService.SendMessage("StateHasChanged");
    }
}