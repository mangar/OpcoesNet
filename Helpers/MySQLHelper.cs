using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcoesNet.Helpers
{
    class MySQLHelper
    {

        /**
         * 
         * 
         */
        public static string convertDateFromBR(string dateBRFormat)
        {
            DateTime date = DateTime.Parse(dateBRFormat);
            return date.ToString("yyyy-MM-dd");
        }


    }
}
