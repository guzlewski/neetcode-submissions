public class Solution {
    private bool Search(char[][] board, int y, int x, string word, int index) {
        if (y < 0 || y >= board.Length || x < 0 || x >= board[y].Length ||
            word[index] != board[y][x]) {
            return false;
        }

        if (index == word.Length - 1) {
            return true;
        }

        board[y][x] = '*';

        bool result =  Search(board, y + 1, x, word, index + 1) ||
               Search(board, y - 1, x, word, index + 1) ||
               Search(board, y, x + 1, word, index + 1) || 
               Search(board, y, x - 1, word, index + 1);

        board[y][x] = word[index];

        return result;
    }

    public bool Exist(char[][] board, string word) {
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                if (Search(board, i, j, word, 0)) {
                    return true;
                }
            }
        }

        return false;
    }
}
