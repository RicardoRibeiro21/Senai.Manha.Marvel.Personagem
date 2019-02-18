using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
          private readonly string StringConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=MARVEL;User ID = sa; Password = 132";
        public void Gravar(PersonagemDomain personagem, int Id)
        {
            using(SqlConnection con = new SqlConnection(StringConexao))
            {
            string QueryInsert = "INSERT INTO PERSONAGENS (NOME, LANCAMENTO) VALUES (@NOME, @LANCAMENTO)";
                SqlCommand cmd = new SqlCommand(QueryInsert, con);
                cmd.Parameters.AddWithValue("@NOME", personagem.Nome);
                cmd.Parameters.AddWithValue("@LANCAMENTO", personagem.Lancamento);
                con.Open();
                cmd.ExecuteNonQuery();
               
            }
        }

        public List<PersonagemDomain> Listar()
        {
            List<PersonagemDomain> listPersonagem = new List<PersonagemDomain>();
            using (SqlConnection con = new SqlConnection(StringConexao)) { 
            string QueryListar = "SELECT ID, NOME, LANCAMENTO FROM PERSONAGENS";
                con.Open();
                SqlDataReader sqr;

                using(SqlCommand cmd = new SqlCommand(QueryListar, con))
                {
                    sqr = cmd.ExecuteReader();
                    if (sqr.HasRows)
                    {
                        while (sqr.Read())
                        {
                            PersonagemDomain personagem = new PersonagemDomain()
                            {
                                Id = Convert.ToInt32(sqr["ID"]),
                                Nome = (sqr["NOME"]).ToString(),
                                Lancamento = (sqr["LANCAMENTO"]).ToString()
                            };
                            listPersonagem.Add(personagem);
                        }
                        return listPersonagem;
                    }
                }
            }
            return null;
        }
    }
}
