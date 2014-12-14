﻿using System;
using System.Net;

namespace HttpReactor.Transport
{
    internal interface IHttpSocket : IDisposable
    {
        void Connect(EndPoint endPoint, int timeoutMicros);

        void Reconnect(EndPoint endPoint, int timeoutMicros);

        int Send(byte[] buffer, int offset, int count, int timeoutMicros);

        int Receive(byte[] buffer, int offset, int count, int timeoutMicros);

        void Close();
    }
}