using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoctoStarter.Interfaces.Logging;

namespace YoctoStarter.Logging.Log4Net
{
    public class Log4NetLogger : ILog
    {
        private readonly log4net.ILog logger;

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
            logger.Debug(message, exception);
        }
    }
}
