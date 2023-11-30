using System;

namespace Day5
{
    class Installer {
        public static int id = 100; 
        private readonly Logger logger;

        public Installer(Logger logger) {
            this.logger = logger;
        }

        public void Install()
        {
            Console.WriteLine("The Packages are Installing");
        }

    }
}
