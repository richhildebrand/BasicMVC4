﻿using System.Threading.Tasks;

namespace BasicMVC4
{
    public interface IQueue<T>
    {
        void Enqueue(T message);

        Task EnqueueAsync(T message);

        T Dequeue();

        Task<T> DequeueAsync();
    }
}
