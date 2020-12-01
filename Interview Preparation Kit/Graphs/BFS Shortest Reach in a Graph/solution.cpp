#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <queue>

using namespace std;

class Graph {
    private:
        const int DEFAULT_WEIGHT = 6;

        int numberOfNodes;
        int** adjacencyMatrix;
        
        vector<int> getAdjancents(int node) {
            vector<int> adjs;
            int nodeIndex = node - 1;
            for(int adjIndex = 0; adjIndex < numberOfNodes; adjIndex++) {
                if(adjacencyMatrix[nodeIndex][adjIndex] > 0) {
                    adjs.push_back(adjIndex + 1);
                }
            }
            return adjs;
        }

        int distance(int u, int v) {
            return adjacencyMatrix[u - 1][v - 1];
        }

    public:
        Graph(int n) {
            numberOfNodes = n;
            adjacencyMatrix = new int*[n];
            for(int i = 0; i < n; i++) {
                adjacencyMatrix[i] = new int[n];
                for(int j = 0; j < n; j++) {
                    if(i == j) {
                        adjacencyMatrix[i][j] = 0;
                    } else {
                        adjacencyMatrix[i][j] = -1;
                    }
                }
            }
        }
        
        ~Graph() {
            for(int i = 0; i < numberOfNodes; i++) {
                delete[] adjacencyMatrix[i];
            }
            delete[] adjacencyMatrix;
        }
        
        void add_edge(int u, int v) {
            int uIndex = u - 1;
            int vIndex = v - 1;
            adjacencyMatrix[uIndex][vIndex] = DEFAULT_WEIGHT;
            adjacencyMatrix[vIndex][uIndex] = DEFAULT_WEIGHT;
        }
    
        vector<int> shortest_reach(int start) {
            int startIndex = start - 1;
            bool* visited = new bool[numberOfNodes]; 
            for(int i = 0; i < numberOfNodes; i++) {
                visited[i] = false;
            }
            int* shortestDistances = new int[numberOfNodes];
            for(int i = 0; i < numberOfNodes; i++) {
                shortestDistances[i] = -1;
            }
            visited[startIndex] = 0;
            shortestDistances[startIndex] = 0;
            
            queue<int> nodesQueue;
            nodesQueue.push(start);

            while(nodesQueue.size()) {
                int currentNode = nodesQueue.front();
                nodesQueue.pop();
                vector<int> adjs = getAdjancents(currentNode);
                for(int i = 0; i < adjs.size(); i++) {
                    int adjNode = adjs[i];
                    int adjIndex = adjNode - 1;
                    if(!visited[adjIndex]) {
                        visited[adjIndex] = true;
                        nodesQueue.push(adjNode);   

                        shortestDistances[adjIndex] = shortestDistances[currentNode - 1] + distance(currentNode, adjNode);
                    }
                }
            }
            vector<int> distances;
            for(int i = 0; i < numberOfNodes; i++) {
                if(i != startIndex) {
                    distances.push_back(shortestDistances[i]);
                }
            }

            delete[] shortestDistances;
            return distances;
        }
    
};

int main() {
    int queries;
    cin >> queries;
        
    for (int t = 0; t < queries; t++) {
      
		int n, m;
        cin >> n;
        // Create a graph of size n where each edge weight is 6: 
        Graph graph(n);
        cin >> m;
        // read and set edges
        for (int i = 0; i < m; i++) {
            int u, v;
            cin >> u >> v;
            // add each edge to the graph
            graph.add_edge(u, v);
        }
		int startId;
        cin >> startId;
        // Find shortest reach from node s
        vector<int> distances = graph.shortest_reach(startId);

        for (int i = 0; i < distances.size(); i++) {
            cout << distances[i] << " ";
        }
        cout << endl;
    }
    
    return 0;
}