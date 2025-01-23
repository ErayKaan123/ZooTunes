using Microsoft.AspNetCore.Components;
using MudBlazor;
using ZooTunes.Client.Dialog;

namespace ZooTunes.Client.Animals;

public partial class SmallAnimalDisplay : ComponentBase
{
    [Parameter] [EditorRequired] public required AnimalData AnimalData { get; set; }

    private void ToggleFavorite()
    {
        AnimalData.IsFavorite = !AnimalData.IsFavorite;
        var result = AnimalData.IsFavorite ? "The animal is now a favorite" : "The animal is not a favorite anymore";
        snackbar.Add(result, Severity.Success);     
        StateHasChanged();
    }

    public async Task OpenAnimalDescription()
    {
        var parameters = new DialogParameters<DescriptionDialog> { { x => x.Content, AnimalData.Description } };
        await dialogService.ShowAsync<DescriptionDialog>("Description", parameters: parameters);
    }
}