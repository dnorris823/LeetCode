using System;
using BSTs;

// Level Order Traversal
public class RunTest {
    static void Main(){
        // Construct the tree
        Console.WriteLine("Constructing Tree.");
        // Create the nodes.
        TreeNode A = new TreeNode(1);
        TreeNode B = new TreeNode(2);
        TreeNode C = new TreeNode(8);
        TreeNode D = new TreeNode(11);
        TreeNode E = new TreeNode(13);
        TreeNode F = new TreeNode(4);
        TreeNode G = new TreeNode(7);
        TreeNode H = new TreeNode(2);
        TreeNode I = new TreeNode(1);

        A.left = B;
        A.right = null;
        B.left = null;
        B.right = null;

        // Init node branches
        /* A.left = B;
        A.right = C;
        B.left = D;
        B.right = null;
        C.left = E;
        C.right = F;
        D.left = G;
        D.right = H;
        E.left = null;
        E.right = null;
        F.left = null;
        F.right = I;
        G.left = null;
        G.right = null;
        H.left = null;
        H.right = null;
        I.left = null;
        I.right = null; */

        // Path Sum
        /* PathSum p = new PathSum();
        bool hasSum = p.HasPathSumHelper(A, 0, 2, 0);
        Console.WriteLine("Checked if tree has the sum"); */


        // Max Depth Search
        /* MaxDepthSearch Max = new MaxDepthSearch();
        Max.FindMaxDepth(A, 1);
        Console.WriteLine("Max Depth is "+Max.depthMax); */
        
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
