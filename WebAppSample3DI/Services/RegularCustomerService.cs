using WebAppSample3DI.Interfaces;

namespace WebAppSample3DI.Services
{
    public class RegularCustomerService : ICustomerService
    {

        private readonly INotificationSender _notificationSender;

        public RegularCustomerService(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public string NotifyCustomer()
        {
            return $"Regular Customer Service: {_notificationSender.SendNotification()}";
        }
    }
}
