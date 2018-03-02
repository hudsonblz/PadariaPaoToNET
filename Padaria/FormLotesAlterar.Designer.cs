namespace Padaria
{
    partial class FormLotesAlterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLotesAlterar));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ckbPerecivel = new System.Windows.Forms.CheckBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cboxProdutos = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboxSelecionaCodigo = new System.Windows.Forms.ComboBox();
            this.lblSelecionaCodigo = new System.Windows.Forms.Label();
            this.lblSelecionaProduto = new System.Windows.Forms.Label();
            this.cboxSelecionaProdutos = new System.Windows.Forms.ComboBox();
            this.erroCodigo = new System.Windows.Forms.Label();
            this.erroQuantidade = new System.Windows.Forms.Label();
            this.erroPreco = new System.Windows.Forms.Label();
            this.erroData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(852, 503);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(144, 46);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(170)))), ((int)(((byte)(40)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(432, 503);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 46);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::Padaria.Properties.Resources.Voltar_text2;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 32);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ckbPerecivel
            // 
            this.ckbPerecivel.AutoSize = true;
            this.ckbPerecivel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPerecivel.Location = new System.Drawing.Point(170, 414);
            this.ckbPerecivel.Name = "ckbPerecivel";
            this.ckbPerecivel.Size = new System.Drawing.Size(80, 21);
            this.ckbPerecivel.TabIndex = 8;
            this.ckbPerecivel.Text = "Perecivel";
            this.ckbPerecivel.UseVisualStyleBackColor = true;
            // 
            // dtpValidade
            // 
            this.dtpValidade.Location = new System.Drawing.Point(401, 229);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(226, 20);
            this.dtpValidade.TabIndex = 9;
            this.dtpValidade.ValueChanged += new System.EventHandler(this.dtpValidade_ValueChanged);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAtivo.Location = new System.Drawing.Point(15, 414);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(59, 21);
            this.ckbAtivo.TabIndex = 7;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 366);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(69, 17);
            this.lblPreco.TabIndex = 33;
            this.lblPreco.Text = "Preço/UN:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 321);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidade.TabIndex = 32;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(333, 229);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(61, 17);
            this.lblValidade.TabIndex = 31;
            this.lblValidade.Text = "Validade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 275);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 17);
            this.lblProduto.TabIndex = 30;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 229);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 17);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Código:";
            // 
            // cboxProdutos
            // 
            this.cboxProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxProdutos.BackColor = System.Drawing.Color.White;
            this.cboxProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProdutos.FormattingEnabled = true;
            this.cboxProdutos.Location = new System.Drawing.Point(100, 272);
            this.cboxProdutos.Name = "cboxProdutos";
            this.cboxProdutos.Size = new System.Drawing.Size(277, 25);
            this.cboxProdutos.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(100, 363);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(186, 25);
            this.txtPreco.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(100, 318);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(186, 25);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(100, 226);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 25);
            this.txtCodigo.TabIndex = 3;
            // 
            // cboxSelecionaCodigo
            // 
            this.cboxSelecionaCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxSelecionaCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSelecionaCodigo.BackColor = System.Drawing.Color.White;
            this.cboxSelecionaCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSelecionaCodigo.FormattingEnabled = true;
            this.cboxSelecionaCodigo.Location = new System.Drawing.Point(497, 115);
            this.cboxSelecionaCodigo.Name = "cboxSelecionaCodigo";
            this.cboxSelecionaCodigo.Size = new System.Drawing.Size(186, 25);
            this.cboxSelecionaCodigo.TabIndex = 2;
            this.cboxSelecionaCodigo.SelectedIndexChanged += new System.EventHandler(this.cboxSelecionaCodigo_SelectedIndexChanged);
            // 
            // lblSelecionaCodigo
            // 
            this.lblSelecionaCodigo.AutoSize = true;
            this.lblSelecionaCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaCodigo.Location = new System.Drawing.Point(409, 118);
            this.lblSelecionaCodigo.Name = "lblSelecionaCodigo";
            this.lblSelecionaCodigo.Size = new System.Drawing.Size(54, 17);
            this.lblSelecionaCodigo.TabIndex = 39;
            this.lblSelecionaCodigo.Text = "Código:";
            // 
            // lblSelecionaProduto
            // 
            this.lblSelecionaProduto.AutoSize = true;
            this.lblSelecionaProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaProduto.Location = new System.Drawing.Point(12, 118);
            this.lblSelecionaProduto.Name = "lblSelecionaProduto";
            this.lblSelecionaProduto.Size = new System.Drawing.Size(61, 17);
            this.lblSelecionaProduto.TabIndex = 41;
            this.lblSelecionaProduto.Text = "Produto:";
            // 
            // cboxSelecionaProdutos
            // 
            this.cboxSelecionaProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxSelecionaProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSelecionaProdutos.BackColor = System.Drawing.Color.White;
            this.cboxSelecionaProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSelecionaProdutos.FormattingEnabled = true;
            this.cboxSelecionaProdutos.Location = new System.Drawing.Point(100, 115);
            this.cboxSelecionaProdutos.Name = "cboxSelecionaProdutos";
            this.cboxSelecionaProdutos.Size = new System.Drawing.Size(277, 25);
            this.cboxSelecionaProdutos.TabIndex = 1;
            this.cboxSelecionaProdutos.SelectedIndexChanged += new System.EventHandler(this.cboxSelecionaProdutos_SelectedIndexChanged);
            // 
            // erroCodigo
            // 
            this.erroCodigo.AutoSize = true;
            this.erroCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroCodigo.ForeColor = System.Drawing.Color.Red;
            this.erroCodigo.Location = new System.Drawing.Point(102, 254);
            this.erroCodigo.Name = "erroCodigo";
            this.erroCodigo.Size = new System.Drawing.Size(0, 13);
            this.erroCodigo.TabIndex = 42;
            // 
            // erroQuantidade
            // 
            this.erroQuantidade.AutoSize = true;
            this.erroQuantidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroQuantidade.ForeColor = System.Drawing.Color.Red;
            this.erroQuantidade.Location = new System.Drawing.Point(102, 347);
            this.erroQuantidade.Name = "erroQuantidade";
            this.erroQuantidade.Size = new System.Drawing.Size(0, 13);
            this.erroQuantidade.TabIndex = 43;
            // 
            // erroPreco
            // 
            this.erroPreco.AutoSize = true;
            this.erroPreco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroPreco.ForeColor = System.Drawing.Color.Red;
            this.erroPreco.Location = new System.Drawing.Point(102, 391);
            this.erroPreco.Name = "erroPreco";
            this.erroPreco.Size = new System.Drawing.Size(0, 13);
            this.erroPreco.TabIndex = 44;
            // 
            // erroData
            // 
            this.erroData.AutoSize = true;
            this.erroData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroData.ForeColor = System.Drawing.Color.Red;
            this.erroData.Location = new System.Drawing.Point(398, 252);
            this.erroData.Name = "erroData";
            this.erroData.Size = new System.Drawing.Size(0, 13);
            this.erroData.TabIndex = 45;
            // 
            // FormLotesAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.erroData);
            this.Controls.Add(this.erroPreco);
            this.Controls.Add(this.erroQuantidade);
            this.Controls.Add(this.erroCodigo);
            this.Controls.Add(this.lblSelecionaProduto);
            this.Controls.Add(this.cboxSelecionaProdutos);
            this.Controls.Add(this.lblSelecionaCodigo);
            this.Controls.Add(this.cboxSelecionaCodigo);
            this.Controls.Add(this.ckbPerecivel);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.ckbAtivo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cboxProdutos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLotesAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Lotes";
            this.Load += new System.EventHandler(this.FormLotesAlterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckBox ckbPerecivel;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboxProdutos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboxSelecionaCodigo;
        private System.Windows.Forms.Label lblSelecionaCodigo;
        private System.Windows.Forms.Label lblSelecionaProduto;
        private System.Windows.Forms.ComboBox cboxSelecionaProdutos;
        private System.Windows.Forms.Label erroCodigo;
        private System.Windows.Forms.Label erroQuantidade;
        private System.Windows.Forms.Label erroPreco;
        private System.Windows.Forms.Label erroData;

    }
}