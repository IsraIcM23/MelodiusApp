using MelodiusDataTrasnfer.DTOS;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSongs()
        {
            try
            {
                var users = await _albumService.GetAllAlbumsAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSongById(int id)
        {
            var song = await _albumService.GetAlbumByIdAsync(id);
            return Ok(song);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSong(AlbumDto album)
        {
            try
            {
                var result = await _albumService.CreateAlbumAsync(album);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSong(AlbumDto album)
        {
            var result = await _albumService.UpdateAlbumAsync(album);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSong(int id)
        {
            var result = await _albumService.DeleteAlbumAsync(id);
            return Ok(result);
        }



    }
}
