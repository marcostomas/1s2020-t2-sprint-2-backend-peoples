using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class FuncionariosDomain
    {
        public int idFuncionario { get; set; }

        public string NomeFuncionario { get; set; }

        public string SobrenomeFuncionario { get; set; }

        public DateTime DataNascimento { get; set; }

        public int idUsuario { get; set; }
    }
}
