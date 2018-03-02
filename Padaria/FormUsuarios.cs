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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }
        #region Botoes

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormUsuariosCadastrar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormUsuariosAlterar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormUsuariosDeletar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form Exibir = new FormUsuariosPesquisar();
            this.Visible = false;
            Exibir.ShowDialog();
            this.Visible = true;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
