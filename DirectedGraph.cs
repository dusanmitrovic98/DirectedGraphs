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
        if (!this._nodes.ContainsKey(id))
        {
            this._nodes[id] = new Node(id);
        }
    }

    public void AddEdge(int startNodeId, int endNodeId, int weight = 0)
    {
        if (this._nodes.ContainsKey(startNodeId) && this._nodes.ContainsKey(endNodeId))
        {
            this._nodes[startNodeId].Edges.Add(new Edge(startNodeId, endNodeId));
        }
    }

    public int Count()
    {
        return this._nodes.Count;
    }

    public List<int> GetNeighbors(int nodeId)
    {
        if (this._nodes.ContainsKey(nodeId))
        {
            return this._nodes[nodeId].Edges.Select(edge => edge.EndNode).ToList();
        }

        return new List<int>();
    }
}