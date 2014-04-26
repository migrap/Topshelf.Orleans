using Orleans.Host.SiloHost;

namespace Topshelf.Orleans {
    public class OrleansService {
        private OrleansSiloHost _host;

        internal OrleansService(OrleansSiloHost host) {
            _host = host;
        }

        public bool Start() {
            _host.LoadOrleansConfig();
            _host.InitializeOrleansSilo();
            return _host.StartOrleansSilo();
        }

        public bool Stop() {
            _host.StopOrleansSilo();
            return true;
        }
    }
}