using log4net;
using System;

namespace LogentriesTest1
{
    class Program
    {
        private static readonly ILog LoggerLe = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            //XmlConfigurator.Configure();

            var random = new Random();
            var num1 = random.Next(1000);

            LoggerLe.Info("A random number at " + DateTime.Now + " is " + num1);

            Console.ReadLine();
        }
    }
}
