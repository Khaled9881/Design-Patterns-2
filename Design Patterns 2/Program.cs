using Builderpattern2;
using ChainOdResponsibility;
using DecoratorPattern;
using Facotory_Patterrn;
using Sate_Pattern;
using SimpleCommandPattern;

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


            //Button button = new Button();

            //try
            //{
            //    button.Pause();
            //    button.Play();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}




            //CommandInvoker commandInvoker = new CommandInvoker();
            //while (true)
            //{
            //    Console.WriteLine("Enter 1 or 2");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a == 1)
            //        commandInvoker.AddCommand(new HelloCommand());
            //    else if (a == 2)
            //        commandInvoker.AddCommand(new WelcomeComman());
            //    else
            //        break;
            //}

            //commandInvoker.ExecuteCommands();

            //CommandInvoker commandInvoker = new CommandInvoker();
            ////List<ICommand> commands = new List<ICommand>();
            //while (true)
            //{
            //    Console.WriteLine("Enter 1 or 2 or 3 for undo");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a == 1)
            //        commandInvoker.AddCommand(new HelloCommand());
            //    else if (a == 2)
            //        commandInvoker.AddCommand(new WelcomeComman());
            //    else if (a == 3)
            //        commandInvoker.Undo();
            //    else if (a == 4)
            //        commandInvoker.Redo();
            //    else
            //        break;
            //}

            //commandInvoker.ExecuteCommands();
            //old
            //MacroCommand macroCommand = new MacroCommand(commands);
            //macroCommand.Undo();
            //macroCommand.Redo();
            //macroCommand.Execute();

            //Pizaa pizaa = new PizaaBuilder().SetSize("Medium").AddPepperoni().AddCheese().Build();

            //Console.WriteLine(pizaa);



            //
            //ICoffee coffee = new SimpleCoffee();
            //Console.WriteLine(coffee.GetDescription());
            //Console.WriteLine(coffee.GetPrice());

            //coffee = new MilkDecorator(coffee);
            //Console.WriteLine(coffee.GetDescription());
            //Console.WriteLine(coffee.GetPrice());

            //coffee = new SugarDecorator(coffee);
            //Console.WriteLine(coffee.GetDescription());
            //Console.WriteLine(coffee.GetPrice());


            //  

            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Test",
                JobTitle = JobTitle.CTO
            };

            VacationRequest request = new VacationRequest()
            {
                employee = employee,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(10)
            };

            IApprovalHandler teamLeaderApprovalHandler = new TeamLeaderApprovalHandler();
            IApprovalHandler technicalManagerApprovalHandler = new TechnicalManagerApprovalHandler();
            IApprovalHandler ctoApprovalHandler = new CTOApprovalHandler();
            IApprovalHandler ceoApprovalHandler = new CEOApprovalHandler();

            teamLeaderApprovalHandler.SetNextHandler(technicalManagerApprovalHandler);
            technicalManagerApprovalHandler.SetNextHandler(ctoApprovalHandler);
            ctoApprovalHandler.SetNextHandler(ceoApprovalHandler);

            teamLeaderApprovalHandler.Process(request);







        }

    }
}
