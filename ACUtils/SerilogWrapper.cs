using System;

namespace ACUtils
{
    internal class SerilogWrapper : ACUtils.ILogger
    {
        private Serilog.ILogger logger;

        public SerilogWrapper(Serilog.ILogger logger)
        {
            this.logger = logger;
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            logger.Debug(messageTemplate, propertyValues);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            logger.Error(messageTemplate, propertyValues);
        }

        public void Exception(Exception exception)
        {
            logger.Error(exception.ToString());
        }

        public void Information(string message)
        {
            logger.Information(message);
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            logger.Information(messageTemplate, propertyValues);
        }

        public void Warning(string message)
        {
            logger.Warning(message);
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            logger.Warning(messageTemplate, propertyValues);
        }
    }
}
