using Microsoft.Extensions.DependencyInjection;
using System;

namespace CorePackage.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }
}

