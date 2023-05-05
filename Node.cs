namespace DataStructures.Collections.Graphs;

public class Node
{
    private int _id;
    private List<Edge> _edges;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public List<Edge> Edges
    {
        get { return this._edges; }
        set { this._edges = value; }
    }

    public Node(int id)
    {
        this._id = id;
        this._edges = new List<Edge>();
    }
}