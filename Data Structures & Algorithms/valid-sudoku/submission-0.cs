public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int row = 0; row < 9; row++) {
            HashSet<int> cells = [];
            for (int col = 0; col < 9; col++) {
                if (board[row][col] == '.') {
                    continue;
                }

                if (!cells.Add(board[row][col])) {
                    return false;
                }
            }
        }

        for (int col = 0; col < 9; col++) {
            HashSet<int> cells = [];
            for (int row = 0; row < 9; row++) {
                if (board[row][col] == '.') {
                    continue;
                }

                if (!cells.Add(board[row][col])) {
                    return false;
                }
            }
        }

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                char[] cells = [
                    board[i * 3 + 0][j * 3 + 0],
                    board[i * 3 + 0][j * 3 + 1],
                    board[i * 3 + 0][j * 3 + 2],
                    board[i * 3 + 1][j * 3 + 0],
                    board[i * 3 + 1][j * 3 + 1],
                    board[i * 3 + 1][j * 3 + 2],
                    board[i * 3 + 2][j * 3 + 0],
                    board[i * 3 + 2][j * 3 + 1],
                    board[i * 3 + 2][j * 3 + 2],
                ];

                HashSet<int> set = [];

                foreach (var cell in cells) {
                    if (cell == '.') {
                        continue;
                    }

                    if (!set.Add(cell)) {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
