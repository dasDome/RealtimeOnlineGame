using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    interface IComparator<T>
    {
        /**
        * compares two objects to each other
        * see: http://docs.oracle.com/javase/6/docs/api/java/util/Comparator.html
        * @param obj1 first object to compare
        * @param obj2 second object to compare
        * @returns negative value if obj1 is greater than obj2, positive value if obj2 is greater than obj1, zero if both objects are equal
        */
        int compare(T obj1, T obj2);
    }
}
