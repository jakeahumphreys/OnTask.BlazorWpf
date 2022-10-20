using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Pages.Dialogs;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages;

public partial class Index
{
    [Inject] private CollectionService CollectionService { get; set; }
    [Inject] private IDialogService DialogService { get; set; }
    [Inject] private NavigationManager NavigationManager { get; set; }
    
    private List<Collection> Collections { get; set; }
    
    protected override void OnInitialized()
    {
        Collections = CollectionService
            .GetAllCollections()
            .Where(x => x.IsArchived == false)
            .OrderByDescending(x => x.IsFocused)
            .ToList();
    }

    private void OpenDialog()
    {
        var options = new DialogOptions {CloseOnEscapeKey = true};
        DialogService.Show<CreateCollectionDialog>("Dialog", options);
    }

    private void OpenCollection(Guid collectionId)
    {
        NavigationManager.NavigateTo($"/Collection/{collectionId.ToString()}");
    }
}