using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SelectWednesday
{
    public class AllWednesday
    {
		//List<DateTime> dateTimes = new List<DateTime>(); 
        public static string Wednesday()
        {
            int yearday = 365;
            string result =string.Empty;

            DateTime dtbegin = new DateTime(2023, 1, 1);
            DateTime dtend = new DateTime(2023, 12, 31);
            
			
            for(int i = 0; i <= yearday; i++)
            {
                if (dtbegin.DayOfWeek == (DayOfWeek)3) result += dtbegin.ToString("yyyy/MM/dd")+"\n";
				if (dtbegin <= dtend) dtbegin = dtbegin.AddDays(1);

			}

			return result;
		}
    }
}
