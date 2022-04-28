namespace SistemaAlunosFormsApp
{
    partial class F_GestaoDeAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_selecionarAluno = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brn_fechar = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_excluirAluno = new System.Windows.Forms.Button();
            this.brn_salverEdicoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecionarAluno)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_selecionarAluno
            // 
            this.dgv_selecionarAluno.AllowUserToAddRows = false;
            this.dgv_selecionarAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_selecionarAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_selecionarAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selecionarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_selecionarAluno.EnableHeadersVisualStyles = false;
            this.dgv_selecionarAluno.Location = new System.Drawing.Point(14, 8);
            this.dgv_selecionarAluno.MultiSelect = false;
            this.dgv_selecionarAluno.Name = "dgv_selecionarAluno";
            this.dgv_selecionarAluno.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_selecionarAluno.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_selecionarAluno.RowHeadersVisible = false;
            this.dgv_selecionarAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_selecionarAluno.Size = new System.Drawing.Size(305, 395);
            this.dgv_selecionarAluno.TabIndex = 1;
            this.dgv_selecionarAluno.SelectionChanged += new System.EventHandler(this.dgv_selecionarAluno_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.brn_fechar);
            this.panel1.Controls.Add(this.btn_financeiro);
            this.panel1.Controls.Add(this.btn_excluirAluno);
            this.panel1.Controls.Add(this.brn_salverEdicoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 31);
            this.panel1.TabIndex = 2;
            // 
            // brn_fechar
            // 
            this.brn_fechar.Location = new System.Drawing.Point(501, 5);
            this.brn_fechar.Name = "brn_fechar";
            this.brn_fechar.Size = new System.Drawing.Size(160, 23);
            this.brn_fechar.TabIndex = 3;
            this.brn_fechar.Text = "Fechar";
            this.brn_fechar.UseVisualStyleBackColor = true;
            this.brn_fechar.Click += new System.EventHandler(this.brn_fechar_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Location = new System.Drawing.Point(335, 4);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(160, 23);
            this.btn_financeiro.TabIndex = 2;
            this.btn_financeiro.Text = "Finceiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_excluirAluno
            // 
            this.btn_excluirAluno.Location = new System.Drawing.Point(170, 4);
            this.btn_excluirAluno.Name = "btn_excluirAluno";
            this.btn_excluirAluno.Size = new System.Drawing.Size(160, 23);
            this.btn_excluirAluno.TabIndex = 1;
            this.btn_excluirAluno.Text = "Excluir Aluno";
            this.btn_excluirAluno.UseVisualStyleBackColor = true;
            this.btn_excluirAluno.Click += new System.EventHandler(this.btn_excluirAluno_Click);
            // 
            // brn_salverEdicoes
            // 
            this.brn_salverEdicoes.Location = new System.Drawing.Point(6, 3);
            this.brn_salverEdicoes.Name = "brn_salverEdicoes";
            this.brn_salverEdicoes.Size = new System.Drawing.Size(160, 23);
            this.brn_salverEdicoes.TabIndex = 0;
            this.brn_salverEdicoes.Text = "Salver Edições";
            this.brn_salverEdicoes.UseVisualStyleBackColor = true;
            this.brn_salverEdicoes.Click += new System.EventHandler(this.brn_salverEdicoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turmas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clique dluplo para alterar a foto";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(345, 37);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(296, 20);
            this.tb_nome.TabIndex = 8;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(345, 104);
            this.mtb_telefone.Mask = "(99)99999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtb_telefone.TabIndex = 9;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(494, 104);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(147, 21);
            this.cb_status.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Imprimir Carterinha";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(345, 168);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(296, 21);
            this.cb_turma.TabIndex = 12;
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_foto.Location = new System.Drawing.Point(345, 246);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(102, 136);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 11;
            this.pb_foto.TabStop = false;
            // 
            // F_GestaoDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(664, 448);
            this.Controls.Add(this.cb_turma);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_selecionarAluno);
            this.Name = "F_GestaoDeAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de alunos";
            this.Load += new System.EventHandler(this.F_GestaoDeAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecionarAluno)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_selecionarAluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button brn_fechar;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_excluirAluno;
        private System.Windows.Forms.Button brn_salverEdicoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.ComboBox cb_turma;
    }
}
