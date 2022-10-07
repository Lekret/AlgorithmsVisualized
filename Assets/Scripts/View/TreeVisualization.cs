using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using Logic;
using UnityEngine;
using UnityEngine.Assertions;

namespace View
{
    public class TreeVisualization : MonoBehaviour
    {
        public int HighlightDelay;
        public TreeNodeView Root;

        private Coroutine _visualizationRoutine;
        
        [Button]
        private void InOrder()
        {
            var nodes = new List<TreeNodeView>();
            TreeIteration<TreeNodeView>.InOrder(Root, nodes);
            
            var recNodes = new List<TreeNodeView>();
            TreeIteration<TreeNodeView>.RecInOrder(Root, recNodes);
            
            Assert.IsTrue(nodes.SequenceEqual(recNodes));
            Visualize(nodes);
        }

        private void Visualize(List<TreeNodeView> nodes)
        {
            foreach (var n in nodes)
            {
                n.SetHighlighted(false);
            }
            if (_visualizationRoutine != null)
                StopCoroutine(_visualizationRoutine);
            _visualizationRoutine = StartCoroutine(VisualizeRoutine(nodes));
        }

        private IEnumerator VisualizeRoutine(List<TreeNodeView> nodes)
        {
            foreach (var n in nodes)
            {
                yield return new WaitForSeconds(HighlightDelay);
                n.SetHighlighted(true);
            }
        }
    }
}