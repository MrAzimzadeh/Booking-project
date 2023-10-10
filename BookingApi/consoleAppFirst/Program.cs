

using Microsoft.AspNetCore.SignalR.Client;

var hubUrl = "https://localhost:5001/chat";

// HubConnectionBuilder nesnesini oluşturur.
var connectionBuilder = new HubConnectionBuilder();

// HubConnectionBuilder nesnesine WithUrl yöntemini çağırır.
connectionBuilder.WithUrl(hubUrl);

// HubConnection nesnesini oluşturur.
var connection = connectionBuilder.Build();
connection.On<string, string>("ReceiveMessage", (user, message) =>
{
    Console.WriteLine($"Mesaj alındı: {user}: {message}");
});

await connection.StartAsync();

Console.WriteLine("Alıcı başlatıldı. Mesajları bekliyor...");
Console.ReadLine();