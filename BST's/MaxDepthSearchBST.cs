using System;
using System.Collections;
using System.Collections.Generic;
using BSTs;

public class MaxDepthSearch {
    public int depthMax = 0;
    
    public void FindMaxDepth(TreeNode root, int d){
        if(d == 1 && root == null){
            depthMax = 0;
            return;
        }
        
        CheckIfMax(d);
        
        if(root.left != null){
            FindMaxDepth(root.left, d+1);
        }
        if(root.right != null){
            FindMaxDepth(root.right, d+1);
        }
    }
    
    public void CheckIfMax(int i){
        if(i > depthMax){
            depthMax = i;
        }
    }
}