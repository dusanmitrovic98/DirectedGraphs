namespace DataStructures.Collections.Graphs;

public class DirectedGraph
{
    private Dictionary<int, Node> _nodes;

    public Dictionary<int, Node> Nodes
    {
        get { return this._nodes; }
        set { this._nodes = value; }
    }

    public DirectedGraph()
    {
        this._nodes = new Dictionary<int, Node>();
    }

    public void AddNode(int id)
    {
        if (!Nodes.ContainsKey(id))
        {
            Nodes[id] = new Node(id);
        }
    }

    public void AddEdge(int startNodeId, int endNodeId, int weight = 0)
    {
        if (Nodes.ContainsKey(startNodeId) && Nodes.ContainsKey(endNodeId))
        {
            Nodes[startNodeId].Edges.Add(new Edge(startNodeId, endNodeId));
        }
    }

    public int GetNumNodes()
    {
        return this._nodes.Count;
    }
}