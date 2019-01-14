namespace pim_final_2
{
    partial class frmTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurma));
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNmTurma = new System.Windows.Forms.TextBox();
            this.lblLeg2 = new System.Windows.Forms.Label();
            this.txtRepTurma = new System.Windows.Forms.TextBox();
            this.lblLeg1 = new System.Windows.Forms.Label();
            this.mspOpc = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlunosNasTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.mspOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(285, 168);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 16;
            this.cmdClear.Text = "Limpar ";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Visible = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdCad
            // 
            this.cmdCad.Location = new System.Drawing.Point(45, 168);
            this.cmdCad.Name = "cmdCad";
            this.cmdCad.Size = new System.Drawing.Size(75, 23);
            this.cmdCad.TabIndex = 15;
            this.cmdCad.Text = "Cadastrar";
            this.cmdCad.UseVisualStyleBackColor = true;
            this.cmdCad.Visible = false;
            this.cmdCad.Click += new System.EventHandler(this.cmdCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Idade da Turma:";
            // 
            // txtNmTurma
            // 
            this.txtNmTurma.Enabled = false;
            this.txtNmTurma.Location = new System.Drawing.Point(146, 79);
            this.txtNmTurma.Name = "txtNmTurma";
            this.txtNmTurma.Size = new System.Drawing.Size(214, 20);
            this.txtNmTurma.TabIndex = 12;
            // 
            // lblLeg2
            // 
            this.lblLeg2.AutoSize = true;
            this.lblLeg2.Location = new System.Drawing.Point(42, 82);
            this.lblLeg2.Name = "lblLeg2";
            this.lblLeg2.Size = new System.Drawing.Size(89, 13);
            this.lblLeg2.TabIndex = 11;
            this.lblLeg2.Text = "Nome da Turma :";
            // 
            // txtRepTurma
            // 
            this.txtRepTurma.Enabled = false;
            this.txtRepTurma.Location = new System.Drawing.Point(146, 27);
            this.txtRepTurma.Name = "txtRepTurma";
            this.txtRepTurma.Size = new System.Drawing.Size(214, 20);
            this.txtRepTurma.TabIndex = 10;
            // 
            // lblLeg1
            // 
            this.lblLeg1.AutoSize = true;
            this.lblLeg1.Location = new System.Drawing.Point(9, 34);
            this.lblLeg1.Name = "lblLeg1";
            this.lblLeg1.Size = new System.Drawing.Size(131, 13);
            this.lblLeg1.TabIndex = 9;
            this.lblLeg1.Text = "Representante da Turma :";
            // 
            // mspOpc
            // 
            this.mspOpc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.listarAlunosNasTurmasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mspOpc.Location = new System.Drawing.Point(0, 0);
            this.mspOpc.Name = "mspOpc";
            this.mspOpc.Size = new System.Drawing.Size(461, 24);
            this.mspOpc.TabIndex = 17;
            this.mspOpc.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = global::pim_final_2.Properties.Resources._7688_64x64;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::pim_final_2.Properties.Resources._11362_64x64;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
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
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listarToolStripMenuItem.Image = global::pim_final_2.Properties.Resources.icone_lista_contatos;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // listarAlunosNasTurmasToolStripMenuItem
            // 
            this.listarAlunosNasTurmasToolStripMenuItem.Image = global::pim_final_2.Properties.Resources._7829_64x64;
            this.listarAlunosNasTurmasToolStripMenuItem.Name = "listarAlunosNasTurmasToolStripMenuItem";
            this.listarAlunosNasTurmasToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listarAlunosNasTurmasToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.listarAlunosNasTurmasToolStripMenuItem.Text = "Listar Alunos nas Turmas";
            this.listarAlunosNasTurmasToolStripMenuItem.Click += new System.EventHandler(this.listarAlunosNasTurmasToolStripMenuItem_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(164, 168);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 18;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(146, 134);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 19;
            // 
            // frmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 202);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNmTurma);
            this.Controls.Add(this.lblLeg2);
            this.Controls.Add(this.txtRepTurma);
            this.Controls.Add(this.lblLeg1);
            this.Controls.Add(this.mspOpc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspOpc;
            this.MaximizeBox = false;
            this.Name = "frmTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDAYV";
            this.mspOpc.ResumeLayout(false);
            this.mspOpc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNmTurma;
        private System.Windows.Forms.Label lblLeg2;
        private System.Windows.Forms.TextBox txtRepTurma;
        private System.Windows.Forms.Label lblLeg1;
        private System.Windows.Forms.MenuStrip mspOpc;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlunosNasTurmasToolStripMenuItem;
    }
}