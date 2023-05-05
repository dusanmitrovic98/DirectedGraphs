namespace DataStructures.Collections.Graphs;

public class Edge
{
    private int _startNode;
    private int _endNode;

    public int StartNode
    {
        get { return _startNode; }
        set { _startNode = value; }
    }

    public int EndNode
    {
        get { return _endNode; }
        set { _endNode = value; }
    }

    public Edge(int startNode, int endNode)
    {

    }
}