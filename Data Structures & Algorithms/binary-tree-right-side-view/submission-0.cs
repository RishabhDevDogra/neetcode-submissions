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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new();
        DFS(root, 0 , res);
        return res;
    }
    public void DFS(TreeNode root, int level, List<int> res){

        if(root == null)
        return;
        if(res.Count == level)
        res.Add(root.val);
        DFS(root.right, level + 1, res);
        DFS(root.left, level + 1, res);
    }
}
