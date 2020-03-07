using Autofac;
using Balances.Domain.Services;

namespace Balances.Services
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BalancesService>()
                .As<IBalancesService>()
                .SingleInstance();
        }
    }
}
