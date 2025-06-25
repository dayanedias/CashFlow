﻿using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    //[ProducesResponseType(typeof(), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        var useCase = new RegisterExpensesUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
        /*
        try
        {
            var useCase = new RegisterExpensesUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ErrorOnValidationException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Errors);

            return BadRequest(errorResponse);
        }
        catch
        {
            var errorResponse = new ResponseErrorJson("Unknown error");

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
        */
    }
}
