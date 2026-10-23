public class TimeMap {
    private readonly Dictionary<string, SortedDictionary<int, string>> dict = [];

    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key)) {
            dict[key] = new();
        }

        dict[key][-timestamp] = value;
    }

    public string Get(string key, int timestamp) {
        if (!dict.TryGetValue(key, out var sortedDict)) {
            return string.Empty;
        }

        foreach (var kp in sortedDict) {
            if (kp.Key >= -timestamp) {
                return kp.Value;
            }
        }

        return string.Empty;
    }
}
