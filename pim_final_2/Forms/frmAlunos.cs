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
    public partial class frmAlunos : Form
        
    {
        ctrAluno ctrAluno;
        ctrTurma ctrTurma;
        ctrResponsavel ctrResp;
        Aluno A;
        Responsavel R;
        Turma T;
        int Cpf_resp;

        public frmAlunos(int R) 
        {
            InitializeComponent();
            Cpf_resp = R;
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R = new Responsavel();
            ctrResp = new ctrResponsavel();

            Limpar_Obj limpar = new Limpar_Obj();
            limpar.Limpar_Campos(this);

            R.CPF_1 = Cpf_resp;

            DialogResult confirm = MessageBox.Show("Isso ira apagar os dados de responsavel cadastrados anteriormente, deseja sair?", "Deseja Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {

                ctrResp.Excluir(R);

            }

            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }
        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //fazer um método para desbloquear todos os label's !! 

            txtNome.Enabled = true;
            txtRa.Enabled = true;
            txtTurma.Enabled = true;
            txtDataNasc.Enabled = true;
            txtEndereco.Enabled = true;
            txtSenha.Enabled = true;
            txtPhone.Enabled = true;
            txtIdd.Enabled = true;
            cmdAdd.Visible = true;
            cmdClear.Visible = true;
            cmdCancel.Visible = true;


            txtNome.Focus();

        }
        private void cmdClear_Click(object sender, EventArgs e)
        {
            Limpar_Obj limpaObj = new Limpar_Obj();
            limpaObj.Limpar_Campos(this);

            txtNome.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Limpar_Obj limpar = new Limpar_Obj();
            limpar.Limpar_Campos(this);

            R.CPF_1 = Cpf_resp;

            
            txtNome.Enabled = false;
            txtRa.Enabled = false;
            txtTurma.Enabled = false;
            txtDataNasc.Enabled = false;
            txtEndereco.Enabled = false;
            txtSenha.Enabled = false;
            txtPhone.Enabled = false;
            txtIdd.Enabled = false;
            cmdAdd.Visible = false;
            cmdClear.Visible = false;
            cmdCancel.Visible = false;
           

            txtNome.Focus();
            
        }

        private void cmdDisp_Click(object sender, EventArgs e)
        {
            frmTurmas consulta = new frmTurmas();
            consulta.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta("Alunos");
            consulta.ShowDialog();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            A = new Aluno();
            ctrAluno = new ctrAluno();

            A.Nome = txtNome.Text;
            A.Idade = Convert.ToInt32(txtIdd.Text);
            A.RA = Convert.ToInt32(txtRa.Text);
            A.senha = txtSenha.Text;
            A.Telefone = Convert.ToInt32(txtPhone.Text);
            A.Turma = txtTurma.Text;
            A.DataNasc = txtDataNasc.Text;
            A.Endereco = txtEndereco.Text;
            A.cpf_resp = Cpf_resp;
            

            ctrAluno.Adicionar(A);

            MessageBox.Show("Cadastrado com Sucesso", "MIDAYV");

            this.Hide();
            this.Close();

            frmMenu menu = new frmMenu();
            menu.ShowDialog();


        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultar consultar = new frmConsultar("Aluno");
            consultar.ShowDialog();
        }
    }
}
