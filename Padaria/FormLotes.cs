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
    public partial class FormLotes : Form
    {
        public FormLotes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormLotesCadastrar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormLotesAlterar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormLotesDeletar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormLotesPesquisar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
