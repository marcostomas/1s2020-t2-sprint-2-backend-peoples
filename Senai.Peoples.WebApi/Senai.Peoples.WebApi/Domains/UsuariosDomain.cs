using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class UsuariosDomain
    {
        public int idUsuario {get ; set;}

        public int idTipoUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        
    }
}
