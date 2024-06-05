using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleApp
{
    public class Database
    {
        private static Database _instance;

        private Database()
        {
            
        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
                
            return _instance;
        }
    }
}
