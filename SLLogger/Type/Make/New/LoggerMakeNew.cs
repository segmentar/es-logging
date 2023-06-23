using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public static SLLogger MakeLoggerNew(Object[] array_OBJECT_SYMBOL, Boolean debug)
        {
            SLLogger loggerResult = default;

            Console.Clear();

            foreach (Object object_SYMBOL in array_OBJECT_SYMBOL)
            {
                Console.Out.WriteLine(object_SYMBOL.ToString());

                continue;
            }

            Console.ReadKey();

            loggerResult = new SLLogger(debug);

            return loggerResult;
        }
    }
}
