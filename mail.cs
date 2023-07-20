using System;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace CustomSenderEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // E-posta gönderenin bilgileri
            string senderEmail = "example@gmail.com"; // Kendi e-posta adresiniz
            string senderPassword = "passowrd"; // Kendi e-posta şifreniz
            string senderDisplayName = "Example Name";

            // E-posta alıcının bilgileri
            string receiverEmail = "example@gmail.com"; // Alıcı e-posta adresi

            // E-posta başlık ve içeriği
            string subject = "";
            string body = "";

            // Custom gönderici e-posta bilgileri
            string customSenderEmail = "example@gmail.com"; // Göstermek istediğiniz özel gönderici e-posta adresi

            Console.WriteLine("Saniyede kaç e-posta göndermek istersiniz?");
            int mailsPerSecond = int.Parse(Console.ReadLine());

            // E-postayı gönderme işlemi
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(customSenderEmail, senderDisplayName);
                    mailMessage.To.Add(receiverEmail);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                    int delayTime = 1000 / mailsPerSecond;

                    for (int i = 0; i < mailsPerSecond; i++)
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine($"E-posta {i + 1}/{mailsPerSecond} gönderildi.");
                        Thread.Sleep(delayTime);
                    }

                    Console.WriteLine("E-postalar gönderildi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }
    }
}
