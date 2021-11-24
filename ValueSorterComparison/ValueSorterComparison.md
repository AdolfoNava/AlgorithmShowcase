#Value Sorter Comparison 
The basis of this project is to display my knowledge of the different algorithms and analysis of the six different sorting systems. 

- QuickSort
- HeapSort
- SelectionSort
- MergeSort
- BubbleSort
- InsertionSort

All the algorithms are calling the same csv file with 10000 values and displaying the results immediately when the sorting process is completed. All the algorithm class have their own comments filled with the info as to the process of sorting everything is done.
##QuickSort
In quicksort an element is chosen from the array to act as a "pivot". The pivot separates the array into two parts, and each element in the subsections is compared to the pivot for sorting. The algorithm recursively calls itself on the subdivided sections until all elements are sorted.
##HeapSort
Heapsort is a comparison-based sort-in-place algorithm that takes no extra storage. It is often described as an improved selection sort. (Although with my results that doesn't appear to the case at least on the surface level)
##SelectionSort
Selection sort is an in-place comparison sorting algorithm. It is inefficient on large lists, and generally performs worse than insertion sort. (Although with my results that doesn't appear to the case at least on the surface level)
##MergeSort
Instead of picking a dividing item and splitting the items into two groups holding items that are larger and smaller than the dividing item, mergesort splits the items into two halves holding an equal number of items. It then recursively calls itself to sort the two halves. When the recursive calls to mergesort return, the algorithm merges the two sorted halves into a combined sorted list.
##BubbleSort
Bubble sort starts at the beginning of an array and swaps the first two elements if the first is greater than the second. Moving to the next pair, the same comparison is made.
##InsertionSort
Insertion sort is a simple sorting algorithm that builds the final sorted set one item at a time. It is efficient on small data sets but is much less efficient on large sets than quicksort, heapsort, or merge sort. 
##Comparison Results
Overall at least with my attempt of analysis all the values get sorted with the exception of bubble sort under 0.1 seconds with doesn't really identify the better one amongst the rest but each have their own issues with memory allocation in particularly with HeapSort with the amount of times the method gets recalled the adjusted array many times before finalizing it but it still gets dealt with extremely quickly. I'm sure if the elements were instead class objects with many other variables contained inside the time and memory used would probably increase the load onto my system which would also identify the differences between each of the sorts more clearly.
