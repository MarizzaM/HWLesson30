using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson30
{
    interface IDAO
    {
        object GetCountyAndItsCapitalCityName(int countryId);
        object GetCountyAndItsCapitalCityDDetails(int countryId);
        object GetCountyAndItsCapitalCityName(string countryName);
        object GetCountyAndItsCapitalCityDDetails(string countryName);
        object GetCountyAndItsCapitalCityNameFromFirstLetter(string firstLetter);
    }
}
