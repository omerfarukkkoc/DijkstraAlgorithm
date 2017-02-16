
using System;
using System.Collections.Generic;

namespace Dijkstra
{
    public class Dijkstra
    {
        public double[] dist { get; private set; }
        public int[] path { get; private set; }
        
        private List<int> queue = new List<int>();
        
        private void Initialize(int s, int len)
        {
            dist = new double[len];
            path = new int[len];

            for (int i = 0; i < len; i++)
            {
                //dist[i] = Convert.ToDouble("Sonsuz");
                dist[i] = Double.PositiveInfinity;

                queue.Add(i);
            }

            dist[s] = 0;
            path[s] = -1;
        }

        private int GetNextVertex()
        {
            double min = Double.PositiveInfinity;
            int Vertex = -1;

            foreach (int j in queue)
            {
                if (dist[j] <= min)
                {
                    min = dist[j];
                    Vertex = j;
                }
            }

            queue.Remove(Vertex);

            return Vertex;

        }

        public Dijkstra(double[,] G, int s)
        {
            if (G.GetLength(0) < 1 || G.GetLength(0) != G.GetLength(1))
            {
            }

            int len = G.GetLength(0);

            Initialize(s, len);

            while (queue.Count > 0)
            {
                int u = GetNextVertex();

                for (int v = 0; v < len; v++)
                {
                    if (G[u, v] < 0)
                    {
                    }
                    
                    if (G[u, v] > 0)
                    {
                        if (dist[v] > dist[u] + G[u, v])
                        {
                            dist[v] = dist[u] + G[u, v];
                            path[v] = u;
                        }
                    }
                }
            }
        }
    }
}
