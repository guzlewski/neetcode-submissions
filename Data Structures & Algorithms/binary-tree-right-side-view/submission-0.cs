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
    private List<int> result = [];

    private void DFS(TreeNode node, int level) {
        if (node is null) {
            return;
        }

        if (result.Count <= level) {
            result.Add(node.val);
        }

        DFS(node.right, level + 1);
        DFS(node.left, level + 1);
    }

    public List<int> RightSideView(TreeNode root) {
        DFS(root, 0);
        return result;
    }
}
