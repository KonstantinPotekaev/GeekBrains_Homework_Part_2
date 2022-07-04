using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3
{
    public class Generate_Id
    {
        public static long Generate_id()
        {
            DateTime centuryBegin = new DateTime(2022, 7, 4); 
            DateTime currentDate = DateTime.Now;
            long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
            return elapsedTicks;
        }
    }
}
