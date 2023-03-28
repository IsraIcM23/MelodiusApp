using MelodiusServices.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlayListService _playlistService;

        public PlaylistController(IPlayListService playlistService)
        {
            _playlistService = playlistService;
        }

    }
}
