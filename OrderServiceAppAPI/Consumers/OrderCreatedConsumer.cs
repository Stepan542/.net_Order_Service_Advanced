using MassTransit;
using OrderServiceAppAPI.Interfaces;

namespace OrderServiceAppAPI.Consumers
{
    public class OrderCreatedConsumer : IConsumer<IOrderCreated>
    {
        public async Task Consume(ConsumeContext<IOrderCreated> context)
        {
            var message = context.Message;
            Console.WriteLine($"Order Created: {message.OrderId} at {message.CreatedAt}");

            await Task.CompletedTask;
        }
    }
}