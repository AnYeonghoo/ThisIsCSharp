﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter21
{
    internal class EchoServer
    {
        static void MainEchoServer(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine($"사용법: {Process.GetCurrentProcess().ProcessName} <Bind IP>");
                return;
            }

            string bindIp = args[0];
            const int bindPort = 5425;
            TcpListener server = null;

            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);

                server = new TcpListener(localAddress);
                server.Start();
                Console.WriteLine("메아리 서버 시작");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("클라이언트 접속: {0}", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());
                    NetworkStream stream = client.GetStream();

                    int length;

                    string data = null;
                    byte[] bytes = new byte[256];

                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {

                        data = Encoding.Default.GetString(bytes, 0, length);
                        Console.WriteLine("수신: {0}", data);

                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("송신 : {0}", data);
                    }
                    stream.Close();
                    client.Close();
                        
                }
                
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop();
            }

           
        }
    }
}
