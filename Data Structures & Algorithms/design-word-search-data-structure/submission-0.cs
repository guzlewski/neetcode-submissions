class Node {
    public Dictionary<char, Node> Children = [];
    public bool EndOfWord = false;
}

public class WordDictionary {
    private Node Root = new();

    public void AddWord(string word) {
        Node current = Root;

        foreach (var letter in word) {
            if (!current.Children.ContainsKey(letter)) {
                current.Children[letter] = new();
            }

            current = current.Children[letter];
        }

        current.EndOfWord = true;
    }

    public bool Search(string word) {
        return Search(Root, word, 0);
    }

    private bool Search(Node current, string word, int index) {
        if (index == word.Length - 1) {
            if (word[index] == '.') {
                foreach (var child in current.Children.Values) {
                    if (child.EndOfWord) {
                        return true;
                    }
                }

                return false;
            }

            return current.Children.ContainsKey(word[index]) &&
                   current.Children[word[index]].EndOfWord;
        }

        if (word[index] == '.') {
            foreach (var child in current.Children.Values) {
                if (Search(child, word, index + 1)) {
                    return true;
                }
            }

            return false;
        }

        if (!current.Children.ContainsKey(word[index])) {
            return false;
        }

        return Search(current.Children[word[index]], word, index + 1);
    }
}
