using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public static SLLogger Runtime_MakeLoggerNew(Object object_ITEM)
        {
            SLLogger loggerResult = default;

            loggerResult = MakeLoggerNew(object_ITEM, SAPolicy.LoggerDebugPolicy);

            return loggerResult;
        }
    }
}
