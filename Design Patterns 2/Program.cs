using Facotory_Patterrn;
using Sate_Pattern;

namespace Design_Patterns_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            //NotificationFactory notification = new EmailFactory();
            //notification.Notify();

            //NotificationFactory notification2 = new SMSFactory();
            //notification2.Notify();


            Button button = new Button();

            try
            {
                button.Pause();
                button.Play();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
}
