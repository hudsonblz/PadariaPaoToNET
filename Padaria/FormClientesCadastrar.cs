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
    public partial class FormClientesCadastrar : Form
    {
        public FormClientesCadastrar()
        {
            InitializeComponent();
        }
        #region Variaveis
        private BLL.Cliente OperadorBLL = new BLL.Cliente();
        #endregion

        #region Funçoes
        /// <summary>
        /// Limpa todos os campos do formulario
        /// </summary>
        private void LimparCampos()
        {
            txtNome.ResetText();
            erroNome.ResetText();
            txtCpf.ResetText();
            erroCpf.ResetText();
            txtCidade.ResetText();
            erroCidade.ResetText();
            txtBairro.ResetText();
            erroBairro.ResetText();
            txtEndereço.ResetText();
            erroEndereço.ResetText();
        }
        /// <summary>
        /// Verifica se não há nenhum erro no preenchimento dos campos
        /// </summary>
        /// <returns></returns>
        private bool CamposValidados() 
        {
            if (erroNome.Text == "" && erroCpf.Text == "" && erroCidade.Text == "" && erroBairro.Text == "" && erroEndereço.Text == "" &&
                txtNome.Text != "" && txtCpf.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereço.Text != "") 
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
            if (CamposValidados())
            {
                Model.Cliente novoCliente = new Model.Cliente
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Endereco = txtEndereço.Text
                };

                if (OperadorBLL.CadastraClientes(novoCliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar cliente!"); 
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
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
        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (txtCidade.Text.ToString() == "" || txtCidade.Text == null)
            {
                erroCidade.Text = "Favor preencher o campo";
            }
            else
            {
                if (txtCidade.Text.ToString().Length <= 2)
                {
                    erroCidade.Text = "Favor preencher o campo com o nome de uma cidade";
                }
                else
                {
                    erroCidade.ResetText();
                }
            }
        }
        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (txtBairro.Text.ToString() == "" || txtBairro.Text == null)
            {
                erroBairro.Text = "Favor preencher o campo";
            }
            else
            {
                if (txtBairro.Text.ToString().Length <= 2)
                {
                    erroBairro.Text = "Favor preencher o campo com o nome de um bairro";
                }
                else
                {
                    erroBairro.ResetText();
                }
            }  
        }
        private void txtEndereço_Leave(object sender, EventArgs e)
        {
            if (txtEndereço.Text.ToString() == "" || txtEndereço.Text == null)
            {
                erroEndereço.Text = "Favor preencher o campo";
            }
            else
            {
                if (txtEndereço.Text.ToString().Length <= 2)
                {
                    erroEndereço.Text = "Favor preencher o campo com o nome de um bairro";
                }
                else
                {
                    erroEndereço.ResetText();
                }
            }
        }

        #endregion


    }
}
