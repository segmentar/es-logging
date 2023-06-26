using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static SLLogged Runtime_MakeLoggedNew(params Object[] array_OBJECT)
        {
            SLLogged loggedResult = default;

            loggedResult = MakeLoggedNew(array_OBJECT, SAPolicy.LoggedDebugPolicy);

            return loggedResult;
        }
    }
}
