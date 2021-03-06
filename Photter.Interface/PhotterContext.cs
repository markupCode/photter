using System.CommandLine;
using System.Net.Http;
using LightInject;
using Phaber.Unsplash;
using Phaber.Unsplash.Clients;
using Photter.Interface.Handlers.Old;

namespace Photter.Interface {
    public class PhotterContext : Context {
        private readonly LaunchConfig _launchConfig;

        public PhotterContext(LaunchConfig launchConfig) {
            _launchConfig = launchConfig;
        }

        protected override void ConfigureServices(ServiceContainer container) {
            container.RegisterInstance(_launchConfig);

            container.RegisterSingleton<ApiUris>();

            container.RegisterSingleton<HttpClient>();

            container.RegisterSingleton<IPhotoClient, PhotoClient>();
            container.RegisterSingleton<ICollectionClient, CollectionClient>();

            container.RegisterInstance(
                new RootCommand("photter")
            );

            container.RegisterSingleton<RootHandler>();
        }
    }
}