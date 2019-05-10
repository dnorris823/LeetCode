using System;
using System.Collections;
using System.Collections.Generic;
using BSTs;

public class PathSum {
    
    public bool HasPathSum(TreeNode root, int sum) {
        return HasPathSumHelper(root, 0, sum, 0);
    }
    
    public bool HasPathSumHelper(TreeNode root, int currentSum, int sum, int depth){
        if(root == null){
            return false;
        }

        if(root.left == null && root.right == null){
            if(currentSum + root.val == sum)
            return true;
        }
        else{
            currentSum = currentSum + root.val;
        }    
        
        if(root.left != null){
            if(HasPathSumHelper(root.left, currentSum, sum, depth+1)){
                return true;
            }
        }
        if(root.right != null){
            if(HasPathSumHelper(root.right, currentSum, sum, depth+1)){
                return true;
            }
        }
        return false;
    }
}