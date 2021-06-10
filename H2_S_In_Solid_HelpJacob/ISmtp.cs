using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_S_In_Solid_HelpJacob
{
    interface ISmtp
    {
        // This interface implements SMTP
        void SendSmtp(Message m, bool isHtml);
    }
}
