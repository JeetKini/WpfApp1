using System;

namespace Day5
{
    class DbMigrator {
        private readonly Logger logger;

        public DbMigrator(Logger logger)     
            
        {
            this.logger = logger;
        }
        public void Migrate()
        {

            Console.WriteLine("The Packages are Migrating");
        }
    
    }
}
