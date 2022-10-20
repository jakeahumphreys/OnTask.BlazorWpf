using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using OnTask.BlazorWpf.Pages.PageModels;
using OnTask.BlazorWpf.Services;

namespace OnTask.BlazorWpf.Pages.Dialogs;

public partial class CreateCollectionDialog
{
    
    [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
    
    [Inject] private CollectionService CollectionService { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }


    private CreateCollectionModel _model = new CreateCollectionModel();
    
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
        CollectionService.CreateCollection(_model);
        Submit();
        StateHasChanged();
        _navigationManager.NavigateTo("/", true);
    }
}