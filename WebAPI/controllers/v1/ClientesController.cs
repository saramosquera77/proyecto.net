using Application.feautres.clientes.commands.CreateClienteCommand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.controllers.v1
{
    [@ApiVersion("1.0")]
    public class ClientesController : BaseApiController 
    {
        [HttpPost]
        public async Task<IActionResult> post(CreateClienteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
