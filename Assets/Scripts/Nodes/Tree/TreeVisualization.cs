using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using UnityEngine;
using UnityEngine.Assertions;

namespace Nodes.Tree
{
    public class TreeVisualization : MonoBehaviour
    {
        public PathVisualizer Visualizer;
        public TreeNode Root;
        
        [Button]
        private void PreOrder()
        {
            var nodes = new List<TreeNode>();
            TreeOps<TreeNode>.PreOrder(Root, nodes);
            
            var recNodes = new List<TreeNode>();
            TreeOps<TreeNode>.RecPreOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualizer.Visualize(nodes);
        }
        
        [Button]
        private void InOrder()
        {
            var nodes = new List<TreeNode>();
            TreeOps<TreeNode>.InOrder(Root, nodes);
            
            var recNodes = new List<TreeNode>();
            TreeOps<TreeNode>.RecInOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualizer.Visualize(nodes);
        }
        
        [Button]
        private void PostOrder()
        {
            var nodes = new List<TreeNode>();
            TreeOps<TreeNode>.PostOrder(Root, nodes);
            
            var recNodes = new List<TreeNode>();
            TreeOps<TreeNode>.RecPostOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualizer.Visualize(nodes);
        }
        
        [Button]
        private void Traverse()
        {
            var nodes = new List<TreeNode>();
            TreeOps<TreeNode>.Traverse(Root, nodes);
            Visualizer.Visualize(nodes);
        }
    }
}