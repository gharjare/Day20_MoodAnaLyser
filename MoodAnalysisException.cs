using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser1
{
    public class MoodAnalysisException : Exception
    {
        NullMoodErrors error;

        public MoodAnalysisException(NullMoodErrors error, string input)
        {
            super(input);
            this.error = error;

        }

        private void super(string input)
        {
            throw new NotImplementedException();
        }

        public enum NullMoodErrors
        {
            NULLMOOD, EMPTYMOOD,
            NO_SUCH_CLASS, NO_SUCH_FIELD,
            NO_SUCH_METHOD, OBJECT_CREATION_ISSUE

        }
        
    }
}
