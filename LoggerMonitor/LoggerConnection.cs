using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace LoggerMonitor
{
    public sealed class LoggerConnection : IDisposable
    {
        private TcpClient client;
        private NetworkStream stream;

        private LoggerConnection(TcpClient tcpClient)
        {
            client = tcpClient;
            stream = tcpClient.GetStream();
        }

        public TcpClient Client
        {
            get { return client; }
        }

        public NetworkStream Stream
        {
            get { return stream; }
        }

        public static bool TryConnect(
            IEnumerable<IPAddress> addresses,
            int port,
            int attempts,
            int timeoutMilliseconds,
            out LoggerConnection connection,
            out string errorMessage)
        {
            if (addresses == null)
                throw new ArgumentNullException("addresses");
            if (port < IPEndPoint.MinPort || port > IPEndPoint.MaxPort)
                throw new ArgumentOutOfRangeException("port");
            if (attempts < 1)
                throw new ArgumentOutOfRangeException("attempts");
            if (timeoutMilliseconds < 1)
                throw new ArgumentOutOfRangeException("timeoutMilliseconds");

            connection = null;
            errorMessage = "No connection attempts were made.";
            for (int attempt = 0; attempt < attempts; attempt++)
            {
                foreach (IPAddress address in addresses)
                {
                    TcpClient candidate = new TcpClient(address.AddressFamily);
                    try
                    {
                        IAsyncResult result = candidate.BeginConnect(address, port, null, null);
                        if (!result.AsyncWaitHandle.WaitOne(timeoutMilliseconds))
                        {
                            errorMessage = "Connection timed out.";
                            continue;
                        }

                        candidate.EndConnect(result);
                        connection = new LoggerConnection(candidate);
                        candidate = null;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        if (candidate != null)
                            candidate.Close();
                    }
                }
            }
            return false;
        }

        public void Dispose()
        {
            if (stream != null)
            {
                stream.Close();
                stream = null;
            }
            if (client != null)
            {
                client.Close();
                client = null;
            }
        }
    }
}
