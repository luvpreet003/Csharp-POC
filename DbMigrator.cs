namespace csharpTrain
{
    public class DbMigrator
    {
        private readonly ILogger _logger;  //dependency injection

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}
