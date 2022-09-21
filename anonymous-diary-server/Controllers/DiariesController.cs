using Microsoft.AspNetCore.Mvc;
using Diary.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_diary_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiariesController : ControllerBase
    {
        private readonly IDiaryServices _diaryServices;

        public DiariesController(IDiaryServices diaryServices)
        {
            _diaryServices = diaryServices;
        }

        [HttpGet]
        public IActionResult GetDiary()
        {
            return Ok(_diaryServices.GetDiaries());
        }

        [HttpPost]
        public IActionResult CreateDiary(Diary.Core.Diary diary)
        {
            _diaryServices.CreateDiary(diary);
            return Ok(diary);
        }

        [HttpPut]
        public IActionResult updateDiary(Diary.Core.Diary diary)
        {
            return Ok(_diaryServices.UpdateDiary(diary));
        }

    }
}