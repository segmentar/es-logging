using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static SLLogged Runtime_MakeLoggedNew(Object object_ITEM)
        {
            SLLogged loggedResult = default;

            loggedResult = MakeLoggedNew(object_ITEM, SAPolicy.LoggedDebugPolicy);

            return loggedResult;
        }
    }
}
