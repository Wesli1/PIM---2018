using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim_final_2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.frmLogin login = new Forms.frmLogin();
            login.ShowDialog();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsulta ListarAlunos = new frmConsulta("Alunos");
            ListarAlunos.ShowDialog();

            
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsulta ListarAlunos = new frmConsulta("Turmas");
            ListarAlunos.ShowDialog();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área em Desenvolvimento !!", "MIDAYV: Desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPedagogico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área em Desenvolvimento !!", "MIDAYV: Desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmdResponsa_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmConsulta ListarAlunos = new frmConsulta("Responsaveis");
            ListarAlunos.ShowDialog();
        }
    }
}
