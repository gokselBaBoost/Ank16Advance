using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ConsoleApp
{
    public class LoggerService
    {
        private ILogger _logger;

        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }


    public interface ILogger
    {
        void Log(string message);
    }

    public class XmlLogger : ILogger
    {
        public void Log(string message)
        {
            //xml dosyası oluşturulacak
            Console.WriteLine(this.GetType() + " => " + message);
        }
    }

    public class TextLogger : ILogger
    {
        public void Log(string message)
        {
            //Text file oluşturulacak
            Console.WriteLine(this.GetType() + " => " + message);
        }
    }

    public class DbLogger : ILogger
    {
        public void Log(string message)
        {
            //Db bağlantısı
            Console.WriteLine(this.GetType() + " => " + message);
        }
    }


}
