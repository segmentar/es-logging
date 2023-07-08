using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SLLogger
    {
        public static IList<SLLogger> LoggerDefaultSet(IEnumerable<Object> enumerable)
        {
            ICollection<SLLogger> collectionResult = default;

            collectionResult = new Collection<SLLogger>();

            foreach (Object object_ITEM in enumerable)
            {
                var logger = Runtime_MakeLoggerNew(object_ITEM);

                collectionResult.Add(logger);

                continue;
            }

            return new List<SLLogger>(collectionResult);
        }
    }
}
