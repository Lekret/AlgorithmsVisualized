using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace Nodes.Graph.Weighted
{
    public class WeightedGraphVisualization : MonoBehaviour
    {
        public WeightedNode Start;
        public WeightedNode Goal;
        public PathVisualizer Visualizer;
        
        [Button]
        private void FindPath()
        { 
            var nodes = new List<WeightedNode>();
            GraphOps.DijkstraSearch<WeightedNode, Edge>(Start, Goal, nodes);
            Visualizer.Visualize(nodes);
        }
    }
}