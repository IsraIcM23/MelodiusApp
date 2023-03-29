using MelodiusDataTrasnfer.DTOS;
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

        [HttpGet]
        public async Task<IActionResult> GetAllPlayListsAsync()
        {
            var playLists = await _playlistService.GetAllPlayListsAsync();
            return Ok(playLists);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPlayListByIdAsync(int id)
        {
            var playList = await _playlistService.GetPlayListByIdAsync(id);
            return Ok(playList);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayListAsync([FromBody] PlayListDto playListDto)
        {
            var playList = await _playlistService.CreatePlayListAsync(playListDto);
            return Ok(playList);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlayListAsync([FromBody] PlayListDto playListDto)
        {
            var playList = await _playlistService.UpdatePlayListAsync(playListDto);
            return Ok(playList);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletePlayListAsync(int id)
        {
            var playList = await _playlistService.DeletePlayListAsync(id);
            return Ok(playList);
        }



    }
}
