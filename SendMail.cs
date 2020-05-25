using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace saturn
{
    class SendMail
    {
        private string bodyMail = "";
        private string nameAuthor = "";
        private string subject = "";
        private object MessageBox;
        const string passMail = "lfirf2000";
        public SendMail(string bodyMail, string nameAuthor, string subject)
        {
            this.bodyMail = bodyMail;
            this.nameAuthor = nameAuthor;
            this.subject = subject;
        }

        public void MySendMail()
        {
            var from = new MailAddress("dahtulova@mail.ru", nameAuthor); //Ящик для отправки сообщений
            var to = new MailAddress("vika.romanenko11@mail.ru", "Вика Романенко"); //Личный ящик

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from.Address, passMail);
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = subject;
                mail.Body = bodyMail;

                smtp.Send(mail);
                {
                }
                {
                }
            }
            catch (Exception ex){;

            {
            }
            }
        }
    }
}

