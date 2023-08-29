using Data_Layer.Models;
using Microsoft.EntityFrameworkCore;
using mystudy.Data;
using Service.DTO.CourseDTO;

namespace Service.Service
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public void AddCourse(CourseRequest course)
        {
            try
            {
                var newCourse = new Course()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Length = course.Length,
                    Price = course.Price,
                };
                _context.Courses.Add(newCourse);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public List<Course> GetCourse()
        {
            try
            {
                var courses = _context.Courses.ToList();
                return courses;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteCourse(Guid id)
        {
            var courseToDelete = _context.Courses.FirstOrDefault(x => x.Id == id);
            if (courseToDelete is not null)
            {
                _context.Courses.Remove(courseToDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateCourse(Guid id, Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}