using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages;

public partial class Index
{
    [Inject] private CollectionService CollectionService { get; set; }
    
    private List<Collection> Collections { get; set; }
    
    protected override void OnInitialized()
    {
        Collections = CollectionService
            .GetAllCollections()
            .Where(x => x.IsArchived == false)
            .OrderByDescending(x => x.IsFocused)
            .ToList();
    }
}