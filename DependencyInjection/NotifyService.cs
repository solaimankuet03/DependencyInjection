namespace DependencyInjection
{
    using System;

    public class NotifyService : INotifyService
    {
        public void SendNotification()
        {
            Console.WriteLine("Notification Service");
        }
    }
}
