using HIS.IRepository;
using HIS.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HIS.Extenssions.DependencyInjection
{
    public static class HisDependencyInjection
    {
        public static void UseRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDemoRepository, DemoRepository>();
        }
    }
}
