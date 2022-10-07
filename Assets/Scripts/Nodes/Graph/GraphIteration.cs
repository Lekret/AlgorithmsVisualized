using System.Collections.Generic;

namespace Nodes.Graph
{
    public class GraphIteration<T> where T : IGraphNode<T>
    {
        public static void Traverse(T current, HashSet<T> result)
        {
            var queue = new Queue<T>();
            while (current != null)
            {
                result.Add(current);
                foreach (var n in current.Nodes)
                {
                    queue.Enqueue(n);
                }
                queue.TryDequeue(out current);
            }
        }
    }
}