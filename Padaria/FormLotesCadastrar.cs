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
    public partial class FormLotesCadastrar : Form
    {
        public FormLotesCadastrar()
        {
            InitializeComponent();
        }
        private void FormLotesCadastrar_Load(object sender, EventArgs e)
        {
            preencherProdutos();
            lblValidade.Visible = false;
            dtpValidade.Visible = false;
        }

        #region Variaveis
        BLL.Lote OperadorBLL_Lote = new BLL.Lote();
        BLL.Produto OperadorBLL_Produto = new BLL.Produto();
        Model.Lote NovoLote = new Model.Lote();
        #endregion

        #region Funcoes

        private void preencherProdutos()
        {
            foreach (string item in OperadorBLL_Produto.ListaNomeAtivos())
            {
                cboxProdutos.Items.Add(item);
            }
        }
        private void limparCampos() 
        {
            txtCodigo.ResetText();
            txtPreco.ResetText();
            txtQuantidade.ResetText();
            cboxProdutos.ResetText();
            ckbAtivo.Checked = false;
            ckbPerecivel.Checked = false;
            dtpValidade.Visible = false;
            lblValidade.Visible = false;
            erroCodigo.ResetText();
            erroData.ResetText();
            erroPreco.ResetText();
            erroQuantidade.ResetText();
        }
        private bool CamposValidados() 
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
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposValidados())
            {
                NovoLote.Codigo = txtCodigo.Text;
                NovoLote.Produto = cboxProdutos.SelectedItem.ToString();
                NovoLote.Quantidade = float.Parse(txtQuantidade.Text);
                NovoLote.PrecoCusto = decimal.Parse(txtPreco.Text);
                NovoLote.Ativo = ckbAtivo.Checked;
                if (ckbPerecivel.Checked)
                {
                    NovoLote.Validade = dtpValidade.Value.Date;
                }
                else
                {
                    NovoLote.Validade = null;
                }
                if (OperadorBLL_Lote.cadastraLote(NovoLote)) 
                {
                    MessageBox.Show("Lote cadastrado com sucesso!");
                    limparCampos();
                }
                else 
                {
                    MessageBox.Show("Falha ao cadastrar Lote!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
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
