Traveling Salesman Problem (TSP) Implementation

Travelling Salesman Problem (TSP): Given a set of cities and distance between every pair of cities, the problem is to find the shortest possible route that visits every city exactly once and returns back to the starting point.
Note the difference between Hamiltonian Cycle and TSP. The Hamiltoninan cycle problem is to find if there exist a tour that visits every city exactly once. Here we know that Hamiltonian Tour exists (because the graph is complete) and in fact many such tours exist, the problem is to find a minimum weight Hamiltonian Cycle.
For example, consider the graph shown in figure on right side. A TSP tour in the graph is 1-2-4-3-1. The cost of the tour is 10+25+30+15 which is 80.

The problem is a famous NP hard problem. There is no polynomial time know solution for this problem.

In this post, implementation of simple solution is discussed.
Algo:
Consider city 1 as the starting and ending point. Since route is cyclic, we can consider any point as starting point.
Generate all (n-1)! permutations of cities.
Calculate cost of every permutation and keep track of minimum cost permutation.
Return the permutation with minimum cost.

