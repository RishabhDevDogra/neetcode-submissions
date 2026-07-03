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
    
    public List<List<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<List<int>> ans = new();

        if (root == null)
            return ans;

        Queue<TreeNode> q = new();
        q.Enqueue(root);

        bool leftToRight = true;

        while (q.Count > 0)
        {
            int size = q.Count;
            LinkedList<int> level = new LinkedList<int>();

            for (int i = 0; i < size; i++)
            {
                TreeNode node = q.Dequeue();

                if (leftToRight)
                    level.AddLast(node.val);
                else
                    level.AddFirst(node.val);

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }

            ans.Add(level.ToList());

            leftToRight = !leftToRight;
        }

        return ans;
    }
}
