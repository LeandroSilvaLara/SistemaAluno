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
    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFoto;
        string destinoCompleto = "";
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            mtb_telefone.Enabled = true;
            cb_status.Enabled = true;
            tb_nome.Clear();
            mtb_telefone.Clear();
            cb_status.SelectedIndex = 0;
            tb_turma.Clear();
            tb_plano.Clear();
            tb_turma.Clear();
            tb_nome.Focus();
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_novo.Enabled = false;


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            mtb_telefone.Clear();
            cb_status.SelectedIndex = 0;
            tb_turma.Clear();
            tb_plano.Clear();
            tb_turma.Clear();
            tb_nome.Focus();
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada.", "Quer continuar ?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("Programa parado");
                    return;
                }

            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                    // MessageBox.Show(destinoCompleto);
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar a goto, deseja continuar ?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string queryInsertAluno = String.Format(@"INSERT INTO tb_alunos (T_NOMEALUNO,T_TELEFONE,T_STATUS,N_IDTURMA,T_FOTO) VALUES ('{0}','{1}','{2}',{3},'{4}')", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, tb_turma.Tag.ToString(), destinoCompleto);
            Banco.dml(queryInsertAluno);
            MessageBox.Show("Novo aluno inserido");

            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            mtb_telefone.Clear();
            cb_status.SelectedIndex = 0;
            tb_turma.Clear();
            tb_plano.Clear();
            tb_turma.Clear();
            tb_nome.Focus();
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            F_SelecionarTurma f_SelecionarTurma = new F_SelecionarTurma(this);
            f_SelecionarTurma.ShowDialog();

        }

        private void brn_addFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFoto;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;

            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquino ja existe, deseja sobrepor?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

            }
            pb_foto.ImageLocation = origemCompleto;

            /* System.IO.File.Copy(origemCompleto, destinoCompleto, true);
             if (File.Exists(destinoCompleto))
             {
                 pb_foto.ImageLocation = destinoCompleto;
                // MessageBox.Show(destinoCompleto);
             }
             else
             {
                 MessageBox.Show("Arquivo não copiado");
             }*/
        }
    }
}