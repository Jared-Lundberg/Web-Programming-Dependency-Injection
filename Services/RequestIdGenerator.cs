using System;

namespace DependencyInjection.Services
{
    public class RequestIdGenerator : IRequestIdGenerator
    {
        public RequestIdGenerator()
        {
            this.RequestId = Guid.NewGuid().ToString();
        }

        public string RequestId { get; }
    }
}
