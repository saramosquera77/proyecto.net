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
using AutoMapper;

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
        private readonly IRepositoryAsync<Cliente>? _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateClienteCommandHandler(IRepositoryAsync<Cliente>? repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }


        public async Task<Response<int>> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
          var nuenoRegistro = _mapper.Map<Cliente>(request);
            var data = await _repositoryAsync.AddAsync(nuenoRegistro);

            return new Response<int>(data.Id);
        }
    }
}
