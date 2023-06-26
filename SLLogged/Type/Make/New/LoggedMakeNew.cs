using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static SLLogged MakeLoggedNew(Object[] array_OBJECT, Boolean debug)
        {
            SLLogged loggedResult = default;

            LoggedZeroTenVoid(array_OBJECT);

            loggedResult = new SLLogged(debug);

            return loggedResult;
        }
    }
}
