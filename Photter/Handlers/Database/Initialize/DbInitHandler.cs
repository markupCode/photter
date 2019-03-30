using System;
using System.CommandLine;
using System.CommandLine.Invocation;

using Photter.Handlers.Db;

namespace Photter.Handlers.Database.Initialize {
    public class DbInitHandler : IDbHandler {
        public Command Command { get; }

        private Lazy<IDbInitService> _service;

        public DbInitHandler(Lazy<IDbInitService> service) {
            _service = service;

            Command = new Command(
                "init",
                handler: CommandHandler.Create(() => {
                    _service.Value.InitializeDb();
                })
            );
        }
    }
}