class Node {
    public Dictionary<char, Node> Children = [];
    public bool EndOfWord = false;
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

        current.EndOfWord = true;
    }

    public bool Search(string word) {
        Node current = root;

        foreach (var letter in word) {
            if (!current.Children.ContainsKey(letter)) {
                return false;
            }

            current = current.Children[letter];
        }

        return current.EndOfWord;
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
