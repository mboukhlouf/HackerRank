/*
Detect a cycle in a linked list. Note that the head pointer may be 'NULL' if the list is empty.

A Node is defined as: 
    struct Node {
        int data;
        struct Node* next;
    }
*/

bool isNodeVisited(Node* node, Node** visitedNodes, int visitedNodesCount) {
    for(int i = 0; i < visitedNodesCount; i++) {
        if(visitedNodes[i] == node) {
            return true;
        }
    }
    return false;
}

bool has_cycle(Node* head) {
    int visitedNodesCount = 0;
    Node* visitedNodes[100];
    Node* node = head;
    while(node != nullptr) {
        if(isNodeVisited(node, visitedNodes, visitedNodesCount)) {
            return true;
        }
        visitedNodes[visitedNodesCount] = node;
        visitedNodesCount++;
        node = node->next;
    }
    return false;
}
