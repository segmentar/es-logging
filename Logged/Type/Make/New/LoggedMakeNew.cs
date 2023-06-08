using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static SLLogged MakeLoggedNew(Object[] array_OBJECT_SYMBOL, Boolean debug)
        {
            SLLogged loggedResult = default;

            foreach (Object object_SYMBOL in array_OBJECT_SYMBOL)
            {
                Console.Out.WriteLine(object_SYMBOL.ToString());

                continue;
            }

            Console.ReadKey();

            loggedResult = new SLLogged(debug);

            return loggedResult;
        }
    }
}
