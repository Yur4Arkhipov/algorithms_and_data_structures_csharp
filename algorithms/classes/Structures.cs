using System.Xml;

class Structures {
    public class Node<T>(T data) {
        public T Data { get; } = data;
        public Node<T> Next { get; set; } 
    }

    public class List<T>(T data) {
        public Node<T> Head = new(data);

        public void AddLast(T data) {
            Node<T> current = Head;
            while (current.Next != null) {
                current = current.Next;
            }
            current.Next = new Node<T>(data);
            
        }

        public void PrintList() {
            Node<T> current = Head;
            while (current != null) {
                Console.Write(current.Data + " ");

                current = current.Next;
            }
        }
    } 
}