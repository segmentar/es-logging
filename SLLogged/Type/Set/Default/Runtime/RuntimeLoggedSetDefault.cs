using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SLLogged
    {
        public static SLLogged[] Runtime_LoggedDefaultSet(IEnumerable<Object> enumerable)
        {
            SLLogged[] arrayResult = default;

            var list = new List<SLLogged>(LoggedDefaultSet(enumerable));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
