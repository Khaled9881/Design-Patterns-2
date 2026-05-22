using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facotory_Patterrn
{
    public class SMSFactory : NotificationFactory
    {
        public override Inotification notification()
        {
            return new SMSNotification();
        }
    }
}
