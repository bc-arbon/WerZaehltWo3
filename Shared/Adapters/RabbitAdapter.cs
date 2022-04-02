using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Diagnostics;
using System.Text;

namespace BCA.WerZaehltWo3.Common.Adapters
{
    public class RabbitAdapter
    {
        private readonly string exchangeName = "werzaehltwo";
        private readonly string queueName = "werzaehltwo.tsdata";
        private readonly string routingKey = "tsdata";

        public IModel Channel { get; private set; }

        public RabbitAdapter(string server, string vhost, string username, string password)
        {
            var vhost2 = string.IsNullOrEmpty(vhost) ? "/" : vhost;
            var factory = new ConnectionFactory() { HostName = server, VirtualHost = vhost2, UserName = username, Password = password };
            var connection = factory.CreateConnection();
            this.Channel = connection.CreateModel();
            this.Channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Fanout);
            this.Channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
            this.Channel.QueueBind(queueName, exchangeName, routingKey);
        }

        public void Send(object payload)
        {
            var message = JsonConvert.SerializeObject(payload);
            var body = Encoding.UTF8.GetBytes(message);
            this.Channel.BasicPublish(exchange: exchangeName, routingKey: routingKey, basicProperties: null, body: body);
            //Debug.WriteLine(" [x] Sent {0}", message);
        }
    }
}
