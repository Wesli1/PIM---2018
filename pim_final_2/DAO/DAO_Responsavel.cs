using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pim_final_2
{
    class DAO_Responsavel
    {
        MySqlConnection objCnx;

        public DAO_Responsavel(){

            objCnx = new MySqlConnection("Server=localhost;Database=bd_pim2;user=root;pwd=root");
            
        }
        public void create(Responsavel r)
        {
            string cmdSql = "INSERT INTO responsavel (responsavel_1, cpf_1, rg_1, responsavel_2, cpf_2, rg_2) VALUES(";
            cmdSql += "'" + r.Responsavel_1 + "',";
            cmdSql += "" + r.CPF_1 + ",";
            cmdSql += "" + r.RG_1 + ",";
            cmdSql += "'" + r.Responsavel_2 + "',";
            cmdSql += "" + r.CPF_2 + ",";
            cmdSql += "" + r.RG_2 + ");";

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
        public Responsavel read(Responsavel R)
        {
            string cmdSql = " select * from responsavel where cpf_1 =" + R.CPF_1;

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            try
            {
                objCnx.Open();
                MySqlDataReader objDados = cmd.ExecuteReader();

                while (objDados.Read())
                {
                    R.Responsavel_1 = Convert.ToString(objDados["responsavel_1"]);
                    R.CPF_1 = Convert.ToInt32(objDados["cpf_1"]);
                    R.RG_1 = Convert.ToInt32(objDados["rg_1"]);
                    R.Responsavel_2 = Convert.ToString(objDados["responsavel_2"]);
                    R.CPF_2 = Convert.ToInt32(objDados["cpf_2"]);
                    R.RG_2 = Convert.ToInt32(objDados["rg_2"]);
                }
                return R;
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

        public void update(Responsavel R)
        {

            string cmdSql = "update responsavel set ";
            cmdSql += "responsavel_1 = '" + R.Responsavel_1 + "',";
            cmdSql += " rg_1 = " + R.RG_1 + ",";
            cmdSql += " responsavel_2 = '" + R.Responsavel_2 + "',";
            cmdSql += " cpf_2 = " + R.CPF_2 + ",";
            cmdSql += " rg_2 = " + R.RG_2 + "";
            cmdSql += " where cpf_1 =" + R.CPF_1;

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

        public void delete(Responsavel r)
        {
            string cmdSql = "DELETE FROM responsavel  WHERE cpf_1 = " + r.CPF_1;

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

        public List<Responsavel> lista_responsaveis()
        {
            string cmdSql = "select * from responsavel";

            MySqlCommand cmd = new MySqlCommand(cmdSql, objCnx);

            List<Responsavel> listaResponsaveis = new List<Responsavel>();

            try
            {
                objCnx.Open();
                MySqlDataReader ler = cmd.ExecuteReader();

                while (ler.Read())
                {
                    listaResponsaveis.Add(new Responsavel()
                    {
                        Responsavel_1 = Convert.ToString(ler["responsavel_1"]),
                        CPF_1 = Convert.ToInt32(ler["cpf_1"]),
                        RG_1 = Convert.ToInt32(ler["rg_1"]),
                        Responsavel_2 = Convert.ToString(ler["responsavel_1"]),
                        CPF_2 = Convert.ToInt32(ler["cpf_1"]),
                        RG_2 = Convert.ToInt32(ler["rg_1"])

                    });
                }
                if (listaResponsaveis.Count() > 0)
                {
                    return listaResponsaveis;
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
