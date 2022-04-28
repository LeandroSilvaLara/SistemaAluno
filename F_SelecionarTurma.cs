using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlunosFormsApp
{
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno formNovoAluno;
        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();
            formNovoAluno = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {

            string queryTurma = String.Format(@"
                    SELECT
                        tbt.N_IDTURMA as 'ID',
                        tbt.T_DSCTURMA as 'Turma',
                        tbh.T_DSCHORARIO as 'Horario',
                        tbp.T_NOMEPROFESSOR as 'Professor',
                        tbt.N_MAXALUNOS as 'Máx. Alunos',
                        ( SELECT
                                count(N_IDALUNO)
                          FROM
                                tb_alunos as tba
                          WHERE
                                tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A'
                        ) as 'Qtde. Alunos'
                    FROM
                        tb_turmas as tbt
                    INNER JOIN
                        tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                    INNER JOIN
                        tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ");
            dgv_selecionarTurma.DataSource = Banco.dql(queryTurma);
            dgv_selecionarTurma.Columns[0].Width = 50;
            dgv_selecionarTurma.Columns[4].Width = 120;
            dgv_selecionarTurma.Columns[3].Width = 230;
             
              
        }

        private void dgv_selecionarTurma_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAulunos = 0;
            int qtdAlunos = 0;
            maxAulunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if (qtdAlunos >= maxAulunos)
            {
                MessageBox.Show("Turma está cheia");
            }
            else
            {
                formNovoAluno.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formNovoAluno.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            } 
        }
    }
}
