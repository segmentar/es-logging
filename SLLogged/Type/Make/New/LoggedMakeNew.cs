using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static SLLogged MakeLoggedNew(Object[] array_OBJECT_SYMBOL_case, Boolean debug)
        {
            SLLogged loggedResult = default;

            LoggedZeroTenVoid(array_OBJECT_SYMBOL_case);

            loggedResult = new SLLogged(debug);

            return loggedResult;
        }
    }
}
