using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static SLLog Runtime_MakeLogNew(Object object_ITEM)
        {
            SLLog logResult = default;

            logResult = MakeLogNew(object_ITEM, SAPolicy.LogDebugPolicy);

            return logResult;
        }
    }
}
