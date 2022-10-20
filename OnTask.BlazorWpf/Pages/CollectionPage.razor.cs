using System;
using Microsoft.AspNetCore.Components;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages;

public partial class CollectionPage
{
    private Collection _collection;
    [Parameter]
    public string Id { get; set; }
    
    private bool dense = false;
    
    [Inject] private CollectionService CollectionService { get; set; }

    protected override void OnInitialized()
    {
        var parsedId = Guid.Parse(Id);
        _collection = CollectionService.GetCollectionById(parsedId); //This isn't very safe
    }
}