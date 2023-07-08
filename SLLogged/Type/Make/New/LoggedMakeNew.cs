using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static SLLogged MakeLoggedNew(Object object_ITEM, Boolean debug)
        {
            SLLogged loggedResult = default;

            Console.Out.WriteLine(object_ITEM);

            Console.ReadKey(true);

            loggedResult = new SLLogged(debug);

            return loggedResult;
        }
    }
}
