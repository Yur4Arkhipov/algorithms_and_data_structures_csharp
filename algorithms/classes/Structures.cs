class Structures {
    public class Node<K, T>(K key, T data) {
        public T Data { get; } = data; // получение занчения
        public K Key { get { return key; } }  // получение ключа
        public Node<K, T> Next { get; set; } // след элемент
        public Node<K, T> Prev { get; set;} // предыдущий элемент
        public override string ToString() {
            return string.Format("(key={0},Value={1})", Key, Data);
        }
    }

    public class LinkedList<K, T> where K: IComparable where T: IComparable  {
        // создание первого элемента
        public Node<K, T> Head = null;
        public Node<K, T> Tail = null;
        int count = 0;

        public LinkedList() {
            Head = null;
            Tail = null;
            count = 0;
        }

        public void AddLast(K key, T data) {
            if (ContainsKey(key)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> newItem = new Node<K, T>(key, data);
            if (Tail != null) {
                Tail.Next = newItem;
                newItem.Prev = Tail;
            } else {
                Head = newItem;
            }
            Tail = newItem;
            count++;
        }

        public void AddFirst(K key, T data) {
            if (ContainsKey(key)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> newItem = new Node<K, T>(key, data);
            Node<K, T> temp = Head;
            newItem.Next = temp;
            Head = newItem;
            if (count == 0)
                Tail = Head;
            else
                temp.Prev = newItem;
            count++;
        }

        public Node<K, T> GetNodeByKey(K key) {
            if (!ContainsKey(key)) {
                throw new ArgumentException("Такого элемента нет");
            }
            Node<K, T> current = Head;
            while (current.Key.CompareTo(key) != 0) {
                current = current.Next;
            }
        
            return current;
        }

        public Node<K, T> GetNodeByIndex(int index) {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index is out of range.");
            
            Node<K, T> current = Head;
            for (int i = 0; i < index; i++) {
                current = current.Next;
            }
            return current;
        }

        public void AddAfterNode(K afterKey, K newKey, T newData) {
            if (ContainsKey(newKey)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> current = Head;
            while (current.Key.CompareTo(afterKey) != 0) {
                current = current.Next;
            }
            Node<K, T> newItem = new Node<K, T>(newKey, newData);
            newItem.Prev = current;
            newItem.Next = current.Next;
            current.Next = newItem;
            if(newItem.Next != null) {
                newItem.Next.Prev = newItem;
            }
            count++;
        }

        public void AddBeforeNode(K keyBefore, K newKey, T newData) {
            if (ContainsKey(newKey)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> current = Head;
            while (current.Key.CompareTo(keyBefore) != 0) {
                current = current.Next;
            }
            Node<K, T> newItem = new Node<K, T>(newKey, newData);
            newItem.Next = current;
            newItem.Prev = current.Prev;
            current.Prev.Next = newItem;
            current.Prev = newItem;
            count++;
        }
        public void DeleteFirstNode() {
            Head = Head.Next;
            Head.Prev = null;
            count--;
        }

        public void DeleteLastNode() {
            if (Head == null) {
                return; // Если список пуст, ничего не делаем
            }
            if (Head.Next == null) {
                // Если в списке только один элемент, делаем головной узел null
                Head = null;
                count--;
                return;
            }
            
            Node<K, T> current = Head;
            while (current.Next != null) {
                current = current.Next;
            }
            current = current.Prev;
            current.Next = null;

            count--;
        }
        public void DeleteNode(K key) {
            if (ContainsKey(key)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> current = Head;
            while (current.Key.CompareTo(key) != 0) {
                current = current.Next;
            }
            if (current.Prev != null && current.Next != null) {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
            } else if (current.Prev == null) {
                Head = Head.Next;
                Head.Prev = null;
            } else if(current.Next == null) {
                current.Prev.Next = null;
            }

            count--;
        }
        
        public void PrintList() {
            Node<K, T> current = Head;
            while (current != null) {
                Console.WriteLine("Key: " + current.Key + " Data: " + current.Data + " ");

                current = current.Next;
            }
        }
 
        public void Clear() {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(K key, T data) {
            Node<K, T> current = Head;
            while (current != null) {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public bool ContainsKey(K key) {
            Node<K, T> current = Head;
            while (current != null) {
                if (current.Key.Equals(key))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public int Count() {
            return count;
        }
    } 

    public class Stack<K, T> where K: IComparable where T: IComparable {
        public Node<K, T> Top = null;
        int count = 0;
        public Stack() {
            Top = null;
            count = 0;
        }
        
        public int Count() {
            return count;
        }

        public bool IsEmpty() {    
            return Count() == 0;
        }

        public void Push(K key, T data) {
            if (ContainsKey(key)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> newItem = new Node<K, T>(key, data);
            newItem.Next = Top; // Новый элемент становится вершиной стека
            if (Top != null)
                Top.Prev = newItem;
            Top = newItem; // Обновление вершины стека
            count++;
        }

        public void Pop() {
            if (Top == null) {
                throw new InvalidOperationException("The stack is empty");
            }
            Node<K, T> removedItem = Top;
            Top = Top.Next;
            if (Top != null)
                Top.Prev = null;
            
            count--;
        }

        public void Clear() {
            while (Top != null) {
                Pop(); // Последовательное удаление элементов из стека
            }
            count = 0;
        }

        public bool ContainsKey(K key) {
            Node<K, T> current = Top;
            while (current != null) {
                if (current.Key.Equals(key))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void PrintStack() {
            Node<K, T> current = Top;
            while (current != null) {
                Console.WriteLine("Key: " + current.Key + " Data: " + current.Data + " ");

                current = current.Next;
            }
        }
    }

    public class Queue<K, T>() where K: IComparable where T: IComparable {
        private Node<K, T> head;
        private Node<K, T> tail;

        public void AddItem(K key, T data) {
            if (ContainsKey(key)) {
                throw new ArgumentException("Такой элемент уже есть");
            }
            Node<K, T> newItem = new Node<K, T>(key, data);
            if (tail == null) {
                head = newItem;
                tail = newItem;
            } else {
                tail.Next = newItem;
                newItem.Prev = tail;
                tail = newItem;
            }
        }

        public Node<K, T> DeleteItem() {
            if (head == null) {
                return null;
            } else {
                Node<K, T> deletingItem = head;
                head = head.Next;
                if (head == null) {
                    tail = null;
                } else {
                    head.Prev = null; 
                }
                return deletingItem;
            }
        }

        public bool IsEmpty() {
            return head == null;
        }

        public void Clear() {
            head = null;
            tail = null;
        }

        public bool ContainsKey(K key) {
            Node<K, T> current = head;
            while (current != null) {
                if (current.Key.Equals(key))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void PrintQueue() {
            Node<K, T> current = head;
            while (current != null) {
                Console.WriteLine("Key: " + current.Key + " Data: " + current.Data + " ");

                current = current.Next;
            }
        }
    }
}