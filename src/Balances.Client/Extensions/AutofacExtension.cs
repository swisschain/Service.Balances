using System;
using System.Diagnostics.CodeAnalysis;
using Autofac;

namespace Balances.Client.Extensions
{
    /// <summary>
    /// Extension for client registration.
    /// </summary>
    public static class AutofacExtension
    {
        /// <summary>
        /// Registers <see cref="IBalancesClient"/> in Autofac container using <see cref="BalancesClientSettings"/>.
        /// </summary>
        /// <param name="builder">Autofac container builder.</param>
        /// <param name="settings">Service client settings.</param>
        public static void RegisterBalancesClient(
            [NotNull] this ContainerBuilder builder,
            [NotNull] BalancesClientSettings settings)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            builder.RegisterInstance(new BalancesClient(settings))
                .As<IBalancesClient>()
                .SingleInstance();
        }
    }
}
