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
    public partial class frmConsultar : Form
    {
        Aluno A;
        ctrAluno CtrAlu;
        Responsavel R;
        ctrResponsavel ctrResp;
        Turma T;
        ctrTurma ctrTu;
        string Opcao;
        public frmConsultar(string aux)
        {

            InitializeComponent();

            cbOpção.Text = aux;

            txtPrimeiro.Visible = false;
            txtSegundo.Visible = false;
            txtTerceiro.Visible = false;
            txtQuarto.Visible = false;
            txtQuinto.Visible = false;
            txtSexta.Visible = false;
            txtSetimo.Visible = false;
            txtOitavo.Visible = false;

            button3.Visible = false;

            lblOitavo.Text = "";
            lblSetimo.Text = "";
            lblSexta.Text = "";
            lblQuinta.Text = "";
            lblQuarto.Text = "";
            lblTerceira.Text = "";
            lblSegundo.Text = "";
            lblPrimeiro.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrimeiro.Visible = true;
            txtSegundo.Visible = true;
            txtTerceiro.Visible = true;
            txtQuarto.Visible = true;
            txtQuinto.Visible = true;
            txtSexta.Visible = true;
            txtSetimo.Visible = true;
            txtOitavo.Visible = true;

            lblOitavo.Text = "";
            lblSetimo.Text = "";
            lblSexta.Text = "";
            lblQuinta.Text = "";
            lblQuarto.Text = "";
            lblTerceira.Text = "";
            lblSegundo.Text = "";
            lblPrimeiro.Text = "";

            Opcao = cbOpção.Text;

            switch (Opcao)
            {
                case "Aluno":
                    A = new Aluno();
                    CtrAlu = new ctrAluno();
                    DateTime Data;

                    A.RA = Convert.ToInt32(txtPesquisa.Text);
                    A = CtrAlu.Consultar(A);

                    Data = Convert.ToDateTime(A.DataNasc);

                    lblPrimeiro.Text = "Nome:";
                    txtPrimeiro.Text = A.Nome;
                    lblSegundo.Text = "Turma:";
                    txtSegundo.Text = A.Turma;
                    lblTerceira.Text = "Senha:";
                    txtTerceiro.Text = A.senha;
                    lblQuarto.Text = "Idade:";
                    txtQuarto.Text = Convert.ToString(A.Idade);
                    lblQuinta.Text = "Data Nascimento:";
                    txtQuinto.Text = (Data).ToString("yyyy-MM-dd");
                    lblSexta.Text = "Edereço:";
                    txtSexta.Text = A.Endereco;
                    lblSetimo.Text = "Telefone:";
                    txtSetimo.Text = Convert.ToString(A.Telefone);
                    lblOitavo.Text = "CPF Resp Fin"; 
                    txtOitavo.Text = Convert.ToString(A.cpf_resp);
                    button3.Visible = true;
                    break;

                case "Responsavel":
                    R = new Responsavel();
                    ctrResp = new ctrResponsavel();

                    R.CPF_1 = Convert.ToInt32(txtPesquisa.Text);
                    R = ctrResp.Consultar(R);

                    lblPrimeiro.Text = "Nome Fin:";
                    txtPrimeiro.Text = R.Responsavel_1;
                    lblSegundo.Text = "CPF Fin:";
                    txtSegundo.Text = Convert.ToString(R.CPF_1);
                    lblTerceira.Text = "RG Fin:";
                    txtTerceiro.Text = Convert.ToString(R.RG_1);
                    lblQuarto.Text = "Nome Jur:";
                    txtQuarto.Text = R.Responsavel_2;
                    lblQuinta.Text = "CPF Jur:";
                    txtQuinto.Text = Convert.ToString(R.CPF_2);
                    lblSexta.Text = "RG Jur:";
                    txtSexta.Text = Convert.ToString(R.RG_2);
                    txtSetimo.Visible = false;
                    txtOitavo.Visible = false;
                    button3.Visible = false;
                    break;

                case "Turma":
                    T = new Turma();
                    ctrTu = new ctrTurma();

                    T.Nome_Turma = txtPesquisa.Text;
                    T = ctrTu.Consultar(T);

                    lblPrimeiro.Text = "Professor:";
                    txtPrimeiro.Text = T.Responsavel_Turma;
                    lblSegundo.Text = "Idade Alunos:";
                    txtSegundo.Text = Convert.ToString(T.Idade);
                    txtTerceiro.Visible = false;
                    txtQuarto.Visible = false;
                    txtQuinto.Visible = false;
                    txtSexta.Visible = false;
                    txtSetimo.Visible = false;
                    txtOitavo.Visible = false;
                    button3.Visible = false;
                    break;
            }
        }

        private void txtPrimeiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPrimeiro.Visible = true;
            txtSegundo.Visible = true;
            txtTerceiro.Visible = true;
            txtQuarto.Visible = true;
            txtQuinto.Visible = true;
            txtSexta.Visible = true;
            txtSetimo.Visible = true;
            txtOitavo.Visible = true;

            lblOitavo.Text = "";
            lblSetimo.Text = "";
            lblSexta.Text = "";
            lblQuinta.Text = "";
            lblQuarto.Text = "";
            lblTerceira.Text = "";
            lblSegundo.Text = "";
            lblPrimeiro.Text = "";

            string Opcao = cbOpção.Text;

            switch (Opcao)
            {
                case "Aluno":
                    A = new Aluno();
                    CtrAlu = new ctrAluno();

                    A.RA = Convert.ToInt32(txtPesquisa.Text);

                    lblPrimeiro.Text = "Nome:";
                    A.Nome = txtPrimeiro.Text;
                    lblSegundo.Text = "Turma:";
                    A.Turma = txtSegundo.Text;
                    lblTerceira.Text = "Senha:";
                    A.senha = txtTerceiro.Text;
                    lblQuarto.Text = "Idade:";
                    A.Idade = Convert.ToInt32(txtQuarto.Text);
                    lblQuinta.Text = "Data Nascimento:";
                    A.DataNasc = txtQuinto.Text;
                    lblSexta.Text = "Edereço:";
                    A.Endereco = txtSexta.Text;
                    lblSetimo.Text = "Telefone:";
                    A.Telefone = Convert.ToInt32(txtSetimo.Text);
                    lblOitavo.Text = "CPF Resp Fin";
                    //A.cpf_resp = Convert.ToInt32(txtOitavo.Text);

                    CtrAlu.Alterar(A);
                    break;

                case "Responsavel":
                    R = new Responsavel();
                    ctrResp = new ctrResponsavel();

                    R.CPF_1 = Convert.ToInt32(txtPesquisa.Text);

                    lblPrimeiro.Text = "Nome Fin:";
                    R.Responsavel_1 = txtPrimeiro.Text;
                    lblSegundo.Text = "CPF Fin:";
                    R.CPF_1 = Convert.ToInt32(txtSegundo.Text);
                    lblTerceira.Text = "RG Fin:";
                    R.RG_1 = Convert.ToInt32(txtTerceiro.Text);
                    lblQuarto.Text = "Nome Jur:";
                    R.Responsavel_2 = txtQuarto.Text;
                    lblQuinta.Text = "CPF Jur:";
                    R.CPF_2 = Convert.ToInt32(txtQuinto.Text);
                    lblSexta.Text = "RG Jur:";
                    R.RG_2 = Convert.ToInt32(txtSexta.Text);
                    txtSetimo.Visible = false;
                    txtOitavo.Visible = false;

                    ctrResp.Alterar(R);
                    break;

                case "Turma":
                    T = new Turma();
                    ctrTu = new ctrTurma();

                    T.Nome_Turma = txtPesquisa.Text;

                    lblPrimeiro.Text = "Professor:";
                    T.Responsavel_Turma = txtPrimeiro.Text;
                    lblSegundo.Text = "Idade Alunos:";
                    T.Idade = Convert.ToInt32(txtSegundo.Text);
                    txtTerceiro.Visible = false;
                    txtQuarto.Visible = false;
                    txtQuinto.Visible = false;
                    txtSexta.Visible = false;
                    txtSetimo.Visible = false;
                    txtOitavo.Visible = false;

                    ctrTu.Alterar(T);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Opcao = cbOpção.Text;

            switch (Opcao)
            {
                case "Aluno":
                    A = new Aluno();
                    CtrAlu = new ctrAluno();

                    A.RA = Convert.ToInt32(txtPesquisa.Text);

                    CtrAlu.Excluir(A);
                    break;

                case "Responsavel":
                    R = new Responsavel();
                    ctrResp = new ctrResponsavel();

                    R.CPF_1 = Convert.ToInt32(txtPesquisa.Text);

                    ctrResp.Excluir(R);
                    break;

                case "Turma":
                    T = new Turma();
                    ctrTu = new ctrTurma();

                    T.Nome_Turma = txtPesquisa.Text;

                    ctrTu.Excluir(T);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbOpção.Text == "Turma")
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
            this.Focus();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmConsulta consultar = new frmConsulta("");
            consultar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmTurmas consulta = new frmTurmas();
            consulta.ShowDialog();
        }
    }
}
