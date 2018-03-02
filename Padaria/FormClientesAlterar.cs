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
    public partial class FormClientesAlterar : Form
    {
        public FormClientesAlterar()
        {
            InitializeComponent();
        }
        private void FormClientesAlterar_Load(object sender, EventArgs e)
        {
            OcultaCampos();
            Preenchercbox();
        }

        #region Variaveis
        private Model.Cliente ClienteSelecionado;
        private BLL.Cliente OperadorBLL = new BLL.Cliente();
        #endregion

        #region Funcoes
        private void Preenchercbox() 
        {
            cboxCpf.Items.Clear();
            cboxNome.Items.Clear();
            List<string> ListaDeCPF = OperadorBLL.ListaClienteCpf();
            foreach (string cpf in ListaDeCPF)
            {
                cboxCpf.Items.Add(cpf);
            }
            List<string> ListaDeNomes = OperadorBLL.ListaClienteNome();
            foreach (string nome in ListaDeNomes)
            {
                cboxNome.Items.Add(nome);
            }
        }
        private void PreencherCampos() 
        {
            if (ClienteSelecionado != null)
            {
                txtNome.Text = ClienteSelecionado.Nome;
                txtCpf.Text = ClienteSelecionado.Cpf;
                txtCidade.Text = ClienteSelecionado.Cidade;
                txtBairro.Text = ClienteSelecionado.Bairro;
                txtEndereco.Text = ClienteSelecionado.Endereco;
            }
            else 
            {
                MessageBox.Show("Nenhum dado retornado!");
            }
        }
        private void CarregaCamposCpf(string cpf) 
        {
            ClienteSelecionado = OperadorBLL.BuscaClienteCpf(cpf);
            PreencherCampos();
        }
        private void CarregaCamposNome(string nome)
        {
            ClienteSelecionado = OperadorBLL.BuscaClienteNome(nome);
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
            txtCidade.ResetText();
            erroCidade.ResetText();
            txtBairro.ResetText();
            erroBairro.ResetText();
            txtEndereco.ResetText();
            erroEndereco.ResetText();
            ClienteSelecionado = null;
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
                lblCidade.Visible = false;
                txtCidade.Visible = false;
                erroCidade.Visible = false;
                lblBairro.Visible = false;
                txtBairro.Visible = false;
                erroBairro.Visible = false;
                lblEndereco.Visible = false;
                txtEndereco.Visible = false;
                erroEndereco.Visible = false;
                
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
                lblCidade.Visible = true;
                txtCidade.Visible = true;
                erroCidade.Visible = true;
                lblBairro.Visible = true;
                txtBairro.Visible = true;
                erroBairro.Visible = true;
                lblEndereco.Visible = true;
                txtEndereco.Visible = true;
                erroEndereco.Visible = true;

            }
        }
        /// <summary>
        /// Verifica se não há nenhum erro no preenchimento dos campos
        /// </summary>
        /// <returns></returns>
        private bool CamposValidados()
        {
            if (erroNome.Text == "" && erroCpf.Text == "" && erroCidade.Text == "" && erroBairro.Text == "" && erroEndereco.Text == "" &&
                txtNome.Text != "" && txtCpf.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "")
            {
                return true;
            }
            else
            {
                return false;
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
            if (txtEndereco.Text.ToString() == "" || txtEndereco.Text == null)
            {
                erroEndereco.Text = "Favor preencher o campo";
            }
            else
            {
                if (txtEndereco.Text.ToString().Length <= 2)
                {
                    erroEndereco.Text = "Favor preencher o campo com o nome de um bairro";
                }
                else
                {
                    erroEndereco.ResetText();
                }
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
            if (ClienteSelecionado != null)
            {
                if (CamposValidados())
                {
                    ClienteSelecionado.Nome = txtNome.Text;
                    ClienteSelecionado.Cpf = txtCpf.Text;
                    ClienteSelecionado.Cidade = txtCidade.Text;
                    ClienteSelecionado.Bairro = txtBairro.Text;
                    ClienteSelecionado.Endereco = txtEndereco.Text;

                    if (OperadorBLL.AlteraCliente(ClienteSelecionado))
                    {
                        MessageBox.Show("Cliente alterado com sucesso!");
                        LimparCampos();
                        OcultaCampos();
                        Preenchercbox();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel alterar o Cliente!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha corretamente todos os campos!");
                }
            }
            else 
            {
                MessageBox.Show("Selecione um cliente para ser alterado");
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

       

        
    }
}
