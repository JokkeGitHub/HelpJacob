using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_S_In_Solid_HelpJacob
{
    public class Message : ISmtp, IVmessage
    {
        // This superclass is responsible for creating the message object
        string to, from, body, subject, cc;

        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }

        public Message(string to, string from, string body, string subject, string cc)
        {
            To = to;
            From = from;
            Body = body;
            Subject = subject;
            Cc = cc;
        }

        void ISmtp.SendSmtp(Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = Converter.ConvertBodyToHTML(m.Body);
            // Here we implement the code to send with SMTP
        }

        void IVmessage.SendVMessage(Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = Converter.ConvertBodyToHTML(m.Body);
            // Here we implement the code to send with VMessage
        }
    }    
}
