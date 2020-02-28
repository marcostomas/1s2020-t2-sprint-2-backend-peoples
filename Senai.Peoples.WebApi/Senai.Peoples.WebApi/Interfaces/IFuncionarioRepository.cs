using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface IFuncionarioRepository
    {
        //Lista Por ID
        List<FuncionariosDomain> Listar();

        //Busca o funcionario pelo seu ID
        FuncionariosDomain BuscarPorId(int id);

        //Busca pelo nome do funcionário
        FuncionariosDomain BuscarPorNome(string nome);

        //Busca pelo nome completo do funcionário
        FuncionariosDomain BuscarPorNomeCompleto(string nome);

        //Insere novos funcionários no sistema
        void Cadastrar(FuncionariosDomain funcionario);

        //Atualiza os daddos de um funcionario ao passar o ID pelo Corpo
        void AtualizarIdCorpo(FuncionariosDomain funcionario);

        //Atualiza os dados de um funcionario ao passar o ID pela URL
        void AtualizarIdUrl(int id, FuncionariosDomain funcionario);

        //Deleta os dados de um funcionario
        void Deletar(int id);
    }
}
