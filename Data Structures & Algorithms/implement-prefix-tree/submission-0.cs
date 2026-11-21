class Node {
    public Dictionary<char, Node> Children = [];
}

public class PrefixTree {
    private Node root = new();

    public void Insert(string word) {
        Node current = root;

        foreach (char letter in word) {
            if (!current.Children.ContainsKey(letter)) {
                current.Children[letter] = new();
            }

            current = current.Children[letter];
        }

        current.Children['#'] = null;
    }

    public bool Search(string word) {
        Node current = root;

        foreach (var letter in word) {
            if (!current.Children.ContainsKey(letter)) {
                return false;
            }

            current = current.Children[letter];
        }

        return current.Children.ContainsKey('#');
    }

    public bool StartsWith(string prefix) {
        Node current = root;

        foreach (char letter in prefix) {
            if (!current.Children.ContainsKey(letter)) {
                return false;
            }

            current = current.Children[letter];
        }

        return true;
    }
}
