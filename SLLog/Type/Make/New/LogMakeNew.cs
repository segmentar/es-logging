using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static SLLog MakeLogNew(Object[] array_OBJECT, Boolean debug)
        {
            SLLog logResult = default;

            LogZeroTenVoid(array_OBJECT);

            logResult = new SLLog(debug);

            return logResult;
        }
    }
}
