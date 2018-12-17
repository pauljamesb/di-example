using System;

namespace dec_18
{
    class Program
    {
        static void Main(string[] args)
        {

            var dBMi = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dBMi.Migrate();

            installer.Install();

        }
    }


    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("This goes to message / Install.");
        }
    }


    public class DbMigrator 
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("This goes to message / Migrate.");
        }

    }


    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }




}
