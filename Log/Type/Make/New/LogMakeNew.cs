using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static SLLog MakeLogNew(Object[] array_OBJECT_SYMBOL, Boolean debug)
        {
            SLLog logResult = default;

            foreach (Object object_SYMBOL in array_OBJECT_SYMBOL)
            {
                Console.Out.WriteLine(object_SYMBOL.ToString());

                continue;
            }

            logResult = new SLLog(debug);

            return logResult;
        }
    }
}
