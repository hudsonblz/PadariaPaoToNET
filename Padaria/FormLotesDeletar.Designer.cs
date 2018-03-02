namespace Padaria
{
    partial class FormLotesDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLotesDeletar));
            this.lblSelecionaProduto = new System.Windows.Forms.Label();
            this.cboxSelecionaProdutos = new System.Windows.Forms.ComboBox();
            this.lblSelecionaCodigo = new System.Windows.Forms.Label();
            this.cboxSelecionaCodigo = new System.Windows.Forms.ComboBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelecionaProduto
            // 
            this.lblSelecionaProduto.AutoSize = true;
            this.lblSelecionaProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaProduto.Location = new System.Drawing.Point(12, 118);
            this.lblSelecionaProduto.Name = "lblSelecionaProduto";
            this.lblSelecionaProduto.Size = new System.Drawing.Size(61, 17);
            this.lblSelecionaProduto.TabIndex = 65;
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
            this.cboxSelecionaProdutos.TabIndex = 46;
            this.cboxSelecionaProdutos.SelectedIndexChanged += new System.EventHandler(this.cboxSelecionaProdutos_SelectedIndexChanged);
            // 
            // lblSelecionaCodigo
            // 
            this.lblSelecionaCodigo.AutoSize = true;
            this.lblSelecionaCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaCodigo.Location = new System.Drawing.Point(409, 118);
            this.lblSelecionaCodigo.Name = "lblSelecionaCodigo";
            this.lblSelecionaCodigo.Size = new System.Drawing.Size(54, 17);
            this.lblSelecionaCodigo.TabIndex = 64;
            this.lblSelecionaCodigo.Text = "Código:";
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
            this.cboxSelecionaCodigo.TabIndex = 47;
            this.cboxSelecionaCodigo.SelectedIndexChanged += new System.EventHandler(this.cboxSelecionaCodigo_SelectedIndexChanged);
            // 
            // ckbPerecivel
            // 
            this.ckbPerecivel.AutoSize = true;
            this.ckbPerecivel.Enabled = false;
            this.ckbPerecivel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPerecivel.Location = new System.Drawing.Point(170, 414);
            this.ckbPerecivel.Name = "ckbPerecivel";
            this.ckbPerecivel.Size = new System.Drawing.Size(80, 21);
            this.ckbPerecivel.TabIndex = 53;
            this.ckbPerecivel.Text = "Perecivel";
            this.ckbPerecivel.UseVisualStyleBackColor = true;
            // 
            // dtpValidade
            // 
            this.dtpValidade.Enabled = false;
            this.dtpValidade.Location = new System.Drawing.Point(401, 229);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(226, 20);
            this.dtpValidade.TabIndex = 54;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Enabled = false;
            this.ckbAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAtivo.Location = new System.Drawing.Point(15, 414);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(59, 21);
            this.ckbAtivo.TabIndex = 52;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Enabled = false;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 366);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(69, 17);
            this.lblPreco.TabIndex = 63;
            this.lblPreco.Text = "Preço/UN:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Enabled = false;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 321);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidade.TabIndex = 62;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Enabled = false;
            this.lblValidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(333, 229);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(61, 17);
            this.lblValidade.TabIndex = 61;
            this.lblValidade.Text = "Validade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Enabled = false;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 275);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 17);
            this.lblProduto.TabIndex = 60;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Enabled = false;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 229);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 17);
            this.lblCodigo.TabIndex = 59;
            this.lblCodigo.Text = "Código:";
            // 
            // cboxProdutos
            // 
            this.cboxProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxProdutos.BackColor = System.Drawing.Color.White;
            this.cboxProdutos.Enabled = false;
            this.cboxProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProdutos.FormattingEnabled = true;
            this.cboxProdutos.Location = new System.Drawing.Point(100, 272);
            this.cboxProdutos.Name = "cboxProdutos";
            this.cboxProdutos.Size = new System.Drawing.Size(277, 25);
            this.cboxProdutos.TabIndex = 49;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(100, 363);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(186, 25);
            this.txtPreco.TabIndex = 51;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(100, 318);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(186, 25);
            this.txtQuantidade.TabIndex = 50;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(100, 226);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 25);
            this.txtCodigo.TabIndex = 48;
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
            this.btnCancelar.TabIndex = 55;
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
            this.btnVoltar.TabIndex = 58;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(852, 503);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(144, 46);
            this.btnDeletar.TabIndex = 70;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // FormLotesDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnDeletar);
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
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLotesDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Lotes";
            this.Load += new System.EventHandler(this.FormLotesDeletar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecionaProduto;
        private System.Windows.Forms.ComboBox cboxSelecionaProdutos;
        private System.Windows.Forms.Label lblSelecionaCodigo;
        private System.Windows.Forms.ComboBox cboxSelecionaCodigo;
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
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
    }
}