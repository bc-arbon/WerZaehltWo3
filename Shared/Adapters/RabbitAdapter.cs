using BCA.WerZaehltWo3.Shared.TournamentSoftware;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace BCA.WerZaehltWo3.Shared.Adapters
{
    public class RabbitAdapter
    {
        private readonly string exchangeName = "werzaehltwo";
        private readonly string queueName = "werzaehltwo.tsdata";
        private readonly string routingKey = "tsdata";
        private readonly IBasicProperties basicProperties;

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

            this.basicProperties = this.Channel.CreateBasicProperties();
            this.basicProperties.Expiration = "10000";
        }

        public void Send(MatchesPayload payload)
        {
            var message = JsonConvert.SerializeObject(payload);
            var body = Encoding.UTF8.GetBytes(message);            
            this.Channel.BasicPublish(exchange: exchangeName, routingKey: routingKey, basicProperties: this.basicProperties, body: body);
        }

        public void Close()
        {
            try
            {
                this.Channel.Close();
                this.Channel.Dispose();
            }
            catch { }
        }
    }
}
