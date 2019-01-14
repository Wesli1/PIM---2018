using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pim_final_2
{
    class Dao_Aluno
    {
        MySqlConnection objCnx;

        public Dao_Aluno()
        {
            objCnx = new MySqlConnection("Server=localhost;Database=bd_pim2;user=root;pwd=root");

        }

        public void create(Aluno A)
        {
            string cmdSql = "INSERT INTO aluno (responsavel_cpf, nome, ra, senha, datanascimento, idade, endereco, telefone, turma_cod) VALUES(";
            cmdSql += "" + A.cpf_resp + ",";
            cmdSql += "'" + A.Nome + "',";
            cmdSql += "" + A.RA + ",";
            cmdSql += "'" + A.senha + "',";
            cmdSql += "'" + A.DataNasc + "',";
            cmdSql += "" + A.Idade + ",";
            cmdSql += "'" + A.Endereco + "',";
            cmdSql += "" + A.Telefone + ",";
            cmdSql += "'" + A.Turma + "');";

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            try
            {
                objCnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                objCnx.Close();
            }
        }

        public Aluno read(Aluno A)
        {
            string cmdSql = "select * from aluno where ra=" + A.RA;

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            try
            {
                objCnx.Open();
                MySqlDataReader objDados = cmd.ExecuteReader();

                while (objDados.Read())
                {
                    A.cpf_resp = Convert.ToInt32(objDados["responsavel_cpf"]);
                    A.Nome = Convert.ToString(objDados["nome"]);
                    A.RA = Convert.ToInt32(objDados["ra"]);
                    A.senha = Convert.ToString(objDados["senha"]);
                    A.DataNasc = Convert.ToString(objDados["datanascimento"]);
                    A.Idade = Convert.ToInt32(objDados["idade"]);
                    A.Endereco = Convert.ToString(objDados["endereco"]);
                    A.Telefone = Convert.ToInt32(objDados["telefone"]);
                    A.Turma = Convert.ToString(objDados["turma_cod"]);
                }
                return A;
            }
            catch
            {
                return null;
            }
            finally
            {
                objCnx.Close();
            }

        }

        public void update(Aluno A)
        { 

            string cmdSql = "update aluno set ";
            //cmdSql += "responsavel_cpf =" + A.cpf_resp + ", ";
            cmdSql += "nome = '" + A.Nome + "', ";
            cmdSql += "senha = '" + A.senha + "', ";
            cmdSql += "datanascimento = '" + A.DataNasc + "', ";
            cmdSql += "idade =" + A.Idade + ", ";
            cmdSql += "endereco = '" + A.Endereco + "', ";
            cmdSql += "telefone =" + A.Telefone + ", ";
            cmdSql += "turma_cod ='" + A.Turma + "' ";
            cmdSql += "where RA =" + A.RA;

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);
            MySqlDataReader ler;

            try
            {
                objCnx.Open();
                ler = cmd.ExecuteReader();
            }
            catch
            {

            }
            finally
            {
                objCnx.Close();
            }


        }

        public void delete(Aluno A)
        {
            string cmdSql = "DELETE FROM aluno  WHERE RA = " + A.RA;

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            try
            {
                objCnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                objCnx.Close();
            }
        }

        public List<Aluno> lista_aluno()
        {
            string cmdSql = "select * from aluno";

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            List<Aluno> listaAluno = new List<Aluno>();

            try
            {
                objCnx.Open();
                MySqlDataReader ler = cmd.ExecuteReader();

                while(ler.Read()){
                    listaAluno.Add(new Aluno()
                    {
                        cpf_resp = Convert.ToInt32(ler["responsavel_cpf"]),
                        Nome = Convert.ToString(ler["nome"]),
                        RA = Convert.ToInt32(ler["ra"]),
                        senha = Convert.ToString(ler["senha"]),
                        DataNasc = Convert.ToString(ler["datanascimento"]),
                        Idade = Convert.ToInt32(ler["idade"]),
                        Endereco = Convert.ToString(ler["endereco"]),
                        Telefone = Convert.ToInt32(ler["telefone"]),
                        Turma = Convert.ToString(ler["turma_cod"])
                });
                }       

                if (listaAluno.Count() > 0)
                {
                    return listaAluno;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                objCnx.Close();
            }

        }
        public List<Aluno> lista_aluno_turma(Aluno A)
        {
            string cmdSql = "select * from aluno where turma_cod = " + "'" + A.Turma + "'";

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            List<Aluno> listaAluno = new List<Aluno>();

            try
            {
                objCnx.Open();
                MySqlDataReader ler = cmd.ExecuteReader();

                while (ler.Read())
                {
                    listaAluno.Add(new Aluno()
                    {
                        cpf_resp = Convert.ToInt32(ler["responsavel_cpf"]),
                        Nome = Convert.ToString(ler["nome"]),
                        RA = Convert.ToInt32(ler["ra"]),
                        senha = Convert.ToString(ler["senha"]),
                        DataNasc = Convert.ToString(ler["datanascimento"]),
                        Idade = Convert.ToInt32(ler["idade"]),
                        Endereco = Convert.ToString(ler["endereco"]),
                        Telefone = Convert.ToInt32(ler["telefone"]),
                        Turma = Convert.ToString(ler["turma_cod"])
                    });
                }

                if (listaAluno.Count() > 0)
                {
                    return listaAluno;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                objCnx.Close();
            }

        }

    }
}
