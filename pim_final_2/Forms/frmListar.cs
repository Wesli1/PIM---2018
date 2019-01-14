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
    public partial class frmConsulta : Form
    {
        List<Aluno> Alunos;
        List<Responsavel> Responsaveis;
        List<Turma> Turmas;
        ctrAluno ctrAlu;
        ctrResponsavel ctrResp;
        ctrTurma ctrTu;
        
        public frmConsulta(string listagem)
        {
            InitializeComponent();
            comboBox1.Text = listagem;
            listarAlunosToolStripMenuItem.Visible = false;
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dtgBdados.Refresh();

            string Lista = comboBox1.Text;

            switch (Lista)
            {
                case "Alunos":
                    ctrAlu = new ctrAluno();
                    Alunos = ctrAlu.ListarAlunos();

                    dtgBdados.DataSource = Alunos;
                    break;

                case "Responsaveis":
                    ctrResp = new ctrResponsavel();
                    Responsaveis = ctrResp.ListarResponsaveis();

                    dtgBdados.DataSource = Responsaveis;
                    break;

                case "Turmas":
                    ctrTu = new ctrTurma();
                    Turmas = ctrTu.ListarTurmas();
                    listarAlunosToolStripMenuItem.Visible = true;

                    dtgBdados.DataSource = Turmas;
                    break;
            }

            
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Turmas")
            {
                this.Hide();
                frmTurma frmCadTurma = new frmTurma();
                frmCadTurma.ShowDialog();
            }


            this.Hide();
            frmResponsa frmRespo = new frmResponsa();
            frmRespo.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultar consultar = new frmConsultar("");
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

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAlunosTurmas AlunoTurma = new frmAlunosTurmas();
            AlunoTurma.ShowDialog();
        }
    }
}
