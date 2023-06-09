﻿using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SLLogged
    {
        public static IList<SLLogged> LoggedDefaultSet(IEnumerable<Object> enumerable)
        {
            ICollection<SLLogged> collectionResult = default;

            collectionResult = new Collection<SLLogged>();

            foreach (Object object_ITEM in enumerable)
            {
                var logged = Runtime_MakeLoggedNew(object_ITEM);

                collectionResult.Add(logged);

                continue;
            }

            return new List<SLLogged>(collectionResult);
        }
    }
}
