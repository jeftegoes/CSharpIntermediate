using System;

namespace Section6InterfacesAndExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}