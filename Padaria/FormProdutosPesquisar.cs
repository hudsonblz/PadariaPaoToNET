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
    public partial class FormProdutosPesquisar : Form
    {
        public FormProdutosPesquisar()
        {
            InitializeComponent();
        }
        private void FormProdutosPesquisar_Load(object sender, EventArgs e)
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
            if (txtNome.Text != "" && txtCodigo.Text != "" && txtPrecoVenda.Text != "" && cboxUnidade.SelectedItem.ToString() != "")
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
            txtNome.ResetText();
            txtPrecoVenda.ResetText();
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
