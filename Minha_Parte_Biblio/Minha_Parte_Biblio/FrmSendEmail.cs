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
using System.Net;

namespace Minha_Parte_Biblio
{
    public partial class FrmSendEmail : Form
    {
        public FrmSendEmail()
        {
            InitializeComponent();
        }


        private void SendEmail_Click(object sender, EventArgs e)
        {
            // Coletar as informações do formulário
            string nome = txtFirstName.Text.ToString() +" "+txtSecondName.Text.ToString();
            string emailindex = txtIndexMail.Text;
            string emailremetente = txtremetente.Text;
            string mensagem = txtMensagem.Text;

            // Criar um objeto de e-mail
            MailMessage emailMessage = new MailMessage();
            emailMessage.To.Add(emailindex);
            emailMessage.Subject = "Formulário de contato";
            emailMessage.Body = $"Nome: {nome}\nEmail: {emailremetente}\nMensagem: {mensagem}";

            // Enviar o e-mail
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "seuservidordeemail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("seuemail@example.com", "suasenha");
            smtpClient.Send(emailMessage);
        }
    }
}
