using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ConsoleApp
{
    public class LogService
    {
        private readonly XmlLog _xmlLog;
        private readonly TextLog _textLog;
        private readonly DbLog _dbLog;

        public LogService()
        {
            _xmlLog = new XmlLog();
            _textLog = new TextLog();
            _dbLog = new DbLog();
        }

        public void Log(string message, LogType logType)
        {
            switch (logType)
            {
                case LogType.XmlLog:
                    _xmlLog.LogYaz(message);
                    break;
                case LogType.TextLog:
                    _textLog.LogOlustur(message);
                    break;
                case LogType.DbLog:
                    _dbLog.LogInsert(message);
                    break;
                default:
                    Console.WriteLine("LogType not supported");
                    break;
            }
        }
    }

    public class XmlLog
    {
        //public XmlLog(string filename)
        //{
        //    //logic
        //}
        public void LogYaz(string message)
        {
            Console.WriteLine("Xml Logger : " + message);
        }
    }

    public class TextLog
    {
        public void LogOlustur(string message)
        {
            Console.WriteLine("Text Logger : " + message);
        }
    }

    public class DbLog
    {
        public void LogInsert(string message)
        {
            Console.WriteLine("Db Logger : " + message);
        }
    }

    public enum LogType
    {
        XmlLog,
        TextLog,
        DbLog
    }
}
