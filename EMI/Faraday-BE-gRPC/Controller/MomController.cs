﻿using System;
using System.Text;
using Faraday_BE_gRPC.Models;
using RabbitMQ.Client;


namespace Faraday_BE_gRPC.Model
{
    public class MomController
    {
        public void CreatePdf(CarBooking booking)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "FinishedOrders", type: ExchangeType.Fanout);
                
                var message = booking.ToString();
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "FinishedOrders",
                    routingKey: "",
                    basicProperties: null,
                    body: body);
                Console.WriteLine(" Pdf creating process started");
            }
        }
    }
}