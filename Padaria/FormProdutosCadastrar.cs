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
    public partial class FormProdutosCadastrar : Form
    {
        public FormProdutosCadastrar()
        {
            InitializeComponent();
        }
        private void FormProdutosCadastrar_Load(object sender, EventArgs e)
        {
            cboxUnidade.SelectedIndex = 1;
        }

        #region Variaveis
        BLL.Produto OperadorBLL = new BLL.Produto();
        #endregion

        #region Funcoes

        private bool CamposValidos() 
        {
            if (txtNome.Text != "" && txtCodigo.Text != "" && txtPrecoVenda.Text != "" && cboxUnidade.SelectedItem.ToString() != "" 
                && erroNome.Text == "" && erroPreco.Text == "" && erroCodigo.Text == "") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LimparCampos() 
        {
            txtCodigo.ResetText();
            erroCodigo.ResetText();
            txtNome.ResetText();
            erroNome.ResetText();
            txtPrecoVenda.ResetText();
            erroPreco.ResetText();
            cboxUnidade.SelectedIndex = 1;
            ckbAtivo.Checked = false;
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
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                Model.Produto produto = new Model.Produto
                {
                    Codigo = txtCodigo.Text,
                    Nome = txtNome.Text,
                    PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text),
                    Unidade = cboxUnidade.SelectedItem.ToString(),
                    Ativo = ckbAtivo.Checked
                };
                if (OperadorBLL.CadastraProduto(produto))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar produto!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        #endregion

        #region Validacoes

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Count() < 5) 
            {
                erroNome.Text = "Favor prencher o campo com um nome de pelomenos 5 caractereses";
            }
            else 
            {
                erroNome.ResetText();
            }
        }
        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            decimal Preco;
            if (!decimal.TryParse(txtPrecoVenda.Text, out Preco)) 
            {
                erroPreco.Text = "Favor informar um preço valido para o produto!";
            }
            else 
            {
                erroPreco.ResetText();
            }
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            long resultado;
            if (txtCodigo.Text.Count() == 5 && long.TryParse(txtCodigo.Text, out resultado))
            {
                erroCodigo.ResetText();
            }
            else if(txtCodigo.Text.Count() == 13 && long.TryParse(txtCodigo.Text, out resultado))
            {
                erroCodigo.ResetText();
            }
            else
            {
                erroCodigo.Text = "Favor inserir um codigo valido!(5 digitos para produtos agranel e 13 para os demais)";
            }
        }

        #endregion


    }
}
