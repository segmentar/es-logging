using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public static SLLog MakeLogNew(Object object_ITEM, Boolean debug)
        {
            SLLog logResult = default;
                
            Console.Out.WriteLine(object_ITEM);

            logResult = new SLLog(debug);

            return logResult;
        }
    }
}
