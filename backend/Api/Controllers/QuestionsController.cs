using InterviewBetter.Application.Services;
using InterviewBetter.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewBetter.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionService _service;

    public QuestionsController(IQuestionService service) => _service = service;

    [HttpGet]
    public IActionResult GetAll([FromQuery] string? category)
    {
        var result = string.IsNullOrEmpty(category) 
            ? _service.GetAll() 
            : _service.GetByCategory(category);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var question = _service.GetById(id);
        return question == null ? NotFound() : Ok(question);
    }
}
