using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webapi.Dtos;
using webapi.Repositories;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class VinylsController : ControllerBase
{

    private readonly IVinylRepository _repository;

    public VinylsController(IVinylRepository repo)
    {
        _repository = repo;
    }
    // Get vinyls
    [HttpGet]
    public async Task<IActionResult> GetVinyls()
    {
        var vinyls = await _repository.GetVinyls();

        return Ok(vinyls);
    }

    // Get Details(artist) of specifik vinyl
    // api/vinyls/1/details
    [Route("{id:int}/details")]
    public async Task<ActionResult<ArtistDto>> GetArtist(int id)
    {
        var artist = await _repository.GetArtist(id);

        return Ok(artist);
    }
}
