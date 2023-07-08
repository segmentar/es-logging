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

            foreach (Object object_ITEM in enumerable)
            {
                var log = Runtime_MakeLogNew(object_ITEM);

                collectionResult.Add(log);

                continue;
            }

            return new List<SLLog>(collectionResult);
        }
    }
}
