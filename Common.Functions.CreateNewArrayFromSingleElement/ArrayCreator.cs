using System.Collections.Generic;

namespace Common.Functions.CreateNewArrayFromSingleElement
{
    public static class ArrayCreator
    {
        public static IEnumerable<T> Array<T>(T firstElement) => new T[] { firstElement };
    }
}
