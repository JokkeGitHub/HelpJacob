using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_S_In_Solid_HelpJacob
{
    interface IVmessage
    {
        // This interface implements VMessages
        void SendVMessage(Message m, bool isHtml);
    }
}
