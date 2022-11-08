using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthmaticProblem
{
    public class MoodCustomException:Exception
    {
        public enum ExceptionType
        {
            Null_Message, Empty_Message
        }
        private readonly Exception type;

        public MoodCustomException(Exception Type, string message):base(message)
        {
            this.type = Type;
        }
    }
}
