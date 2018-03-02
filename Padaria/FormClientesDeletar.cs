using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Padaria
{
    public partial class FormClientesDeletar : Form
    {
        public FormClientesDeletar()
        {
            InitializeComponent();
        }
        private void FormClientesDeletar_Load(object sender, EventArgs e)
        {
            Preenchercbox();   
        }
        #region Variaveis
        private Model.Cliente ClienteSelecionado;
        private BLL.Cliente OperadorBLL = new BLL.Cliente();
        #endregion

        #region Funcoes
        private void CarregaCamposCpf(string cpf)
        {
            ClienteSelecionado = OperadorBLL.BuscaClienteCpf(cpf);
            if (ClienteSelecionado != null)
            {
                txtNome.Text = ClienteSelecionado.Nome;
                txtCpf.Text = ClienteSelecionado.Cpf;
                txtCidade.Text = ClienteSelecionado.Cidade;
                txtBairro.Text = ClienteSelecionado.Bairro;
                txtEndereco.Text = ClienteSelecionado.Endereco;
            }
        }
        private void CarregaCamposNome(string nome)
        {
            ClienteSelecionado = OperadorBLL.BuscaClienteNome(nome);
            if (ClienteSelecionado != null)
            {
                txtNome.Text = ClienteSelecionado.Nome;
                txtCpf.Text = ClienteSelecionado.Cpf;
                txtCidade.Text = ClienteSelecionado.Cidade;
                txtBairro.Text = ClienteSelecionado.Bairro;
                txtEndereco.Text = ClienteSelecionado.Endereco;
            }
        }
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
        private void LimparCampos()
        {
            cboxCpf.ResetText();
            cboxNome.ResetText();

            txtNome.ResetText();
            txtCpf.ResetText();
            txtCidade.ResetText();
            txtBairro.ResetText();
            txtEndereco.ResetText();
            ClienteSelecionado = null;
        }
        #endregion

        private void cboxCpf_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaCamposCpf(cboxCpf.SelectedItem.ToString());
        }

        private void cboxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaCamposNome(cboxNome.SelectedItem.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (ClienteSelecionado != null)
            {
                if (OperadorBLL.DeletaCliente(ClienteSelecionado.Id))
                {
                    MessageBox.Show("Cliente deletado com sucesso!");
                    Preenchercbox();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar o cliente!");
                }
            }
            else 
            {
                MessageBox.Show("Selecione um cliente para ser deletado!");
            }
        }


    }
}
