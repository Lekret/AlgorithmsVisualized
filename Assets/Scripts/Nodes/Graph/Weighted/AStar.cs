using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nodes.Graph.Weighted
{
    // TODO
    public static class AStar
    {
        /*
        private static IEnumerable<T> ReconstructPath<T>(Dictionary<T, T> cameFrom, T current) where T : IWeightedNode<,>
        {
            var totalPath = new List<T>()
            {
                current
            };
    
            foreach (var cell in cameFrom.Keys)
            {
                totalPath.Insert(0, cameFrom[cell]);
            }
    
            return totalPath;
        }
    
        public static IEnumerable<T> CalcPath<T>(T start, T goal, Func<T, float> h)
        {
            var openSet = new HashSet<T> {start};
            var cameFrom = new Dictionary<T, T>();
    
            var gScore = new Dictionary<T, float> {[start] = 0};
            var fScore = new Dictionary<T, float> {[start] = h(start)};
    
            while (openSet.Count > 0)
            {
                var current = openSet.OrderBy(c => fScore[c]).First();
                if (current.Equals(goal))
                    return ReconstructPath(cameFrom, current);
    
                openSet.Remove(current);
    
                foreach (var neighbor in current.Nodes)
                {
                    var experimentalScore = gScore[current] + Vector2.Distance(current.Position, neighbor.Position);
                    if (experimentalScore < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = experimentalScore;
                        fScore[neighbor] = experimentalScore + h(neighbor);
                        openSet.Add(neighbor);
                    }
                }
            }
    
            return Array.Empty<T>();
            return null;
        }
        */
    }
}