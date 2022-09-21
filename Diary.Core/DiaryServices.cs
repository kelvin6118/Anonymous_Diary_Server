using MongoDB.Driver;

namespace Diary.Core
{
    public class DiaryServices : IDiaryServices
    {
        private readonly IMongoCollection<Diary> _diaries;
        public DiaryServices(IDbClient dbClient)
        {
            _diaries = dbClient.GetDiariesCollection();
        }

        public Diary CreateDiary(Diary diary)
        {
            _diaries.InsertOne(diary);
            return diary;
        }

        public List<Diary> GetDiaries() => _diaries.Find(diary => true).ToList();

        public Diary UpdateDiary(Diary diary)
        {
            _diaries.ReplaceOne(d => d.Id == diary.Id, diary);
            return diary;
        }
    }
}
