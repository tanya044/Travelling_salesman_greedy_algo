
private class GreedyRoute
        {
publicGreedyRoute(City[] list) {
Cities = list; visited = new bool[Cities.Length];
for (int i = 0; i <visited.Length; i++)
visited[i] = false;
r = new Random(); startIndex = r.Next() % Cities.Length;
numVisited = 1;
route = new ArrayList();
}
public void SetRoute()
            {
if (startIndex>= Cities.Length) startIndex = startIndex % Cities.Length;
                //start with a random city
City currentCity = Cities[startIndex]; route.Add(Cities[startIndex]);
visited[startIndex] = true;
                City nextDest = null;
while (numVisited<Cities.Length) {
doubleminCost = Double.PositiveInfinity; intcurrentIndex = -1;
for (int i = 0; i <Cities.Length; i++) {
if (!visited[i])
{
doubletempCost = currentCity.costToGetTo(Cities[i]);
if (tempCost<minCost)
minCost = tempCost;
nextDest = Cities[i];
currentIndex = i;
}
//break if a dead-end city is reached if (minCost == Double.PositiveInfinity)
break; else
                    {
route.Add(nextDest);
visited[currentIndex] = true;
currentCity = nextDest;
} }
//set the route to null if not completed
if (currentCity.costToGetTo(Cities[startIndex]) == Double.PositiveInfinity) route = null;
else if (route.Count<Cities.Length)
route = null;
}
publicArrayListGetRoute()
            {
return route;
            }
            //get ready to form a new route
public void Reset()
            {
startIndex = r.Next();
route = new ArrayList();
            }
private Random r;
private City[] Cities;
private bool[] visited;
privateintstartIndex;
privateintnumVisited;
privateArrayList route;
}
