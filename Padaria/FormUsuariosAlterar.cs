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
    public partial class FormUsuariosAlterar : Form
    {
        public FormUsuariosAlterar()
        {
            InitializeComponent();
        }
        private void FormUsuariosAlterar_Load(object sender, EventArgs e)
        {
            OcultaCampos();
            cboxAcesso.SelectedIndex = 2;
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
                txtLogin .Text = usuarioSelecionado.Login;
                txtSenha.Text = usuarioSelecionado.Senha;
                cboxAcesso.SelectedItem = usuarioSelecionado.Acesso;
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
            erroNome.ResetText();
            txtCpf.ResetText();
            erroCpf.ResetText();
            txtLogin.ResetText();
            erroLogin.ResetText();
            txtSenha.ResetText();
            erroSenha.ResetText();
            cboxAcesso.SelectedIndex = 2;
            usuarioSelecionado = null;
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
                erroNome.Visible = false;
                lblCpf.Visible = false;
                txtCpf.Visible = false;
                erroCpf.Visible = false;
                lblLogin.Visible = false;
                txtLogin.Visible = false;
                erroLogin.Visible = false;
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                erroSenha.Visible = false;
                lblAcesso.Visible = false;
                cboxAcesso.Visible = false;
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
                erroNome.Visible = true;
                lblCpf.Visible = true;
                txtCpf.Visible = true;
                erroCpf.Visible = true;
                lblLogin.Visible = true;
                txtLogin.Visible = true;
                erroLogin.Visible = true;
                lblSenha.Visible = true;
                txtSenha.Visible = true;
                erroSenha.Visible = true;
                lblAcesso.Visible = true;
                cboxAcesso.Visible = true;
            }
        }
        /// <summary>
        /// Verifica se não há erros nos formularios
        /// </summary>
        /// <returns></returns>
        private bool camposValidados()
        {
            if (erroNome.Text == "" && erroCpf.Text == "" && erroLogin.Text == "" && erroSenha.Text == "" &&
                txtNome.Text != "" && txtCpf.Text != "" && txtLogin.Text != "" && txtSenha.Text != "")
            {
                return true;
            }
            else
            {
                return false;
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            OcultaCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                if (camposValidados())
                {
                    usuarioSelecionado.Nome = txtNome.Text;
                    usuarioSelecionado.Cpf = txtCpf.Text;
                    usuarioSelecionado.Login = txtLogin.Text;
                    usuarioSelecionado.Senha = txtSenha.Text;
                    usuarioSelecionado.Acesso = cboxAcesso.SelectedItem.ToString();

                    if (OperadorBLL.AlteraUsuario(usuarioSelecionado))
                    {
                        MessageBox.Show("Usuário alterado com sucesso!");
                        LimparCampos();
                        OcultaCampos();
                        Preenchercbox();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar usuário!");
                    }
                }
                else
                {
                    MessageBox.Show("Corrija os campos sinalizados!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuario para ser alterado");
            }
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

        #region Validaçoes

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString() == "" || txtNome.Text == null)
            {
                erroNome.Text = "Favor preencher o campo";
            }
            else
            {
                if (txtNome.Text.ToString().Length < 5)
                {
                    erroNome.Text = "Favor preencher o campo com nome completo";
                }
                else
                {
                    erroNome.ResetText();
                }
            }
        }
        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text.ToString() == "" || txtCpf.Text == null)
            {
                erroCpf.Text = "Favor preencher o campo";
            }
            else
            {
                if (BLL.Utilidades.IsCpf(txtCpf.Text.ToString()))
                {
                    erroCpf.ResetText();
                }
                else
                {
                    erroCpf.Text = "O CPF informado não é valido";
                }
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text.ToString() == "" || txtLogin.Text == null)
            {
                erroLogin.Text = "Favor preencher o campo";
            }
            else
            {
                erroLogin.ResetText();
            }
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.ToString() == "" || txtSenha.Text == null)
            {
                erroSenha.Text = "Favor preencher o campo";
            }
            else if (txtSenha.Text.ToString().Length < 6)
            {
                erroSenha.Text = "A senha é curta demais(minimo 6 digitos)";
            }
            else
            {
                erroSenha.ResetText();
            }
        }

        #endregion

        
    }
}
