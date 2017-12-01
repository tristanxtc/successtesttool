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
        //create new object of class Socket, assign a value for the text, and 
        public Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        static string text = "Hello";
        public byte[] send_buffer = Encoding.ASCII.GetBytes(text);
        //

        public void Setip()
        {
            Console.WriteLine("Please Enter an IP:");
        }

            static IPAddress serverAddr = IPAddress.Parse(Console.ReadLine());
            public IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);
        

        
        
        public void SetIP()
        {
            //not yet implemented
       
        }
       // public void SetEndpoint()
        //{
    //}
                         
            
        
        public void SendUDP()
        {
           
            sock.SendTo(send_buffer, endPoint);
        }
        
    }


       
            
       

}

            
    
   
      









    

