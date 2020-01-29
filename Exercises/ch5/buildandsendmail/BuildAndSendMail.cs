namespace eu.sig.training.ch05.buildandsendmail.v1
{
    public class BuildAndSendMail
    {
        public void DoBuildAndSendMail(MailMan m, Mail mail)
        {
            // Format the email address
            string mId = $"{mail.firstName[0]}.{mail.lastName.Substring(0, 7)}" +
                $"@{mail.division.Substring(0, 5)}.compa.ny";
            // Format the message given the content type and raw message
            MailMessage mMessage = FormatMessage(mail.font,
                mail.message1 + mail.message2 + mail.message3);
            // Send message
            m.Send(mId, mail.subject, mMessage);
        }

        public MailMessage FormatMessage(MailFont font, string s)
        {
            return null;
        }

        public class Mail
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string division { get; set; }
            public string subject { get; set; }
            public MailFont font { get; set; }
            public string message1 { get; set; }
            public string message2 { get; set; }
            public string message3 { get; set; }
        }

        public class MailMan
        {

            public void Send(string mId, string subject, MailMessage mMessage) { }

        }

        public class MailFont
        {

        }

        public class MailMessage
        {

        }

        

    }
}
