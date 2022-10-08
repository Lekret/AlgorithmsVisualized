using System;
using UnityEditor;
using UnityEngine;

namespace Nodes.Graph.Weighted
{
    public class Edge : MonoBehaviour, IEdge<WeightedNode, Edge>
    {
        public int weight;
        public WeightedNode from;
        public WeightedNode to;

        public int Weight => weight;
        public WeightedNode From => from;
        public WeightedNode To => to;

        private void OnDrawGizmos()
        {
            if (from && to)
            {
                var fromPos = from.transform.position;
                var toPos = to.transform.position;
                
                Handles.color = Color.red;
                Handles.DrawLine(fromPos, toPos);
                
                Handles.color = Color.green;
                var edgePos = Vector3.Lerp(fromPos, toPos, 0.5f);
                transform.position = edgePos;
                Handles.Label(edgePos, weight.ToString());
                
                Handles.color = Color.white;
            }
        }
    }
}