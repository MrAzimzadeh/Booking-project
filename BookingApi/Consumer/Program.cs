// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.SignalR.Client;
// See https://aka.ms/new-console-template for more information
Console.Write("Otel Kimliği (hotel ID): ");
var hotelId = Console.ReadLine();

var connection = new HubConnectionBuilder()
    .WithUrl($"http://localhost:5026/chat")
    .Build();

await connection.StartAsync();

connection.On<string, string>("ReceiveMessage", (userId, message) =>
{
    Console.WriteLine($"Kullanıcı ({userId}): {message}");

    // Kullanıcıya cevap vermek için kod burada olacak.
    Console.Write("Cevap yazın: ");
    var response = Console.ReadLine();
    connection.InvokeAsync("SendMessage", hotelId, response);
});

Console.WriteLine("Mesajları dinliyor...");

// Uygulamanın çalışmasını beklemek için bir tuşa basmayı bekleyin.
Console.WriteLine("Çıkmak için bir tuşa basın...");
Console.ReadKey();

await connection.StopAsync();