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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

           private void tmrPercent_Tick(object sender, EventArgs e)
        {
            if (pgbPercent.Value < 100)
            {
                pgbPercent.Value = pgbPercent.Value + 2;
            }
            else
            {
                tmrPercent.Enabled = false;

                this.Hide();
                Forms.frmLogin objTela = new Forms.frmLogin();
                objTela.ShowDialog();
            }

            
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmrPercent.Start();
        }
    }
}
