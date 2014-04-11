using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoctoStarter.Interfaces.Logging;

namespace YoctoStarter.Logging.NLog
{
    public class NLogLogger : ILog
    {
        private readonly Logger logger;

        public void Info()
        {
            throw new NotImplementedException();
        }

        public void Warn()
        {
            throw new NotImplementedException();
        }

        public void Error()
        {
            throw new NotImplementedException();
        }

        public void Fatal()
        {
            throw new NotImplementedException();
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Debug(string message, Exception exception)
        {
            logger.DebugException(message, exception);
        }
    }
}
