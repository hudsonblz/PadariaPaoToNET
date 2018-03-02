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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormClientes();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormUsuarios();
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

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormRelatorios();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }      
    }
}
