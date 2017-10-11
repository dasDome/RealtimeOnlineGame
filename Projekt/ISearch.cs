using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    interface ISearch<T>
    {
        /**
        * searches for a specific element in a given list. When multiple elements match only the first one will be returned.
        * @param list the list to browse through
        * @param predicate the matcher to determine whether we found our element
        * @returns the first element in the list to satisfy the predicate. NULL if no element satisfies the predicate
        */
        T search(List<T> list, IMatcher<T> predicate);

        /**
        * searches for a elements in a given list that satisfy a predicate.
        * @param list the list to browse through
        * @param predicate the matcher to determine whether we found an element
        * @returns a list of elements that satisfy the predicate. The list may be empty if no element in the input-list matches our needs
        */
        List<T> searchAll(List<T> list, IMatcher<T> predicate);
    }
}
