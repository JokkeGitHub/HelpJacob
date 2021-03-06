using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_S_In_Solid_HelpJacob
{
    class SendToAll : Message
    {
        // This subclass is responsible for sending a "global" message out to all recipients
        public SendToAll(string to, string from, string body, string subject, string cc) : base(to, from, body, subject, cc)
        {
            To = to;
            From = from;
            Body = body;
            Subject = subject;
            Cc = cc;
        }

        public void SendMessage(EnumMessageCarrier type, string[] to, Message m, bool isHTML)
        {
            //In here we send a message to the recipients
            if (type.Equals(EnumMessageCarrier.Smtp))
            {
                ((ISmtp)m).SendSmtp(m, isHTML);
            }
            else if (type.Equals(EnumMessageCarrier.VMessage))
            {
                ((IVmessage)m).SendVMessage(m, isHTML);
            }
        }
    }
}
