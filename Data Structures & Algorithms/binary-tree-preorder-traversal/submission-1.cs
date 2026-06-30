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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> ans = new();
        if(root == null){
            return ans;
        }
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while(stack.Count>0)
        {
            TreeNode current = stack.Pop();
            ans.Add(current.val);

            if(current.right!=null)
            stack.Push(current.right);

            if(current.left!=null)
            stack.Push(current.left);
            
        }
        return ans;
        
    }
    //public List<int> PreorderTraversal(TreeNode root) {
      //      List<int> ans = new();

        //    DFS(root,ans);

        //    return ans;
      //  }

    private void DFS(TreeNode root, List<int> ans)
    {
        if(root == null)
        {
        return;
        }
        ans.Add(root.val);
        DFS(root.left, ans);
        DFS(root.right, ans);
    }
}