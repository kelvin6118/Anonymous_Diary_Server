using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Core
{
    public interface IDiaryServices
    {
        List<Diary> GetDiaries();
        Diary CreateDiary(Diary diary);

        Diary UpdateDiary(Diary diary);
    }
}
