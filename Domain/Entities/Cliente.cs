using Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cliente : AuditableBaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;

        public int Edad
        {
            get
            {
                if (FechaNacimiento == default(DateTime))
                    return 0;
                
                return new DateTime(DateTime.Now.Subtract(FechaNacimiento).Ticks).Year - 1;
            }
        }
    }
}
