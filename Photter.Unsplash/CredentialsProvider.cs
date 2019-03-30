using System;

using Phaber.Unsplash;

using Photter;
using Photter.Configs;

namespace Photter.Unsplash {
    public class CredentialsProvider {
        private ProjectConfig _configs;

        public CredentialsProvider(ProjectConfig configs) {
            _configs = configs;
        }

        public Credentials Provide() {
            return new Credentials(_configs.AppId, "NOT_NEEDED");
        }
    }
}