using WebAppSample3DI.Interfaces;

namespace WebAppSample3DI.Services
{
    public class EmailNotificationSender : INotificationSender
    {
        public string SendNotification()
        {
            return "Sending email notification";
        }
    }
}
