using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoDependecyInjection.Models
{
    public class RessourceLocator : LocatorBase
    {
        private static RessourceLocator _instance;

        public static RessourceLocator Instance
        {
            get
            {
                return _instance ?? (_instance = new RessourceLocator());
            }
        }

        private RessourceLocator()
        {

        }


        protected override void ConfigureService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IService, Service>();
        }

        public IService Service
        {
            get { return Container.GetService<IService>(); }
        }
    }
}