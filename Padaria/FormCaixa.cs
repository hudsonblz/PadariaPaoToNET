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
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();
        }

        private void FormCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
             
        }
    }
}
