
using PingPong;

void DisplayMessagePong(string message) => Console.WriteLine(message);
void DisplayMessagePing(string message) => Console.WriteLine(message);

Ping ping = new Ping();
Pong pong = new Pong();

ping.onReadPing += DisplayMessagePong;
pong.onReadPong += DisplayMessagePing;
ping.Pong();
pong.Ping();
ping.Pong();
pong.Ping();
ping.Pong();
pong.Ping();
Console.WriteLine();


