using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace Nodes.Graph
{
    public class GraphVisualization : MonoBehaviour
    {
        public PathVisualizer Visualizer;
        public Node Root;
        
        [Button]
        private void Traverse()
        {
            var nodes = new HashSet<Node>();
            GraphOps.Traverse(Root, nodes);
            Visualizer.Visualize(nodes);
        }
    }
}