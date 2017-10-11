interface IComparator<T> {
	/**
	* compares two objects to each other
	* see: http://docs.oracle.com/javase/6/docs/api/java/util/Comparator.html
	* @param obj1 first object to compare
	* @param obj2 second object to compare
	* @returns negative value if obj1 is greater than obj2, positive value if obj2 is greater than obj1, zero if both objects are equal
	*/
	int compare(T obj1, T obj2);
}

interface IMatcher<T> {
	/**
	* checks whether a given element satisfies a certain predicate
	* @param element the element to check
	* @return true if the element satisfies the predicate
	*/
	boolean matches(T element);
}

interface ISort<T> {
	/**
	* sorts an unordered list into a new list. Note that not the passed list is ordered but
	* a new list is created where all elements from the input-list are put in order.
	* @param unorderedList the list to sort
	* @returns the ordered list
	*/
	List<T> sort(List<T> unorderedList);
}

interface ISearch<T> {
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

