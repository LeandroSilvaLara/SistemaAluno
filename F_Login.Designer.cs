using System;

namespace SistemaAlunosFormsApp
{
    partial class F_Login
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
            this.tb_text = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_canelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_text
            // 
            this.tb_text.AutoSize = true;
            this.tb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_text.Location = new System.Drawing.Point(64, 127);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(128, 20);
            this.tb_text.TabIndex = 0;
            this.tb_text.Text = "Digite seu E-mail";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(109, 164);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(340, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "reandoro";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(109, 253);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(340, 20);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.Text = "123";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(64, 218);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(131, 20);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Digite sua Senha";
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(156, 339);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_canelar
            // 
            this.btn_canelar.Location = new System.Drawing.Point(301, 339);
            this.btn_canelar.Name = "btn_canelar";
            this.btn_canelar.Size = new System.Drawing.Size(75, 23);
            this.btn_canelar.TabIndex = 5;
            this.btn_canelar.Text = "Cancelar";
            this.btn_canelar.UseVisualStyleBackColor = true;
            this.btn_canelar.Click += new System.EventHandler(this.btn_canelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 76);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "OnliNotas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaAlunosFormsApp.Properties.Resources.Educa;
            this.pictureBox1.Location = new System.Drawing.Point(69, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(518, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_canelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tb_text;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_canelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}