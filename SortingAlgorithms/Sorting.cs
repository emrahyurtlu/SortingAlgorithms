namespace SortingAlgorithms;

public class Sorting
{
    /// <summary>
    ///     Time Complexity: O(n2) as there are two nested loops.
    ///     Auxiliary Space: O(1)
    /// </summary>
    /// <param name="arr"></param>
    public void SelectionSort(List<int> arr)
    {
        var n = arr.Count;

        // One by one move boundary of unsorted subarray
        for (var i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            var minIdx = i;
            for (var j = i + 1; j < n; j++)
                if (arr[j] < arr[minIdx])
                    minIdx = j;

            // Swap the found minimum element with the first
            // element
            var temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    /// <summary>
    ///     Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are
    ///     in wrong order.
    ///     ( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1.
    ///     Worst and Average Case Time Complexity: O(n2). Worst case occurs when array is reverse sorted.
    ///     Best Case Time Complexity: O(n). Best case occurs when array is already sorted.
    ///     Auxiliary Space: O(1)
    ///     Boundary Cases: Bubble sort takes minimum time (Order of n) when elements are already sorted.
    ///     Sorting In Place: Yes
    ///     Stable: Yes
    /// </summary>
    /// <param name="arr"></param>
    public void BubbleSort(List<int> arr)
    {
        var n = arr.Count;
        for (var i = 0; i < n - 1; i++)
        for (var j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {
                // swap temp and arr[i]
                var temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    }

    /// <summary>
    ///     Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands.
    ///     The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and
    ///     placed at the correct position in the sorted part.
    ///     Time Complexity: O(n^2)
    ///     Auxiliary Space: O(1)
    /// </summary>
    /// <param name="arr"></param>
    public void InsertionSort(List<int> arr)
    {
        var n = arr.Count;
        for (var i = 1; i < n; ++i)
        {
            var key = arr[i];
            var j = i - 1;

            // Move elements of arr[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }

    /// <summary>
    /// Merge Sort is a Divide and Conquer algorithm.
    /// It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves.
    /// The merge() function is used for merging two halves.
    /// The merge(arr, l, m, r) is a key process that assumes that arr[l..m] and arr[m+1..r] are sorted and merges the two sorted sub-arrays into one.
    /// See the following C implementation for details.
    /// Time Complexity: T(n) = 2T(n/2) + θ(n)
    /// </summary>
    /// <param name="arr"></param>
    public void MergeSort(List<int> arr)
    {
        Sort(arr, 0, arr.Count - 1);
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        void Merge(List<int> arr1, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            var n1 = m - l + 1;
            var n2 = r - m;

            // Create temp arrays
            var L = new int[n1];
            var R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr1[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr1[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            var k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr1[k] = L[i];
                    i++;
                }
                else
                {
                    arr1[k] = R[j];
                    j++;
                }

                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr1[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr1[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        void Sort(List<int> arr2, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                var m = l + (r - l) / 2;

                // Sort first and
                // second halves
                Sort(arr2, l, m);
                Sort(arr2, m + 1, r);

                // Merge the sorted halves
                Merge(arr2, l, m, r);
            }
        }
    }
    
    
}