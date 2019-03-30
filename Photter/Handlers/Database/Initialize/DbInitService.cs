using Photter.Datastore.Services;

namespace Photter.Handlers.Database.Initialize {
    public class DbInitService : IDbInitService {
        private DbService _dbService;

        public DbInitService(DbService dbService) {
            _dbService = dbService;
        }

        public void InitializeDb() {
            _dbService.InitializeDb();
        }
    }
}