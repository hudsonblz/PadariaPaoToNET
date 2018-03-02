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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormProdutosCadastrar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormProdutosAlterar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormProdutosDeletar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormProdutosPesquisar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }
    }
}
