using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static SLLog Runtime_MakeLogNew(params Object[] array_OBJECT_SYMBOL)
        {
            SLLog logResult = default;

            logResult = MakeLogNew(array_OBJECT_SYMBOL, SAPolicy.LogDebugPolicy);

            return logResult;
        }
    }
}
