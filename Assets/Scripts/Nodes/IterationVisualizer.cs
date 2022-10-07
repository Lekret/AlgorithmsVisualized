using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nodes
{
    public class IterationVisualizer : MonoBehaviour
    {
        public float HighlightDelay;
        private Coroutine _visualizationRoutine;

        public void Visualize(IEnumerable<IHighlightNode> nodes)
        {
            foreach (var n in nodes)
            {
                n.SetHighlighted(false);
            }
            if (_visualizationRoutine != null)
                StopCoroutine(_visualizationRoutine);
            _visualizationRoutine = StartCoroutine(VisualizeRoutine(nodes));
        }

        private IEnumerator VisualizeRoutine(IEnumerable<IHighlightNode> nodes)
        {
            foreach (var n in nodes)
            {
                yield return new WaitForSeconds(HighlightDelay);
                n.SetHighlighted(true);
            }
        }
    }
}