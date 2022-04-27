using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SistemaAlunosFormsApp
{
    public partial class F_Esqueceu_Senha : Form
    {
        string randomCode;
        public static string to;

        public F_Esqueceu_Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "leandrolaragames@gmail.com";
            pass = "D@rk14145";
            messageBody = "your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";
            SmtpClient smpt = new SmtpClient("smtp.gmail.com");
            smpt.EnableSsl = true;
            smpt.Port = 587;
            smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
            smpt.Credentials = new NetworkCredential(from, pass);
            try
            {
                smpt.Send(message);
                MessageBox.Show("code send successfully");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
            {
                to = txtEmail.Text;
                F_Resetar_Senha rp = new F_Resetar_Senha();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }
    }
}
