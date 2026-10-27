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
    private int Depth(TreeNode node, int depth) {
        if (node is null) {
            return depth;
        }

        return Math.Max(Depth(node.left, depth + 1), Depth(node.right, depth + 1));
    }

    public int MaxDepth(TreeNode root) {
        return Depth(root, 0);
    }
}
