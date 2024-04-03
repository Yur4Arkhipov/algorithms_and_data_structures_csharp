/**
    SORTING: 
        (1)BubbleSort
        (2)InsertionSort1
        (3)InsertionSort2
        (4)SelectionSort
        (5)ShellSort1
        (6)ShellSort2
        (7)RadixSort1
        (8)RadixSort2
        (9)MergeSortRecursive
        (10)MergeSortIterative
        (11)QuickSort
/

/* int[] arrToBubbleSort = [6,3,7,54,15,6,34,5,47];
Sorting.BubbleSort(arrToBubbleSort);
Console.Write("BubbleSort: ");
foreach (var item in arrToBubbleSort) {
    Console.Write(item + " ");
}
Console.WriteLine(); */

/* int[] arrToInsertionSort1 = {86,13,27,54,15,65,34,15,47};
Sorting.InsertionSort1(arrToInsertionSort1);
Console.Write("InsertionSort1: ");
foreach (var item in arrToInsertionSort1) {
    Console.Write(item + " ");
}
Console.WriteLine(); */

/* int[] arrToInsertionSort2 = {86,13,27,54,15,65,34,15,47};
Sorting.InsertionSort2(arrToInsertionSort2);
Console.Write("InsertionSort2: ");
foreach (var item in arrToInsertionSort2) {
    Console.Write(item + " ");
}
Console.WriteLine();*/

/* int[] arrToSelectionSort = {86,24,7,74,5,65,14,17,35,47};
Sorting.SelectionSort(arrToSelectionSort);
Console.Write("SelectionSort: ");
foreach (var item in arrToSelectionSort) {
    Console.Write(item + " ");
}
Console.WriteLine();*/

/* int[] arrToShellSort1 = {24,6,3,64,28,73,30,1,17};
Sorting.ShellSort1(arrToShellSort1);
Console.Write("ShellSort1: ");
foreach (var item in arrToShellSort1) {
    Console.Write(item + " ");
}
Console.WriteLine();*/

/* int[] arrToShellSort2 = {24,6,3,64,28,73,30,1,17};
Sorting.ShellSort2(arrToShellSort2);
Console.Write("ShellSort2: ");
foreach (var item in arrToShellSort2) {
    Console.Write(item + " ");
}
Console.WriteLine(); */

/* int[] arrToRadixSort1 = {240,60,32,640,28,73,3,1,17};
Sorting.RadixSort1(arrToRadixSort1);
Console.Write("RadixSort1: ");
foreach (var item in arrToRadixSort1) {
    Console.Write(item + " ");
}
Console.WriteLine();*/

/* int[] arrToRadixSort2 = {240,60,32,640,28,73,3,1,17};
Sorting.RadixSort2(arrToRadixSort2);
Console.Write("RadixSort2: ");
foreach (var item in arrToRadixSort2) {
    Console.Write(item + " ");
}
Console.WriteLine(); */

/* int[] arrToMergeSortRecursive = {240,60,32,640,28,73,3,1,17};
int left = 0;
int right = arrToMergeSortRecursive.Length;
Sorting.MergeSortRecursive(arrToMergeSortRecursive, left, right);
Console.WriteLine("MergeSortRecursive: ");
foreach (var item in arrToMergeSortRecursive) {
    Console.Write(item + " ");
} */

/* int[] arrToMergeSortIterative = {240,60,32,640,28,73,3,1,17};
Sorting.MergeSortIterative(arrToMergeSortIterative);
Console.Write("MergeSortIterative: ");
foreach (var item in arrToMergeSortIterative) {
    Console.Write(item + " ");
} */

/* int[] arrToQuickSort = {240,60,32,640,28,73,3,1,17};
int left = 0;
int right = arrToQuickSort.Length;
Sorting.QuickSort(arrToQuickSort, left, right);
Console.Write("QuickSort: ");
foreach (var item in arrToQuickSort) {
    Console.Write(item + " ");
} */

/**
    STRUCTURES


 */

Structures.List<int> list = new(1);
list.AddLast(2);
list.AddLast(3);
list.AddLast(4);
list.AddLast(5);

list.PrintList();