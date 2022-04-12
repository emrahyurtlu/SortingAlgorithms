using SortingAlgorithms;

var sorting = new Sorting();
var arr = new List<int>
{
    11, 12, 22, 25, 64, 8, 1, 3, 78, 87, 45, 34
};

Console.WriteLine("Before Sorting: ");
foreach (var item in arr) Console.Write(item + " ");

sorting.MergeSort(arr);
Console.WriteLine("\nAfter Sorting: ");

foreach (var item in arr) Console.Write(item + " ");

Console.ReadLine();