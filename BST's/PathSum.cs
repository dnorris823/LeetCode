using System;
using System.Collections;
using System.Collections.Generic;
using BSTs;

public class Solution {
    
    public bool HasPathSum(TreeNode root, int sum) {
        return HasPathSumHelper(root, 0, sum);
    }
    
    public bool HasPathSumHelper(TreeNode root, int currentSum, int sum){
        if(root == null){
            return false;
        }
        
        if(currentSum + root.val == sum){
            return true;
        }
        else{
            currentSum  = currentSum + root.val;
        }
        
        if(root.left != null){
            HasPathSumHelper(root.left, currentSum, sum);
        }
        if(root.right != null){
            HasPathSumHelper(root.right, currentSum, sum);
        }
        return false;
    }
}