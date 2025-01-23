using Microsoft.AspNetCore.Components;
using MudBlazor;
using ZooTunes.Client.Dialog;

namespace ZooTunes.Client.Animals;

public partial class SmallAnimalDisplay : ComponentBase
{
    [Parameter] [EditorRequired] public required AnimalData AnimalData { get; set; }
    [Parameter] public EventCallback OnStateChanged { get; set; }

    private void ChangeState()
    {
        // Change some state
        // Notify the parent
        StateHasChanged();
        OnStateChanged.InvokeAsync();
    }

    private void ToggleFavorite()
    {
        AnimalData.IsFavorite = !AnimalData.IsFavorite;
        var result = AnimalData.IsFavorite ? "The animal is now a favorite" : "The animal is not a favorite anymore";
        snackbar.Add(result, Severity.Success);
        ChangeState();
    }

    public async Task OpenAnimalDescription()
    {
        var parameters = new DialogParameters<DescriptionDialog> { { x => x.Content, AnimalData.Description } };
        await dialogService.ShowAsync<DescriptionDialog>("Description", parameters: parameters);
    }
}