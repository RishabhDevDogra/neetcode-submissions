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
 public List<int> PostorderTraversal(TreeNode root) {
        List<int> ans = new();
        if(root == null){
            return ans;
        }
        Stack<TreeNode> stack1 = new();
        stack1.Push(root);

        Stack<TreeNode> stack2 = new();

        while(stack1.Count>0)
        {
            TreeNode current = stack1.Pop();
            stack2.Push(current);

            if(current.left != null)
            {
                stack1.Push(current.left);
            }

            if(current.right != null)
            {
                stack1.Push(current.right);
            }
        }
        while (stack2.Count > 0)
        {
        ans.Add(stack2.Pop().val);
        }

        return ans;
    }
}
//public class Solution {
    //public List<int> PostorderTraversal(TreeNode root) {
     //   List<int> ans = new();

     //   DFS(root,ans);
    //    return ans;
   // }
   // private void DFS(TreeNode root,List<int> ans){
    //    if(root == null)
      //  {
     //   return;
     //   }
     //   DFS(root.left,ans);
      //  DFS(root.right,ans);
      //  ans.Add(root.val);
   // }
