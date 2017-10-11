using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    interface IMatcher<T>
    {
        /**
        * checks whether a given element satisfies a certain predicate
        * @param element the element to check
        * @return true if the element satisfies the predicate
        */
        Boolean matches(T element);
    }
}
