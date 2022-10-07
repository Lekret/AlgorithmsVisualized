using System.Collections.Generic;

namespace Nodes.Graph
{
    public interface IGraphNode<out T>
    {
        IEnumerable<T> Nodes { get; }
    }
}