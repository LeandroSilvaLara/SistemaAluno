using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SistemaAlunosFormsApp
{
    public partial class F_Envio_Documento : Form
    {
        public F_Envio_Documento()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EmailEnviar();
        }

        private void EmailEnviar()
        {
            try
            {
                using (SmtpClient smpt = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage()) 
                    { 
                            //Servidor SMTP
                        smpt.Host = "smtp.gmail.com ";
                        smpt.UseDefaultCredentials = false;
                        smpt.Credentials = new System.Net.NetworkCredential("leandrolaragames@gmail.com", "D@rk14145");
                        smpt.Port = 587;
                        smpt.EnableSsl = true;

                        //Email (Mensagem)
                        email.From = new MailAddress(txtRemetente.Text);
                        email.To.Add(textDestinatario.Text);

                        email.Subject = textAssunto.Text;
                        email.IsBodyHtml = false;
                        email.Body = textMensagem.Text;

                        //anexo do email
                        if (lblAnexo.Text !=  "")
                            email.Attachments.Add(new Attachment(lblAnexo.Text));

                        //Envar email
                        smpt.Send(email);
                        
                    }
                }
                MessageBox.Show("Email enviado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " +  ex.Message);
            }
        }

        private void lblAnexo_Click(object sender, EventArgs e)
        {
            var anexo = new OpenFileDialog();

            anexo.Title = "Anexar arquivos";

            if (anexo.ShowDialog() == DialogResult.OK)
                lblAnexo.Text = anexo.FileName;
        }
    }
}
