using System;

namespace WebSocketSharp.Net.WebSockets.Exceptions
{
    public class WebSocketAlreadyClosedException : Exception
    {
        public WebSocketAlreadyClosedException() { }

        public WebSocketAlreadyClosedException(string name)
            : base(string.Format($"The websocket is already closed: {name}", name))
        {

        }
    }
}