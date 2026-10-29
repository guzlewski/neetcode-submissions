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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == p || root == q || (root.val > Math.Min(p.val, q.val) && root.val < Math.Max(p.val, q.val))) {
            return root;
        }

        return root.val > Math.Max(p.val, q.val) 
            ? (root.left is null ? root : LowestCommonAncestor(root?.left, p, q))
            : (root.right is null ? root : LowestCommonAncestor(root?.right, p, q));
    }
}
