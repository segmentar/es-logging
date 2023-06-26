using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public static SLLogger MakeLoggerNew(Object[] array_OBJECT, Boolean debug)
        {
            SLLogger loggerResult = default;

            Console.Clear();

            foreach (Object entry in array_OBJECT)
            {
                Console.Out.WriteLine(entry.ToString());

                continue;
            }

            Console.ReadKey();

            loggerResult = new SLLogger(debug);

            return loggerResult;
        }
    }
}
