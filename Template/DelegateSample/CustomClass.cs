﻿using System;
using System.Collections.Generic;

namespace Template.DelegateSample
{
    public static class CustomClass
    {
        public static IEnumerable<T> DoWhere<T>
            (this IEnumerable<T> source, Func<T, Boolean> predicate)
        {
            foreach (T item in source)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
            }
        }
    }
}