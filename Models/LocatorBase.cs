using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoDependecyInjection.Models
{
    public abstract class LocatorBase
    {
        protected IServiceProvider Container { get; private set; }

        public LocatorBase()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            Container = serviceCollection.BuildServiceProvider();
        }

        protected abstract void ConfigureService(IServiceCollection serviceCollection);
    }
}