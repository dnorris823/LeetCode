using System;
using System.Collections;
using System.Collections.Generic;
using BSTs;

// Definition of main and Tree construction
namespace BSTs {

    // Definition of Solution for preOrder Traverse problem
    public class LevelOrderTraverse {
        private List<List<int>> list =  new List<List<int>>();

        public void LevelOrder(TreeNode root, int idx) {
            if(root == null)
                return;

            if(list.Count == idx){
                list.Add(new List<int>());
            }

            list[idx].Add(root.val);
            LevelOrder(root.left, idx+1);
            LevelOrder(root.right, idx+1);
        }
        
        public void PrintList(List<int> list){
            foreach( int i in list){
                Console.WriteLine(i.ToString());
            }
        }

        public void ClearList(List<int> list){
            list.Clear();
        }
    }
}