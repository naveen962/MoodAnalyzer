using System;
using System.Collections.Generic;
using System.Text;

namespace UC3MoodAnalyzer
{
   public class CustomMoodException:Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, INVALID_MESSAGE, NO_SUCH_CLASS, NO_CONSTRUCTOR_FOUND
        }
        public CustomMoodException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

