using System;
using Topshelf.ServiceConfigurators;

namespace Topshelf.Orleans {
    public static class ServiceConfiguratorExtensions {
        public static ServiceConfigurator<OrleansService> ConstructUsing(this ServiceConfigurator<OrleansService> self, Action<OrleansServiceConfigurator> configure) {
            var configurator = new OrleansServiceConfigurator();
            configure(configurator);
            self.ConstructUsing(() => configurator.Build());
            return self;
        }
    }
}
