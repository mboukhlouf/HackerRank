#include <bits/stdc++.h>

using namespace std;

vector<string> split_string(string);

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

// Complete the bfs function below.
vector<int> bfs(int n, int m, vector<vector<int>> edges, int s) {
    Graph graph(n);
    for(int i = 0; i < edges.size(); i++) {
        graph.add_edge(edges[i][0], edges[i][1]);
    }
    vector<int> distances = graph.shortest_reach(s);
    return distances;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int q;
    cin >> q;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int q_itr = 0; q_itr < q; q_itr++) {
        string nm_temp;
        getline(cin, nm_temp);

        vector<string> nm = split_string(nm_temp);

        int n = stoi(nm[0]);

        int m = stoi(nm[1]);

        vector<vector<int>> edges(m);
        for (int i = 0; i < m; i++) {
            edges[i].resize(2);

            for (int j = 0; j < 2; j++) {
                cin >> edges[i][j];
            }

            cin.ignore(numeric_limits<streamsize>::max(), '\n');
        }

        int s;
        cin >> s;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        vector<int> result = bfs(n, m, edges, s);

        for (int i = 0; i < result.size(); i++) {
            fout << result[i];

            if (i != result.size() - 1) {
                fout << " ";
            }
        }

        fout << "\n";
    }

    fout.close();

    return 0;
}

vector<string> split_string(string input_string) {
    string::iterator new_end = unique(input_string.begin(), input_string.end(), [] (const char &x, const char &y) {
        return x == y and x == ' ';
    });

    input_string.erase(new_end, input_string.end());

    while (input_string[input_string.length() - 1] == ' ') {
        input_string.pop_back();
    }

    vector<string> splits;
    char delimiter = ' ';

    size_t i = 0;
    size_t pos = input_string.find(delimiter);

    while (pos != string::npos) {
        splits.push_back(input_string.substr(i, pos - i));

        i = pos + 1;
        pos = input_string.find(delimiter, i);
    }

    splits.push_back(input_string.substr(i, min(pos, input_string.length()) - i + 1));

    return splits;
}
