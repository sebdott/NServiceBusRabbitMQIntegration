using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Billing
{
    public class OrderPlacedHandler :IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced, OrderId = {message.OrderId} -  Should we ship now?");

            return Task.CompletedTask;

            //var orderPlaced = new OrderPlaced
            //{
            //    OrderId = message.OrderId
            //};
            //return context.Publish(orderPlaced);

        }
    }
}
