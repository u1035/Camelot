using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camelot.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            
            if (action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            
            foreach (var item in collection)
            {
                action(item);
            }
        }
        
        public static async Task ForEachAsync<T>(this IEnumerable<T> collection, Func<T, Task> action)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            
            if (action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            
            foreach (var item in collection)
            {
                await action(item);
            }
        }
    }
}