using WebAppSample3DI.Interfaces;

namespace WebAppSample3DI.Services
{
    public class PremiumCustomerService : ICustomerService
    {

        private readonly INotificationSender _notificationSender;

        public PremiumCustomerService(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public string NotifyCustomer()
        {
            return $"Premium Customer Service: {_notificationSender.SendNotification()}";
        }
    }
}
