using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace networktesttool
{

    //target =
    //ip = System.Console
    public class Attack
    {

        public Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        static string text = "Hello";
        public byte[] send_buffer = Encoding.ASCII.GetBytes(text);
        static  IPAddress serverAddr = IPAddress.Parse(Console.ReadLine());
        public IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);

        public void SendUDP()
        {
            sock.SendTo(send_buffer, endPoint);
        }
            
       

    }
}
            
    
   
      









    

