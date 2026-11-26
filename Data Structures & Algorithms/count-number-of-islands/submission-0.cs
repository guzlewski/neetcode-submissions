public class Solution {
    private void Fill(char[][] grid, int y, int x) {
        if (y < 0 || x < 0 || y >= grid.Length || x >= grid[y].Length || grid[y][x] == '0') {
            return;
        }

        grid[y][x] = '0';

        Fill(grid, y + 1, x);
        Fill(grid, y - 1, x);
        Fill(grid, y, x + 1);
        Fill(grid, y, x - 1);
    }

    public int NumIslands(char[][] grid) {
        int islands = 0;

        for (int y = 0; y < grid.Length; y++) {
            for (int x = 0; x < grid[y].Length; x++) {
                if (grid[y][x] == '0') {
                    continue;
                }

                Fill(grid, y, x);
                islands++;
            }
        }

        return islands;
    }
}
