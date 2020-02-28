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

        public void AtualizarIdCorpo(FuncionariosDomain funcionario)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryUpdate = "UPDATE Funcionarios SET NomeFuncionario = @Nome WHERE idFuncionario = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", funcionario.idFuncionario);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.NomeFuncionario);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, FuncionariosDomain funcionario)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryUpdateURL = "UPDATE Funcionarios SET NomeFuncionario = @Nome, SobrenomeFUncionario = @Sobrenome WHERE idFuncionario = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateURL, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.NomeFuncionario);
                    cmd.Parameters.AddWithValue("@Sobrenome", funcionario.SobrenomeFuncionario);
         
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Buscar Funcionario Por ID
        public FuncionariosDomain BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryBuscarPorId = "SELECT IdFuncionario, NomeFuncionario, SobrenomeFuncionario FROM Funcionarios WHERE idFuncionario = @ID";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(queryBuscarPorId, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain
                        {
                            idFuncionario = Convert.ToInt32(reader[0]),
                            NomeFuncionario = reader["NomeFuncionario"].ToString(),
                            SobrenomeFuncionario = reader["SobrenomeFuncionario"].ToString()
                        };

                        return funcionario;
                    }

                    return null;
                }
            }
        }

        //Buscar Funcionario Por Nome
        public FuncionariosDomain BuscarPorNome(string nome)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryBuscarPorNome = "SELECT NomeFuncionario, SobrenomeFuncionario FROM Funcionarios WHERE NomeFuncionario = @Nome";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(queryBuscarPorNome, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain
                        {
                            NomeFuncionario = reader["NomeFuncionario"].ToString(),
                            SobrenomeFuncionario = reader["SobrenomeFuncionario"].ToString()
                        };

                        return funcionario;
                    }

                    return null;
                }
            }
        }

        //Buscar Funcionario Por Nome
        public FuncionariosDomain BuscarPorNomeCompleto(string nome)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryBuscarPorNome = "SELECT NomeFuncionario, SobrenomeFuncionario FROM Funcionarios WHERE NomeFuncionario = @Nome";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(queryBuscarPorNome, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain
                        {
                            NomeFuncionario = reader["NomeFuncionario"].ToString(),
                            SobrenomeFuncionario = reader["SobrenomeFuncionario"].ToString()
                        };

                        return funcionario;
                    }

                    return null;
                }
            }
        }

        //Cadastrar Funcionários
        public void Cadastrar(FuncionariosDomain funcionario)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryInsert = "INSERT INTO Funcionarios (NomeFuncionario, SobrenomeFuncionario) VALUES (@NomeFuncionario, @SobrenomeFuncionario)";

                SqlCommand cmd = new SqlCommand(queryInsert, conn);

                cmd.Parameters.AddWithValue("@NomeFuncionario", funcionario.NomeFuncionario);
                cmd.Parameters.AddWithValue("@SobrenomeFuncionario", funcionario.SobrenomeFuncionario);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryDelete = "DELETE FROM Funcionarios WHERE idFuncionario = @ID";

                using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Listar Funcionarios Existentes
        public List<FuncionariosDomain> Listar()
        {
            List<FuncionariosDomain> funcionarios = new List<FuncionariosDomain>();

            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                string queryListar = "SELECT * FROM Funcionarios";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(queryListar, conn))
                {
                    reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain
                        {
                            idFuncionario = Convert.ToInt32(reader[0]),
                            NomeFuncionario = reader["NomeFuncionario"].ToString(),
                            SobrenomeFuncionario = reader["SobrenomeFuncionario"].ToString()
                        };

                        funcionarios.Add(funcionario);
                    }
                }
            }

            return funcionarios;
        }
    }
}
