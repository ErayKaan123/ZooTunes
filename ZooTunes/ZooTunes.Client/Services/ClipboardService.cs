using Microsoft.JSInterop;

namespace ZooTunes.Client.Services;

public class ClipboardService(IJSRuntime jsRuntime)
{
    public async Task CopyTextToClipboard(string text)
    {
        await jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}