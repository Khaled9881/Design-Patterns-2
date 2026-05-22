using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facotory_Patterrn
{
    public abstract class NotificationFactory
    {

        public void Notify()
        {
            Inotification inotification = notification();

            inotification.send();

        }

        public abstract Inotification notification();


    }
}
