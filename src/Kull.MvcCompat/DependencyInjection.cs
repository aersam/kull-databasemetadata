﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Kull.MvcCompat
{
    public static class DependencyInjection
    {
        public static void AddMvcCompat(this IUnityContainer services)
        {
            services.RegisterType(typeof(ILogger<>), typeof(Logger<>), new SingletonLifetimeManager());
            services.RegisterType(typeof(IHostingEnvironment), typeof(HostingEnvironment), new SingletonLifetimeManager());
            services.RegisterFactory(typeof(IServiceProvider), (c)=> new ServiceProviderUnity(c), new SingletonLifetimeManager());
        }
    }
}
