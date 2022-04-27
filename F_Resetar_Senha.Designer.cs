namespace SistemaAlunosFormsApp
{
    partial class F_Resetar_Senha
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
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.txtResetPassVerf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResetPass
            // 
            this.txtResetPass.Location = new System.Drawing.Point(171, 102);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Size = new System.Drawing.Size(100, 20);
            this.txtResetPass.TabIndex = 0;
            // 
            // txtResetPassVerf
            // 
            this.txtResetPassVerf.Location = new System.Drawing.Point(171, 208);
            this.txtResetPassVerf.Name = "txtResetPassVerf";
            this.txtResetPassVerf.Size = new System.Drawing.Size(100, 20);
            this.txtResetPassVerf.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Resetar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Resetar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResetPassVerf);
            this.Controls.Add(this.txtResetPass);
            this.Name = "F_Resetar_Senha";
            this.Text = "F_Resetar_Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.TextBox txtResetPassVerf;
        private System.Windows.Forms.Button button1;
    }
}