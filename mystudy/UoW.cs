public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    private IRepository<Student> _studentRepository;
    private IRepository<Mentor> _mentorRepository;
    private IRepository<Course> _courseRepository;
    private IRepository<Group> _groupRepository;

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

    public IRepository<Group> Groups
    {
        get
        {
            return _groupRepository ??= new IRepository<Group>(_context);
        }
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

