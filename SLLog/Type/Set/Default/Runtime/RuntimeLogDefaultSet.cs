using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SLLog
    {
        public static SLLog[] Runtime_LogDefaultSet(IEnumerable<Object> enumerable)
        {
            SLLog[] arrayResult = default;

            var list = new List<SLLog>(LogDefaultSet(enumerable));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
