using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson30
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAO dao = new DAO();
            Console.WriteLine(dao.GetCountyAndItsCapitalCityName(2));
            Console.WriteLine(dao.GetCountyAndItsCapitalCityDDetails(1));
            Console.WriteLine(dao.GetCountyAndItsCapitalCityName("Belarus"));
            Console.WriteLine(dao.GetCountyAndItsCapitalCityDDetails("Israel"));
            Console.WriteLine(dao.GetCountyAndItsCapitalCityNameFromFirstLetter("I"));

        }
    }
}
