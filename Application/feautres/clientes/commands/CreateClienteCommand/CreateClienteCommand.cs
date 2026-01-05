using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Application.wrappers;
using Application.Interfaces;
using Domain.Entities;

namespace Application.feautres.clientes.commands.CreateClienteCommand
{
    public class CreateClienteCommand : IRequest<Response<int>>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }
    
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Cliente> _repositoryAsync;

        public CreateClienteCommandHandler(IRepositoryAsync<Cliente> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente = new Cliente
            {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                FechaNacimiento = request.FechaNacimiento,
                Telefono = request.Telefono,
                Email = request.Email,
                Direccion = request.Direccion
            };

            var data = await _repositoryAsync.AddAsync(cliente, cancellationToken);
            return new Response<int>(data.Id, "Cliente creado exitosamente");
        }
    }
}
