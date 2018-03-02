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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        BLL.Usuario OperadorBLL = new BLL.Usuario();
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Model.Usuario usuarioLogado = OperadorBLL.VerificaLogin(txtLogin.Text, txtSenha.Text);
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Acesso == "ADMINISTRADOR")
                {
                    Form Exibir = new FormAdmin();
                    this.Visible = false;
                    this.txtLogin.Clear();
                    this.txtSenha.Clear();
                    Exibir.ShowDialog();
                    this.Visible = true;
                }
                else if (usuarioLogado.Acesso == "REPOSITOR") 
                {
                    Form Exibir = new FormRepositor();
                    this.Visible = false;
                    this.txtLogin.Clear();
                    this.txtSenha.Clear();
                    Exibir.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    Form Exibir = new FormCaixa();
                    this.Visible = false;
                    this.txtLogin.Clear();
                    this.txtSenha.Clear();
                    Exibir.ShowDialog();
                    this.Visible = true;
                }
            }
            else 
            {
                MessageBox.Show("O login ou senha estao incorretos");
            }
        }
    }
}
