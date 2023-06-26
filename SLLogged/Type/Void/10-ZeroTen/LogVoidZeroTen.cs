using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogged
    {
        public static void LoggedZeroTenVoid(Object[] array_OBJECT)
        {
            foreach (Object entry in array_OBJECT)
            {
                Console.Out.WriteLine(entry.ToString());

                continue;
            }

            Console.ReadKey();

            return;
        }
    }
}
