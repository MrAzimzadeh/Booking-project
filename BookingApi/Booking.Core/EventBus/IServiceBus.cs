using System;

namespace CorePackage.EventBus
{
    public interface IServiceBus
    {
        void SendMessage(object model, string queue);
        void ReciveMessage(string queue);
    }
}

