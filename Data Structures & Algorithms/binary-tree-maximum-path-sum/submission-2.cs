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
    private int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        MaxTree(root);
        return maxSum;
        
    }
    private int MaxTree(TreeNode root)
    {
        if(root == null)
        return 0;

        int lsum = Math.Max(0, MaxTree(root.left));
        int rsum = Math.Max(0, MaxTree(root.right));

        maxSum = Math.Max(maxSum,lsum + rsum + root.val);

        return (root.val + Math.Max(lsum,rsum));
    }
}
