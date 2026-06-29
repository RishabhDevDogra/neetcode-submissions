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
    public TreeNode InvertTree(TreeNode root) {
        // Base case
        if (root == null)
        {
            return null;
        }
        // Swap the left and right child
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        // Recursively invert the left subtree
        InvertTree(root.left);

        // Recursively invert the right subtree
        InvertTree(root.right);

        // Return the root of the inverted tree
        return root;
    }
}
