public class Graphs {
   public enum COLORS_VERTEX { WHITE, GREY, BLACK}

    public class Edge {
        public Vertex BeginPoint; // Начальная вершина
        public Vertex EndPoint;  // Конечная вершина

        public double distance; // Длина ребра
        
        // Конструктор
        public Edge(Vertex begin, Vertex end, double distance)
        {
            this.BeginPoint = begin;
            this.EndPoint = end;
            this.distance = distance;
        }
        public override string ToString()
        {
            string sout = "";
            sout = "{"+BeginPoint.label + "  " + EndPoint.label + " Distance: " + distance.ToString()+"}";
            return sout;
        }
    }

   public class Vertex {
        private static int IDV = 0; 
        private int ID;
        public string label; // Метка (имя вершины)
        private List<Edge> edges; // Список ребер, связанных с вершиной
        public double sumDistance = 0; // Сумма растояний
        public COLORS_VERTEX color; // Цвет вершины
        public Vertex previousVertex; // Ссылка на предшественника
        public bool visited;

        //конструктор
        public Vertex(string label) {
            this.label = label;
            IDV++;
            edges = new List<Edge>();
            sumDistance = Double.MaxValue;
            color = COLORS_VERTEX.WHITE;
            previousVertex = null;
            ID = IDV;
            this.visited = false;
        }

        public int GetID() { return ID; }
        // Получение списка ребер
        public List<Edge> GetEdges() { return edges; }
        public override string ToString() {
            string sout = "";
            sout += label;
            sout = sout + "  ID="+ID.ToString();
            return sout ;
        }
        // Просмотр ребер, связанных с вершиной
        public void ViewEdges() {
            Console.Write("Edges for {0}", this);
            foreach(Edge curedge in edges)
                Console.Write("  {0}", curedge);
            Console.WriteLine();
        }
        // Добавление ребра
        public bool AddEdge(Edge edge) {
            if (edge.BeginPoint != this) return false;
            for (int i = 0; i < edges.Count; i++)
            {
                Edge CurEdge = edges[i];
                if (edge.EndPoint.Equals(CurEdge.EndPoint)) return false;
            }
            edges.Add(edge);
            return true;
        }        
    } 

   public class Graph {
        public List<Vertex> allVertexs; // Список всех вершин
        public List<Edge> allEdges; // Список всех ребер
        //конструктор
        public Graph() {
            allVertexs = new List<Vertex>();
            allEdges = new List<Edge>();
        }

        //добавление ребра
        public bool AddEdge(Vertex v1, Vertex v2, double dist) {
            if (!allVertexs.Contains(v1)) return false;
            if (!allVertexs.Contains(v2)) return false;
            foreach (Edge cure in v1.GetEdges()) {
                if (cure.EndPoint.GetID() == v2.GetID()) return false;
            }
            
            Edge ev1v2 = new Edge(v1, v2, dist);
            v1.GetEdges().Add(ev1v2); allEdges.Add(ev1v2);
            return true;
        }

        public void PrintAdjacencyList(Graph graph) {
            Console.WriteLine("Adjacency list of Graph: ");
            foreach (var vertex in graph.allVertexs) {
                Console.Write($"Vertex {vertex.label}: ");
                foreach (var edge in vertex.GetEdges()) {
                    Console.Write($"{edge.EndPoint.label}({edge.distance}) ");
                }
                Console.WriteLine();
            }
        }


        // Поиск в ширину
       /*  public void BFS(Vertex s){
            Queue<Vertex> Q = new Queue<Vertex>(); // Очередь вершин
            // Инициализация
            foreach(Vertex cv in allVertexs) {
                cv.sumDistance = double.MaxValue;
                cv.previousVertex = null;
            }
            s.color = COLORS_VERTEX.GREY;       
            s.sumDistance = 0;
            Q.Enqueue (s);
            Vertex u, v;
            Edge tr;
            List<Edge> edges_u;
            // Основной цикл
            while (Q.Count > 0)
            {               
                u = Q.Dequeue();

            } 

        } */
    }
}