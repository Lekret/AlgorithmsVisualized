using System.Collections.Generic;
using EasyButtons;
using Nodes;
using UnityEngine;

namespace Graph
{
    public class GraphVisualization : MonoBehaviour
    {
        public IterationVisualizer Visualizer;
        public GraphNode Root;
        
        [Button]
        private void Traverse()
        {
            var nodes = new HashSet<GraphNode>();
            GraphIteration<GraphNode>.Traverse(Root, nodes);
            Visualizer.Visualize(nodes);
        }
    }
}