using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        //Common User Functions

        void Cadastrar(UsuariosDomain usuario);

        //Administrator Functions

        List<UsuariosDomain> Listar();

        UsuariosDomain BuscarPorId(int id);

        void AtualizarIdUrl(int id, UsuariosDomain usuario);

        void Deletar(int id);

    }
}
