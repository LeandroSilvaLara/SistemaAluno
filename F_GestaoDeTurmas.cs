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
    public partial class F_GestaoDeTurmas : Form
    {
        public F_GestaoDeTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoDeTurmas_Load(object sender, EventArgs e)
        {
            string vquery = @"SELECT tbt.N_IDTURMA as 'ID' ,tbt.T_DSCTURMA as 'Turma',tbh.T_DSCHORARIO  as 'Horário da turma'
                FROM tb_turmas as tbt
                INNER JOIN
                tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO";
            dgv_turmas.DataSource = Banco.dql(vquery);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 120;

            //Popular professroes
            string vqueryProfessores = @"SELECT N_IDPROFESSOR,T_NOMEPROFESSOR FROM tb_professores ORDER BY N_IDPROFESSOR";
            cb_professores.Items.Clear();
            cb_professores.DataSource = Banco.dql(vqueryProfessores);
            cb_professores.DisplayMember = "T_NOMEPROFESSOR";
            cb_professores.ValueMember = "N_IDPROFESSOR";

            //Popular ComboBox Status
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralizada");
            st.Add("C", "Cencelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            /*
            string vqueryStatus = @"SELECT T_STATUS,N_IDTURMA FROM tb_turmas";
            cb_status.DataSource = Banco.dql(vqueryStatus);
            cb_status.DisplayMember = "T_STATUS";
            cb_status.ValueMember = "N_IDTURMA";
            */

            //Popular combo box horarios
            string vqueryHorarios = @"SELECT * FROM tb_horarios ORDER BY T_DSCHORARIO";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";


            //Nome da turma

        }
    }
}
