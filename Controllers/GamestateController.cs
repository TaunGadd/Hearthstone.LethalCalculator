﻿using Hearthstone.LethalCalculator.Application.Interfaces;
using Hearthstone.LethalCalculator.Models.dtos;
using Microsoft.AspNetCore.Mvc;

namespace Hearthstone.LethalCalculator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamestateController : ControllerBase
{
    readonly IGamestateApplication _gamestateApplication;

    public GamestateController(IGamestateApplication gamestateApplication)
    {
        _gamestateApplication = gamestateApplication;
    }

    [HttpPost(Name = "IsLethal")]
    public IActionResult IsLethal([FromBody] GamestateDto dto)
    {
        // TODO handle errors
        var result = _gamestateApplication.IsLethal(dto);
        return Ok(result);
    }
}
