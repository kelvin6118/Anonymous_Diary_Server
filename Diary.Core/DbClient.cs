using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Diary.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Diary> _diaries;
        public DbClient(IOptions<DiaryDbConfig> diaryDbConfig)
        {
            var client = new MongoClient(diaryDbConfig.Value.Connection_String);
            var database = client.GetDatabase(diaryDbConfig.Value.Database_Name);
            _diaries = database.GetCollection<Diary>(diaryDbConfig.Value.Diaries_Collection_Name);
        }
        public IMongoCollection<Diary> GetDiariesCollection()
        {
            return _diaries;
        }
    }
}
