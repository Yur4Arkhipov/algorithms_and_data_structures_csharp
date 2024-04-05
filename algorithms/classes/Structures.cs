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
            current.Next = new Node<K, T>(key, data);
        }

        public Node<K, T> GetNode(K key) {
            Node<K, T> current = Head;
            while (current.Key.CompareTo(key) != 0) {
                current = current.Next;
            }
        
            return current;
        }

        public void AddAfterNode(K key, T data, K newKey, T newData) {
            Node<K, T> current = Head;
            while (current.Key.CompareTo(key) != 0) {
                current = current.Next;
            }
            Node<K, T> temp = current;
            temp.Next = current.Next;
            current.Next = temp;
        }

        // public void DeleteFirstNode() TODO();
/*         public void DeleteLastNode(K key) {
            Node<K, T> current = Head;
            while (current.Key != null) {
                current = current.Next;
            }
            current = current.Prev;
            current.Next = null;
        } */
/*         public void DeleteNode(K key) {
            Node<K, T> current = Head;
            while (current.Key.CompareTo(key) != 0) {
                current = current.Next;
            }
            Node<K, T> temp = current.Prev;
            temp.Next =  
            current.Next = null;
            current.Prev = null;

        } */
        
        public void PrintList() {
            Node<K, T> current = Head;
            while (current != null) {
                Console.WriteLine("Key: " + current.Key + " Data: " + current.Data + " ");

                current = current.Next;
            }
        }
    } 
}