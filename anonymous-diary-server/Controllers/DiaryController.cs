using Microsoft.AspNetCore.Mvc;
using Diary.Core;

namespace anonymous_diary_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiaryController : ControllerBase
    {
        private readonly IDiaryServices _diaryServices;
        public DiaryController(IDiaryServices diaryServices)
        {
            _diaryServices = diaryServices;
        }
        [HttpGet]
        public IActionResult GetDiary()
        {
            return Ok(_diaryServices.GetDiaries());
        }

    }
}