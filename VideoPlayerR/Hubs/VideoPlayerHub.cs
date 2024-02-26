using Microsoft.AspNetCore.SignalR;

namespace VideoPlayerR.Hubs;

public class VideoPlayerHub : Hub
{
    public async Task PlayVideo()
    {
        await Clients.All.SendAsync("PlayVideo");
    }

    public async Task PauseVideo()
    {
        await Clients.All.SendAsync("PauseVideo");
    }

    public async Task ChangeVideo(string url)
    {
        await Clients.All.SendAsync("ChangeVideo", url);
    }
}