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
    public bool IsValidBST(TreeNode node, int min, int max) {
        if (node is null) {
            return true;
        }

        if (node.val >= max || node.val <= min) {
            return false;
        }

        return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
    }

    public bool IsValidBST(TreeNode root) {
        return IsValidBST(root, int.MinValue, int.MaxValue);
    }
}
