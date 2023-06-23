using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static void LoggedZeroTenVoid(Object[] array_OBJECT_SYMBOL_case)
        {
            foreach (Object object_SYMBOL in array_OBJECT_SYMBOL_case)
            {
                Console.Out.WriteLine(object_SYMBOL.ToString());

                continue;
            }

            Console.ReadKey();

            return;
        }
    }
}
