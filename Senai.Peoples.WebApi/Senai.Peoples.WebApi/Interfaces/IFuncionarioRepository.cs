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
        List<Funcionarios> Listar();

        //Busca o funcionario pelo seu ID
        Funcionarios BuscarPorId(int id);

        //Busca pelo nome do funcionário
        Funcionarios BuscarPorNome(string nome);

        //Busca pelo nome completo do funcionário
        Funcionarios BuscarPorNomeCompleto(string nome);

        //Insere novos funcionários no sistema
        void Cadastrar(Funcionarios funcionario);

        //Atualiza os daddos de um funcionario ao passar o ID pelo Corpo
        void AtualizarIdCorpo(Funcionarios funcionario);

        //Atualiza os dados de um funcionario ao passar o ID pela URL
        void AtualizarIdUrl(int id, Funcionarios funcionario);

        //Deleta os dados de um funcionario
        void Deletar(int id);
    }
}
