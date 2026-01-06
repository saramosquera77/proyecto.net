using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.feautres.clientes.commands.CreateClienteCommand
{
    public class CreateClienteCommandHandlerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryAsync<Cliente>? _repositoryAsync;
    }
}