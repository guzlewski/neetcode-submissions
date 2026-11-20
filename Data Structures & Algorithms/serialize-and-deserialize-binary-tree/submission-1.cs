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

public class Codec {
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        Queue<TreeNode> nodes = [];
        List<string> serialized = [];

        nodes.Enqueue(root);

        while (nodes.Count != 0) {
            TreeNode node = nodes.Dequeue();

            if (node is null) {
                serialized.Add("null");
            } else {
                serialized.Add(node.val.ToString());
                nodes.Enqueue(node.left);
                nodes.Enqueue(node.right);
            }
        }

        return string.Join(',', serialized);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        string[] values = data.Split(',');

        if (values[0] == "null") {
            return null;
        }

        TreeNode root = new TreeNode(int.Parse(values[0]));
        Queue<TreeNode> queue = [];

        queue.Enqueue(root);

        for (int i = 1; i < values.Length; i += 2) {
            TreeNode current = queue.Dequeue();

            current.left = Create(values[i]);
            current.right = Create(values[i + 1]);

            if (current.left is not null) {
                queue.Enqueue(current.left);
            }

            if (current.right is not null) {
                queue.Enqueue(current.right);
            }
        }

        return root;
    }

    private TreeNode Create(string value) {
        if (value == "null") {
            return null;
        }

        return new TreeNode(int.Parse(value));
    }
}
