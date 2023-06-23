using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static void LogZeroTenVoid(Object[] array_OBJECT_SYMBOL_case)
        {
            foreach (Object object_SYMBOL in array_OBJECT_SYMBOL_case)
            {
                Console.Out.WriteLine(object_SYMBOL.ToString());

                continue;
            }

            return;
        }
    }
}
