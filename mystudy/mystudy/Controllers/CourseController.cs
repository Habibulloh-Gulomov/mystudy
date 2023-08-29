using Data_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Service.DTO.CourseDTO;
using Service.Service;

namespace mystudy.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;


        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult CreateCourse([FromBody] CourseRequest course)
        {
            {
                try
                {
                    _service.AddCourse(course);
                    return Ok();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        [HttpGet]
        public ActionResult<List<Course>> GetCourse()
        {
            var response = _service.GetCourse();
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(Guid id)
        {
            _service.DeleteCourse(id);
            return NoContent();
        }
        [HttpPut("id")]
        public ActionResult Updatecourse(Guid id, [FromBody] Course course)
        {
            _service.UpdateCourse(id, course);
            return NoContent();
        }
    }
}