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

    public class LinkedList<K, T>(K key, T data) where K: IComparable where T: IComparable  {
        // создание первого элемента
        public Node<K, T> Head = new Node<K, T>(key, data);

        public void AddLast(K key, T data) {
            Node<K, T> current = Head;
            while (current.Next != null) {
                current = current.Next;
            }
            Node<K, T> newItem = new Node<K, T>(key, data);
            current.Next = newItem;
            newItem.Prev = current;
        }

        public Node<K, T> GetNode(K key) {
            Node<K, T> current = Head;
            while (current.Key.CompareTo(key) != 0) {
                current = current.Next;
            }
        
            return current;
        }

        public void AddAfterNode(K afterKey, K newKey, T newData) {
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
            
        }

        public void AddBeforeNode(K keyBefore, K newKey, T newData) {
            Node<K, T> current = Head;
            while (current.Key.CompareTo(keyBefore) != 0) {
                current = current.Next;
            }
            Node<K, T> newItem = new Node<K, T>(newKey, newData);
            newItem.Next = current;
            newItem.Prev = current.Prev;
            current.Prev.Next = newItem;
            current.Prev = newItem;
        }
        public void DeleteFirstNode() {
            Head = Head.Next;
            Head.Prev = null;
 
        }

        public void DeleteLastNode() {
            if (Head == null) {
                return; // Если список пуст, ничего не делаем
            }
            if (Head.Next == null) {
                // Если в списке только один элемент, делаем головной узел null
                Head = null;
                return;
            }
            
            Node<K, T> current = Head;
            while (current.Next != null) {
                current = current.Next;
            }
            current = current.Prev;
            current.Next = null;
        }
        public void DeleteNode(K key) {
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
        }

        public int Count() {
            Node<K, T> current = Head;
            int count = 0;
            while(current != null) {
                current = current.Next;
                count++;
            }

            return count;
        }
    } 

    public class Stack<K, T>(K key, T data) where K: IComparable where T: IComparable {
        public Node<K, T> Top = new Node<K, T>(key, data);
        
        public int Count() {
            Node<K, T> current = Top;
            int count = 0;
            while (current != null) {
                count++;
            }

            return count;
        }

        public bool IsEmpty() {    
            return Count() == 0;
        }

        public void Push(K key, T data) {
            Node<K, T> newItem = new Node<K, T>(key, data);
            newItem.Next = Top; // Новый элемент становится вершиной стека
            if (Top != null)
                Top.Prev = newItem;
            Top = newItem; // Обновление вершины стека
        }

        public void Pop() {
            if (Top == null) {
                throw new InvalidOperationException("The stack is empty");
            }
            Node<K, T> removedItem = Top;
            Top = Top.Next;
            if (Top != null)
                Top.Prev = null;
        }

        public void Clear() {
            while (Top != null) {
                Pop(); // Последовательное удаление элементов из стека
            }
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

        public void PrintQueue() {
            Node<K, T> current = head;
            while (current != null) {
                Console.WriteLine("Key: " + current.Key + " Data: " + current.Data + " ");

                current = current.Next;
            }
        }
    }
}