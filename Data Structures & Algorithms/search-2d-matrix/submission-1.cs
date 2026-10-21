public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0, right = matrix.Length * matrix[0].Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            int y = mid / matrix[0].Length, x = mid % matrix[0].Length;

            if (matrix[y][x] > target) {
                right = mid - 1;
            } else if (matrix[y][x] < target) {
                left = mid + 1;
            } else {
                return true;
            }
        }

        return false;
    }
}
