using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace consoleAppFirst
{
    public class ConnectionTest
    {
        public ConnectionTest()
        {
            var connection = new HubConnectionBuilder()
                .("http://localhost:5000/yourHubPath")
                .Build();
        }
    }
}
