using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoctoStarter.Interfaces.Logging
{
    public interface ILog
    {
        void Debug(string message);
        void Debug(string message, Exception exception);
        void Info();
        void Warn();
        void Error();
        void Fatal();
    }
}
