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
    public partial class FormClientesPesquisar : Form
    {
        public FormClientesPesquisar()
        {
            InitializeComponent();
        }
        private void FormClientesPesquisar_Load(object sender, EventArgs e)
        {
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
        #endregion

        #region Botoes
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion     

        #region Seletores
        private void cboxCpf_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaCamposCpf(cboxCpf.SelectedItem.ToString());
        }
        private void cboxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaCamposNome(cboxNome.SelectedItem.ToString());
        }
        #endregion
        
    }
}
