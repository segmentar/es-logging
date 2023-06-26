using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static void LogZeroTenVoid(Object[] array_OBJECT)
        {
            foreach (Object entry in array_OBJECT)
            {
                Console.Out.WriteLine(entry.ToString());

                continue;
            }

            return;
        }
    }
}
