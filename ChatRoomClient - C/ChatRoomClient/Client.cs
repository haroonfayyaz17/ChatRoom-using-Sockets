using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace ChatRoomClient
{

    class Client
    {
        public DBController db;
        public Encryption encryption;
        public String Udirectory,Uname;
        Socket server, client;
        public String filepath = "";
        public bool fileReceived=false;
        public List<string> clientMsgs = new List<string>();

        public List<String> IPAddresses = new List<string>();
        public List<String> ports = new List<string>();
        public List<String> names = new List<string>();
        public List<String> directory = new List<string>();
        public IPEndPoint remEP;
        public String ip;
        Socket peerSocket;
        int portNo;
        public Client()
        {
            db = new DBController();
            encryption = new Encryption();
        }
        private int getPort()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }
        private string GetLocalIP()
        {
            //for (int i = 0; i < IPAddresses.Count; i++)
            //{
            //    if (assigned[i] == "usassign")
            //    {
            //        assigned[i] = "assign";
            //        db.updateStatus(IPAddresses[i]);
            //        portNo = Convert.ToInt32(ports[i]);
            //        return IPAddresses[i];
            //    }
            //}
            //return "";

            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            int i = 0;
            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    if (i >= IPAddresses.Count)
                        return ip.ToString();
                    if (ip.ToString() != IPAddresses[i])
                        return ip.ToString();
                }
            }

            i++;

            return "127.0.0.1";
        }
        public void StartClient()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                db.LoadIPs(IPAddresses, ports,names,directory);
                //yeh comment kya hai
                portNo = getPort();
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                String ipaddress = GetLocalIP();
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ipaddress), portNo);

                // Create a TCP/IP  socket.  
                server = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                ip = ipaddress;
                db.insertIP(ipaddress, portNo.ToString(),Uname,Udirectory);
                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    //db.LoadIPs(IPAddresses, ports);
                    //server.Bind(remoteEP);


                    //Thread listen = new Thread(() => ListenPeer());
                    //listen.IsBackground = true;
                    //listen.Start();
                    remEP = remoteEP;
                    //ConnectPeers();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                //Console.WriteLine("\nPress ENTER to continue...");
                //Console.Read();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Bind(IPEndPoint remoteEP)
        {
            server.Bind(remoteEP);

            Thread listen = new Thread(() => ListenPeer());
            listen.IsBackground = true;
            listen.Start();
        }
        public void ListenPeer()
        {
            server.Listen(1);
            while (true)
            {
                peerSocket = server.Accept();
                Thread receive = new Thread(() => ReceiveMsg(peerSocket));
                receive.IsBackground = true;
                receive.Start();
            }
        }

        public void ConnectPeers()
        {

            for (int i = 0; i < IPAddresses.Count; i++)
            {

                
                    client.Connect(new IPEndPoint(IPAddress.Parse(IPAddresses[i]), Convert.ToInt32(ports[i])));
                    Thread receive = new Thread(() => ReceiveMsg(client));
                    receive.IsBackground = true;
                    receive.Start();
            }
        }

        public void SendMsg(string msg)
        {
            try
            {
                if (peerSocket == null)
                    peerSocket = client;
                byte[] bytes = new byte[4000];
                msg = encryption.encrypt(msg);
                int bytesSent = peerSocket.Send(Encoding.ASCII.GetBytes(msg));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void ReceiveMsg(Socket socket)
        {
            try
            {
                while (true)
                {
                    byte[] bytes = new byte[4000];
                    int bytesRec = 0;

                    bytesRec = socket.Receive(bytes);
                    String message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    message = encryption.decrypt(message);

                    if (bytesRec == 0)
                    {
                        socket.Close();
                        //clientSockets.Remove(socket);

                        return;
                    }
                    char operation=message[0];
                    String temp = message;
                    String msg = message.Substring(1, message.Length-1);
                    
                    switch (operation)
                    {
                            //to receive messages from sender
                        case '#':
                            
                            clientMsgs.Add(msg);
                            break;
                            //to receive file from sender
                        case '@':
                            String senderName=message.Substring(1,message.IndexOf('~')-1);
                            int index=temp.IndexOf('~')+1;
                            String path=temp.Substring(index);
                            clientMsgs.Add("File Received from "+senderName);
                            filepath = path;
                            fileReceived = true;
                            break;
                        case '$':
                            break;
                        default:
                            break;
                    }
                    //foreach (var socket1 in clientSockets)
                    //{
                    //    socket1.Send(bytes);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseConnection()
        {
            
            server.Close();
            peerSocket.Close();
        }
    }
}
