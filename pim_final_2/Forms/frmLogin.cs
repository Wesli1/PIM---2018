using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim_final_2.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "admin" && txtPass.Text == "admin")
            {
                MessageBox.Show("Bem Vindo Admin", "MIDAYV");

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
            else if (txtLogin.Text !="midayv" && txtPass.Text !="tis")
            {
                MessageBox.Show("Erro : Usuário Inválido","MIDAYV: Erro !!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
            if (txtLogin.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Dados Inválidos","Erro !!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
