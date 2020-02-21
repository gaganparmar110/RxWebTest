using Microsoft.Extensions.DependencyInjection;
using FaceBookRxWeb.Infrastructure.Singleton;
using FaceBookRxWeb.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace FaceBookRxWeb.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




