using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private string StringConexao = "Data Source=DEV801\\SQLEXPRESS; initial catalog= M_Peoples; user Id=sa; pwd=sa@132";

        
        //Listar Funcionarios Existentes
        public List<Funcionarios> Listar()
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();

            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryListar = "SELECT NomeFuncionario, SobrenomeFuncionario FROM Funcionarios";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(queryListar, conn))
                {
                    reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Funcionarios funcionario = new Funcionarios
                        {
                            idFuncionario = Convert.ToInt32(reader[0]),
                            NomeFuncionario = reader["Nome"].ToString()
                        };

                        funcionarios.Add(funcionario);
                    }
                }
            }

            return funcionarios;
        }

        //

    }
}
