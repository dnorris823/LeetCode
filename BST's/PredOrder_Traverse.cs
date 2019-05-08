using System;
using System.Collections;
using System.Collections.Generic;

// Definition of main and Tree construction
namespace BSTs {
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