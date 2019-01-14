namespace pim_final_2.Forms
{
    partial class frmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultar));
            this.txtPrimeiro = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbOpção = new System.Windows.Forms.ComboBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.txtTerceiro = new System.Windows.Forms.TextBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.txtQuinto = new System.Windows.Forms.TextBox();
            this.txtSexta = new System.Windows.Forms.TextBox();
            this.txtSetimo = new System.Windows.Forms.TextBox();
            this.txtOitavo = new System.Windows.Forms.TextBox();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mnsOpc = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblTerceira = new System.Windows.Forms.Label();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.lblQuinta = new System.Windows.Forms.Label();
            this.lblSexta = new System.Windows.Forms.Label();
            this.lblSetimo = new System.Windows.Forms.Label();
            this.lblOitavo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.Location = new System.Drawing.Point(106, 95);
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(250, 20);
            this.txtPrimeiro.TabIndex = 0;
            this.txtPrimeiro.TextChanged += new System.EventHandler(this.txtPrimeiro_TextChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(162, 54);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(285, 51);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbOpção
            // 
            this.cbOpção.FormattingEnabled = true;
            this.cbOpção.Items.AddRange(new object[] {
            "Turma",
            "Responsavel",
            "Aluno"});
            this.cbOpção.Location = new System.Drawing.Point(15, 54);
            this.cbOpção.Name = "cbOpção";
            this.cbOpção.Size = new System.Drawing.Size(141, 21);
            this.cbOpção.TabIndex = 3;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(106, 121);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(121, 20);
            this.txtSegundo.TabIndex = 4;
            // 
            // txtTerceiro
            // 
            this.txtTerceiro.Location = new System.Drawing.Point(106, 147);
            this.txtTerceiro.Name = "txtTerceiro";
            this.txtTerceiro.Size = new System.Drawing.Size(121, 20);
            this.txtTerceiro.TabIndex = 5;
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(106, 173);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(141, 20);
            this.txtQuarto.TabIndex = 6;
            // 
            // txtQuinto
            // 
            this.txtQuinto.Location = new System.Drawing.Point(106, 199);
            this.txtQuinto.Name = "txtQuinto";
            this.txtQuinto.Size = new System.Drawing.Size(141, 20);
            this.txtQuinto.TabIndex = 7;
            // 
            // txtSexta
            // 
            this.txtSexta.Location = new System.Drawing.Point(106, 225);
            this.txtSexta.Name = "txtSexta";
            this.txtSexta.Size = new System.Drawing.Size(187, 20);
            this.txtSexta.TabIndex = 8;
            // 
            // txtSetimo
            // 
            this.txtSetimo.Location = new System.Drawing.Point(106, 251);
            this.txtSetimo.Name = "txtSetimo";
            this.txtSetimo.Size = new System.Drawing.Size(141, 20);
            this.txtSetimo.TabIndex = 9;
            // 
            // txtOitavo
            // 
            this.txtOitavo.Location = new System.Drawing.Point(106, 281);
            this.txtOitavo.Name = "txtOitavo";
            this.txtOitavo.Size = new System.Drawing.Size(141, 20);
            this.txtOitavo.TabIndex = 10;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Location = new System.Drawing.Point(22, 38);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(54, 13);
            this.lblConsultar.TabIndex = 11;
            this.lblConsultar.Text = "Consultar:";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(159, 38);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 12;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mnsOpc
            // 
            this.mnsOpc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem1,
            this.consultarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnsOpc.Location = new System.Drawing.Point(0, 0);
            this.mnsOpc.Name = "mnsOpc";
            this.mnsOpc.Size = new System.Drawing.Size(368, 24);
            this.mnsOpc.TabIndex = 37;
            this.mnsOpc.Text = "mnsOpc";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Image = global::pim_final_2.Properties.Resources._11362_64x64;
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(12, 102);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(35, 13);
            this.lblPrimeiro.TabIndex = 38;
            this.lblPrimeiro.Text = "label1";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(12, 128);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(35, 13);
            this.lblSegundo.TabIndex = 39;
            this.lblSegundo.Text = "label2";
            // 
            // lblTerceira
            // 
            this.lblTerceira.AutoSize = true;
            this.lblTerceira.Location = new System.Drawing.Point(12, 154);
            this.lblTerceira.Name = "lblTerceira";
            this.lblTerceira.Size = new System.Drawing.Size(35, 13);
            this.lblTerceira.TabIndex = 40;
            this.lblTerceira.Text = "label3";
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(12, 180);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(35, 13);
            this.lblQuarto.TabIndex = 41;
            this.lblQuarto.Text = "label4";
            // 
            // lblQuinta
            // 
            this.lblQuinta.AutoSize = true;
            this.lblQuinta.Location = new System.Drawing.Point(12, 206);
            this.lblQuinta.Name = "lblQuinta";
            this.lblQuinta.Size = new System.Drawing.Size(35, 13);
            this.lblQuinta.TabIndex = 42;
            this.lblQuinta.Text = "label5";
            // 
            // lblSexta
            // 
            this.lblSexta.AutoSize = true;
            this.lblSexta.Location = new System.Drawing.Point(12, 232);
            this.lblSexta.Name = "lblSexta";
            this.lblSexta.Size = new System.Drawing.Size(35, 13);
            this.lblSexta.TabIndex = 43;
            this.lblSexta.Text = "label6";
            // 
            // lblSetimo
            // 
            this.lblSetimo.AutoSize = true;
            this.lblSetimo.Location = new System.Drawing.Point(12, 258);
            this.lblSetimo.Name = "lblSetimo";
            this.lblSetimo.Size = new System.Drawing.Size(35, 13);
            this.lblSetimo.TabIndex = 44;
            this.lblSetimo.Text = "label7";
            // 
            // lblOitavo
            // 
            this.lblOitavo.AutoSize = true;
            this.lblOitavo.Location = new System.Drawing.Point(12, 284);
            this.lblOitavo.Name = "lblOitavo";
            this.lblOitavo.Size = new System.Drawing.Size(35, 13);
            this.lblOitavo.TabIndex = 45;
            this.lblOitavo.Text = "label8";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Ver turmas disponiveis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem.Image")));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::pim_final_2.Properties.Resources.icone_lista_contatos;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.consultarToolStripMenuItem.Text = "Listar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::pim_final_2.Properties.Resources._11292_64x64;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblOitavo);
            this.Controls.Add(this.lblSetimo);
            this.Controls.Add(this.lblSexta);
            this.Controls.Add(this.lblQuinta);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.lblTerceira);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.mnsOpc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.txtOitavo);
            this.Controls.Add(this.txtSetimo);
            this.Controls.Add(this.txtSexta);
            this.Controls.Add(this.txtQuinto);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.txtTerceiro);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.cbOpção);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtPrimeiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDAYV";
            this.mnsOpc.ResumeLayout(false);
            this.mnsOpc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimeiro;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbOpção;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.TextBox txtTerceiro;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.TextBox txtQuinto;
        private System.Windows.Forms.TextBox txtSexta;
        private System.Windows.Forms.TextBox txtSetimo;
        private System.Windows.Forms.TextBox txtOitavo;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip mnsOpc;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblTerceira;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.Label lblQuinta;
        private System.Windows.Forms.Label lblSexta;
        private System.Windows.Forms.Label lblSetimo;
        private System.Windows.Forms.Label lblOitavo;
        private System.Windows.Forms.Button button3;
    }
}