﻿namespace Padaria
{
    partial class FormUsuariosDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuariosDeletar));
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.erroSenha = new System.Windows.Forms.Label();
            this.erroLogin = new System.Windows.Forms.Label();
            this.erroCpf = new System.Windows.Forms.Label();
            this.erroNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.cboxNome = new System.Windows.Forms.ComboBox();
            this.cboxCpf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(79, 342);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(137, 25);
            this.txtCpf.TabIndex = 34;
            // 
            // erroSenha
            // 
            this.erroSenha.AutoSize = true;
            this.erroSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroSenha.ForeColor = System.Drawing.Color.Red;
            this.erroSenha.Location = new System.Drawing.Point(386, 372);
            this.erroSenha.Name = "erroSenha";
            this.erroSenha.Size = new System.Drawing.Size(0, 13);
            this.erroSenha.TabIndex = 47;
            // 
            // erroLogin
            // 
            this.erroLogin.AutoSize = true;
            this.erroLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroLogin.ForeColor = System.Drawing.Color.Red;
            this.erroLogin.Location = new System.Drawing.Point(76, 418);
            this.erroLogin.Name = "erroLogin";
            this.erroLogin.Size = new System.Drawing.Size(0, 13);
            this.erroLogin.TabIndex = 46;
            // 
            // erroCpf
            // 
            this.erroCpf.AutoSize = true;
            this.erroCpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroCpf.ForeColor = System.Drawing.Color.Red;
            this.erroCpf.Location = new System.Drawing.Point(76, 370);
            this.erroCpf.Name = "erroCpf";
            this.erroCpf.Size = new System.Drawing.Size(0, 13);
            this.erroCpf.TabIndex = 45;
            // 
            // erroNome
            // 
            this.erroNome.AutoSize = true;
            this.erroNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroNome.ForeColor = System.Drawing.Color.Red;
            this.erroNome.Location = new System.Drawing.Point(76, 322);
            this.erroNome.Name = "erroNome";
            this.erroNome.Size = new System.Drawing.Size(0, 13);
            this.erroNome.TabIndex = 44;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCpf.Location = new System.Drawing.Point(12, 350);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 17);
            this.lblCpf.TabIndex = 40;
            this.lblCpf.Text = "CPF:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAcesso.Location = new System.Drawing.Point(322, 398);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(53, 17);
            this.lblAcesso.TabIndex = 43;
            this.lblAcesso.Text = "Acesso:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(12, 302);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 17);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 294);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(319, 25);
            this.txtNome.TabIndex = 33;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(389, 344);
            this.txtSenha.MaxLength = 16;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(137, 25);
            this.txtSenha.TabIndex = 36;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenha.Location = new System.Drawing.Point(322, 352);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 17);
            this.lblSenha.TabIndex = 42;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogin.Location = new System.Drawing.Point(12, 398);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 17);
            this.lblLogin.TabIndex = 41;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(79, 390);
            this.txtLogin.MaxLength = 16;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(137, 25);
            this.txtLogin.TabIndex = 35;
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
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAcesso
            // 
            this.txtAcesso.BackColor = System.Drawing.Color.White;
            this.txtAcesso.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcesso.Location = new System.Drawing.Point(389, 390);
            this.txtAcesso.MaxLength = 16;
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.ReadOnly = true;
            this.txtAcesso.Size = new System.Drawing.Size(137, 25);
            this.txtAcesso.TabIndex = 51;
            this.txtAcesso.TabStop = false;
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
            this.btnVoltar.TabIndex = 52;
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
            this.btnDeletar.TabIndex = 63;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // cboxNome
            // 
            this.cboxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNome.FormattingEnabled = true;
            this.cboxNome.Location = new System.Drawing.Point(468, 125);
            this.cboxNome.Name = "cboxNome";
            this.cboxNome.Size = new System.Drawing.Size(322, 25);
            this.cboxNome.TabIndex = 65;
            this.cboxNome.SelectedIndexChanged += new System.EventHandler(this.cboxNome_SelectedIndexChanged);
            // 
            // cboxCpf
            // 
            this.cboxCpf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCpf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCpf.FormattingEnabled = true;
            this.cboxCpf.Location = new System.Drawing.Point(119, 125);
            this.cboxCpf.Name = "cboxCpf";
            this.cboxCpf.Size = new System.Drawing.Size(205, 25);
            this.cboxCpf.TabIndex = 64;
            this.cboxCpf.SelectedIndexChanged += new System.EventHandler(this.cboxCpf_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(345, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Buscar por Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Buscar por Cpf:";
            // 
            // FormUsuariosDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.cboxNome);
            this.Controls.Add(this.cboxCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtAcesso);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.erroSenha);
            this.Controls.Add(this.erroLogin);
            this.Controls.Add(this.erroCpf);
            this.Controls.Add(this.erroNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblAcesso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUsuariosDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Usuario";
            this.Load += new System.EventHandler(this.FormUsuariosDeletar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label erroSenha;
        private System.Windows.Forms.Label erroLogin;
        private System.Windows.Forms.Label erroCpf;
        private System.Windows.Forms.Label erroNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ComboBox cboxNome;
        private System.Windows.Forms.ComboBox cboxCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}