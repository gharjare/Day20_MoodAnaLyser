using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser1
{
    public class MoodAnalyserCustomException : Exception

    {
        public enum ExceptionType
        {
            NULLMOOD, EMPTYMOOD,
            NO_SUCH_CLASS, NO_SUCH_FIELD,
            NO_SUCH_METHOD, OBJECT_CREATION_ISSUE

        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, string input) : base(input)
        {
            this.type = Type;
        }
    }
}
