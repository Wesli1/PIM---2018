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
    public partial class frmResponsa : Form
    {

        ctrAluno ctrAluno;
        ctrTurma ctrTurma;
        ctrResponsavel ctrResp;
        Aluno A;
        Responsavel R;
        Turma T;


        public frmResponsa()
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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            txtRGRespJur.Enabled = true;
            txtRgFin.Enabled = true;
            txtCPFJur.Enabled = true;
            txtCPFFIN.Enabled = true;
            txtRespJur.Enabled = true;
            txtRespFinn.Enabled = true;
            cmdAdd.Visible = true;
            cmdClear.Visible = true;
            cmdCancel.Visible = true;


            txtRespJur.Focus();

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Forms.Limpar_Obj limpar = new Forms.Limpar_Obj();
            limpar.Limpar_Campos(this);

            txtRGRespJur.Enabled = false;
            txtRgFin.Enabled = false;
            txtCPFJur.Enabled = false;
            txtCPFFIN.Enabled = false;
            txtRespJur.Enabled = false;
            txtRespFinn.Enabled = false;
            cmdAdd.Visible = false;
            cmdClear.Visible = false;
            cmdCancel.Visible = false;


            txtRespFinn.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            Forms.Limpar_Obj limpaObj = new Forms.Limpar_Obj();
            limpaObj.Limpar_Campos(this);

            txtRespJur.Focus();

            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consul = new frmConsulta("Responsaveis");
            consul.ShowDialog();
        }

        private void ckbResp_CheckedChanged(object sender, EventArgs e)
        {
            txtRespJur.Text = txtRespFinn.Text;
            txtRespJur.Enabled = false;
            txtCPFJur.Text = txtCPFFIN.Text;
            txtCPFJur.Enabled = false;
            txtRGRespJur.Text = txtRgFin.Text;
            txtRGRespJur.Enabled = false;

            if (!ckbResp.Checked)
            {
                txtRespFinn.Enabled = true;
                txtRespFinn.Clear();
                txtRespFinn.Focus();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            R = new Responsavel();
            ctrResp = new ctrResponsavel();

            R.Responsavel_1 = txtRespFinn.Text;
            R.CPF_1 = Convert.ToInt32(txtCPFFIN.Text);
            R.RG_1 = Convert.ToInt32(txtRgFin.Text);
            R.Responsavel_2 = txtRespJur.Text;
            R.CPF_2 = Convert.ToInt32(txtCPFJur.Text);
            R.RG_2 = Convert.ToInt32(txtRGRespJur.Text);
            
            ctrResp.Adicionar(R);

            Forms.frmAlunos alunos = new frmAlunos(R.CPF_1);
            this.Hide();
            
            alunos.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultar consultar = new frmConsultar("Responsavel");
            consultar.ShowDialog();
        }
    }
    }

