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
    public partial class FormUsuariosPesquisar : Form
    {
        public FormUsuariosPesquisar()
        {
            InitializeComponent();
        }
        private void FormUsuariosPesquisar_Load(object sender, EventArgs e)
        {
            OcultaCampos();
            Preenchercbox();
        }

        #region Variaveis
        Model.Usuario usuarioSelecionado = new Model.Usuario();
        BLL.Usuario OperadorBLL = new BLL.Usuario();
        #endregion

        #region Funçoes

        private void Preenchercbox()
        {
            cboxCpf.Items.Clear();
            cboxNome.Items.Clear();
            List<string> ListaDeCPF = OperadorBLL.ListaUsuarioCpf();
            foreach (string cpf in ListaDeCPF)
            {
                cboxCpf.Items.Add(cpf);
            }
            List<string> ListaDeNomes = OperadorBLL.ListaUsuarioNome();
            foreach (string nome in ListaDeNomes)
            {
                cboxNome.Items.Add(nome);
            }
        }

        private void PreencherCampos()
        {
            if (usuarioSelecionado != null)
            {
                txtNome.Text = usuarioSelecionado.Nome;
                txtCpf.Text = usuarioSelecionado.Cpf;
                txtLogin.Text = usuarioSelecionado.Login;
                txtSenha.Text = usuarioSelecionado.Senha;
                txtAcesso.Text = usuarioSelecionado.Acesso;
            }
            else
            {
                MessageBox.Show("Nenhum dado retornado!");
            }
        }

        private void CarregaCamposCpf(string cpf)
        {
            usuarioSelecionado = OperadorBLL.BuscaUsuarioCpf(cpf);
            PreencherCampos();
        }

        private void CarregaCamposNome(string nome)
        {
            usuarioSelecionado = OperadorBLL.BuscaUsuarioNome(nome);
            PreencherCampos();
        }

        /// <summary>
        /// Limpa todos os campos do formulario
        /// </summary>
        private void LimparCampos()
        {
            cboxCpf.ResetText();
            cboxNome.ResetText();

            txtNome.ResetText();
            txtCpf.ResetText();
            txtLogin.ResetText();
            txtSenha.ResetText();
            txtAcesso.ResetText();
        }
        /// <summary>
        /// Oculta os campos de alteraçao do formulario se eles estiverem visiveis
        /// </summary>
        private void OcultaCampos()
        {
            if (lblNome.Visible)
            {
                lblNome.Visible = false;
                txtNome.Visible = false;
                lblCpf.Visible = false;
                txtCpf.Visible = false;
                lblLogin.Visible = false;
                txtLogin.Visible = false;
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                lblAcesso.Visible = false;
                txtAcesso.Visible = false;
            }
        }
        /// <summary>
        /// Exibe os campos de alteraçao do formulario se eles não estiverem visiveis
        /// </summary>
        private void ExibeCampos()
        {
            if (!lblNome.Visible)
            {
                lblNome.Visible = true;
                txtNome.Visible = true;
                lblCpf.Visible = true;
                txtCpf.Visible = true;
                lblLogin.Visible = true;
                txtLogin.Visible = true;
                lblSenha.Visible = true;
                txtSenha.Visible = true;
                lblAcesso.Visible = true;
                txtAcesso.Visible = true;
            }
        }

        #endregion

        #region Botoes

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Seletores

        private void cboxCpf_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaCamposCpf(cboxCpf.SelectedItem.ToString());
            ExibeCampos();
        }
        private void cboxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaCamposNome(cboxNome.SelectedItem.ToString());
            ExibeCampos();
        }

        #endregion

    }
}
