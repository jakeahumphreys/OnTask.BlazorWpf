using System;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Pages.Dialogs.AddComment;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages;

public partial class CollectionPage
{
    private Collection _collection;
    [Parameter]
    public string Id { get; set; }
    
    private bool dense = false;
    
    [Inject] private CollectionService CollectionService { get; set; }
    [Inject] private IDialogService DialogService { get; set; }

    protected override void OnInitialized()
    {
        var parsedId = Guid.Parse(Id);
        _collection = CollectionService.GetCollectionById(parsedId); //This isn't very safe
    }

    private void AddComment()
    {
        var paramaters = new DialogParameters();
        paramaters.Add("ParentId", Id);
        paramaters.Add("isForCollection", true);
        paramaters.Add("ParentPage", this);

        var options = new DialogOptions() {CloseButton = true};
        DialogService.Show<AddCommentDialog>("Add Comment", paramaters, options);
        StateHasChanged();
    }

    public void RefreshState()
    {
        StateHasChanged();
    }
}