using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static SLLog Runtime_MakeLogNew(params Object[] array_OBJECT_SYMBOL_case)
        {
            SLLog logResult = default;

            logResult = MakeLogNew(array_OBJECT_SYMBOL_case, SAPolicy.LogDebugPolicy);

            return logResult;
        }
    }
}
