
using PingPong;

void DisplayMessagePong(string message) => Console.WriteLine(message);
void DisplayMessagePon(string message) => Console.WriteLine(message);

Ping ping = new Ping();
Pong pong = new Pong();

ping.onReadPing += DisplayMessagePong;
ping.Pong();
pong.Ping();
Console.WriteLine();


