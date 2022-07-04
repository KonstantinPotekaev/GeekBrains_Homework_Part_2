using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3
{
    internal class Generate_Id
    {
        static Guid Generate_id()
        {
            return Guid.NewGuid();
        }
    }
}
