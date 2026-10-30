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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = [];
        Queue<TreeNode> current = [], next = [];
        current.Enqueue(root);

        while (current.Count > 0 || next.Count > 0) {
            List<int> level = [];
            while (current.TryDequeue(out var node)) {
                if (node is null) {
                    continue;
                }

                level.Add(node.val);
                next.Enqueue(node.left);
                next.Enqueue(node.right);
            }

            if (level.Count > 0) {
                result.Add(level);
            }
            
            current = next;
            next = [];
        }

        return result;
    }
}
