namespace pim_final_2
{
    partial class frmResponsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsa));
            this.cmdCancel = new System.Windows.Forms.Button();
            this.ckbResp = new System.Windows.Forms.CheckBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtRespFinn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRespJur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPFJur = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtRGRespJur = new System.Windows.Forms.TextBox();
            this.lblRa = new System.Windows.Forms.Label();
            this.mnsOpc = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRgFin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPFFIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mnsOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(282, 231);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(66, 23);
            this.cmdCancel.TabIndex = 50;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // ckbResp
            // 
            this.ckbResp.AutoSize = true;
            this.ckbResp.Location = new System.Drawing.Point(73, 120);
            this.ckbResp.Name = "ckbResp";
            this.ckbResp.Size = new System.Drawing.Size(123, 17);
            this.ckbResp.TabIndex = 40;
            this.ckbResp.Text = "Igualar Responsável";
            this.ckbResp.UseVisualStyleBackColor = true;
            this.ckbResp.CheckedChanged += new System.EventHandler(this.ckbResp_CheckedChanged);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(172, 231);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 51;
            this.cmdClear.Text = "Limpar";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Visible = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(68, 231);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(66, 23);
            this.cmdAdd.TabIndex = 49;
            this.cmdAdd.Text = "Cadastrar";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Visible = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtRespFinn
            // 
            this.txtRespFinn.Enabled = false;
            this.txtRespFinn.Location = new System.Drawing.Point(73, 36);
            this.txtRespFinn.Name = "txtRespFinn";
            this.txtRespFinn.Size = new System.Drawing.Size(280, 20);
            this.txtRespFinn.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Resp. Fin :";
            // 
            // txtRespJur
            // 
            this.txtRespJur.Enabled = false;
            this.txtRespJur.Location = new System.Drawing.Point(68, 143);
            this.txtRespJur.Name = "txtRespJur";
            this.txtRespJur.Size = new System.Drawing.Size(280, 20);
            this.txtRespJur.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Resp. Jur :";
            // 
            // txtCPFJur
            // 
            this.txtCPFJur.Enabled = false;
            this.txtCPFJur.Location = new System.Drawing.Point(68, 169);
            this.txtCPFJur.Name = "txtCPFJur";
            this.txtCPFJur.Size = new System.Drawing.Size(120, 20);
            this.txtCPFJur.TabIndex = 44;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(12, 179);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(50, 13);
            this.lblTurma.TabIndex = 52;
            this.lblTurma.Text = "CPF Jur :";
            // 
            // txtRGRespJur
            // 
            this.txtRGRespJur.Enabled = false;
            this.txtRGRespJur.Location = new System.Drawing.Point(68, 195);
            this.txtRGRespJur.Name = "txtRGRespJur";
            this.txtRGRespJur.Size = new System.Drawing.Size(120, 20);
            this.txtRGRespJur.TabIndex = 42;
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(12, 202);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(49, 13);
            this.lblRa.TabIndex = 51;
            this.lblRa.Text = "RG Jur : ";
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
            this.mnsOpc.Size = new System.Drawing.Size(393, 24);
            this.mnsOpc.TabIndex = 58;
            this.mnsOpc.Text = "mnsOpc";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem.Image")));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Image = global::pim_final_2.Properties.Resources._11362_64x64;
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
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
            // txtRgFin
            // 
            this.txtRgFin.Enabled = false;
            this.txtRgFin.Location = new System.Drawing.Point(73, 88);
            this.txtRgFin.Name = "txtRgFin";
            this.txtRgFin.Size = new System.Drawing.Size(120, 20);
            this.txtRgFin.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "RG Fin :";
            // 
            // txtCPFFIN
            // 
            this.txtCPFFIN.Enabled = false;
            this.txtCPFFIN.Location = new System.Drawing.Point(73, 62);
            this.txtCPFFIN.Name = "txtCPFFIN";
            this.txtCPFFIN.Size = new System.Drawing.Size(120, 20);
            this.txtCPFFIN.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "CPF Fin :";
            // 
            // frmResponsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 279);
            this.Controls.Add(this.txtCPFFIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRgFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.ckbResp);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtRespFinn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRespJur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPFJur);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.txtRGRespJur);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.mnsOpc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResponsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDAYV";
            this.mnsOpc.ResumeLayout(false);
            this.mnsOpc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox ckbResp;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtRespFinn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRespJur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPFJur;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.TextBox txtRGRespJur;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.MenuStrip mnsOpc;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRgFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPFFIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
    }
}