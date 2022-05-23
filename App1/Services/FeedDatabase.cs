using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace App1
{
    public class FeedDatabase
    {
        private readonly SQLiteAsyncConnection _FeedDatabase;

        public FeedDatabase(string dbfeedPath)
        {
            _FeedDatabase = new SQLiteAsyncConnection(dbfeedPath);
            _FeedDatabase.CreateTableAsync<Feed>();
        }

        public Task<List<Feed>> GetFeedAsync()
        {
            return _FeedDatabase.Table<Feed>().ToListAsync();
        }

        public Task<int> SaveFeedAsync(Feed feed)
        {
            return _FeedDatabase.InsertAsync(feed);
        }
    }
}