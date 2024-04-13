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
    (1)LinkedList
        Methods:
            1.AddLast()
            2.GetNode()
            3.AddAfterNode()
            4.AddBeforeNode()
            5.DeleteFirstNode()
            6.DeleteLastNode()
            7.DeleteNode()
            8.PrintList()
            9.Clear()
            10.Count()

    (2)Stack
        Methods:
            1.Count()
            2.IsEmpty()
            3.Push()
            4.Pop()
            5.Clear()
            6.PrintStack()

    (3)Queue
        Methods:
            1.AddItem()
            2.DeleteItem()
            3.IsEmpty()
            4.Clear()
            5.PrintQueue()
 */

/* Structures.LinkedList<int, int> list = new();
list.AddFirst(0, 0);
list.AddLast(1, 10);
list.AddLast(2, 20);
list.AddLast(3, 30);
list.AddLast(4, 40);
list.AddLast(5, 50);
list.PrintList();
//Get element by index
Console.WriteLine("Element by index: " + list.GetNodeByIndex(2).ToString());
// Console.WriteLine("Element by index: " + list.GetNodeByIndex(10).ToString());

//Get Element by keys
Console.WriteLine("Element by key: " + list.GetNodeByKey(1).ToString());
Console.WriteLine("Element by key: " + list.GetNodeByKey(2).ToString());
Console.WriteLine("Element by key: " + list.GetNodeByKey(5).ToString());
Console.WriteLine("Element by key: " + list.GetNodeByKey(4).ToString());
Console.WriteLine("Add new item after some mode: ");
list.AddAfterNode(2, 8, 80);
list.AddAfterNode(3, 9, 90);
list.PrintList();
Console.WriteLine("Add new item before some node: ");
list.AddBeforeNode(3, 6, 60);
list.AddBeforeNode(5, 7, 70);
list.PrintList();
Console.WriteLine("Delete first node: ");
list.DeleteFirstNode();
list.PrintList();
Console.WriteLine("Delete last node: ");
list.DeleteLastNode();
list.PrintList();
Console.WriteLine("Count of list: ");
Console.WriteLine("Count: " + list.Count());
Console.WriteLine("Delete node by key: ");
list.DeleteNode(9);
list.DeleteNode(6);
list.DeleteNode(3);
list.DeleteNode(7);
list.DeleteNode(2);
list.PrintList(); */

/* Console.WriteLine("List with Persons:");
Structures.LinkedList<int, string> listPersons = new();
listPersons.AddLast(1, "Yura");
listPersons.AddLast(2, "Zhenya");
listPersons.AddLast(3, "Anton");
listPersons.AddLast(4, "ton");
listPersons.PrintList();
listPersons.DeleteLastNode();
listPersons.DeleteLastNode();
listPersons.DeleteLastNode();
listPersons.DeleteLastNode();
Console.WriteLine("Count: " + listPersons.Count());
Console.WriteLine("List of presons after clear: ");
listPersons.Clear();
listPersons.PrintList(); */

//STACK
/* Structures.Stack<int, int> stack = new();
stack.Push(1, 10);
stack.Push(2, 20);
stack.Push(3, 30);
stack.Push(4, 40);
stack.PrintStack();
Console.WriteLine("Pop stack: ");
stack.Pop();
stack.Pop();
stack.PrintStack();
stack.Pop();
stack.Pop(); */

//QUEUE
/* Structures.Queue<int, int> queue = new();
queue.AddItem(1, 10);
queue.AddItem(2, 20);
queue.AddItem(3, 30);
queue.AddItem(4, 40);
queue.PrintQueue();
Console.WriteLine("Delete items: ");
queue.DeleteItem();
queue.DeleteItem();
queue.PrintQueue();
queue.AddItem(5, 50);
Console.WriteLine("Add new item: ");
queue.PrintQueue();
queue.DeleteItem();
Console.WriteLine("After deleting: ");
queue.PrintQueue();
Console.WriteLine("Queue is empty: " + queue.IsEmpty());
Console.WriteLine("After clearing: ");
queue.Clear();
queue.PrintQueue(); */

//Set


/* //Graph
Graphs.Graph graph = new();
// Создаем вершины
Graphs.Vertex A = new Graphs.Vertex("A");
Graphs.Vertex B = new Graphs.Vertex("B");
Graphs.Vertex C = new Graphs.Vertex("C");
// Добавляем вершины в граф
graph.allVertexs.Add(A);
graph.allVertexs.Add(B);
graph.allVertexs.Add(C);
// Добавляем ребра
graph.AddEdge(A, B, 5); // Ребро от вершины A к вершине B с расстоянием 5
graph.AddEdge(A, C, 3); // Ребро от вершины A к вершине C с расстоянием 3
graph.AddEdge(B, C, 2); // Ребро от вершины B к вершине C с расстоянием 2

graph.PrintAdjacencyList(graph); */