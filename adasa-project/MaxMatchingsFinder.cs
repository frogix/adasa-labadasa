using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaximalMatchingsTask
{
    public class MaxMatchingsFinder
    {

        /// <summary>
        /// Method that finds the maximum mathics for given bipartite graph
        /// </summary>
        /// <param name="cardinality">
        /// Number of vertices in each part of bipartite graph (should be equal)
        /// </param>
        /// <param name="connections">
        /// Adjacency matrix for the given bipartite graph where elements are boolean values (false - not connected, true - connected).
        /// Lines represent vertices of the first part, and columns represent vertices of the second part
        /// </param>
        /// <param name="matchingSearchHistory">
        /// Out parameter that contains current state of maximal mathcing of every iteration of searching algorithm
        /// </param>
        /// <returns>
        /// Array of ints where
        ///     index (int) represents vertex of the second part and
        ///     value (int) is index of matching vertex of the first part
        /// </returns>
        public static int[] GetMaxMathings(int cardinality, bool[,] connections, out List<int[]> matchingSearchHistory)
        {
            if (cardinality <= 0)
                throw new ArgumentOutOfRangeException(nameof(cardinality) + " should be a positive integer");
            if (connections.GetLength(0) != cardinality || connections.GetLength(1) != cardinality)
                throw new ArgumentException(nameof(connections) + " should be an NxN matrix where N equals given cardinality");


            // Get a starting matchings set
            // by connecting each vertex from one part to the first available vertex (or none) from the other part

            // currentMatchings - array of ints where key represents vertex from the SECOND part and value represents its matching vertex from the FRIST part
            int[] currentMatchings = new int[cardinality];
            for (int i = 0; i < cardinality; ++i)
                currentMatchings[i] = -1;

            bool[] firstPartVerticesTaken = new bool[cardinality];
            bool[] secondPartVerticesTaken = new bool[cardinality];
            for (int i = 0; i < cardinality; ++i)
            {

                bool connected = false;
                for (int j = 0; j < cardinality && !connected; ++j)
                {
                    if (!connections[i, j] || secondPartVerticesTaken[j]) continue;

                    currentMatchings[j] = i;
                    firstPartVerticesTaken[i] = true;
                    secondPartVerticesTaken[j] = true;
                    connected = true;
                }
            }

            // matchingSearchHistory contains currentMatchings of every iteration of searching algorithm
            matchingSearchHistory = new List<int[]>();
            matchingSearchHistory.Add(currentMatchings);
            // Expand current matchings to the maximum 
            // adding one new matching using augmenting path
            while (firstPartVerticesTaken.Any(c => !c))
            {
                // Nested method that finds augmenting path or null if no path was found
                int[] augmentingPath = FindAugmentingPath();
                // If augmenting path wasn't found
                if (augmentingPath == null)
                    return currentMatchings;

                // Else reverse found augmenting path

                // Mark first and last vertices as visited
                firstPartVerticesTaken[augmentingPath[0]] = true;
                secondPartVerticesTaken[augmentingPath[augmentingPath.Length - 1]] = true;

                // And change current matchings
                for (int i = 0; i < augmentingPath.Length; i += 2)
                {
                    currentMatchings[augmentingPath[i + 1]] = augmentingPath[i];
                }
                matchingSearchHistory.Add(currentMatchings);
            }

            return currentMatchings;



            // Method that finds augmenting path for current matchings
            int[] FindAugmentingPath()
            {
                // Create arrays for visited vertices
                bool[] firstPartVerticesVisited = new bool[cardinality];
                bool[] secondPartVerticesVisited = new bool[cardinality];
                // Create a stack for current path
                Stack<int> path = new Stack<int>();
                int current = -1; // Index of current first part vertex
                while (true)
                {
                    // If path is empty now
                    if (!path.Any())
                    {
                        try
                        {
                            // Take first vertex from first part to start from
                            current = firstPartVerticesTaken.Select((value, index) => index)
                                .First(index => !firstPartVerticesTaken[index] && !firstPartVerticesVisited[index]);
                            firstPartVerticesVisited[current] = true;
                            path.Push(current);
                        }
                        catch (InvalidOperationException)
                        {
                            // If none was found then current matchings set is the maximum
                            break;
                        }
                    }
                    else
                    {
                        current = path.Peek();
                        try
                        {
                            // Take first unvisited vertex from the second part that can be reached from current
                            int nextStep = secondPartVerticesTaken.Select((value, index) => index)
                                .First(index => !secondPartVerticesVisited[index] && connections[current, index]);

                            secondPartVerticesVisited[nextStep] = true;
                            path.Push(nextStep);
                            // If it's not in any pair, augmenting path found, return
                            if (!secondPartVerticesTaken[nextStep])
                                return path.Reverse().ToArray();

                            // Else take it's matching vertex from the first part
                            //TODO: reverse
                            int nextCurrent = currentMatchings[nextStep];
                            // If it hasn't been visited, it's going to be the next current
                            if (!firstPartVerticesVisited[nextCurrent])
                            {
                                path.Push(nextCurrent);
                                firstPartVerticesVisited[nextCurrent] = true;
                            }

                            // else look for another next step on the next iteration

                        }
                        // The case when next step to the second part of graph couldn't be taken
                        // because all vertices that could be reached from current have been already visited
                        catch (InvalidOperationException)
                        {
                            // Pop the last pair of vertices
                            path.Pop();
                            if (path.Any())
                                path.Pop();
                        }
                    }
                }


                return null;
            }
        }

    }
}
