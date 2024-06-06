using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.WebApp.Models;
using System.Diagnostics;
using System.Text;

namespace RabbitMQ.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory() { 
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };

            using (IConnection connection = connectionFactory.CreateConnection())
            {
                using(IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare( queue: "Siparisler",
                        durable: true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                        );

                    string mesaj = "Bu bir sipariþ bilgisi içeren mesaj";
                    byte[] byteMesaj = Encoding.UTF8.GetBytes(mesaj);

                    channel.BasicPublish(exchange: "",
                        routingKey: "Siparisler",
                        basicProperties: null,
                        body: byteMesaj);

                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            List<string> siparisler = new List<string>();

            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };

            using (IConnection connection = connectionFactory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "Siparisler",
                        durable: true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                        );

                   var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, mq) =>
                    {
                        var body = mq.Body;
                        siparisler.Add(Encoding.UTF8.GetString(body.ToArray()));

                    };

                    channel.BasicConsume(
                        queue: "Siparisler",
                        autoAck: true,
                        consumer: consumer
                        );

                }
            }



            return View(siparisler);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
