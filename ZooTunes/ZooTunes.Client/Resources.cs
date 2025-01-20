using MudBlazor;

namespace ZooTunes.Client;

public class Resources
{
    public static readonly MudTheme ApplicationTheme = new()
    {
        PaletteDark = new PaletteDark()
        {
            Background = Colors.Shades.Black,
            
            Primary = "#FFFFFF",
            PrimaryContrastText = "#000000"
        }
    };

    public const bool isDarkMode = true;
}