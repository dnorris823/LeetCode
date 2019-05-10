using System;
using BSTs;

// Level Order Traversal
public class RunTest {
    static void Main(){
        // Construct the tree
        Console.WriteLine("Constructing Tree.");
        // Create the nodes.
        TreeNode A = new TreeNode(3);
        TreeNode B = new TreeNode(9);
        TreeNode C = new TreeNode(20);
        TreeNode D = new TreeNode(15);
        TreeNode E = new TreeNode(7);
        TreeNode X = new TreeNode(100);

        // Init node branches
        A.left = B;
        A.right = C;
        B.left = null;
        B.right = X;
        C.left = D;
        C.right = E;
        D.left = null;
        D.right = null;
        E.left = null;
        E.right = null;
        X.left = null;
        X.right = null;

        // Max Depth Search
        MaxDepthSearch Max = new MaxDepthSearch();
        Max.FindMaxDepth(A, 1);
        Console.WriteLine("Max Depth is "+Max.depthMax);
        
        // Level Order Traverse the node
        /* LevelOrderTraverse level = new LevelOrderTraverse();
        level.LevelOrder(A, 0);
        Console.WriteLine("Traversed"); */

        /* BasicTraversal Basic = new BasicTraversal();
        Console.WriteLine("PreOrder");
        Basic.PreorderTraversal(A);
        Basic.PrintList();
        Basic.ClearList();
        Console.WriteLine("InOrder");
        Basic.InorderTraversal(A);
        Basic.PrintList();
        Basic.ClearList();
        Console.WriteLine("PostOrder");
        Basic.PostorderTraversal(A);
        Basic.PrintList();
        Basic.ClearList();
        Console.WriteLine("Traversed"); */
    }
}

// Basic Tree Traversals
/* public class RunTest {
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
        S.PrintList();
        S.ClearList();
        S.InorderTraversal(A);
        S.PrintList();
        S.ClearList();
        S.PostorderTraversal(A);
        S.PrintList();
        S.ClearList();
        Console.WriteLine("Traversed");
        return;
    }
} */
