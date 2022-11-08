
using PingPong;

void DisplayMessagePong(string message) => Console.WriteLine(message);
void DisplayMessagePing(string message) => Console.WriteLine(message);

Ping ping = new Ping();
Pong pong = new Pong();

ping.SubscribeToPong(pong.Ping);
pong.SubscribeToPing(ping.Pong);


ping.Handler.Invoke();

Console.WriteLine();

