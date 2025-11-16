using Nomirun.Sdk.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace Accounts.Infrastructure.HttpApi.v1;

[Route("api")]
public class AccountsController : NomirunApiController
{
    private readonly ILogger<AccountsController> _logger;

    public AccountsController(ILogger<AccountsController> logger) : base(logger)
    {
        _logger = logger;
    }

    [HttpGet("accounts/{accountId}")]
    public async Task<IActionResult> GetAccount([FromRoute] long accountId)
    {
        return Ok();
    }
}