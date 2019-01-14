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
    public partial class frmAlunosTurmas : Form
    {
        Aluno A;
        ctrAluno ctrAlu;
        List<Aluno> Alunos;
        public frmAlunosTurmas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            A = new Aluno();
            ctrAlu = new ctrAluno();

            A.Turma = txtProcurar.Text;   
            Alunos = ctrAlu.ListarAlunosTurmas(A);

            dataGridView1.DataSource = Alunos;

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmTurma frmTu = new frmTurma();
            frmTu.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultar consultar = new frmConsultar("Aluno");
            consultar.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }
    }
}
