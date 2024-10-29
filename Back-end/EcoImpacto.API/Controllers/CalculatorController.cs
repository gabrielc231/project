using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcoImpacto.Application.UseCases.Calculator;
using EcoImpacto.Communication.Requests;
using EcoImpacto.Communication.Responses;

namespace EcoImpacto.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCalculatorResultJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Calculator([FromBody] RequestCalculatorResultJson request)
    {
        var useCase = new RegisterCalculatorDataUseCase();

        var response = useCase.Execute(request);

        return Ok(response);
    }

}
