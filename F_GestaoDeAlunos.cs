using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaAlunosFormsApp
{
    public partial class F_GestaoDeAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        public F_GestaoDeAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoDeAlunos_Load(object sender, EventArgs e)
        {

            vqueryDGV = @"
                    SELECT
                        N_IDALUNO as 'ID',
                        T_NOMEALUNO as 'Aluno',
                        T_MEDIA as 'Média'
                    FROM
                        tb_alunos
            ";
            dgv_selecionarAluno.DataSource = Banco.dql(vqueryDGV);
            dgv_selecionarAluno.Columns[0].Width = 40;
            dgv_selecionarAluno.Columns[1].Width = 120;

            tb_nome.Text = dgv_selecionarAluno.Rows[dgv_selecionarAluno.SelectedRows[0].Index].Cells[1].Value.ToString();
            //Pupulas o cb_turmas


            string vqueryTurmas = @"
                    SELECT N_IDTURMA as 'ID',
                           ('Vagas: ' || ((N_MAXALUNOS) - 
                                    (
                                            SELECT count(tba.N_IDALUNO) from tb_alunos as tba WHERE tba.T_STATUS = 'A' and tba.N_IDTURMA = tbt.N_IDTURMA 
                                    )
                                        )|| '   /   Turma: ' || T_DSCTURMA) as 'Turma'
                            FROM tb_turmas as tbt
                            ORDER BY
                             N_IDTURMA";

            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.dql(vqueryTurmas);
            cb_turma.DisplayMember = "Turma";
            //cb_turma.ValueMember = "N_IDTURMA";
            cb_turma.ValueMember = "ID";
            

            //Popular o ComboBox Status
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turma.Text;
            turmaAtual = cb_turma.Text;
            idSelecionado = dgv_selecionarAluno.Rows[0].Cells[0].Value.ToString();
        }

        private void brn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluirAluno_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir ? ID", "Exclusão", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (File.Exists(pb_foto.ImageLocation))
                {
                    File.Delete(pb_foto.ImageLocation);
                }

                string vqueryDelete = string.Format(@"DELETE FROM tb_alunos WHERE N_IDALUNOS = {0}", idSelecionado);
                Banco.dql(vqueryDelete);
                MessageBox.Show("Eclusão feita com sucesso");
                dgv_selecionarAluno.Rows.Remove(dgv_selecionarAluno.CurrentRow);
            }
        }

        private void dgv_selecionarAluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                //idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                idSelecionado = dgv_selecionarAluno.Rows[0].Cells[0].Value.ToString();
                tb_nome.Text = dgv_selecionarAluno.Rows[dgv_selecionarAluno.SelectedRows[0].Index].Cells[1].Value.ToString();
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();

                string vqueryCampos = String.Format(@"
                        SELECT
                            N_IDALUNO,
                            T_NOMEALUNO,
                            T_TELEFONE,
                            T_STATUS,
                            N_IDTURMA,
                            T_FOTO
                        FROM
                            tb_alunos
                        WHERE N_IDALUNO = {0}
                ", idSelecionado);

                DataTable dt = Banco.dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_turma.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");
                turmaAtual = cb_turma.Text;
                pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
            }
        }

        private void brn_salverEdicoes_Click(object sender, EventArgs e)
        {
            turma = cb_turma.Text;
            if (turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada, selecione outra turma!");
                    cb_turma.Focus();
                    return;
                }
                //linha = dgv_selAluno.SelectedRows[0].Index;
                string queryAtualizarAluno = String.Format(@"
                        UPDATE
                            tb_alunos
                        SET
                            T_NOMEALUNO = '{0}',
                            T_TELEFONE = '{1}',
                            T_STATUS = '{2}',
                            N_IDTURMA = '{3}'
                        WHERE
                            N_IDALUNO = {4}
                ", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turma.SelectedValue, idSelecionado);
                Banco.dml(queryAtualizarAluno);
                MessageBox.Show("Alterações Gravadas");
                //dgv_selAluno[1, linha].Value = tb_nome.Text;
            }
        }
    }
}