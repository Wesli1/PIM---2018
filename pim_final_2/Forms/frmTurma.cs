using pim_final_2.Forms;
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
    public partial class frmTurma : Form
    {
        ctrAluno ctrAluno;
        ctrTurma ctrTurma;
        ctrResponsavel ctrResp;
        Aluno A;
        Responsavel R;
        Turma T;

        public frmTurma()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar consul = new frmConsultar("Turma");
            consul.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRepTurma.Enabled = true;
            txtNmTurma.Enabled = true;
            
            cmdCad.Visible = true;
            cmdCancel.Visible = true;
            cmdClear.Visible = true;

            txtRepTurma.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            Forms.Limpar_Obj limpar = new Forms.Limpar_Obj();
            limpar.Limpar_Campos(this);

            txtRepTurma.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Forms.Limpar_Obj limpar = new Forms.Limpar_Obj();
            limpar.Limpar_Campos(this);


            txtRepTurma.Enabled = false;
            txtNmTurma.Enabled = false;
            
            cmdCad.Visible = false;
            cmdCancel.Visible = false;
            cmdClear.Visible = false;

            txtRepTurma.Focus();
        }

        private void cmdCad_Click(object sender, EventArgs e)
        {
            T = new Turma();
            ctrTurma = new ctrTurma();

            T.Nome_Turma = txtNmTurma.Text;
            T.Responsavel_Turma = txtRepTurma.Text;
            T.Idade = Convert.ToInt32(txtIdade.Text);

            ctrTurma.Adicionar(T);
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consul = new frmConsulta("Turmas");
            consul.ShowDialog();
        }

        private void listarAlunosNasTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunosTurmas AlunoTurma = new frmAlunosTurmas();
            AlunoTurma.ShowDialog();
        }
    }
}
