using WebAppSample3DI.Interfaces;

namespace WebAppSample3DI.Services
{
    public class SmsNotificationSender : INotificationSender
    {
        public string SendNotification()
        {
            return "Sending SMS notification";
        }
    }
}
