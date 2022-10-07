using System.Collections.Generic;

namespace Graph
{
    public interface IGraphNode<out T>
    {
        IEnumerable<T> Nodes { get; }
    }
}