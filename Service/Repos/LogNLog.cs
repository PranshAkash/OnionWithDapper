﻿using NLog;
using System;

namespace Infrastructure.Repos
{
    public class LogNLog : Interface.ILog, IDisposable
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public LogNLog()
        {
        }

        public void Information(string message)
        {
            logger.Info(message);
        }

        public void Warning(string message)
        {
            logger.Warn(message);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
