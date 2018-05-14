using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows;
using ClassLibrary;

public enum TypeOfInfo
{
    Films = 1, Cinemas, Users, User
};

public class StateObject
{
    public Socket workSocket = null;

    public const int BufferSize = 500000;

    public byte[] buffer = new byte[BufferSize];

    public StringBuilder sb = new StringBuilder();
}

namespace CP_WPF
{
    public class AsyncClient
    {
        public static void SetTypeInfo(TypeOfInfo src)
        {
            TypeOfTheInfo = src;
        }

        public static void SetUser(User src)
        {
            user = src;
        }

        public static TypeOfInfo TypeOfTheInfo;
        private const int port = 11000;

        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        public static List<Film> films;
        public static List<Cinema> cinemas;
        public static List<User> users;
        public static User user;
        public static void StartClient()
        {
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry("Client1");
                IPAddress ipAddress = ipHostInfo.AddressList[1];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                Socket client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                Send(client, TypeOfTheInfo.ToString());                                    //сам запрос
                
                sendDone.WaitOne();

                Receive(client);
                receiveDone.WaitOne();

                if (TypeOfTheInfo == TypeOfInfo.User)
                {
                    Send(client, user);
                    sendDone.WaitOne();
                    Receive(client);
                    receiveDone.WaitOne();
                }
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                client.EndConnect(ar);

                MessageBox.Show("Socket connected to " + client.RemoteEndPoint.ToString());

                connectDone.Set();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                StateObject state = new StateObject
                {
                    workSocket = client
                };

                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                int bytesRead = client.EndReceive(ar);
                
                if (bytesRead > 0)
                {
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    switch (TypeOfTheInfo)
                    {
                        case TypeOfInfo.Films:
                            {
                                films = FilmHandler.ConvertByteArrayToFilmList(state.buffer);
                                break;
                            }
                        case TypeOfInfo.Cinemas:
                            {
                                cinemas = CinemaHandler.ConvertByteArrayToCinemaList(state.buffer);
                                break;
                            }
                        case TypeOfInfo.Users:
                            {
                                users = UserHandler.ConvertByteArrayToUserList(state.buffer);
                                break;
                            }
                        case TypeOfInfo.User:
                            {
                                state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, state.buffer.Length));
                                MessageBox.Show(state.sb.ToString());
                                break;
                            }
                        default: break;
                    }

                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void Send(Socket client, String data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }

        private static void Send(Socket client, User data)
        {
            byte[] byteData = UserHandler.ConvertUserToByteArray(data);

            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }
        
        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                int bytesSent = client.EndSend(ar);

                sendDone.Set();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
