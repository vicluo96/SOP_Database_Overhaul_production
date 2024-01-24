using API.Controllers;
using Application.T10;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API;

public class T10Controller : BaseApiController
{

    [HttpPost] //api/t10
    public async Task<IActionResult> CreateScholarship(Create.Command command)
    {
        if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }
        await Mediator.Send(command);
        return Ok();
    }

}