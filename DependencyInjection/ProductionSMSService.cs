namespace DependencyInjection
{
    using System;

    public class ProductionSMSService : ISMSService
    {
        public void SendSms(string phoneNumber, string body)
        {
            this.SendSMSUsingGateway(phoneNumber, body);
        }

        private void SendSMSUsingGateway(string mobileNumber, string body)
        {
            Console.WriteLine("Production Sending SMS using gateway to mobile: {0}. SMS body: {1}", mobileNumber, body);
        }
    }
}
