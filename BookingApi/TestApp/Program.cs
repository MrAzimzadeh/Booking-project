// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.SignalR.Client;

using Microsoft.AspNetCore.SignalR.Client;
Console.Write("Kullanıcı Kimliği (user ID): ");
var userId = Console.ReadLine();

Console.Write("Otel Kimliği (hotel ID): ");
var hotelId = Console.ReadLine();

var connection = new HubConnectionBuilder()
    .WithUrl($"http://localhost:5026/chat")
    .Build();

await connection.StartAsync();

while (true)
{
    Console.Write("Mesajınızı girin (çıkmak için 'exit' yazın): ");
    var message = Console.ReadLine();

    if (message.ToLower() == "exit")
    {
        break;
    }

    // Kullanıcının otel kanalına mesaj gönderme kodu burada olacak.
    await connection.InvokeAsync("JoinRoom", userId, hotelId);
}

await connection.StopAsync();
