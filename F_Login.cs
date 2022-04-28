using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace SistemaAlunosFormsApp
{
    
    public partial class F_Login : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
              (
                int nLeft,
                int nTop,
                int nRight,
                int nBotoom,
                int nWidthEllipse,
                int nHeightEllipse
              );

        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }



        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e ou senha inválidos ");
                tb_username.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"' AND T_SENHAUSUARIO='"+senha+"'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }


        private void btn_canelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            F_Esqueceu_Senha sc = new F_Esqueceu_Senha();
            this.Hide();
            sc.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            btn_logar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logar.Width,
                btn_logar.Height, 30, 30));
        }
    }
}
