using System.Collections.Generic;
using UnityEngine;
using System;

namespace Nodes.Graph.Weighted
{
    public class WeightedNode : MonoBehaviour,
        IWeightedNode<WeightedNode, Edge>,
        IHighlightNode
    {
        public MeshRenderer renderer;
        public Edge[] edges = Array.Empty<Edge>();

        public IEnumerable<Edge> Edges => edges;

        private void Awake()
        {
            renderer.material = new Material(renderer.material);
        }

        public void SetHighlighted(bool value)
        {
            renderer.material.color = value ? Color.green : Color.white;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            foreach (var n in edges)
            {
                if (n == null)
                    continue;
                Gizmos.DrawLine(n.transform.position, transform.position);
            }
            Gizmos.color = Color.white;
        }
    }
}