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

    public interface IEdge<TNode, TEdge> 
        where TNode : IWeightedNode<TNode, TEdge> 
        where TEdge : IEdge<TNode, TEdge>
    {
        int Weight { get; }
        TNode From { get; }
        TNode To { get; }
    }

    public interface IWeightedNode<TNode, TEdge> 
        where TNode : IWeightedNode<TNode, TEdge> 
        where TEdge : IEdge<TNode, TEdge>
    {
        IEnumerable<TEdge> Edges { get; }
    }
}