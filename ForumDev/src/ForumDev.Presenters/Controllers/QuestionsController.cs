using ForumDev.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ForumDev.Presenters.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateQuestionDto request, CancellationToken cancellationToken)
    {
        return Ok("Question has been created");
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync([FromQuery] GetQuestionsDto request, CancellationToken cancellationToken)
    {
        return Ok("Questions has been got");
    }

    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid request, CancellationToken cancellationToken)
    {
        return Ok("Question has been got");
    }
    
    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> UpdateAsync(
        [FromRoute] Guid questionId, 
        [FromBody] UpdateQuestionDto questionDto, 
        CancellationToken cancellationToken)
    {
        return Ok("Question has been updated");
    }
    
    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question has been updated");
    }

    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> SelectSolutionAsync(
        [FromRoute] Guid questionId, 
        [FromQuery] Guid answerId, 
        CancellationToken cancellationToken)
    {
        return Ok("Solution has been selected");
    }
    
    [HttpPost("{questionId:guid}/answers")]
    public async Task<IActionResult> AddAnswerAsync(
        [FromRoute] Guid questionId, 
        [FromBody] AddAnswerDto request, 
        CancellationToken cancellationToken)
    {
        return Ok("Answer has been added to question");
    }
}