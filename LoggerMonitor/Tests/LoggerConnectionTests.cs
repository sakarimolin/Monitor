using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Xunit;

namespace LoggerMonitor.Tests
{
    public class LoggerConnectionTests
    {
        [Fact]
        public async Task TryConnect_ConnectsToListeningLogger()
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            try
            {
                int port = ((IPEndPoint)listener.LocalEndpoint).Port;
                Task<TcpClient> acceptedClient = listener.AcceptTcpClientAsync();

                LoggerConnection connection;
                string error;
                bool connected = LoggerConnection.TryConnect(
                    new[] { IPAddress.Loopback }, port, 1, 1000, out connection, out error);

                Assert.True(connected, error);
                Assert.NotNull(connection);
                Assert.NotNull(connection.Client);
                Assert.NotNull(connection.Stream);

                TcpClient accepted = await acceptedClient;
                accepted.Close();
                connection.Dispose();
            }
            finally
            {
                listener.Stop();
            }
        }

        [Fact]
        public void TryConnect_ReturnsFalseWhenNoAddressIsAvailable()
        {
            LoggerConnection connection;
            string error;

            bool connected = LoggerConnection.TryConnect(
                new IPAddress[0], 22222, 1, 100, out connection, out error);

            Assert.False(connected);
            Assert.Null(connection);
            Assert.Equal("No connection attempts were made.", error);
        }

        [Fact]
        public void TryConnect_ReturnsFalseWhenLoggerRefusesConnection()
        {
            int unusedPort;
            TcpListener listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            unusedPort = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();

            LoggerConnection connection;
            string error;
            bool connected = LoggerConnection.TryConnect(
                new[] { IPAddress.Loopback }, unusedPort, 1, 1000, out connection, out error);

            Assert.False(connected);
            Assert.Null(connection);
            Assert.False(string.IsNullOrWhiteSpace(error));
        }

        [Fact]
        public void Dispose_ReleasesClientAndStream()
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            try
            {
                int port = ((IPEndPoint)listener.LocalEndpoint).Port;
                LoggerConnection connection;
                string error;
                Assert.True(LoggerConnection.TryConnect(
                    new[] { IPAddress.Loopback }, port, 1, 1000, out connection, out error), error);

                connection.Dispose();

                Assert.Null(connection.Client);
                Assert.Null(connection.Stream);
            }
            finally
            {
                listener.Stop();
            }
        }
    }
}
