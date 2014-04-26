using Orleans.Host.SiloHost;

namespace Topshelf.Orleans {
    public class OrleansServiceConfigurator {
        private OrleansSiloHost _host = new OrleansSiloHost("");

        internal OrleansServiceConfigurator() {
        }

        public OrleansServiceConfigurator Name(string value) {
            _host.SiloName = value;
            return this;
        }

        public OrleansServiceConfigurator ConfigFileName(string value) {
            _host.ConfigFileName = value;
            return this;
        }

        public OrleansServiceConfigurator DeploymentId(string value) {
            _host.DeploymentId = value;
            return this;
        }

        internal OrleansService Build() {
            return new OrleansService(_host);
        }
    }
}