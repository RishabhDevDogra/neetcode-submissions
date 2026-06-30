/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> InorderTraversal(TreeNode root) {
        List<int> ans = new();

        Stack<TreeNode> stack = new();
        TreeNode current = root;
        while(true)
        {
            if(current!=null)
            {
                stack.Push(current);
                current = current.left;
            }
            else
            {
                if(stack.Count==0)
                {
                    break;
                }
                current = stack.Pop();
                ans.Add(current.val);
                
                current = current.right;
            }
        }
        return ans;
        
    }

    //public IList<int> InorderTraversal(TreeNode root) {
   //     List<int> ans = new();
   //     DFS(root,ans);
   //     return ans;
  // }
    //private void DFS(TreeNode root, List<int> ans)
    //{
   //     if(root == null){
    //        return;
    //    }
   //     DFS(root.left,ans);
    //    ans.Add(root.val);
   //     DFS(root.right,ans);
   // }
}