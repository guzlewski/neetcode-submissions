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
    private int DFS(TreeNode node, ref bool result) {
        if (node is null) {
            return 0;
        }

        int left = DFS(node.left, ref result);
        int right = DFS(node.right, ref result);

        if (Math.Abs(left - right) > 1) {
            result = false;
        }

        return Math.Max(left, right) + 1;
    }

    public bool IsBalanced(TreeNode root) {
        bool result = true;
        DFS(root, ref result);

        return result;
    }
}
