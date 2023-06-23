using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SLLogger
    {
        public static SLLogger[] Runtime_LoggerDefaultSet(IEnumerable<Object> enumerable)
        {
            SLLogger[] arrayResult = default;

            var list = new List<SLLogger>(LoggerDefaultSet(enumerable));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
