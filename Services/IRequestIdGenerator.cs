using System;
namespace DependencyInjection.Services
{
    public interface IRequestIdGenerator
    {
        string RequestId { get; }
    }
}
