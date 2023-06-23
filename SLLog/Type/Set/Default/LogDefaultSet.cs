using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SLLog
    {
        public static IList<SLLog> LogDefaultSet(IEnumerable<Object> enumerable)
        {
            ICollection<SLLog> collectionResult = default;

            collectionResult = new Collection<SLLog>();

            foreach (Object item in enumerable)
            {
                var log = Runtime_MakeLogNew(item);

                collectionResult.Add(log);
            }

            return new List<SLLog>(collectionResult);
        }
    }
}
