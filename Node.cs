namespace DataStructures.Collections.Graphs;

public class Node
{
    private static int _id;
    private List<Edge> _edges;

    public int Id
    {
        get { return _id; }
    }

    public List<Edge> Edges
    {
        get { return this._edges; }
        set { this._edges = value; }
    }

    public Node()
    {
        this._edges = new List<Edge>();
    }
}