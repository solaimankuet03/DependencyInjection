namespace DependencyInjection
{
    using System;

    public class MockSMSService : ISMSService
    {
        public void SendSms(string phoneNumber, string body)
        {
            SendSMSUsingGateway(phoneNumber, body);
        }

        private void SendSMSUsingGateway(string mobileNumber, string body)
        {
            Console.WriteLine("Mock Sending SMS using gateway to mobile: {0}. SMS body: {1}", mobileNumber, body);
        }
    }
}
