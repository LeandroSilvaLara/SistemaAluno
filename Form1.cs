﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void abreForm(int nivel, Form f)
        { 
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                //PROCEDIMENTOS
                {
                     f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
             }
        }
           

        private void labl1_Click(object sender, EventArgs e)
        {

        }

        private void pb_ledLogado_Click(object sender, EventArgs e)
        { 
        }

      

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog(this);
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0; 
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abreForm()
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abreForm(1, f_NovoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                abreForm(1, f_GestaoUsuarios);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                F_NovoAluno f_NovoAluno = new F_NovoAluno();
                abreForm(1, f_NovoAluno);
         }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_horarios = new F_Horarios();
            abreForm(2, f_horarios);
            //NOVA ROTINA
            // f_horarios.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(2, f_GestaoProfessores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoDeTurmas f_GestaoDeTurmas = new F_GestaoDeTurmas();
            abreForm(3, f_GestaoDeTurmas);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoDeAlunos f_GestaoDeAlunos = new F_GestaoDeAlunos();
            abreForm(3, f_GestaoDeAlunos);
        }

        private void envioDeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Envio_Documento f_Envio_Documento = new F_Envio_Documento();
            abreForm(3, f_Envio_Documento);
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 10)
            { 
            pictureBox1.Image = imageList1.Images[count];
            count++;
            }
            else
            {
                count = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
