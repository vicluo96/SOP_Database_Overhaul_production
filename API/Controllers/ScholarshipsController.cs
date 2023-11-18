using API.Controllers;
using Application;
using Application.Scholarships;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API;

public class ScholarshipsController : BaseApiController
{
    [HttpGet] //api/scholarships
    public async Task<ActionResult<List<Studentbasic>>> GetScholarships()
    {
        return await Mediator.Send(new List.Query());
    }

    [HttpGet("{id}")] //api/scholarships/$id
    //fix later
    public async Task<ActionResult<Studentbasic>> GetScholarship(string StudentId)
    {
        return await Mediator.Send(new Details.Query{StudentId = StudentId});
    }

    // [HttpPost]
    // public async Task<IActionResult> CreateScholarship(Studentbasic studentbasic)
    // {
    //     await Mediator.Send(new Create.Command {Studentbasic = studentbasic});
    //     return Ok();
    // }

    [HttpPost]
    public async Task<IActionResult> CreateScholarship(Studentbasic studentbasic)
    {
        await Mediator.Send(new Create.Command {Studentbasic = studentbasic});
        return Ok();
    }

    public async Task<IActionResult> CreateDetail(Studentdetail studentdetail){
        await Mediator.Send(new Create.Command {Studentdetail = studentdetail});
        return Ok();
    }

    public async Task<IActionResult> Create(Advising advising){
        await Mediator.Send(new Create.Command {Advising = advising});
        return Ok();
    }



}

