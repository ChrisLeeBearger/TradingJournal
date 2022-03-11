﻿using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace TradingJournal.Server.Controllers;

// api controller base class utilizing mediator and inheriting from controller base class that has no view support
[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
    private ISender _mediator = null!;

    // if _mediator is null get it from httpcontext and assign it to the local variable
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}

