using Data_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data_Layer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IRepository<Student> _studentRepository;
        private IRepository<Mentor> _mentorRepository;
        private IRepository<Course> _courseRepository;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<Student> Students
        {
            get
            {
                return _studentRepository ??= new Repository<Student>(_context);
            }
        }

        public IRepository<Mentor> Mentors
        {
            get
            {
                return _mentorRepository ??= new Repository<Mentor>(_context);
            }
        }

        public IRepository<Course> Courses
        {
            get
            {
                return _courseRepository ??= new Repository<Course>(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
