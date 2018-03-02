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
    public partial class FormProdutosAlterar : Form
    {
        public FormProdutosAlterar()
        {
            InitializeComponent();
        }
        private void FormProdutosAlterar_Load(object sender, EventArgs e)
        {
            OcultarCampos();
            PreencherCbox();
        }
        #region Variaveis

        Model.Produto ProdutoSelecionado = null;
        BLL.Produto OperadorBLL = new BLL.Produto();

        #endregion

        #region Funcoes

        private void CarregaCamposCodigo(string codigo)
        {
            ProdutoSelecionado = OperadorBLL.BuscaProdutoCodigo(codigo);
            PreencherCampos();
        }
        private void CarregaCamposNome(string nome)
        {
            ProdutoSelecionado = OperadorBLL.BuscaProdutoNome(nome);
            PreencherCampos();
        }
        private void PreencherCampos()
        {
            if (ProdutoSelecionado != null)
            {
                txtNome.Text = ProdutoSelecionado.Nome;
                txtCodigo.Text = ProdutoSelecionado.Codigo;
                txtPrecoVenda.Text = ProdutoSelecionado.PrecoVenda.ToString();
                cboxUnidade.SelectedItem = ProdutoSelecionado.Unidade;
                ckbAtivo.Checked = ProdutoSelecionado.Ativo;
            }
            else
            {
                MessageBox.Show("Nenhum dado retornado!");
            }
        }
        private void PreencherCbox() 
        {
            cboxCodigo.Items.Clear();
            cboxNome.Items.Clear();
            List<string> ListaDeCPF = OperadorBLL.ListaCodigos();
            foreach (string cpf in ListaDeCPF)
            {
                cboxCodigo.Items.Add(cpf);
            }
            List<string> ListaDeNomes = OperadorBLL.ListaNome();
            foreach (string nome in ListaDeNomes)
            {
                cboxNome.Items.Add(nome);
            }
        }
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
            cboxCodigo.ResetText();
            cboxNome.ResetText();
            txtCodigo.ResetText();
            erroCodigo.ResetText();
            txtNome.ResetText();
            erroNome.ResetText();
            txtPrecoVenda.ResetText();
            erroPreco.ResetText();
            cboxUnidade.SelectedIndex = 1;
            ckbAtivo.Checked = false;
            ProdutoSelecionado = null;
        }
        private void OcultarCampos() 
        {
            if (txtNome.Visible) 
            {
                txtNome.Visible = false;
                txtCodigo.Visible = false;
                txtPrecoVenda.Visible = false;
                erroNome.Visible = false;
                erroCodigo.Visible = false;
                erroPreco.Visible = false;
                cboxUnidade.Visible = false;
                ckbAtivo.Visible = false;
                lblNome.Visible = false;
                lblCodigo.Visible = false;
                lblPreco.Visible = false;
                lblUnidade.Visible = false;
            }
        }
        private void ExibirCampos()
        {
            if (!txtNome.Visible)
            {
                txtNome.Visible = true;
                txtCodigo.Visible = true;
                txtPrecoVenda.Visible = true;
                erroNome.Visible = true;
                erroCodigo.Visible = true;
                erroPreco.Visible = true;
                cboxUnidade.Visible = true;
                ckbAtivo.Visible = true;
                lblNome.Visible = true;
                lblCodigo.Visible = true;
                lblPreco.Visible = true;
                lblUnidade.Visible = true;
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
            OcultarCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                ProdutoSelecionado.Nome = txtNome.Text;
                ProdutoSelecionado.Codigo = txtCodigo.Text;
                ProdutoSelecionado.PrecoVenda = decimal.Parse(txtPrecoVenda.Text.Replace('.', ','));
                ProdutoSelecionado.Unidade = cboxUnidade.SelectedItem.ToString();
                ProdutoSelecionado.Ativo = ckbAtivo.Checked;
                if (OperadorBLL.AtualizarProduto(ProdutoSelecionado))
                {
                    MessageBox.Show("Produto atualizado com sucesso!");
                    LimparCampos(); 
                    PreencherCbox();
                    OcultarCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar o produto!");
                }
            }
            else
            {
                MessageBox.Show("Corrija os erros nos campos!");
            }
        }

        #endregion

        #region Seletores

        private void cboxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarCampos();
            LimparCampos();
            CarregaCamposCodigo(cboxCodigo.SelectedItem.ToString());
            ExibirCampos();
        }
        private void cboxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarCampos();
            LimparCampos();
            CarregaCamposNome(cboxNome.SelectedItem.ToString());
            ExibirCampos();
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
            else if (txtCodigo.Text.Count() == 13 && long.TryParse(txtCodigo.Text, out resultado))
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
