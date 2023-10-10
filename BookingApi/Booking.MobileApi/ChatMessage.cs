using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Booking.MobileApi
{
    public class ChatHub : Hub
    {
        public async Task JoinRoom(string userId, string hotelId)
        {
            // Kullanıcıyı belirtilen otele katılması için yönlendirin
            await Groups.AddToGroupAsync(Context.ConnectionId, $"{userId}_{hotelId}");
        }

    }   

    public class MessageFilter
    {
        public string UserId { get; set; }
        public string HotelId { get; set; }
    }
}