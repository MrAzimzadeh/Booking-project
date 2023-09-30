﻿using Microsoft.EntityFrameworkCore.Metadata;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Text.Json;
using IModel = RabbitMQ.Client.IModel;

namespace CorePackage.EventBus.RabbitMq
{
    public class RabbitMqServiceBus : IServiceBus
    {
        public void SendMessage(object model, string queue)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost");
            //factory.HostName = "localhost";

            using IConnection connection = factory.CreateConnection();
            using IModel channel = connection.CreateModel();
            channel.QueueDeclare(queue, false, false, true);
            var message = JsonSerializer.Serialize(model);
            byte[] bytemessage = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish(exchange: "", routingKey: queue, body: bytemessage);
        }

        public void ReciveMessage(string queue)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost");

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue, false, false, true);
                EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                channel.BasicConsume(queue, false, consumer);
                consumer.Received += (sender, e) =>
                {
                    var message = JsonSerializer.Deserialize<object>(e.Body.ToArray());
                };
            }
        }

    }
}

