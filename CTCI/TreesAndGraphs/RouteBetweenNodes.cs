using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	public enum State
	{
		Unvisited,
		Visiting,
		Visited
	};

	class RouteBetweenNodes
	{
		
		public static bool search(int[][] graph, int start, int end)
		{
			if (start == end)
				return true;

			State[] nodeState = new State[graph.Length];
			Queue<int> queue = new Queue<int>();

			for(int i = 0; i < nodeState.Length; i++)
			{
				nodeState[i] = State.Unvisited;
			}

			nodeState[start] = State.Visiting;
			queue.Enqueue(start);

			int node;
			while(queue.Count > 0)
			{
				node = queue.Dequeue();
				for (int j = 0; j < graph[0].Length; j++)
					{
						if(graph[start][j] == 1)
						{
							if (nodeState[j] == State.Unvisited)
							{
								if (j == end)
								{
									return true;
								}
								else
								{
									nodeState[j] = State.Visiting;
									queue.Enqueue(j);
								}
							}
						}
					}
				nodeState[node] = State.Visited;
			}
			return false;
		}
	}
}
