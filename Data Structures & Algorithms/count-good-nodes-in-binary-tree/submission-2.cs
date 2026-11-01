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
    private void DFS(TreeNode node, int maxValueInPath, ref int result) {
        if (node is null) {
            return;
        }

        if (node.val >= maxValueInPath) {
            result++;
            maxValueInPath = node.val;
        }

        DFS(node.left, maxValueInPath, ref result);
        DFS(node.right, maxValueInPath, ref result);
    }

    public int GoodNodes(TreeNode root) {
        int result = 0;
        DFS(root, int.MinValue, ref result);

        return result;
    }
}
