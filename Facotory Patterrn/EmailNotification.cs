using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facotory_Patterrn
{
    public class EmailNotification : Inotification
    {
        public void send()
        {
            Console.WriteLine("Email Notfifcation");
        }
    }
}
