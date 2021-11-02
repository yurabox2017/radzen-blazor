using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Radzen.Blazor
{
    internal static class Ut
    {

        internal static bool In<T>(this T sourse, params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            return values.Contains(sourse);
        }
    }
}
