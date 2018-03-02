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
    public partial class FormLotesAlterar : Form
    {
        public FormLotesAlterar()
        {
            InitializeComponent();
        }
        private void FormLotesAlterar_Load(object sender, EventArgs e)
        {
            preencherSelecionaProdutos();
            ocultarCampos();
        }

        #region Variaveis
        BLL.Lote OperadorBLL_Lote = new BLL.Lote();
        BLL.Produto OperadorBLL_Produto = new BLL.Produto();
        Model.Lote LoteSelecionado = null;
        #endregion

        #region Funcoes

        private void preencherCampos() 
        {
            txtCodigo.Text = LoteSelecionado.Codigo;
            preencherProdutos();
            cboxProdutos.SelectedItem = LoteSelecionado.Produto;
            if (LoteSelecionado.Validade != null)
            {
                ckbPerecivel.Checked = true;
                dtpValidade.Value = (DateTime)LoteSelecionado.Validade;
            }
            else 
            {
                ckbPerecivel.Checked = false;
            }
            txtQuantidade.Text = LoteSelecionado.Quantidade.ToString();
            txtPreco.Text = LoteSelecionado.PrecoCusto.ToString();
            ckbAtivo.Checked = LoteSelecionado.Ativo;
        }
        private void ocultarCampos() 
        {
            if (txtCodigo.Visible) 
            {
                txtCodigo.Visible = false;
                lblCodigo.Visible = false;
                txtPreco.Visible = false;
                lblPreco.Visible = false;
                txtQuantidade.Visible = false;
                lblQuantidade.Visible = false;
                cboxProdutos.Visible = false;
                lblProduto.Visible = false;
                dtpValidade.Visible = false;
                lblValidade.Visible = false;
                ckbAtivo.Visible = false;
                ckbPerecivel.Visible = false;
                cboxSelecionaCodigo.Visible = false;
                lblSelecionaCodigo.Visible = false;
            }
        }
        private void exibeCampos() 
        {
            if (!txtCodigo.Visible)
            {
                txtCodigo.Visible = true;
                lblCodigo.Visible = true;
                txtPreco.Visible = true;
                lblPreco.Visible = true;
                txtQuantidade.Visible = true;
                lblQuantidade.Visible = true;
                cboxProdutos.Visible = true;
                lblProduto.Visible = true;
                ckbAtivo.Visible = true;
                ckbPerecivel.Visible = true;
                if (ckbPerecivel.Checked) 
                {
                    dtpValidade.Visible = true;
                    lblValidade.Visible = true;
                }
            }
        }
        private void preencherProdutos()
        {
            foreach (string item in OperadorBLL_Produto.ListaNomeAtivos())
            {
                cboxProdutos.Items.Add(item);
            }
        }
        private void preencherSelecionaProdutos() 
        {
            foreach (string item in OperadorBLL_Produto.ListaNomeAtivos())
            {
                cboxSelecionaProdutos.Items.Add(item);
            }
        }
        private void limparCampos()
        {
            txtCodigo.ResetText();
            txtPreco.ResetText();
            txtQuantidade.ResetText();
            ckbAtivo.Checked = false;
            ckbPerecivel.Checked = false;
            dtpValidade.Visible = false;
            lblValidade.Visible = false;
            cboxSelecionaProdutos.ResetText();
            cboxSelecionaCodigo.Items.Clear();
            cboxSelecionaCodigo.ResetText();
            cboxProdutos.ResetText();
            cboxProdutos.Items.Clear();
            erroCodigo.ResetText();
            erroData.ResetText();
            erroPreco.ResetText();
            erroQuantidade.ResetText();
            LoteSelecionado = null;
        }
        private bool camposValidados()
        {
            if (txtCodigo.Text != "" && txtPreco.Text != "" && txtQuantidade.Text != "" && cboxProdutos.SelectedItem.ToString() != "" &&
                erroCodigo.Text == "" && erroPreco.Text == "" && erroQuantidade.Text == "" && erroData.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void preencherCodigo(string produto)
        {
            foreach (string item in OperadorBLL_Lote.ListaCodigos(produto))
            {
                cboxSelecionaCodigo.Items.Add(item);
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
            limparCampos();
            ocultarCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (LoteSelecionado != null)
            {
                if (camposValidados())
                {
                    LoteSelecionado.Codigo = txtCodigo.Text;
                    LoteSelecionado.Produto = cboxProdutos.SelectedItem.ToString();
                    if (ckbPerecivel.Checked)
                    {
                        LoteSelecionado.Validade = dtpValidade.Value;
                    }
                    else
                    {
                        LoteSelecionado.Validade = null;
                    }
                    LoteSelecionado.Quantidade = float.Parse(txtQuantidade.Text);
                    LoteSelecionado.PrecoCusto = decimal.Parse(txtPreco.Text);
                    LoteSelecionado.Ativo = ckbAtivo.Checked;

                    if (OperadorBLL_Lote.atualizaLote(LoteSelecionado))
                    {
                        MessageBox.Show("O lote foi atualizado com sucesso!");
                        limparCampos();
                        ocultarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o lote!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor conferir o preenchimento dos campos!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Lote para ser alterado!");
            }
        }

        #endregion     

        #region Seletores

        private void cboxSelecionaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ocultarCampos();
            limparCampos();
            preencherCodigo(cboxSelecionaProdutos.SelectedItem.ToString());
            if (cboxSelecionaCodigo.Items.Count > 0)
            {
                lblSelecionaCodigo.Visible = true;
                cboxSelecionaCodigo.Visible = true;
            }
            else
            {
                MessageBox.Show("O produto não tem lotes cadastrados");
            }
        }
        private void cboxSelecionaCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ocultarCampos();
            LoteSelecionado = OperadorBLL_Lote.BuscaLote(cboxSelecionaCodigo.SelectedItem.ToString());
            preencherCampos();
            exibeCampos();
        }

        #endregion

        #region Validacoes

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                erroCodigo.Text = "Favor informar um codigo";
            }
            else
            {
                erroCodigo.ResetText();
            }
        }
        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            int qtd;
            if (int.TryParse(txtQuantidade.Text, out qtd))
            {
                erroQuantidade.ResetText();
            }
            else
            {
                erroQuantidade.Text = "Preencha o campo apenas com valores inteiros numericos!";
            }
        }
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            decimal qtd;
            if (decimal.TryParse(txtPreco.Text, out qtd))
            {
                erroPreco.ResetText();
            }
            else
            {
                erroPreco.Text = "Preencha o campo apenas com valores monetarios!";
            }
        }
        private void ckbPerecivel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPerecivel.Checked)
            {
                lblValidade.Visible = true;
                dtpValidade.Visible = true;
            }
            else
            {
                lblValidade.Visible = false;
                dtpValidade.Visible = false;
            }
        }
        private void dtpValidade_ValueChanged(object sender, EventArgs e)
        {
            if (dtpValidade.Value < DateTime.Now)
            {
                erroData.Text = "A data deve ser posterior a data atual";
            }
            else
            {
                erroData.ResetText();
            }
        }

        #endregion
                
    }
}
