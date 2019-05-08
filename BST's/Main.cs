
using System;
using BSTs;
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