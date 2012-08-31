using System;
using System.Threading.Tasks;

namespace BasicMVC4.Messaging
{
    public interface IMessenger
    {
        event EventHandler<MessageReceivedEventArgs> MessageReceived;

        Task Publish(string channel, byte[] message);
    }
}
