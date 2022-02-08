using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises2.Data
{
    public class DataAccess : IDataAccess
    {
        public int getRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }
    }
}
