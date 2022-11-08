using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthmaticProblem
{
    public class MoodIsNullException:Exception
    {
        public MoodIsNullException(string message) : base(message)
        {

        }

    }
}
