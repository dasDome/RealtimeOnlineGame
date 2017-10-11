using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    interface ISort<T>
    {
        /**
        * sorts an unordered list into a new list. Note that not the passed list is ordered but
        * a new list is created where all elements from the input-list are put in order.
        * @param unorderedList the list to sort
        * @returns the ordered list
        */
        List<T> sort(List<T> unorderedList);
    }
}
