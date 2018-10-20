﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class Collections
    {
        public static bool ContainsN<T>(this IEnumerable<T> enumerable, Func<T, bool> func, int count)
        {
            return enumerable.Count(func) == count;
        }

        public static IEnumerable<T> New<T>(Func<T> get, int count)
        {
            return Enumerable
                .Range(0, count)
                .Select(it => get());
        }

        public static MustAssertions Must<T>(this T o) => new MustAssertions(o);
    }
}
