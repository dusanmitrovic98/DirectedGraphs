namespace DataStructures.Collections.Graphs;

public class DirectedGraph
{
    private Dictionary<int, Node> _nodes;

    public Dictionary<int, Node> Nodes
    {
        get { return this._nodes; }
        set { this._nodes = value; }
    }
}