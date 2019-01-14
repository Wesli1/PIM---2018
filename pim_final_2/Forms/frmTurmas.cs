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
    public partial class frmTurmas : Form
    {
        ctrTurma ctrTu;
        List<Turma> ListaTurmas;
        public frmTurmas()
        {
            InitializeComponent();
            ctrTu = new ctrTurma();
            ListaTurmas = ctrTu.ListarTurmas();

            dataGridView1.DataSource = ListaTurmas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
