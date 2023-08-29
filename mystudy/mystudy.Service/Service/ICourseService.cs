using Data_Layer.Models;
using Service.DTO.CourseDTO;

namespace Service.Service
{
    public interface ICourseService
    {
        public List<Course> GetCourse();

        public void AddCourse(CourseRequest course);

        public void DeleteCourse(Guid Id);

        public void UpdateCourse(Guid Id , Course course);
    }
}