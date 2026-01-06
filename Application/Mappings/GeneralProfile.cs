using Application.feautres.clientes.commands.CreateClienteCommand;
using Domain.Entities;
using AutoMapper;

namespace Application.Mappings
{
   public class GeneralProfile : Profile    
   {
        public GeneralProfile()
        {
            #region Commands
            CreateMap<CreateClienteCommand, Cliente>();
            #endregion
        }


   }
}