using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{

    public delegate void PingHandler(string message);
    internal class Ping
    {
        public event PingHandler? onReadPing;
        public void Pong()
        {
            onReadPing?.Invoke($"Ping received Pong");
        }
    }


    internal class Pong 
    {
        public event PingHandler? onReadPong;
        public void Ping()
        {
            onReadPong?.Invoke($"Pong received Ping");
        }
    }
}
