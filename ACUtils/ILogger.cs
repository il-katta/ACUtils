using System;

namespace ACUtils
{
    public interface ILogger
    {
        void Debug(string message);
        void Information(string message);
        void Warning(string message);
        void Error(string message);
        void Exception(Exception exception);
    }
}
