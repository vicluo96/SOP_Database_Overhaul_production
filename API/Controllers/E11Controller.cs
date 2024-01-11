using API.Controllers;
using Application.E11;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API;

public class E11Controller : BaseApiController
{
    [HttpGet] //api/e11
    public async Task<ActionResult<List<Studentbasic>>> GetScholarships()
    {
        return await Mediator.Send(new List.Query());
    }

    [HttpGet("{id}")] //api/e11/$id
    //fix later
    public async Task<ActionResult<Studentbasic>> GetScholarship(string StudentId)
    {
        return await Mediator.Send(new Details.Query{StudentId = StudentId});
    }

    [HttpPost]
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

