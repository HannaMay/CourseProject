using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows;
public class StateObject
{
    // Client  socket.  
    public Socket workSocket = null;
    // Size of receive buffer
    // Размер буфера приёма 
    public const int BufferSize = 1024;
    // Receive buffer
    // Буфер приема
    public byte[] buffer = new byte[BufferSize];
    // Received data string  
    // Полученная строка данных
    public StringBuilder sb = new StringBuilder();
}

namespace CP_WPF
{
    public class AsyncClient
    {
        private const int port = 11000;

        // ManualResetEvent instances signal completion.  
        // Завершение подачи экземпляров ManualResetEvent.
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.  
        // Ответ от удаленного устройства.
        private static String response = String.Empty;

        public static void StartClient()
        {
            // Connect to a remote device.  
            // Подключение к удаленному устройству.
            try
            {
                // Establish the remote endpoint for the socket.  
                // The name of the   
                // remote device is "host.contoso.com".  
                // Установите удаленную конечную точку для сокета.
                // Имя
                // удаленным устройством является «host.contoso.com».
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a TCP/IP socket.  
                Socket client = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.  
                // Подключение к удаленной конечной точке.
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                // Send test data to the remote device.  
                // Отправлять тестовые данные на удаленное устройство.
                Send(client, "This is a test<EOF>");
                sendDone.WaitOne();

                // Receive the response from the remote device.  
                // Получать ответ с удаленного устройства.
                Receive(client);
                receiveDone.WaitOne();

                // Write the response to the console.  
                // Записываем ответ на консоль.
                MessageBox.Show("Response received : {0}", response);

                // Release the socket.  
                // Отпустите сокет.
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
                // Retrieve the socket from the state object.  
                // Извлеките сокет из объекта состояния.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.  
                // Завершите соединение.
                client.EndConnect(ar);

                MessageBox.Show("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.  
                // Сообщаем, что соединение выполнено.
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
                // Create the state object. 
                // Создаем объект состояния.
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.  
                // Начнем получать данные с удаленного устройства.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
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
                // Retrieve the state object and the client socket   
                // from the asynchronous state object.  
                // Получить объект состояния и клиентский сокет
                // из объекта асинхронного состояния.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.  
                // Чтение данных с удаленного устройства.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.  
                    // Там может быть больше данных, поэтому сохраняйте полученные данные до сих пор.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data. 
                    // Получить остальные данные.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.  
                    // Все данные прибыли; ответьте.
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    // Сигнал о том, что все байты были получены.
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
            // Convert the string data to byte data using ASCII encoding.  
            // Преобразование строковых данных в байтовые данные с использованием ASCII-кодирования.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device. 
            // Начнем отправку данных на удаленное устройство.
            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                // Извлеките сокет из объекта состояния.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                // Завершение отправки данных на удаленное устройство.
                int bytesSent = client.EndSend(ar);
                MessageBox.Show("Sent {0} bytes to server.", bytesSent.ToString());

                // Signal that all bytes have been sent.  
                // Сигнал о том, что все байты были отправлены.
                sendDone.Set();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
