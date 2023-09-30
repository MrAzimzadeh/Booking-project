using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Entities.Concrete
{
    public class ChatMessage
    {
        public string Id { get; set; }           
        public string SenderId { get; set; }     
        public string SenderName { get; set; }  
        public string ReceiverId { get; set; }   
        public string ReceiverName { get; set; } 
        public string MessageText { get; set; }  
        public DateTime Timestamp { get; set; }  
    }
}