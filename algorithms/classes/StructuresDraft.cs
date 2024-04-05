/* class DoubleNode<K, T> {
    private DoubleNode<K, T> next;  // Ссылка на следующий узел
    private DoubleNode<K, T> prev; // Ссылка на предыдущий узел
    private readonly T value;  // значение
    private K key;  // ключ
    public DoubleNode<K, T> Next { set { next = value; } get { return next; } } 
    public DoubleNode<K, T> Prev { set { prev = value; } get { return prev; } }
    public K Key { set { key = value; } get { return key; } }
    public T Value { set { this.Value = value; } get { return this.value; } }
    
    // Конструкторы
    public DoubleNode(K key,T value) {
        this.key = key;
        this.value = value;
        next = null;
        prev = null;
    }
    public DoubleNode(K key, T value, DoubleNode<K,T> previous) {
        this.key = key;
        this.value = value;
        next = null;
        prev = previous;
    }
    public override string ToString() {
        return string.Format("(key={0},Value={1})", Key, Value);
    }
}

class DoubleLinkedList<K, T> where K : IComparable where T : IComparable {
    private DoubleNode<K, T> first = null; // Ссылка на первый узел
    private DoubleNode<K, T> last = null; // Ссылка на последний узел
    private readonly int position = 0;
    public DoubleNode<K, T> First { get { return first; } }
    public DoubleNode<K, T> Last { get { return last; } }
    public DoubleLinkedList() {
        first = null;
        last = null;
        position = 0;
    }
    public int AddEnd(K key, T value) {
        DoubleNode<K, T> current = 
        
        if (this.last != null) {
            DoubleNode<K, T> temp = new DoubleNode<K, T>(key, value, this.last);
            this.last.Next = temp;
            this.last = temp;
        } else {
            DoubleNode<K, T> temp = new DoubleNode<K, T>(key,value, null);
            this.first = temp;
            this.last = temp;
        }
        return this.position++;
    }
    public void Clear() {
        this.first = null;
        this.last = null;
        this.position = 0;
    }
//

//
}


//получение узла по номеру */