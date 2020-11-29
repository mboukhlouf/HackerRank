#include <bits/stdc++.h>

using namespace std;

class Node {
    public:
        int data;
        Node *left;
        Node *right;
        Node(int d) {
            data = d;
            left = NULL;
            right = NULL;
        }
};

class Solution {
    public:
  		Node* insert(Node* root, int data) {
            if(root == NULL) {
                return new Node(data);
            } else {
                Node* cur;
                if(data <= root->data) {
                    cur = insert(root->left, data);
                    root->left = cur;
                } else {
                    cur = insert(root->right, data);
                    root->right = cur;
               }

               return root;
           }
        }
/*The tree node has data, left child and right child 
class Node {
    int data;
    Node* left;
    Node* right;
};

*/
    int height(Node* root) {
        return heightRecursive(root);
    }
    
    int heightRecursive(Node* root) {
        if(root == nullptr) {
            return -1;
        }
        int leftHeight = 1 + heightRecursive(root->left);
        int rightHeight = 1 + heightRecursive(root->right);
        if(rightHeight > leftHeight) {
            return rightHeight;
        } else {
            return leftHeight;
        }
    }
}; //End of Solution