using System;

namespace ACUtils
{
    public interface ILogger
    {
        void Debug(string message);
        void Debug(string messageTemplate, params object[] propertyValues);
        void Information(string message);
        void Information(string messageTemplate, params object[] propertyValues);
        void Warning(string message);
        void Warning(string messageTemplate, params object[] propertyValues);
        void Error(string message);
        void Error(string messageTemplate, params object[] propertyValues);
        void Exception(Exception exception);
    }
}
