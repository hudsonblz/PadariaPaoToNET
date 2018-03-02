using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class FormRepositor : Form
    {
        public FormRepositor()
        {
            InitializeComponent();
        }
        private BLL.Lote OperadorBLL = new BLL.Lote();

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormClientes();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormProdutos();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormLotes();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void FormRepositor_Load(object sender, EventArgs e)
        {
            dgvVencidos.DataSource = OperadorBLL.LotesVencidos();
        }

        private void FormRepositor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvVencidos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Deu");
        }
    }
}
