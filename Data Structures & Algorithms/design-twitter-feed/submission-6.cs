public class Twitter {
    private readonly Dictionary<int, List<(int id, int timestamp)>> tweets = [];
    private readonly Dictionary<int, HashSet<int>> follows = [];
    private int _timestamp = 1;

    public Twitter() {}

    public void PostTweet(int userId, int tweetId) {
        if (!tweets.ContainsKey(userId)) {
            tweets[userId] = [];
        }

        tweets[userId].Add((tweetId, _timestamp++));
    }

    public List<int> GetNewsFeed(int userId) {
        PriorityQueue<(List<(int id, int timestamp)> list, int index), int> queue = new();

        if (tweets.ContainsKey(userId)) {
            queue.Enqueue((tweets[userId], tweets[userId].Count - 1),
                          -tweets[userId][^1].timestamp);
        }

        if (follows.ContainsKey(userId)) {
            foreach (var follow in follows[userId]) {
                if (!tweets.ContainsKey(follow)) {
                    continue;
                }

                queue.Enqueue((tweets[follow], tweets[follow].Count - 1),
                              -tweets[follow][^1].timestamp);
            }
        }

        List<int> result = [];

        while (queue.Count != 0 && result.Count < 10) {
            (List<(int id, int timestamp)> list, int index) = queue.Dequeue();

            result.Add(list[index].id);

            if (index-- > 0) {
                queue.Enqueue((list, index), -list[index].timestamp);
            }
        }

        return result;
    }

    public void Follow(int followerId, int followeeId) {
        if (!follows.ContainsKey(followerId)) {
            follows[followerId] = [];
        }

        follows[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId) {
        follows[followerId].Remove(followeeId);
    }
}
