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
		/// <summary>
		/// 找出2023年所有的星期三
		/// </summary>
		/// <returns>回傳2023年所有星期三的日期</returns>
		public static string Wednesday()
        {
            int yearday = 365; //一年365天
            string result =string.Empty;

            DateTime dtbegin = new DateTime(2023, 1, 1); //起始日
            DateTime dtend = new DateTime(2023, 12, 31); //結束日
            DayOfWeek dayOfWeek = (DayOfWeek)3; //星期三
            
			
            for(int i = 0; i <= yearday; i++)
            {
                if (dtbegin.DayOfWeek == dayOfWeek) result += dtbegin.ToString("yyyy/MM/dd")+"\n";
				if (dtbegin <= dtend) dtbegin = dtbegin.AddDays(1);

			}

			return result;
		}
    }
}
