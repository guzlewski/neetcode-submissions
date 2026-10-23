public class TimeMap {
    private Dictionary<string, List<(int Timestamp, string Value)>> dict = [];

    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key)) {
            dict[key] = [];
        }

        dict[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp) {
        if (!dict.ContainsKey(key)) {
            return string.Empty;
        }

        int left = 0, right = dict[key].Count - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (dict[key][mid].Timestamp == timestamp) {
                return dict[key][mid].Value;
            } else if (dict[key][mid].Timestamp < timestamp) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return right < dict[key].Count && right >= 0 && dict[key][right].Timestamp <= timestamp
                   ? dict[key][right].Value
                   : string.Empty;
    }
}
