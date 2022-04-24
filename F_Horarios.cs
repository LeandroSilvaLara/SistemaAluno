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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
              SELECT 
                    N_IDHORARIO as 'ID Horário',
                    T_DSCHORARIO as 'Horário'
                FROM 
                    tb_horarios ORDER BY  T_DSCHORARIO
            ";
            
            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 142;
            dgv_horarios.Columns[1].Width = 270;

        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                String vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                            SELECT * FROM tb_horarios
                                    WHERE N_IDHORARIO =                                       
                        " + vid;
                //MessageBox.Show("A CONTULTA QUE VAI SR FEITA VAI SER ASSIM "+vquery+vid);
                dt = Banco.dql(vquery);
                tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_dscHoario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");

            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mtb_dscHoario.Clear();
            mtb_dscHoario.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquety;
            if (tb_idHorario.Text == "")
            {
                vquety = @" INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('" + mtb_dscHoario.Text + "')";
            }
            else
            {
                vquety = @"UPDATE tb_horarios SET T_DSCHORARIO = '" + mtb_dscHoario.Text + "'  WHERE N_IDHORARIO = " + tb_idHorario.Text;
            }

            Banco.dml(vquety);
            string vquery = @"
              SELECT 
                    N_IDHORARIO as 'ID Horário',
                    T_DSCHORARIO as 'Horário'
                FROM 
                    tb_horarios ORDER BY  T_DSCHORARIO
            ";
            dgv_horarios.DataSource = Banco.dql(vquery);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão ?", "EXCLUIR! CUIDADO!!!!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery1 = @"DELETE from tb_horarios WHERE N_IDHORARIO = " + tb_idHorario.Text;
                Banco.dml(vquery1);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);

            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
