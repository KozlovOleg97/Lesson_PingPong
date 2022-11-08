using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{

    public delegate void PingHandler();
    internal class Ping
    {
        public PingHandler Handler;
        public Ping()
        {
            
        }

        public void Pong()
        {
            Console.WriteLine("Ping received Pong");
            Handler.Invoke();
        }

        public void SubscribeToPong(PingHandler handler)
        {
            Handler = handler;
        }
    }


    internal class Pong 
    {
        public PingHandler Handler;
        public Pong()
        {
           
        }
        
        public void Ping()
        {
            Console.WriteLine("Pong received Ping");
            Handler.Invoke();
        }

        public void SubscribeToPing(PingHandler handler)
        {
            Handler = handler;
        }
    }
}
