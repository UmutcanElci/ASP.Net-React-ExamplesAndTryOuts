using Microsoft.AspNetCore.SignalR;

namespace ReactPlayerProjectTryOut.Hubs;

public class VideoPlayerHub : Hub
{
    public async Task SendPlayStatus(bool isPlaying)
    {
        await Clients.All.SendAsync("ReceivePlayStatus",isPlaying);
    }
}