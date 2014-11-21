namespace DependencyInjection
{
    public interface ISMSService
    {
        void SendSms(string phoneNumber, string body);
    }
}
