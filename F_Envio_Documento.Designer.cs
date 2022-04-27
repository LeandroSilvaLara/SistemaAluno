namespace SistemaAlunosFormsApp
{
    partial class F_Envio_Documento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.textDestinatario = new System.Windows.Forms.TextBox();
            this.textAssunto = new System.Windows.Forms.TextBox();
            this.textMensagem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remetente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinatário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Assunto";
            // 
            // txtRemetente
            // 
            this.txtRemetente.Location = new System.Drawing.Point(122, 146);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(320, 20);
            this.txtRemetente.TabIndex = 4;
            // 
            // textDestinatario
            // 
            this.textDestinatario.Location = new System.Drawing.Point(122, 202);
            this.textDestinatario.Name = "textDestinatario";
            this.textDestinatario.Size = new System.Drawing.Size(320, 20);
            this.textDestinatario.TabIndex = 5;
            // 
            // textAssunto
            // 
            this.textAssunto.Location = new System.Drawing.Point(122, 258);
            this.textAssunto.Name = "textAssunto";
            this.textAssunto.Size = new System.Drawing.Size(320, 20);
            this.textAssunto.TabIndex = 6;
            // 
            // textMensagem
            // 
            this.textMensagem.Location = new System.Drawing.Point(122, 310);
            this.textMensagem.MaxLength = 60000;
            this.textMensagem.Multiline = true;
            this.textMensagem.Name = "textMensagem";
            this.textMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMensagem.Size = new System.Drawing.Size(320, 90);
            this.textMensagem.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mensagem";
            // 
            // lblAnexo
            // 
            this.lblAnexo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAnexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexo.Location = new System.Drawing.Point(142, 426);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(300, 23);
            this.lblAnexo.TabIndex = 9;
            this.lblAnexo.Click += new System.EventHandler(this.lblAnexo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(232, 461);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(101, 38);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_Envio_Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 538);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblAnexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMensagem);
            this.Controls.Add(this.textAssunto);
            this.Controls.Add(this.textDestinatario);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Envio_Documento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Envio_Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox textDestinatario;
        private System.Windows.Forms.TextBox textAssunto;
        internal System.Windows.Forms.TextBox textMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}