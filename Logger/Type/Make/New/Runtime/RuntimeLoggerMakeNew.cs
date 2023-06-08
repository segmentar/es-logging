using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public static SLLogger Runtime_MakeLoggerNew(params Object[] array_OBJECT_SYMBOL)
        {
            SLLogger loggerResult = default;

            loggerResult = MakeLoggerNew(array_OBJECT_SYMBOL, SAPolicy.LoggerDebugPolicy);

            return loggerResult;
        }
    }
}
