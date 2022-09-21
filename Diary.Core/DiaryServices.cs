namespace Diary.Core
{
    public class DiaryServices : IDiaryServices
    {

        public List<Diary> GetDiaries()
        {
            Comment comment = new Comment()
            {
                date = "09/21/2022 17:00",
                comment = "this is the first comment"
            };

            Emoji emoji = new Emoji()
            {
                happy = 0,
                like = 1,
                love = 2
            };

            Comment[] comments = new Comment[] { comment };

            return new List<Diary>()
            {
                new Diary(){
                    title = "this is a test title",
                    description = "this is a test description",
                    comments = comments,
                    emoji= emoji,
                    giphy = "https://media3.giphy.com/media/5x5iPtXlR4LzwXzZhi/100.gif?cid=1253b287nm00qq88juxxwaardy3xcyngnemxrikpt19brgsq&rid=100.gif&ct=g"
                  }

            };
        }
           
    }
}
