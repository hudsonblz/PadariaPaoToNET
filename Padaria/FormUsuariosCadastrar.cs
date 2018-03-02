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
    public partial class FormUsuariosCadastrar : Form
    {

        public FormUsuariosCadastrar()
        {
            InitializeComponent();
        }
        private void FormUsuariosCadastrar_Load(object sender, EventArgs e)
        {
            cboxAcesso.SelectedIndex = 2;
        }

        #region Variaveis
        BLL.Usuario OperadorBLL = new BLL.Usuario();
        #endregion

        #region Funçoes

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
        /// <summary>
        /// Limpa todos os campos do formulario
        /// </summary>
        private void LimparCampos()
        {
            txtNome.ResetText();
            erroNome.ResetText();
            txtCpf.ResetText();
            erroCpf.ResetText();
            txtLogin.ResetText();
            erroLogin.ResetText();
            txtSenha.ResetText();
            erroSenha.ResetText();
            cboxAcesso.SelectedIndex = 2;
        }

        #endregion

        #region Ações de botões

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(camposValidados())
            {
                Model.Usuario novoUsuario = new Model.Usuario { 
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Login = txtLogin.Text,
                    Senha = txtSenha.Text,
                    Acesso = cboxAcesso.SelectedItem.ToString(),
                
                };

                if (OperadorBLL.CadastraUsuarios(novoUsuario)) 
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    LimparCampos();
                }
                else 
                {
                    MessageBox.Show("Falha ao cadastrar usuário!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
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
