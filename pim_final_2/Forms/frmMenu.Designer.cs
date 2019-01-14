namespace pim_final_2
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnPedagogico = new System.Windows.Forms.Button();
            this.btnEscola = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.cmdResponsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedagogico
            // 
            this.btnPedagogico.BackColor = System.Drawing.Color.White;
            this.btnPedagogico.Image = ((System.Drawing.Image)(resources.GetObject("btnPedagogico.Image")));
            this.btnPedagogico.Location = new System.Drawing.Point(220, 198);
            this.btnPedagogico.Name = "btnPedagogico";
            this.btnPedagogico.Size = new System.Drawing.Size(81, 89);
            this.btnPedagogico.TabIndex = 11;
            this.btnPedagogico.Text = "Pedagogico";
            this.btnPedagogico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedagogico.UseVisualStyleBackColor = false;
            this.btnPedagogico.Click += new System.EventHandler(this.btnPedagogico_Click);
            // 
            // btnEscola
            // 
            this.btnEscola.BackColor = System.Drawing.Color.White;
            this.btnEscola.Image = ((System.Drawing.Image)(resources.GetObject("btnEscola.Image")));
            this.btnEscola.Location = new System.Drawing.Point(110, 198);
            this.btnEscola.Name = "btnEscola";
            this.btnEscola.Size = new System.Drawing.Size(81, 89);
            this.btnEscola.TabIndex = 10;
            this.btnEscola.Text = "Escola";
            this.btnEscola.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEscola.UseVisualStyleBackColor = false;
            this.btnEscola.Click += new System.EventHandler(this.btnEscola_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.BackColor = System.Drawing.SystemColors.Window;
            this.btnTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnTurma.Image")));
            this.btnTurma.Location = new System.Drawing.Point(335, 54);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(81, 89);
            this.btnTurma.TabIndex = 3;
            this.btnTurma.Text = "Turma";
            this.btnTurma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTurma.UseVisualStyleBackColor = false;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(335, 197);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 90);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.White;
            this.btnAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlunos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlunos.Image")));
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlunos.Location = new System.Drawing.Point(110, 54);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(81, 89);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // cmdResponsa
            // 
            this.cmdResponsa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdResponsa.Image = ((System.Drawing.Image)(resources.GetObject("cmdResponsa.Image")));
            this.cmdResponsa.Location = new System.Drawing.Point(220, 54);
            this.cmdResponsa.Name = "cmdResponsa";
            this.cmdResponsa.Size = new System.Drawing.Size(81, 89);
            this.cmdResponsa.TabIndex = 12;
            this.cmdResponsa.Text = "Responsavel";
            this.cmdResponsa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdResponsa.UseVisualStyleBackColor = false;
            this.cmdResponsa.Click += new System.EventHandler(this.cmdResponsa_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 315);
            this.Controls.Add(this.cmdResponsa);
            this.Controls.Add(this.btnPedagogico);
            this.Controls.Add(this.btnEscola);
            this.Controls.Add(this.btnTurma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDAYV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedagogico;
        private System.Windows.Forms.Button btnEscola;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button cmdResponsa;
    }
}