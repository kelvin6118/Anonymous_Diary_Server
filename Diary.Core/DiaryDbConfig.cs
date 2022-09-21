using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Core
{
    public class DiaryDbConfig
    {
        public string Database_Name { get; set; }
        public string Diaries_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
