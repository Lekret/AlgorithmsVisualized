using System.Collections.Generic;
using UnityEngine;

namespace Nodes.Graph
{
    public interface INode<out T>
    {
        IEnumerable<T> Nodes { get; }
    }
    
    public interface IPositionNode
    {
        Vector2 Position { get; }
    }
}