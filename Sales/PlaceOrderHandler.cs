using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;
using System;

namespace Sales
{
    public class PlaceOrderHandler :
        IHandleMessages<PlaceOrder>
    {
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();

        //public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        //{
        //    log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");
        //    return Task.CompletedTask;
        //}

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

            // This is normally where some business logic would occur

            return Task.CompletedTask;

            //var orderPlaced = new OrderPlaced
            //{
            //    OrderId = message.OrderId
            //};
            //return context.Publish(orderPlaced);
        }

        //public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        //{
        //    log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

        //    // This is normally where some business logic would occur
        //    throw new Exception("BOOM");

        //    //var orderPlaced = new OrderPlaced
        //    //{
        //    //    OrderId = message.OrderId
        //    //};
        //    //return context.Publish(orderPlaced);
        //}
    }
}