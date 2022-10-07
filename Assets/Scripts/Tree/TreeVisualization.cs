﻿using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using Nodes;
using UnityEngine;
using UnityEngine.Assertions;

namespace Tree
{
    public class TreeVisualization : MonoBehaviour
    {
        public IterationVisualizer Visualizer;
        public TreeNode Root;
        
        [Button]
        private void PreOrder()
        {
            var nodes = new List<TreeNode>();
            TreeIteration<TreeNode>.PreOrder(Root, nodes);
            
            var recNodes = new List<TreeNode>();
            TreeIteration<TreeNode>.RecPreOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualizer.Visualize(nodes);
        }
        
        [Button]
        private void InOrder()
        {
            var nodes = new List<TreeNode>();
            TreeIteration<TreeNode>.InOrder(Root, nodes);
            
            var recNodes = new List<TreeNode>();
            TreeIteration<TreeNode>.RecInOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualizer.Visualize(nodes);
        }
        
        [Button]
        private void PostOrder()
        {
            var nodes = new List<TreeNode>();
            TreeIteration<TreeNode>.PostOrder(Root, nodes);
            
            var recNodes = new List<TreeNode>();
            TreeIteration<TreeNode>.RecPostOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualizer.Visualize(nodes);
        }
        
        [Button]
        private void Traverse()
        {
            var nodes = new List<TreeNode>();
            TreeIteration<TreeNode>.Traverse(Root, nodes);
            Visualizer.Visualize(nodes);
        }
    }
}