namespace DependencyInjection
{
    using System;
    using System.Reflection;
    using Ninject;

    class Program
    {
        static void Main(string[] args)
        {
            /*calling mock service*/
            ISMSService Mockservice = new MockSMSService();
            var ProductionUIHandler = new UIHandler(Mockservice);
            ProductionUIHandler.Send("+8801717272410");

            /*calling production service*/
            ISMSService ProductionService = new MockSMSService();
            var uiHandler = new UIHandler(ProductionService);
            uiHandler.Send("+8801717272410");

            Console.WriteLine("By NINJECT Dependency Injection");
            /*using Ninject Kernel*/
            var Kernal = new StandardKernel();
            Kernal.Load(Assembly.GetExecutingAssembly());
            var SMSService = Kernal.Get<ISMSService>();

            uiHandler = new UIHandler(SMSService);
            uiHandler.Send("+8801717272410");

            var notifyService = Kernal.Get<INotifyService>();
            notifyService.SendNotification();

            Console.ReadLine();
        }
    }
}
