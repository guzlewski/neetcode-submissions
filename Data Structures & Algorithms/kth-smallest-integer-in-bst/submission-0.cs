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
    private void DFS(TreeNode node, List<int> result) {
        if (node is null) {
            return;
        }

        DFS(node.left, result);
        result.Add(node.val);
        DFS(node.right, result);
    }

    public int KthSmallest(TreeNode root, int k) {
        List<int> result = [];
        DFS(root, result);

        return result[k - 1];
    }
}
