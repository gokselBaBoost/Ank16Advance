using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp.StructrualDP
{
    public class Database
    {
        private static Database _instance;
        private static object _lockObject = new object();


        private Database()
        {

        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        //Bir işlem geçikmesi oluşursa
                        Thread.Sleep(1000);
                        _instance = new Database();
                    }
                }
            }

            return _instance;
        }
    }
}
