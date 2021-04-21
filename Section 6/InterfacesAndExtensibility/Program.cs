using System;

namespace Section6InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"log.txt"));
            dbMigrator.Migrate();
        }
    }
}
