namespace DependencyInjection
{
    public class UIHandler
    {
        private ISMSService smsService;

        public UIHandler(ISMSService _smsService)
        {
            this.smsService = _smsService;
        }

        public void Send(string phoneNumber)
        {
            smsService.SendSms("+8801717272410", "This is a test message");
        }
    }
}
