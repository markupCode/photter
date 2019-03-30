using Newtonsoft.Json;

namespace Photter.Configs {
    public class ProjectConfig {
        public readonly string AppId;

        [JsonIgnore]
        public readonly string DbConnetion = "Data Source=photter.db";

        public ProjectConfig(string appId) {
            AppId = appId;
        }
    }
}