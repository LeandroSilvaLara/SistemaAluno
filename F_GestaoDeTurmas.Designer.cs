namespace SistemaAlunosFormsApp
{
    partial class F_GestaoDeTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluirHorario = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_exluirTurma = new System.Windows.Forms.Button();
            this.btn_salvarSalvaredicoes = new System.Windows.Forms.Button();
            this.btn_novaTurma = new System.Windows.Forms.Button();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.cb_professores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.n_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomeTurma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_excluirHorario);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_exluirTurma);
            this.panel1.Controls.Add(this.btn_salvarSalvaredicoes);
            this.panel1.Controls.Add(this.btn_novaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 36);
            this.panel1.TabIndex = 0;
            // 
            // btn_excluirHorario
            // 
            this.btn_excluirHorario.Location = new System.Drawing.Point(473, 4);
            this.btn_excluirHorario.Name = "btn_excluirHorario";
            this.btn_excluirHorario.Size = new System.Drawing.Size(150, 27);
            this.btn_excluirHorario.TabIndex = 10;
            this.btn_excluirHorario.Text = "Imprimir Turma";
            this.btn_excluirHorario.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(629, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(105, 27);
            this.btn_fechar.TabIndex = 11;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_exluirTurma
            // 
            this.btn_exluirTurma.Location = new System.Drawing.Point(317, 4);
            this.btn_exluirTurma.Name = "btn_exluirTurma";
            this.btn_exluirTurma.Size = new System.Drawing.Size(150, 27);
            this.btn_exluirTurma.TabIndex = 9;
            this.btn_exluirTurma.Text = "Excluir Horário";
            this.btn_exluirTurma.UseVisualStyleBackColor = true;
            this.btn_exluirTurma.Click += new System.EventHandler(this.btn_exluirTurma_Click);
            // 
            // btn_salvarSalvaredicoes
            // 
            this.btn_salvarSalvaredicoes.Location = new System.Drawing.Point(160, 4);
            this.btn_salvarSalvaredicoes.Name = "btn_salvarSalvaredicoes";
            this.btn_salvarSalvaredicoes.Size = new System.Drawing.Size(150, 27);
            this.btn_salvarSalvaredicoes.TabIndex = 8;
            this.btn_salvarSalvaredicoes.Text = "Salvar Edições";
            this.btn_salvarSalvaredicoes.UseVisualStyleBackColor = true;
            this.btn_salvarSalvaredicoes.Click += new System.EventHandler(this.btn_salvarSalvaredicoes_Click);
            // 
            // btn_novaTurma
            // 
            this.btn_novaTurma.Location = new System.Drawing.Point(5, 4);
            this.btn_novaTurma.Name = "btn_novaTurma";
            this.btn_novaTurma.Size = new System.Drawing.Size(150, 27);
            this.btn_novaTurma.TabIndex = 7;
            this.btn_novaTurma.Text = "Nova Turma";
            this.btn_novaTurma.UseVisualStyleBackColor = true;
            this.btn_novaTurma.Click += new System.EventHandler(this.btn_novaTurma_Click);
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(485, 477);
            this.dgv_turmas.TabIndex = 10;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // cb_professores
            // 
            this.cb_professores.FormattingEnabled = true;
            this.cb_professores.Location = new System.Drawing.Point(506, 79);
            this.cb_professores.Name = "cb_professores";
            this.cb_professores.Size = new System.Drawing.Size(204, 21);
            this.cb_professores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Professores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Máximo de Aluno";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(620, 135);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(90, 21);
            this.cb_status.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Satus";
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(506, 192);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(204, 21);
            this.cb_horario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Horário";
            // 
            // n_maxAlunos
            // 
            this.n_maxAlunos.Location = new System.Drawing.Point(507, 136);
            this.n_maxAlunos.Name = "n_maxAlunos";
            this.n_maxAlunos.Size = new System.Drawing.Size(90, 20);
            this.n_maxAlunos.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nome Turma";
            // 
            // tb_nomeTurma
            // 
            this.tb_nomeTurma.Location = new System.Drawing.Point(507, 34);
            this.tb_nomeTurma.Name = "tb_nomeTurma";
            this.tb_nomeTurma.Size = new System.Drawing.Size(203, 20);
            this.tb_nomeTurma.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vagas";
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(510, 257);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(200, 20);
            this.tb_vagas.TabIndex = 18;
            this.tb_vagas.TabStop = false;
            // 
            // F_GestaoDeTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 528);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_nomeTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_maxAlunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_professores);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoDeTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão De Turmas";
            this.Load += new System.EventHandler(this.F_GestaoDeTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Button btn_excluirHorario;
        private System.Windows.Forms.Button btn_exluirTurma;
        private System.Windows.Forms.Button btn_salvarSalvaredicoes;
        private System.Windows.Forms.Button btn_novaTurma;
        private System.Windows.Forms.ComboBox cb_professores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown n_maxAlunos;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomeTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vagas;
       
    }
}