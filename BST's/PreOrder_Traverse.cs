using System;
using System.Collections;
using System.Collections.Generic;
using BSTs;

// Definition of main and Tree construction
namespace BSTs {

    // Definition of Solution for preOrder Traverse problem
    public class BasicTraversal {
        private List<int> list =  new List<int>();
        public void PreorderTraversal(TreeNode root) {
            if(root == null)
                return;

            while(true){
                list.Add(root.val);

                if(root.left != null){
                    InorderTraversal(root.left);
                }
                if (root.right != null){
                    InorderTraversal(root.right);
                }
                return;
            }
        }

        public void InorderTraversal(TreeNode root) {
            if(root == null)
                return;

            while(true){
                if(root.left != null){
                    PreorderTraversal(root.left);
                }

                list.Add(root.val);

                if (root.right != null){
                    PreorderTraversal(root.right);
                }
                return;
            }
        }

        public void PostorderTraversal(TreeNode root) {
            if(root == null)
                return;

            while(true){
                if(root.left != null){
                    PostorderTraversal(root.left);
                }
                if (root.right != null){
                    PostorderTraversal(root.right);
                }

                list.Add(root.val);
                return;
            }
        }

        public void PrintList(){
            foreach( int i in list){
                Console.WriteLine(i.ToString());
            }
        }

        public void ClearList(){
            list.Clear();
        }
    }
}