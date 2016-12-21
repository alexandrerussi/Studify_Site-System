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



namespace Sistema
{
    public partial class frmEnviaEmail : Form
    {
        static int codigo;
        public frmEnviaEmail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            codigo = Convert.ToInt32(random.Next(1, 9999999).ToString());
            label1.Text = codigo.ToString();
            if (String.IsNullOrEmpty(txtDest.Text))
                return;
            try
            {
                
                MailMessage mail = new MailMessage();
                mail.To.Add(txtDest.Text);
                mail.From = new MailAddress("studifyeducacao@gmail.com");
                mail.Subject = "Studify - Código de Verificação";

                mail.Body = "<html><head><style type=\"text/css\">@import url(https://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900);*{font-family: 'Roboto', sans-serif; padding: 0; margin: 0; border: 0;}.fundo{background-color:#80cbc4; background-image: url('http://studify.com.br/imagens/fundo.jpg'); margin: 0; padding: 0; min-width: 100%; min-height: 100%; background-repeat: no-repeat;}.header{top: 0;left: 0;right: 0;background-color: #009688;padding: 15px 0;}.logo{text-align: center;}.all{text-align: center;color: #f5f5f5;}.thanks{font-size: 40px;margin-top: 50px;font-weight: 400;}.text{font-size: 28px;margin-top: 20px;font-weight: 300;margin: 0 50px;}.site{font-size: 22px;margin-top: 10px;font-weight: 300;}.follow{font-size: 28px;margin-top: 90px;font-weight: 400;}.SocialNetwork{margin-top: 30px;margin-bottom: 20px;}.imgSocial{width: 275px;height: 275px;}@media only screen and (min-width: 1920px){body{background-size: 100%;}}@media only screen and (max-width: 992px){.thanks{font-size: 40px;margin-top: 50px;font-weight: 400;}.text{font-size: 26px;margin-top: 20px;font-weight: 300;margin: 0 50px;}.site{font-size: 22px;margin-top: 10px;font-weight: 300;}.follow{font-size: 28px;margin-top: 90px;font-weight: 400;}.SocialNetwork{margin-top: 30px;margin-bottom: 20px;}.imgSocial{width: 200px;height: 200px;}}</style></head><body><div class=\"fundo\"><div class=\"header\"><div class=\"logo\"><img src=\"http://studify.com.br/imagens/logo.png\"width=\"205\" height=\"80\"/></div></div><div class=\"all\"><h2 class=\"thanks\" style=\"color:#f5f5f5;\">SEU CÓDIGO DE VERIFICAÇÃO É:</h2><br/><h1 class=\"site\" style=\"color:#ff7043; font-size: 40px\">" + codigo + "</h1><br/><h4 class=\"text\" style=\"color:#f5f5f5;\">COPIE O CÓDIGO ACIMA E COLE NO CAMPO INDICADO NO SITE</h4><h3 class=\"follow\" style=\"color:#f5f5f5;\">Siga-nos em nossas redes sociais!</h3><div class=\"SocialNetwork\"><a href=\"https://www.facebook.com/studifyeducacao/?fref=ts\"><img src=\"http://studify.com.br/imagens/fb.jpg\" class=\"imgSocial\"/></a><a href=\"https://www.youtube.com/channel/UCTCIAlYf7QcHdaoCiCj3Gnw\"><img src=\"http://studify.com.br/imagens/yt.jpg\" class=\"imgSocial\" /></a></div></div></div></body></html>";

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential("studifyeducacao@gmail.com", "Studify10"); // ***use valid credentials***
                smtp.Port = 587;
                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                panel1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in sendEmail:" + ex.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (codigo.ToString() == textBox1.Text)
            {
                MessageBox.Show("Certo!");
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Errado!");
            }
        }
    }
}
