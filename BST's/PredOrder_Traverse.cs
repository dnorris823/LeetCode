using System;
using System.Collections;
using System.Collections.Generic;

// Definition of main and Tree construction
namespace PreorderTraversal {

    public class RunTest {
        static void Main(){
            // Construct the tree
            Console.WriteLine("Constructing Tree.");
            // Create the nodes.
            TreeNode A = new TreeNode(3);
            TreeNode B = new TreeNode(1);
            TreeNode C = new TreeNode(2);

            // Init node branches
            A.left = B;
            A.right = C;
            B.left = null;
            B.right = null;
            C.left = null;
            C.right = null;

            // Traverse the node
            Solution S = new Solution();
            S.PreorderTraversal(A);
            return;
        }
    }

    // Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    // Definition of Solution for preOrder Traverse problem
    public class Solution {
        private List<int> list =  new List<int>();
        public void PreorderTraversal(TreeNode root) {
            if(root == null)
                return;

            while(true){
                if(root.val != null)
                    list.Add(root.val);

                if(root.left != null){
                    PreorderTraversal(root.left);
                }
                if (root.right != null){
                    PreorderTraversal(root.right);
                }
                return;
            }
        }
    }
}