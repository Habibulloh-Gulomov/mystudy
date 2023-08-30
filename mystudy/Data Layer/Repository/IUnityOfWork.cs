using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data_Layer.Repository
{
    public interface IUnitOfWork
    {
        IRepository<Student> Students { get; }
        IRepository<Mentor> Mentors { get; }
        IRepository<Course> Courses { get; }
        void Commit();
        void SaveChanges();
    }
}
