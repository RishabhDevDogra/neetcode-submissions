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
    public bool IsBalanced(TreeNode root) {
        return MaxDepth(root) != -1;
    }

    private int MaxDepth(TreeNode root){
        if(root == null){
            return 0;
        }
        int lh = MaxDepth(root.left);
        if(lh == -1){
            return -1;
        }
        int lr = MaxDepth(root.right);
        if(lr == -1){
            return -1;
        }
        if(Math.Abs(lh-lr)>1){
            return -1;
        }
        return Math.Max(lh,lr)+1;
    }
}
