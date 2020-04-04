using System;
using System.Collections.Generic;

namespace DependencyInjection.Services
{
    public interface IDatabase
    {
        void AddString(string key, string newData);

        int Size { get; }

        IEnumerable<string> GetData(string key);

        void DeleteAll();
    }
}
