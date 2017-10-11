using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Comparator<T> : Projekt.IComparator<T> where T : IComparable
    {
        public Comparator()
        { }

        public int compare(T obj1, T obj2)
        {
            if (obj1.CompareTo(obj2) == 0)
                return 0;

            else if(obj1.CompareTo(obj2) > 0)
                return -1;
            else
                return 1;
        }

        /*public int compare(T obj1, T obj2)
        {
  
           // obj1.GetType().FindMembers(Player);
            throw new NotImplementedException();
        }*/
    }
}
