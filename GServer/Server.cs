using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace GServer
{
    class Server
    {
        private TcpListener server;
        private IPAddress localAddr;
        private int port;
        private Thread listenerThread;
        public bool isInitialized = false;
        public bool isStarted = false;

        public TreeNode<string> test;
        public Tree tree;

        public bool itFirst = true;


        public TreeNode<string> createTree()
        {
            // Root
            TreeNode<string> root = new TreeNode<string>("root");
            {
                // 1
                TreeNode<string> node1 = root.AddChild("node1");
                {
                    // 11
                    TreeNode<string> node11 = node1.AddChild("node11");
                    {
                        TreeNode<string> node111 = node11.AddChild("node111");
                        TreeNode<string> node112 = node11.AddChild("node112");
                    }

                    // 12
                    TreeNode<string> node12 = node1.AddChild("node12");
                    {
                        TreeNode<string> node121 = node12.AddChild("node121");
                        TreeNode<string> node122 = node12.AddChild("node122");
                    }
                }
                // 2
                TreeNode<string> node2 = root.AddChild("node2");
                {
                    // 21
                    TreeNode<string> node21 = node2.AddChild("node21");
                    {
                        TreeNode<string> node211 = node21.AddChild("node211");
                        TreeNode<string> node212 = node21.AddChild("node212");
                    }

                    // 22
                    TreeNode<string> node22 = node2.AddChild("node22");
                    {
                        TreeNode<string> node221 = node22.AddChild("node221");
                        TreeNode<string> node222 = node22.AddChild("node222");
                    }
                }
            }
            return root;
        }

        public Server ()
        {
            this.isInitialized = true;
        }

        public Server (string ip, int p)
        {
            this.localAddr = IPAddress.Parse(ip);
            this.port = p;
            this.isInitialized = true;

        }

        public void Start()
        {
            listenerThread = new Thread(ListenerThread);
            listenerThread.IsBackground = true;
            listenerThread.Name = "Listener";
            listenerThread.Start();
        }

        public void Log(string message)
        {
            Form1._Form1.update(message);
        }

        public void UpdateQuestion(string message)
        {
            Form1._Form1.updateQuestionLabel(message);
        }

        protected void ListenerThread()
        {
            TcpListener server = null;
            try
            {
                // TcpListener server = new TcpListener(port);
                this.server = new TcpListener(localAddr, port);
                // Start listening for client requests.
                this.server.Start();
                this.isStarted = true;

                tree = new Tree(this, "left", "right");


                // Three choise
                if (itFirst)
                {
                    this.test = createTree();
                    itFirst = false;
                    Form1._Form1.updateQuestionLabel(this.test.Data);
                    Form1._Form1.updateButtonLabel(this.test.ElementAt(0).Data);
                    Form1._Form1.updateButtonLabel2(this.test.ElementAt(1).Data);
                }

  
            
                // Socket s = server.AcceptSocket();
                // Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;
                // Enter the listening loop.
                while (true)
                {
                    this.Log("Waiting for a connection... ");
                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = this.server.AcceptTcpClient();
                    this.Log("Connected!");
                    data = null;
                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();
                    int i;
                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        this.Log(data);
                        this.test = tree.makeChoice(data, this.test);
                        Form1._Form1.updateQuestionLabel(this.test.Data);
                        Form1._Form1.updateButtonLabel(this.test.ElementAt(0).Data);
                        Form1._Form1.updateButtonLabel2(this.test.ElementAt(1).Data);

                        // TODO:
                        // Make deeper tree, displaying final, restarting tree path and maybe
                        // a litle of design

                        // Process the data sent by the client.
                        data = data.ToUpper();
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        break;
                    }
                    client.Close();
                    // Shutdown and end connection
                }
            }
            catch (SocketException e)
            {
                this.Log("SocketException: {0}" + e);
            }
            finally
            {
                // Stop listening for new clients.
                if (this.isStarted)
                {
                    this.server.Stop();
                }
            }
        }

        public void Stop()
        {
            this.server.Stop();
            this.isStarted = false;
            this.Log("Server stoped.");
        }
        public void Suspend()
        {
            this.server.Stop();
        }
        public void Resume()
        {
            this.server.Start();
        }

    }
}
