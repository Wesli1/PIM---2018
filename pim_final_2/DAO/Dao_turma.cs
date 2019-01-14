using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pim_final_2
{
    class Dao_turma
    {
        MySqlConnection objCnx;

        public Dao_turma()
        {
            objCnx = new MySqlConnection("Server=localhost;Database=bd_pim2;user=root;pwd=root");

        }

        public void create(Turma T)
        {
            string cmdSql = "INSERT INTO turma (cod, idade, professor) VALUES(";
            cmdSql += "'" + T.Nome_Turma + "',";
            cmdSql += "" + T.Idade + ",";
            cmdSql += "'" + T.Responsavel_Turma + "')";
            

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

        public Turma read(Turma T)
        {
            string cmdSql = " select * from turma where cod =" + "'" + T.Nome_Turma + "';";

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            try
            {
                objCnx.Open();
                MySqlDataReader objDados = cmd.ExecuteReader();

                while (objDados.Read())
                {
                    T.Nome_Turma = Convert.ToString(objDados["cod"]);
                    T.Idade = Convert.ToInt32(objDados["idade"]);
                    T.Responsavel_Turma= Convert.ToString(objDados["professor"]);
                    
                }
                return T;
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

        public void update(Turma T)
        {

            string cmdSql = "Update turma set ";
            //cmdSql += "cod = '" + T.Nome_Turma + "',";
            cmdSql += "idade = " + T.Idade + ",";
            cmdSql += "professor = '" + T.Responsavel_Turma + "' ";
            cmdSql += "where cod =" + "'" + T.Nome_Turma + "'";
            

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

        public void delete(Turma T)
        {
            string cmdSql = "DELETE FROM turma  WHERE cod = " + "'" + T.Nome_Turma + "'";

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

        public List<Turma> lista_turma()
        {
            string cmdSql = "select * from turma";

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            List<Turma> ListaTurma = new List<Turma>();

            try
            {
                objCnx.Open();
                MySqlDataReader ler = cmd.ExecuteReader();

                while (ler.Read())
                {
                    ListaTurma.Add(new Turma()
                    {
                        Nome_Turma = Convert.ToString(ler["cod"]),
                        Idade = Convert.ToInt32(ler["idade"]),
                        Responsavel_Turma = Convert.ToString(ler["professor"])
                    });
                }

                if (ListaTurma.Count() > 0)
                {
                    return ListaTurma;
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
