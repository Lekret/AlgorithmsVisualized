using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nodes.Graph
{
    public class Node : MonoBehaviour, INode<Node>, IHighlightNode
    {
        public MeshRenderer renderer;
        public Node[] nodes = Array.Empty<Node>();

        public IEnumerable<Node> Nodes => nodes;
        
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
            foreach (var n in Nodes)
            {
                if (n == null)
                    continue;
                Gizmos.DrawLine(transform.position, n.transform.position);
            }
            Gizmos.color = Color.white;
        }
    }
}