using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace SistemaAlunosFormsApp
{
    public partial class F_Resetar_Senha : Form
    {
        DataTable dt = new DataTable();
        string tb_username = F_Esqueceu_Senha.to;
        string tb_senha = F_Esqueceu_Senha.to;

        public F_Resetar_Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVerf.Text)
            {
                string queryAtualizarTurma = "";
                string mgs = "";

               

            }
        }
    }
}
