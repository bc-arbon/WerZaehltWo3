using BCA.WerZaehltWo3.Shared.TpNetwork.XmlBuilder;
using System;
using System.Buffers.Binary;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.Adapters
{
    public static class TpNetworkAdapter
    {
        public static async Task<string> Login(string serverIp, string clientIp, string password)
        {
            var client = new TcpClient();

            client.ConnectAsync(serverIp, 9901).Wait();

            var stream = client.GetStream();

            var loginRequest = new LoginRequest()
            {
                IP = IPAddress.Parse(clientIp),
                Password = password
            };

            StringBuilder sb = new StringBuilder();
            using (StringWriter ss = new StringWriter(sb))
            using (var xmlWriter = XmlWriter.Create(ss))
            {
                loginRequest.CreateDocument().WriteContentTo(xmlWriter);
            }

            var loginRequestXml = sb.ToString();

            await SendCompressedXmlAsync(stream, loginRequestXml);

            var loginResponseXml = await ReadCompressedXmlAsync(stream);

            Console.WriteLine(loginResponseXml);
            return loginResponseXml;
        }

        public static async Task<string> GetTournamentInfo(string serverIp, string clientIp, string password, string unicode)
        {
            var client = new TcpClient();
            client.ConnectAsync(serverIp, 9901).Wait();
            var stream = client.GetStream();
            var request = new TournamentInfoRequest()
            {
                IP = IPAddress.Parse(clientIp),
                Password = password,
                Unicode = unicode
            };

            StringBuilder sb = new StringBuilder();
            using (StringWriter ss = new StringWriter(sb))
            using (var xmlWriter = XmlWriter.Create(ss))
            {
                request.CreateDocument().WriteContentTo(xmlWriter);
            }

            var requestXml = sb.ToString();
            await SendCompressedXmlAsync(stream, requestXml);
            var responseXml = await ReadCompressedXmlAsync(stream);
            Console.WriteLine(responseXml);
            return responseXml;
        }

        public static async Task SendCompressedXmlAsync(NetworkStream stream, string xml)
        {
            var xmlBytes = new UTF8Encoding(false).GetBytes(xml);

            byte[] compressedData;

            using (var compressedStream = new MemoryStream())
            {
                using (var gzip = new GZipStream(
                    compressedStream,
                    CompressionLevel.Optimal,
                    leaveOpen: true))
                {
                    await gzip.WriteAsync(xmlBytes, 0, xmlBytes.Length);
                }

                compressedData = compressedStream.ToArray();
            }

            var lengthBuffer = new byte[4];
            BinaryPrimitives.WriteInt32BigEndian(lengthBuffer, compressedData.Length);

            await stream.WriteAsync(lengthBuffer, 0, lengthBuffer.Length);
            await stream.WriteAsync(compressedData, 0, compressedData.Length);
            await stream.FlushAsync();
        }

        public static async Task<string> ReadCompressedXmlAsync(NetworkStream stream)
        {
            // 1. Die ersten 4 Bytes enthalten die Länge des gzip-Payloads
            var lengthBuffer = await ReadExactlyAsync(stream, 4);

            var compressedLength = BinaryPrimitives.ReadInt32BigEndian(lengthBuffer);

            if (compressedLength <= 0)
            {
                throw new InvalidDataException($"Ungültige Payload-Länge: {compressedLength}");
            }

            // 2. Exakt so viele Bytes lesen
            var compressedData = await ReadExactlyAsync(stream, compressedLength);

            // 3. gzip entpacken
            string xmlText;
            using (var compressedStream = new MemoryStream(compressedData))
            {
                using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    using (var reader = new StreamReader(gzipStream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true))
                    {
                        xmlText = await reader.ReadToEndAsync();
                    }
                }
            }

            return xmlText;
        }

        private static async Task<byte[]> ReadExactlyAsync(NetworkStream stream, int length)
        {
            var buffer = new byte[length];
            var offset = 0;

            while (offset < length)
            {
                var read = await stream.ReadAsync(buffer, offset, length - offset);

                if (read == 0)
                {
                    throw new EndOfStreamException($"Verbindung wurde geschlossen. Erwartet: {length} Bytes, erhalten: {offset} Bytes.");
                }

                offset += read;
            }

            return buffer;
        }
    }
}
