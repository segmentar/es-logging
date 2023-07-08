using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public static SLLogger MakeLoggerNew(Object object_ITEM, Boolean debug)
        {
            SLLogger loggerResult = default;

            Console.Clear();

            Console.Out.WriteLine(object_ITEM);

            Console.ReadKey(true);

            loggerResult = new SLLogger(debug);

            return loggerResult;
        }
    }
}
