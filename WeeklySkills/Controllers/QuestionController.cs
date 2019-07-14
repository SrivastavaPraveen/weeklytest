using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeeklySkills.Services;
using WeeklySkills.Models;

namespace WeeklySkills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly SkillsService _skillsService;

        public QuestionController(SkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        // GET api/values
        [HttpGet("{topic}")]
        public ActionResult<List<Question>> Get(string topic)
        {
             return _skillsService.Get(topic);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Question question)
        {
            _skillsService.Create(question);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] Question question)
        {
            _skillsService.Create(question);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
