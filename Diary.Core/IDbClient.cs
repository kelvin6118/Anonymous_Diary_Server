using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Diary.Core
{
    public interface IDbClient
    {
        IMongoCollection<Diary> GetDiariesCollection();
    }
}
