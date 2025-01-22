using Microsoft.AspNetCore.Components;

namespace ZooTunes.Client.Animals;

public partial class SmallAnimalDisplay : ComponentBase
{
    [Parameter]
    [EditorRequired]
    public required AnimalData AnimalData { get; set; }
}