using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class appointment_details
    {
        public static string schedule(List<string>obj,string datetime)
        {
            obj.Add(datetime);
            string[] date = datetime.Split(" ");
            string[] date = Date[0].Split("\");
            string[] time = date[1].Split(":");

            return date[2] + "," + date[0]+ "," +date[1] +","
        }
    }
}
