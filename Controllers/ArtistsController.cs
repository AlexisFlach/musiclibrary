using Microsoft.AspNetCore.Mvc;

using webapi.Repositories;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistsController : ControllerBase
{
    private readonly IArtistsRepository _repository;

    public ArtistsController(IArtistsRepository repo)
    {
        _repository = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetArtists()
    {
        var artists = await _repository.GetArtists();

        return Ok(artists);
    }
}
