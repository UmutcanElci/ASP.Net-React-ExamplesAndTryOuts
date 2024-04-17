using Example1.Models;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.AspNetCore.Mvc;


namespace Example1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class YoutubeController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetChannelVideos()
    {
        var youtubeService = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey = "AIzaSyCTj2_3OLm67B4lc1YlBjp1ioGk82fo634",
            ApplicationName = "Trys",
        });
        var searchRequest = youtubeService.Search.List("snippet");
        searchRequest.ChannelId = "UCq8LldVrjqe61KQttZlLW8g";
        searchRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
        
        var searchResponse = await searchRequest.ExecuteAsync();

	var videoList = searchResponse.Items.Select(item => new VideoDetails
			{
			Title = item.Snippet.Title,
			Link = $"https://www.youtube.com/watch?v={item.Id.VideoId}",
			Thumbnail = item.Snippet.Thumbnails.Medium.Url,
			PublishedAt = item.Snippet.PublishedAtDateTimeOffset
			})
	.OrderByDescending(video => video.PublishedAt)
		.ToList();

        return Ok(videoList);
    }
}
