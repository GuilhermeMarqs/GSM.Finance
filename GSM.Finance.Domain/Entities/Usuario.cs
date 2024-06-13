using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Finance.Domain.Entities
{
    public class Usuario : Entity
    {

        public Guid PerfilId { get; set; }
        public virtual required Perfil Perfil { get; set; }
        public required string Login { get; set; }
        public required string Senha {  get; set; }  
        public required string Email { get; set; }

    }
}
