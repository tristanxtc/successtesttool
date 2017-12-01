using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace networktesttool
{
    class Program
    {

        //public string target;
        static void Main(string[] args)
        {
            //public string target = Console.ReadLine();
            //IpString ipString = new IpString(System.Console.ReadLine());
            //target = ipString.target;

            //ipstring = System.Console.ReadLine();

            Attack attack = new Attack();
            attack.Setip();
            attack.SendUDP();
        }
    }
}
