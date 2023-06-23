﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public static SLLogger Runtime_MakeLoggerNew(params Object[] array_OBJECT_SYMBOL_case)
        {
            SLLogger loggerResult = default;

            loggerResult = MakeLoggerNew(array_OBJECT_SYMBOL_case, SAPolicy.LoggerDebugPolicy);

            return loggerResult;
        }
    }
}
