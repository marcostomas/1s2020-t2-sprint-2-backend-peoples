using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        //Administrator Functions

        List<TipoUsuarioDomain> Listar();

        TipoUsuarioDomain BuscarPorId(int id);

        void AtualizarIdUrl(int id, TipoUsuarioDomain tipoFuncionario);

        void Deletar(int id);

    }
}
